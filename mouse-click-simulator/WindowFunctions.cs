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

using mouse_click_simulator.window_handling;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace mouse_click_simulator
{
    /// <summary>
    /// Contains window-related functions. Those may rely on WinAPI and only
    /// work on a Windows operating system.
    /// </summary>
    internal static class WindowFunctions
    {
        
        /// <summary>
        /// Determines whether there data contains enough information to keep
        /// it in the list of available windows.
        /// </summary>
        /// <param name="data">the data instance to check</param>
        /// <returns>Returns true, if data shall be kept.
        /// Returns false otherwise.</returns>
        private static bool KeepWindowData(WindowData data)
        {
            return !string.IsNullOrEmpty(data.Caption)
                && (data.Caption != "Default IME")
                && (data.Caption != "Hidden Window");
        }


        /// <summary>
        /// This is a callback implementation for WinAPI's EnumWindows() function.
        /// It adds all windows which have enough data to identify them to the
        /// list of WindowData elements which is passed as pointer in lParam.
        /// </summary>
        /// <param name="handleToWindow">handle of the window to enumerate</param>
        /// <param name="lParam">opaque pointer to WindowData list</param>
        /// <returns>Always returns true.</returns>
        /// <exception cref="InvalidCastException">if lParam cannot be cast to
        /// a generic list of WindowData elements</exception>
        private static bool AddWindowToList(IntPtr handleToWindow, IntPtr lParam)
        {
            GCHandle gch = GCHandle.FromIntPtr(lParam);
            if (gch.Target is not List<WindowData> list)
            {
                throw new InvalidCastException("GCHandle target could not be cast to List<WindowData>!");
            }
            var data = GetWindowData(handleToWindow);
            if (KeepWindowData(data))
            {
                list.Add(data);
            }
            return true;
        }

        static WindowData GetWindowData(IntPtr handleToWindow)
        {
            var captionBuilder = new StringBuilder(1024);
            var classNameBuilder = new StringBuilder(1024);
            WinApi.GetWindowText(handleToWindow, captionBuilder, captionBuilder.Capacity);
            if (WinApi.GetClassName(handleToWindow, classNameBuilder, classNameBuilder.Capacity) == 0)
            {
                classNameBuilder.Clear();
            }
            var data = new WindowData()
            {
                Handle = handleToWindow,
                Class = classNameBuilder.ToString()
            };
            if (captionBuilder.ToString() != string.Empty)
            {
                data.Caption = captionBuilder.ToString();
            }
            else
            {
                captionBuilder = new StringBuilder(Convert.ToInt32(WinApi.SendMessage(data.Handle, WinApi.WMConstants.WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero)) + 1);
                WinApi.SendMessage(data.Handle, WinApi.WMConstants.WM_GETTEXT, captionBuilder.Capacity, captionBuilder);
                data.Caption = captionBuilder.ToString();
            }
            return data;
        }

        internal static List<WindowData>? ListWindows()
        {
            var windows = new List<WindowData>();
            GCHandle gch = GCHandle.Alloc(windows);
            try
            {
                if (!WinApi.EnumWindows(AddWindowToList, GCHandle.ToIntPtr(gch)))
                {
                    return null;
                }
            }
            finally
            {
                if (gch.IsAllocated)
                    gch.Free();
            }

            return windows;
        }
    }
}
