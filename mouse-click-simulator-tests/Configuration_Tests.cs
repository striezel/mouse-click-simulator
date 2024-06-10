/*
    This file is part of the mouse click simulator test suite.
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using mouse_click_simulator;
using System.IO;

namespace mouse_click_simulator_tests
{
    [TestClass]
    public class Configuration_Tests
    {
        private static string GetTempFileName()
        {
            return Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        }
        

        /// <summary>
        /// Checks whether a configuration can be saved to a file.
        /// </summary>
        [TestMethod]
        public void SaveToFile()
        {
            var conf = new Configuration();
            var path = GetTempFileName();
            try
            {
                var success = conf.SaveToFile(path);
                Assert.IsTrue(success);
            }
            catch
            {
                Assert.Fail("Attempting to save a configuration threw an exception!");
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }


        /// <summary>
        /// Checks whether a configuration can be saved to a file.
        /// </summary>
        [TestMethod]
        public void SaveToFile_Failure()
        {
            var conf = new Configuration();
            var path = "C:\\Path\\Does\\Not\\Exist.tmp";
            try
            {
                var success = conf.SaveToFile(path);
                Assert.IsFalse(success);
            }
            catch
            {
                Assert.Fail("Attempting to save to a directory that does not exist threw an exception!");
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }


        /// <summary>
        /// Checks whether a configuration can be loaded from a non-existent file.
        /// </summary>
        [TestMethod]
        public void LoadFromFile_Failure()
        {
            var conf = new Configuration();
            var path = "C:\\Path\\Does\\Really\\Not\\Exist.tmp";
            try
            {
                var success = conf.LoadFromFile(path);
                Assert.IsFalse(success);
            }
            catch
            {
                Assert.Fail("Attempting to load from a file that does not exist threw an exception!");
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }


        /// <summary>
        /// Checks whether a configuration can be saved to a file and loaded
        /// from that file again.
        /// </summary>
        [TestMethod]
        public void SaveLoadRoundtrip()
        {
            var conf = new Configuration
            {
                LoadPresetAtStart = true,
                Preset =
                {
                    WindowCaption = "Example Window Text",
                    Left = false,
                    Middle = true,
                    Right = true,
                    IntervalMilliseconds = 555,
                    X = 123,
                    Y = 456,
                    Synchronous = false
                }
            };
            var path = GetTempFileName();
            try
            {
                var success = conf.SaveToFile(path);
                Assert.IsTrue(success);
                var loaded = new Configuration();
                Assert.IsTrue(loaded.LoadFromFile(path));
                Assert.AreEqual(conf.LoadPresetAtStart, loaded.LoadPresetAtStart);
                Assert.AreEqual(conf.Preset.WindowCaption, loaded.Preset.WindowCaption);
                Assert.AreEqual(conf.Preset.Left, loaded.Preset.Left);
                Assert.AreEqual(conf.Preset.Middle, loaded.Preset.Middle);
                Assert.AreEqual(conf.Preset.Right, loaded.Preset.Right);
                Assert.AreEqual(conf.Preset.IntervalMilliseconds, loaded.Preset.IntervalMilliseconds);
                Assert.AreEqual(conf.Preset.X, loaded.Preset.X);
                Assert.AreEqual(conf.Preset.Y, loaded.Preset.Y);
                Assert.AreEqual(conf.Preset.Synchronous, loaded.Preset.Synchronous);
            }
            catch
            {
                Assert.Fail("Attempting to save and re-load a configuration threw an exception!");
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }
    }
}
