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

namespace mouse_click_simulator.window_handling
{
    /// <summary>
    /// Contains basic data of a window.
    /// </summary>
    public struct WindowData : IComparable<WindowData>
    {
        /// <summary>
        /// handle to the window
        /// </summary>
        public IntPtr Handle = IntPtr.Zero;

        /// <summary>
        /// caption of the window, i. e. usually it's title bar
        /// </summary>
        public string Caption = "";

        /// <summary>
        /// name of the window class
        /// </summary>
        public string Class = "";


        public WindowData()
        {
            Handle = IntPtr.Zero;
            Caption = "";
            Class = "";
        }

        public int CompareTo(WindowData other)
        {
            int c = Caption.CompareTo(other.Caption);
            if (c != 0)
                return c;
            return Handle.CompareTo(other.Handle);
        }

        public override string ToString()
        {
            return "Window " + Handle.ToString() + ", \"" + Caption + "\", " + Class;
        }
    }
}
