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
using System.Runtime.InteropServices;

namespace Turn_off_display
{
    public class DisplayPower
    {
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MONITORPOWER = 0xF170;
        private const int HWND_BROADCAST = 0xFFFF;
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        
        /// <summary>
        /// Locks the computer.
        /// </summary>
        [DllImport("user32.dll")]
        private static extern void LockWorkStation();
        public DisplayPower()
        {

        }
        /// <summary>
        /// Turns off the monitor or display.
        /// </summary>
        /// <param name="Handle">The Handle of the current window or form.</param>
        public void turnOffMonitor(int Handle)
        {
            SendMessage(Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        /// <summary>
        /// Turns off the monitor display.
        /// </summary>
        public void turnOffMonitor()
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        /// <summary>
        /// Locks the computer or workstation.
        /// </summary>
        public void lockComputer()
        {
            LockWorkStation();
        }
    }
}
