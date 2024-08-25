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

namespace mouse_click_simulator
{
    public class ConfigurationManager
    {
        /// <summary>
        /// Gets the path to the configuration file.
        /// </summary>
        /// <returns>Returns the path to the configuration file, if possible.
        /// Returns null, if an error occurred.</returns>
        public static string? GetConfigurationPath()
        {
            string? roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create);
            if (string.IsNullOrWhiteSpace(roaming))
            {
                roaming = Environment.GetEnvironmentVariable("APPDATA", EnvironmentVariableTarget.Process);
            }
            if (string.IsNullOrWhiteSpace(roaming))
                return null;
            try
            {
                return System.IO.Path.Combine(roaming, "mouse-click-simulator", "configuration.xml");
            }
            catch
            {
                return null;
            }
        }


        private static Configuration cur = new();


        /// <summary>
        /// Gets the default configuration instance.
        /// </summary>
        public static Configuration Default
        {
            get
            {
                return new();
            }
        }


        /// <summary>
        /// Gets the current configuration instance.
        /// </summary>
        public static Configuration Current
        {
            get
            {
                return cur;
            }

            set
            {
                cur = value;
            }
        }
    }
}
