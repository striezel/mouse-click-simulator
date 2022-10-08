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

namespace mouse_click_simulator_tests
{
    [TestClass]
    public class ConfigurationManager_Tests
    {
        /// <summary>
        /// Checks whether the GetConfigurationPath() method returns a valid path.
        /// </summary>
        [TestMethod]
        public void GetConfigurationPath()
        {
            var path = ConfigurationManager.GetConfigurationPath();
            Assert.IsNotNull(path);

            var path_low = path.ToLowerInvariant();
            var users = path_low.Contains("users");
            var appdata = path_low.Contains("appdata");
            var roaming = path_low.Contains("roaming");
            var systemprofile = path_low.Contains("systemprofile");

            Assert.IsTrue(users && appdata && roaming || systemprofile);
        }


        /// <summary>
        /// Checks whether the default instance is not null.
        /// </summary>
        [TestMethod]
        public void Default()
        {
            var def = ConfigurationManager.Default;
            Assert.IsNotNull(def);
        }


        /// <summary>
        /// Checks whether the current instance is not null and always returns
        /// the same instance.
        /// </summary>
        [TestMethod]
        public void Current()
        {
            var cur1 = ConfigurationManager.Current;
            Assert.IsNotNull(cur1);

            var cur2 = ConfigurationManager.Current;
            Assert.IsNotNull(cur2);

            Assert.IsTrue(ReferenceEquals(cur1, cur2));
        }


        /// <summary>
        /// Checks that current and default instance are not the same instance.
        /// </summary>
        [TestMethod]
        public void CurrentIsNotSameAsDefault()
        {
            var cur = ConfigurationManager.Current;
            var def = ConfigurationManager.Default;
            Assert.IsFalse(ReferenceEquals(cur, def));
        }
    }
}