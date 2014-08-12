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
    static class InternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int Reserved);

        /// <summary>
        /// Checks wether the computer is connected to the internet
        /// </summary>
        /// <returns>True if connected to the internet and false if not</returns>
        public static bool checkConntection()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}
