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

namespace mouse_click_simulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!PrerequisitesFulfilled())
                return;

            // TODO: Implement click simulation.
            MessageBox.Show("Well, the simulation could start now, but there "
                + "is one problem ...\r\n\r\nThis feature is not implemented yet.",
                "Not implemented yet", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
