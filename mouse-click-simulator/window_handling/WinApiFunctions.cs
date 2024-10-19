/*
    This file is part of the mouse click simulator.
    Copyright (C) 2022, 2024  Dirk Stolle

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
    /// <param name="handleToWindow">window handle to a topl-level window</param>
    /// <param name="lParam">application-defined value given in EnumWindows()</param>
    /// <returns>Returns true, if the enumeration shall continue.
    /// Returns false, if the enumeration shall be stopped.</returns>
    public delegate bool EnumWindowsCallBack(IntPtr handleToWindow, IntPtr lParam);

    /// <summary>
    /// Contains imported Windows API functions.
    /// 
    /// Basically, everything inside that class is just "glue code" which allows
    /// us to use some selected Windows API functions from C# code.
    /// </summary>
    internal static class WinApi
    {
        /// <summary>
        /// Enumerates all top-level windows on the screen by passing the handle
        /// to each window, in turn, to an application-defined callback function.
        /// EnumWindows continues until the last top-level window is enumerated
        /// or the callback function returns FALSE.
        /// </summary>
        /// <param name="cb">application-defined callback function</param>
        /// <param name="param">application-defined value that is passed to the
        /// callback function</param>
        /// <returns>Returns true in case of success.
        /// Returns false in case of error.
        /// If the callback returns false / zero, the return value is also false.
        /// In that case the callback function should have called SetLastError()
        /// to set a meaningful error code to be returned to the caller of the
        /// EnumWindows() function.</returns>
        [DllImport("user32.dll")]
        internal static extern bool EnumWindows(EnumWindowsCallBack cb, IntPtr param);


        /// <summary>
        /// Retrieves the name of the class to which the specified window belongs.
        /// </summary>
        /// <param name="hWnd">handle to the window</param>
        /// <param name="lpClassName">(output parameter) the class name string</param>
        /// <param name="nMaxCount">The length of the lpClassName buffer, in
        /// characters. The buffer must be large enough to include the
        /// terminating null character. Otherwise, the class name string is
        /// truncated to nMaxCount-1 characters.</param>
        /// <returns>In case of success, the number of characters copied to the
        /// buffer (not including the terminating null character) is returned.
        /// In case of failure, zero is returned. In that case call
        /// GetLastError() to get information about the error.</returns>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);


        /// <summary>
        /// Retrieves the coordinates of a window's client area.
        /// The client coordinates specify the upper-left and lower-right
        /// corners of the client area. Because client coordinates are relative
        /// to the upper-left corner of a window's client area, the coordinates
        /// of the upper-left corner are (0,0).
        /// </summary>
        /// <param name="hWnd">handle to the window</param>
        /// <param name="lpRect">pointer to the RECT structure where the client
        /// coordinates will be stored</param>
        /// <returns>Returns true in case of success.
        /// Returns false, if the function failed.</returns>
        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);


        /// <summary>
        /// Copies the text of the specified window's title bar (if it has one)
        /// into a buffer.
        /// </summary>
        /// <param name="hWnd">handle to the window containing the text</param>
        /// <param name="text">buffer that will receive the text</param>
        /// <param name="count">maximum number of characters to copy to the
        /// buffer, including the NUL terminator</param>
        /// <returns>In case of success, the length of the copied string (in
        /// characters) is returned, not including the NUL terminator.
        /// Returns zero, if the window has no title bar or text or the text is
        /// empty. Also returns zero if the handle is invalid.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        internal static extern int PostMessage(IntPtr hwnd, WMConstants message, IntPtr wParam, IntPtr lParam);

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


        /// <summary>
        /// Message type constants for use with WinAPI's SendMessage() function.
        /// </summary>
        internal enum WMConstants
        {
            // window caption
            /// <summary>
            /// Copies the text that corresponds to a window into a buffer
            /// provided by the caller.
            /// </summary>
            WM_GETTEXT = 0x000D,

            /// <summary>
            /// Determines the length of the text associated with a window
            /// (in characters, not bytes).
            /// </summary>
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
        internal enum MouseEventWParam : int
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
            MK_CONTROL = 0x0008,

            /// <summary>
            /// The middle mouse button is down.
            /// </summary>
            MK_MBUTTON = 0x0010,

            /// <summary>
            /// The first X button is down.
            /// </summary>
            MK_XBUTTON1 = 0x0020,

            /// <summary>
            /// The second X button is down.
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
