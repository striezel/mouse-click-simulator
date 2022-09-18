/*
    This file is part of the mouse click simulator.
    Copyright (C) 2017, 2022  Dirk Stolle

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
    /// Provides access to some Git information for the updater.
    /// </summary>
    public static class GitInfo
    {
        /// <summary>
        /// Gets the hexadecimal SHA1 hash of the current commit (40 hex digits).
        /// </summary>
        /// <returns>Returns the SHA1 hash of the current commit.</returns>
        public static string Commit()
        {
            return Properties.Resources.git_hash.Trim();
        }


        /// <summary>
        /// Gets the date of the last commit (e.g. "2017-01-29 14:59:33 +0200").
        /// </summary>
        /// <returns>Returns the date of the last commit.</returns>
        public static string CommitDate()
        {
            return Properties.Resources.git_date.Trim();
        }


        /// <summary>
        /// Gets a Git-like description (e.g. "v2017.04.18-5-gabcdef") of the current commit.
        /// </summary>
        /// <returns>Returns a Git-like description (e.g. "v2017.04.18-5-gabcdef").</returns>
        public static string Description()
        {
            return Properties.Resources.git_description.Trim();
        }
    } // class
} // namespace
