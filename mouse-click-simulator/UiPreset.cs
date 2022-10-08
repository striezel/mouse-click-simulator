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

namespace mouse_click_simulator
{
    /// <summary>
    /// Contains data for a UI preset of selected options.
    /// </summary>
    public  class UiPreset
    {
        /// <summary>
        /// Creates an UiPreset instance with default values.
        /// </summary>
        public UiPreset()
        {
            Left = true;
            Middle = false;
            Right = false;

            IntervalMilliseconds = 1000;

            X = 0;
            Y = 0;

            Synchronous = true;
        }

        /// <summary>
        /// Whether the left mouse button option is checked.
        /// </summary>
        public bool Left { get; set; }

        /// <summary>
        /// Whether the middle mouse button option is checked.
        /// </summary>
        public bool Middle { get; set; }

        /// <summary>
        /// Whether the right mouse button option is checked.
        /// </summary>
        public bool Right { get; set; }

        /// <summary>
        /// Click interval in milliseconds.
        /// </summary>
        public int IntervalMilliseconds { get; set; }

        /// <summary>
        /// X coordinate for the mouse click
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate for the mouse click
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Whether messages are sent in a synchronous way.
        /// </summary>
        public bool Synchronous { get; set; }
    }
}
