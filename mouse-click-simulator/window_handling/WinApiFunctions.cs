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

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        internal static extern int SendMessage(IntPtr hwnd, WMConstants message, int wParam, StringBuilder sb);

        [DllImport("user32.dll")]
        internal static extern int SendMessage(IntPtr hwnd, WMConstants message, IntPtr wParam, IntPtr lParam);

        internal enum WMConstants
        {
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E
        }
    }
}
