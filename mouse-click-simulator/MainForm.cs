/*
    This file is part of the mouse click simulator.
    Copyright (C) 2022, 2024  Dirk Stolle

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using mouse_click_simulator.window_handling;
using System;
using System.Windows.Forms;

namespace mouse_click_simulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshWindowList();
        }


        /// <summary>
        /// Refreshes the list of available target windows.
        /// </summary>
        private void RefreshWindowList()
        {
            btnRefresh.Enabled = false;
            var selection = GetSelectedWindowData();
            var topIdx = lbWindows.TopIndex;
            try
            {
                var list = WindowFunctions.ListWindows();
                if (list == null)
                {
                    MessageBox.Show("Error: Could not get available windows.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                list.Sort();
                lbWindows.Enabled = false;
                lbWindows.Items.Clear();
                lbWindows.BeginUpdate();
                try
                {
                    foreach (var item in list)
                    {
                        lbWindows.Items.Add(item);
                    }
                    // Try to restore previous selection.
                    if (selection.HasValue)
                    {
                        int idx = GetWindowIndexByHandle(selection.Value.Handle);
                        if (idx != -1)
                        {
                            lbWindows.SelectedIndex = idx;
                            if (topIdx < lbWindows.Items.Count)
                                lbWindows.TopIndex = topIdx;
                        }
                    }
                }
                finally
                {
                    lbWindows.EndUpdate();
                    lbWindows.Enabled = true;
                }
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }


        /// <summary>
        /// Checks whether a target window has been selected.
        /// </summary>
        /// <returns>Returns true, if a target window is selected.
        /// Return false otherwise.</returns>
        private bool IsWindowSelected()
        {
            return lbWindows.Enabled && lbWindows.SelectedIndex >= 0;
        }


        /// <summary>
        /// Checks whether at least one mouse button has been selected for simulation.
        /// </summary>
        /// <returns>Returns true, if at least one button is selected.
        /// Returns false, if no mouse button is selected.</returns>
        private bool IsMouseButtonSelected()
        {
            return cbLeftMouseButton.Checked || cbMiddleMouseButton.Checked
                || cbRightMouseButton.Checked;
        }


        /// <summary>
        /// Checks whether all prerequisites for click simulation are fulfilled,
        /// i. e. if user has made all necessary selections for it.
        /// </summary>
        /// <returns>Returns true, if prerequisites are fulfilled.
        /// Returns false otherwise.</returns>
        private bool PrerequisitesFulfilled()
        {
            // User has to select a window.
            if (!IsWindowSelected())
            {
                MessageBox.Show("Please select a window before starting the click simulation."
                    + Environment.NewLine + Environment.NewLine
                    + "You may need to refresh the window list before a selection is available.",
                    "No window selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // At least one mouse button must be selected.
            if (!IsMouseButtonSelected())
            {
                MessageBox.Show("Please select at least one mouse button to simulate the clicks for.",
                    "No mouse button selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Extracts the selected WindowData instance from the list of
        /// available windows.
        /// </summary>
        /// <returns>Returns the corresponding WindowData in case of success.
        /// Returns null, if an error occurred.</returns>
        private WindowData? GetSelectedWindowData()
        {
            if (lbWindows.SelectedIndex == -1)
                return null;
            object item = lbWindows.SelectedItem;
            if (item.GetType().FullName != typeof(WindowData).FullName)
            {
                return null;
            }
            return (WindowData)item;
        }


        /// <summary>
        /// Finds the first window with a given caption in the window list.
        /// </summary>
        /// <param name="caption">the caption of the window</param>
        /// <returns>Returns the zero-based index of the item, if a match was found.
        /// Returns -1, if no match was found.</returns>
        private int GetWindowIndexByCaption(string caption)
        {
            for (int i = 0; i < lbWindows.Items.Count; i++)
            {
                var item = lbWindows.Items[i];
                if (item is not WindowData)
                {
                    continue;
                }
                var data = (WindowData)item;
                if (data.Caption == caption)
                    return i;
            }
            // Not found.
            return -1;
        }


        /// <summary>
        /// Finds the first window with a given handle in the window list.
        /// </summary>
        /// <param name="handle">the handle of the window</param>
        /// <returns>Returns the zero-based index of the item, if a match was found.
        /// Returns -1, if no match was found.</returns>
        private int GetWindowIndexByHandle(IntPtr handle)
        {
            for (int i = 0; i < lbWindows.Items.Count; i++)
            {
                var item = lbWindows.Items[i];
                if (item is not WindowData)
                {
                    continue;
                }
                var data = (WindowData)item;
                if (data.Handle == handle)
                    return i;
            }
            // Not found.
            return -1;
        }


        private void AdjustClickCoordinatesToWindowRectangle(WinApi.RECT rectangle)
        {
            if (numericUpDownCoordX.Value > rectangle.right)
            {
                numericUpDownCoordX.Value = Math.Min(rectangle.right, numericUpDownCoordX.Maximum);
            }
            if (numericUpDownCoordY.Value > rectangle.bottom)
            {
                numericUpDownCoordY.Value = Math.Min(rectangle.bottom, numericUpDownCoordY.Maximum);
            }
        }


        /// <summary>
        /// Simulates a mouse click on a window.
        /// </summary>
        /// <param name="window">the target window to click onto</param>
        /// <param name="coordinates">encoded coordinates for the click</param>
        /// <param name="button">the mouse button to click (only left, right
        /// and middle mouse button are supported)</param>
        private static void SimulateMouseClick(WindowData window, IntPtr coordinates, MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_LBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_LBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.Right:
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_RBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_RBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.Middle:
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_MBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.SendMessage(window.Handle, WinApi.WMConstants.WM_MBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.XButton1:
                case MouseButtons.XButton2:
                case MouseButtons.None:
                default:
                    // No simulation capability provided.
                    break;
            }
        }


        /// <summary>
        /// Simulates a mouse click on a window, in an asynchronous manner.
        /// </summary>
        /// <param name="window">the target window to click onto</param>
        /// <param name="coordinates">encoded coordinates for the click</param>
        /// <param name="button">the mouse button to click (only left, right
        /// and middle mouse button are supported)</param>
        private static void SimulateMouseClickAsync(WindowData window, IntPtr coordinates, MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_LBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_LBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.Right:
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_RBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_RBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.Middle:
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_MBUTTONDOWN, IntPtr.Zero, coordinates);
                    WinApi.PostMessage(window.Handle, WinApi.WMConstants.WM_MBUTTONUP, IntPtr.Zero, coordinates);
                    break;
                case MouseButtons.XButton1:
                case MouseButtons.XButton2:
                case MouseButtons.None:
                default:
                    // No simulation capability provided.
                    break;
            }
        }


        /// <summary>
        /// Triggers emission of click event messages, in an asynchronous manner.
        /// </summary>
        /// <param name="window">the target window to click onto</param>
        /// <param name="coordinates">encoded coordinates for the click</param>
        private void EmitClickEventsAsync(WindowData window, IntPtr coordinates)
        {
            if (cbLeftMouseButton.Checked)
            {
                SimulateMouseClickAsync(window, coordinates, MouseButtons.Left);
            }
            if (cbRightMouseButton.Checked)
            {
                SimulateMouseClickAsync(window, coordinates, MouseButtons.Right);
            }
            if (cbMiddleMouseButton.Checked)
            {
                SimulateMouseClickAsync(window, coordinates, MouseButtons.Middle);
            }
        }


        /// <summary>
        /// Triggers emission of click event messages.
        /// </summary>
        /// <param name="window">the target window to click onto</param>
        /// <param name="coordinates">encoded coordinates for the click</param>
        private void EmitClickEventsSync(WindowData window, IntPtr coordinates)
        {
            if (cbLeftMouseButton.Checked)
            {
                SimulateMouseClick(window, coordinates, MouseButtons.Left);
            }
            if (cbRightMouseButton.Checked)
            {
                SimulateMouseClick(window, coordinates, MouseButtons.Right);
            }
            if (cbMiddleMouseButton.Checked)
            {
                SimulateMouseClick(window, coordinates, MouseButtons.Middle);
            }
        }


        private void EmitClickEvents(WindowData window)
        {
            int coordinates = WinApi.CoordinatesToLParam(Convert.ToInt32(numericUpDownCoordX.Value), Convert.ToInt32(numericUpDownCoordY.Value));
            IntPtr coordParam = new(coordinates);
            bool asynchronous = rbAsync.Checked;
            if (asynchronous)
            {
                EmitClickEventsAsync(window, coordParam);
            }
            else
            {
                EmitClickEventsSync(window, coordParam);
            }
        }


        private void EnableOrDisableClickPropertyChanges(bool enable)
        {
            cbLeftMouseButton.Enabled = enable;
            cbRightMouseButton.Enabled = enable;
            cbMiddleMouseButton.Enabled = enable;
            numericUpDownInterval.Enabled = enable;
            numericUpDownCoordX.Enabled = enable;
            numericUpDownCoordY.Enabled = enable;
            rbSynchronous.Enabled = enable;
            rbAsync.Enabled = enable;
            btnRefresh.Enabled = enable;
            lbWindows.Enabled = enable;
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
            tsmiLoadPresetNow.Enabled = enable;
        }


        private void EnableClickPropertyChanges()
        {
            EnableOrDisableClickPropertyChanges(true);
        }


        private void DisableClickPropertyChanges()
        {
            EnableOrDisableClickPropertyChanges(false);
        }


        private void Start_Click(object sender, EventArgs e)
        {
            if (!PrerequisitesFulfilled())
                return;

            var w = GetSelectedWindowData();
            if (!w.HasValue)
            {
                MessageBox.Show("The selected item does not contain window data.",
                   "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var window = w.Value;
            if (!WinApi.GetClientRect(window.Handle, out WinApi.RECT rectangle))
            {
                MessageBox.Show("Could not get window's client area."
                    + Environment.NewLine + Environment.NewLine
                    + "Try to refresh the window list and select another window"
                    + " to get rid of this error.",
                    "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdjustClickCoordinatesToWindowRectangle(rectangle);

            timerClick.Tag = window;
            timerClick.Interval = Convert.ToInt32(numericUpDownInterval.Value);
            DisableClickPropertyChanges();
            timerClick.Start();
        }

        private void TimerClick_Tick(object sender, EventArgs e)
        {
            EmitClickEvents((WindowData)timerClick.Tag);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timerClick.Stop();
            EnableClickPropertyChanges();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Version_Click(object sender, EventArgs e)
        {
            var form = new VersionForm();
            form.ShowDialog();
            form.Dispose();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerClick.Stop();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshWindowList();
            LoadConfiguration();
        }

        private void LoadPresetAtStartup_Click(object sender, EventArgs e)
        {
            tsmiLoadPresetAtStartup.Checked = !tsmiLoadPresetAtStartup.Checked;
            ConfigurationManager.Current.LoadPresetAtStart = tsmiLoadPresetAtStartup.Checked;
            SaveConfiguration(SuccessDialog.Hide);
        }

        private void SaveCurrentSettingsAsPreset_Click(object sender, EventArgs e)
        {
            StoreSettingsInPreset();
            SaveConfiguration(SuccessDialog.Show);
        }


        /// <summary>
        /// Updates the current configuration with all currently set options.
        /// </summary>
        private void StoreSettingsInPreset()
        {
            var conf = ConfigurationManager.Current;
            conf.LoadPresetAtStart = tsmiLoadPresetAtStartup.Checked;
            var window = GetSelectedWindowData();
            conf.Preset.WindowCaption = window.HasValue ? window.Value.Caption : "";
            conf.Preset.Left = cbLeftMouseButton.Checked;
            conf.Preset.Middle = cbMiddleMouseButton.Checked;
            conf.Preset.Right = cbRightMouseButton.Checked;
            conf.Preset.IntervalMilliseconds = Convert.ToInt32(numericUpDownInterval.Value);
            conf.Preset.X = Convert.ToInt32(numericUpDownCoordX.Value);
            conf.Preset.Y = Convert.ToInt32(numericUpDownCoordY.Value);
            conf.Preset.Synchronous = rbSynchronous.Checked;
        }


        /// <summary>
        /// Updates the settings with the values from the preset.
        /// </summary>
        private void LoadSettingsFromPreset()
        {
            var conf = ConfigurationManager.Current;
            if (!string.IsNullOrWhiteSpace(conf.Preset.WindowCaption))
            {
                int idx = GetWindowIndexByCaption(conf.Preset.WindowCaption);
                if (idx >= 0)
                    lbWindows.SelectedIndex = idx;
            }
            cbLeftMouseButton.Checked = conf.Preset.Left;
            cbMiddleMouseButton.Checked = conf.Preset.Middle;
            cbRightMouseButton.Checked = conf.Preset.Right;
            numericUpDownInterval.Value = Math.Clamp(conf.Preset.IntervalMilliseconds, numericUpDownInterval.Minimum, numericUpDownInterval.Maximum);
            numericUpDownCoordX.Value = Math.Clamp(conf.Preset.X, numericUpDownCoordX.Minimum, numericUpDownCoordX.Maximum);
            numericUpDownCoordY.Value = Math.Clamp(conf.Preset.Y, numericUpDownCoordY.Minimum, numericUpDownCoordY.Maximum);
            rbSynchronous.Checked = conf.Preset.Synchronous;
            rbAsync.Checked = !conf.Preset.Synchronous;
        }


        /// <summary>
        /// Indicates whether a message shall be displayed when saving succeeded.
        /// </summary>
        enum SuccessDialog
        {
            /// <summary>
            /// Hide success dialog.
            /// </summary>
            Hide,

            /// <summary>
            /// Show success dialog.
            /// </summary>
            Show
        }


        /// <summary>
        /// Saves the current configuration to the user's profile directory.
        /// </summary>
        private static void SaveConfiguration(SuccessDialog hide_show)
        {
            var path = ConfigurationManager.GetConfigurationPath();
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Failed to save preset!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(directory))
            {
                MessageBox.Show("Could not determine directory path to save the configuration!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.IO.Directory.Exists(directory))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(directory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create directory to save the configuration!"
                        + Environment.NewLine + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!ConfigurationManager.Current.SaveToFile(path))
            {
                MessageBox.Show("Could not save the configuration!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hide_show == SuccessDialog.Show)
            {
                MessageBox.Show("Configuration was saved successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadConfiguration()
        {
            var path = ConfigurationManager.GetConfigurationPath();
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }
            if (!System.IO.File.Exists(path))
            {
                ConfigurationManager.Current = ConfigurationManager.Default;
                return;
            }
            if (!ConfigurationManager.Current.LoadFromFile(path))
            {
                MessageBox.Show("Could not load the configuration!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tsmiLoadPresetAtStartup.Checked = ConfigurationManager.Current.LoadPresetAtStart;
            if (ConfigurationManager.Current.LoadPresetAtStart)
            {
                LoadSettingsFromPreset();
            }
        }

        private void LoadPresetNow_Click(object sender, EventArgs e)
        {
            LoadSettingsFromPreset();
        }
    }
}
