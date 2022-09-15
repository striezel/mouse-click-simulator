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
using System.Runtime.InteropServices;
using System.Text;

namespace mouse_click_simulator.window_handling
{
    /// <summary>
    /// Callback for WinAPI's EnumWindows() function.
    /// </summary>
    /// <param name="handleToWindow">window handle</param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    public delegate bool EnumWindowsCallBack(IntPtr handleToWindow, IntPtr lParam);

    /// <summary>
    /// Contains imported Windows API functions.
    /// </summary>
    internal static class WinApi
    {
        [DllImport("user32.dll")]
        internal static extern bool EnumWindows(EnumWindowsCallBack cb, IntPtr param);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern int SendMessage(IntPtr hwnd, WMConstants message, int wParam, StringBuilder sb);

        [DllImport("user32.dll")]
        internal static extern int SendMessage(IntPtr hwnd, WMConstants message, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Rectangle structure that is used by GetClientRect() function.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            internal int left;
            internal int top;
            internal int right;
            internal int bottom;
        }

        /// <summary>
        /// Transforms a RECT to a human-readable string.
        /// </summary>
        /// <param name="r">the RECT instance</param>
        /// <returns>Returns a string containing the rectangle's coordinates.</returns>
        internal static string RectToString(RECT r)
        {
            return "{ left: " + r.left.ToString() + ", top: " + r.top.ToString()
                + ", right: " + r.right.ToString() + ", bottom: "
                + r.bottom.ToString() + " }";
        }

        internal enum WMConstants
        {
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,
            // left mouse button
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            // right mouse button
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            // middle mouse button
            WM_MBUTTONDOWN = 0x0207,
            WM_MBUTTONUP = 0x0208
        }


        /// <summary>
        /// Possible values / flags for mouse input-related messages
        /// WM_LBUTTONDOWN, WM_LBUTTONUP, WM_RBUTTONDOWN, WM_RBUTTONUP,
        /// WM_MBUTTONDOWN, and WM_MBUTTONUP. Those flags can be passed in the
        /// wParam parameter of SendMessage().
        /// </summary>
        internal enum MouseEventWParam: int
        {
            /// <summary>
            /// The left mouse button is down.
            /// </summary>
            MK_LBUTTON = 0x0001,

            /// <summary>
            /// The right mouse button is down.
            /// </summary>
            MK_RBUTTON = 0x0002,

            /// <summary>
            /// The Shift key is down.
            /// </summary>
            MK_SHIFT = 0x0004,

            /// <summary>
            /// The CTRL key is down.
            /// </summary>
            MK_CONTROL =0x0008,

            /// <summary>
            /// The middle mouse button is down.
            /// </summary>
            MK_MBUTTON = 0x0010,

            /// <summary>
            /// The first X button is down.
            /// </summary>
            MK_XBUTTON1 = 0x0020,

            /// <summary>
            /// The seconds X button is down.
            /// </summary>
            MK_XBUTTON2 = 0x0040
        }

        /// <summary>
        /// Translates mouse coordinates to the proper form used by the lParam
        /// parameter of SendMessage().
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <returns>Returns an int suitable for use in lParam parameter of
        /// SendMessage().</returns>
        internal static int CoordinatesToLParam(int x, int y)
        {
            return (x & 0x0000ffff) | (y << 16);
        }
    }
}
