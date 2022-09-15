/*
    This file is part of the mouse click simulator.
    Copyright (C) 2022  Dirk Stolle

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
            btnRefresh.Enabled = false;
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
            object item = lbWindows.SelectedItem;
            if (item.GetType().FullName != typeof(WindowData).FullName)
            {
                return null;
            }
            return (WindowData)item;
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
        /// <param name="window">the target window to click onto.</param>
        /// <param name="coordinates">encoded coordinates for the click</param>
        /// <param name="button">the mouse button to click</param>
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

        private void EmitClickEvents(WindowData window)
        {
            int coordinates = WinApi.CoordinatesToLParam(Convert.ToInt32(numericUpDownCoordX.Value), Convert.ToInt32(numericUpDownCoordY.Value));
            IntPtr coordParam = new(coordinates);

            if (cbLeftMouseButton.Checked)
            {
                SimulateMouseClick(window, coordParam, MouseButtons.Left);
            }
            if (cbRightMouseButton.Checked)
            {
                SimulateMouseClick(window, coordParam, MouseButtons.Right);
            }
            if (cbMiddleMouseButton.Checked)
            {
                SimulateMouseClick(window, coordParam, MouseButtons.Middle);
            }
        }

        void EnableOrDisableClickPropertyChanges(bool enable)
        {
            cbLeftMouseButton.Enabled = enable;
            cbRightMouseButton.Enabled = enable;
            cbMiddleMouseButton.Enabled = enable;
            numericUpDownInterval.Enabled = enable;
            numericUpDownCoordX.Enabled = enable;
            numericUpDownCoordY.Enabled = enable;
            btnRefresh.Enabled = enable;
            lbWindows.Enabled = enable;
            btnStart.Enabled = enable;
            btnStop.Enabled = !enable;
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
                MessageBox.Show("Could not get window's client area.",
                    "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdjustClickCoordinatesToWindowRectangle(rectangle);
            
            timerClick.Tag = window;
            timerClick.Interval = Convert.ToInt32(numericUpDownInterval.Value);
            EnableOrDisableClickPropertyChanges(false);
            timerClick.Start();
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            EmitClickEvents((WindowData)timerClick.Tag);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timerClick.Stop();
            EnableOrDisableClickPropertyChanges(true);
        }
    }
}
