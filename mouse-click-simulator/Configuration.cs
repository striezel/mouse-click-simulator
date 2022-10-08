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
using System.IO;
using System.Xml.Serialization;

namespace mouse_click_simulator
{
    public class Configuration
    {
        /// <summary>
        /// Creates a configuration with default settings.
        /// </summary>
        public Configuration()
        {
            LoadPresetAtStart = false;
            Preset = new UiPreset();
        }
        
        /// <summary>
        /// Whether to load the preset at program start.
        /// </summary>
        public bool LoadPresetAtStart { get; set; }
        
        /// <summary>
        /// The configured UI preset.
        /// </summary>
        public UiPreset Preset { get; set; }


        /// <summary>
        /// Saves the configuration's data to the given file.
        /// </summary>
        /// <param name="path">file name where the data shall be saved</param>
        /// <returns>Returns whether the save operation was successful.</returns>
        public bool SaveToFile(string path)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                TextWriter writer = new StreamWriter(path);
                serializer.Serialize(writer, this);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Loads the configuration's data from the given file.
        /// </summary>
        /// <param name="path">file from which the data shall be read</param>
        /// <returns>Returns whether the load operation was successful.</returns>
        public bool LoadFromFile(string path)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                var stream = new FileStream(path, FileMode.Open);
                Configuration data = (Configuration)serializer.Deserialize(stream);
                stream.Close();
                if (data == null)
                    return false;
                LoadPresetAtStart = data.LoadPresetAtStart;
                Preset = data.Preset;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
