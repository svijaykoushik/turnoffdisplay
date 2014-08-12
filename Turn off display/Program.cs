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
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Turn_off_display
{
    static class Program
    {
        public enum ShowWindowConstants
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        };
        [DllImport("User32.dll")]
        public static extern int ShowWindowAsync(IntPtr hWnd , int swCommand);

        private static Process currentProcess = Process.GetCurrentProcess();
        private static Process[] runningProcess = Process.GetProcessesByName(currentProcess.ProcessName);

        public static Process[] RunningProcesses
        {
            get
            {
                return runningProcess;
            }
        }
        public static int NumberOfPriorProcesses
        {
            get
            {
                return runningProcess.Length;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            if (NumberOfPriorProcesses == 1)
            {                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (StartApp app = new StartApp())
                {
                    app.startApplication();
                    Application.Run();
                }
            }
            else
            {
                ShowWindowAsync(RunningProcesses[0].MainWindowHandle, (int)ShowWindowConstants.SW_SHOWMINIMIZED);
                ShowWindowAsync(RunningProcesses[0].MainWindowHandle, (int)ShowWindowConstants.SW_RESTORE);
            }
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
