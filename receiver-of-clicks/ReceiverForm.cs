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

namespace receiver_of_clicks
{
    /// <summary>
    /// Windows form that logs the mouse clicks it receives.
    /// </summary>
    public partial class ReceiverForm : Form
    {
        /// <summary>
        /// NLog.Logger for Program
        /// </summary>
        private static readonly NLog.Logger logger = NLog.LogManager.GetLogger(typeof(ReceiverForm).FullName);

        public ReceiverForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for mouse click events that logs clicks.
        /// </summary>
        /// <param name="sender">WinForms control that triggered the event</param>
        /// <param name="e">event data, e. g. button, location, etc.</param>
        private void LogClickEvent(object sender, MouseEventArgs e)
        {
            logger.Info(sender.GetType().Name + " was clicked at point "
                + e.Location.ToString() + " with "
                + e.Button.ToString().ToLowerInvariant() + " mouse button "
                + (e.Clicks == 1 ? "once" : e.Clicks.ToString() + " times") + ".");
        }

        private void ReceiverForm_Shown(object sender, EventArgs e)
        {
            // Logging can only be intialized after the form has been created,
            // so static initialization is not enough.
            Logging.Initialize();
        }
    }
}