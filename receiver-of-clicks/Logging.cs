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

namespace receiver_of_clicks
{
    /// <summary>
    /// Handles some logging-related tasks.
    /// </summary>
    internal static class Logging
    {
        /// <summary>
        /// Initializes the configuration of NLog.LogManager with logging to console + file.
        /// </summary>
        public static void Initialize()
        {
            // create configuration object
            var config = new NLog.Config.LoggingConfiguration();

            // create targets and add them to the configuration 
            // --- rich text box
            var textBoxTarget = new NLog.Windows.Forms.RichTextBoxTarget();
            textBoxTarget.FormName = "ReceiverForm";
            textBoxTarget.ControlName = "rtbLogging";
            textBoxTarget.UseDefaultRowColoringRules = true;
            textBoxTarget.CreatedForm = false;
            textBoxTarget.Name = "rtb";
            config.AddTarget(textBoxTarget);
            // --- file
            var fileTarget = new NLog.Targets.FileTarget();
            config.AddTarget("file", fileTarget);

            // set target properties 
            textBoxTarget.Layout = @"${date:format=yyyy-MM-dd HH\:mm\:ss} - ${message}";
            fileTarget.FileName = GetLogFileName();
            fileTarget.Layout = @"${date:format=yyyy-MM-dd HH\:mm\:ss} [${logger}] ${message}";

            // define rules
#if DEBUG
            var rule1 = new NLog.Config.LoggingRule("*", NLog.LogLevel.Debug, textBoxTarget);
#else
            var rule1 = new NLog.Config.LoggingRule("*", NLog.LogLevel.Info, textBoxTarget);
#endif
            config.LoggingRules.Add(rule1);
            var rule2 = new NLog.Config.LoggingRule("*", NLog.LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);

            // activate the configuration
            NLog.LogManager.Configuration = config;
        }

        /// <summary>
        /// Gets a log file name for the application.
        /// </summary>
        /// <returns>Returns a log file name that includes the current date / time.</returns>
        private static string GetLogFileName()
        {
            string datePart = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            return Path.Combine(Path.GetTempPath(), "receiver-of-clicks_log_" + datePart + ".txt");
        }
    }
}
