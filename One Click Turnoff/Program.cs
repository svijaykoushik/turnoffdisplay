﻿/***********************************************************************************
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
using System.Windows.Forms;
using Turn_off_display;
using System.Diagnostics;

namespace One_Click_Turn_Off
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            DisplayPower power = new Turn_off_display.DisplayPower();
            Turn_off_display.Setting settings = new Turn_off_display.Setting();
            if (settings.LockComputer)
            {
                power.lockComputer();
            }
            if (settings.ShowTrayIcon)
            {
                System.Diagnostics.Process.Start("Turn off display.exe");
            }
            power.turnOffMonitor();
            
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string crashFile = CrashDumper.dumpCrash((Exception)e.ExceptionObject);
            if (crashFile != string.Empty)
            {
                Process.Start("Turn off Crash reporter.exe", crashFile);
            }
            Application.Exit();
        }
    }
}
