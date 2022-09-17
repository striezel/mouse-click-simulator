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

using System;
using System.Windows.Forms;

namespace mouse_click_simulator
{
    /// <summary>
    /// Form that shows version information and third party licenses.
    /// </summary>
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Sets the icon of the form.
        /// </summary>
        private void LoadIcon()
        {
            Icon = System.Drawing.Icon.FromHandle(Properties.Resources.information.GetHicon());
        }

        private void VersionForm_Load(object sender, EventArgs e)
        {
            LoadIcon();
            LoadVersionData();
            LoadLicenseData();
        }


        /// <summary>
        /// Loads the application version into the corresponding GUI elements.
        /// </summary>
        private void LoadVersionData()
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            if (ver != null)
            {
                lblVersionData.Text = ver.ToString();
            }
        }


        /// <summary>
        /// Loads the license information of third party components into the
        /// corresponding GUI element.
        /// </summary>
        private void LoadLicenseData()
        {
            var cc_by_3_0 = Properties.Resources.cc_by_3_0_legalcode;
            string separator = Environment.NewLine
                + "========================================"
                + Environment.NewLine;
            rtbLicenses.Text = Properties.Resources.fugue_intro + cc_by_3_0
                + separator + Environment.NewLine
                + Properties.Resources.silk_intro + cc_by_3_0;
        }
    }
}
