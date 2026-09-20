/*
    This file is part of the mouse click simulator test suite.
    Copyright (C) 2026  Dirk Stolle

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
using mouse_click_simulator.window_handling;

namespace mouse_click_simulator_tests.window_handling
{
    [TestClass]
    public class WindowData_Tests
    {
        /// <summary>
        /// Checks whether CompareTo() compares by window caption.
        /// </summary>
        [TestMethod]
        public void CompareTo_Less_Greater()
        {
            var a = new WindowData
            {
                Caption = "Alice's App",
                Class = "AliceAppWndClass",
                Handle = 12345
            };

            var b = new WindowData
            {
                Caption = "Bob's App",
                Class = "AliceAppWndClass",
                Handle = 12345
            };

            Assert.IsLessThan(0, a.CompareTo(b));
            Assert.IsGreaterThan(0, b.CompareTo(a));
        }


        /// <summary>
        /// Checks whether CompareTo() compares by handle value when everything
        /// else is the same.
        /// </summary>
        [TestMethod]
        public void CompareTo_Handle()
        {
            var a = new WindowData
            {
                Caption = "Alice's App",
                Class = "AliceAppWndClass",
                Handle = 12345
            };

            var b = new WindowData
            {
                Caption = "Alice's App",
                Class = "AliceAppWndClass",
                Handle = 23456
            };

            Assert.IsLessThan(0, a.CompareTo(b));
            Assert.IsGreaterThan(0, b.CompareTo(a));
        }


        /// <summary>
        /// Checks whether the window caption comes first in the result of the
        /// ToString() method.
        /// </summary>
        [TestMethod]
        public void ToString_CaptionComesFirst()
        {
            var window = new WindowData
            {
                Caption = "Alice's App",
                Class = "AliceAppWndClass",
                Handle = 12345
            };

            Assert.StartsWith("\"" + window.Caption + "\"", window.ToString());
        }


        /// <summary>
        /// Checks whether the result of the ToString() method contains all
        /// relevant data.
        /// </summary>
        [TestMethod]
        public void ToString_ContainsAllData()
        {
            var window = new WindowData
            {
                Caption = "Bobs's App",
                Class = "BobAppWndClass",
                Handle = 54321
            };

            Assert.Contains(window.Caption, window.ToString());
            Assert.Contains(window.Class, window.ToString());
            Assert.Contains(window.Handle.ToString(), window.ToString());
        }
    }
}
