/***********************************************************************************
This file is part of Turn off display.

    Turn off display is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License version 3 as published by
    the Free Software Foundation.

    Turn off display is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Turn off display.  If not, see <http://www.gnu.org/licenses/>.
*************************************************************************************/
using System;
using System.Runtime.InteropServices;

namespace Turn_off_display
{
    public static class WindowHandle
    {
        private static IntPtr hWnd;
        private static int handle;
        [DllImport("user32.dll",SetLastError=true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Gets the current window handle and returns it aas 32 bit signed integer
        /// </summary>
        /// <returns>handle</returns>
        public static int getCurrentWindowHandle()
        {
            hWnd = GetForegroundWindow();
            handle = hWnd.ToInt32();
            return handle;
        }

    }
}
