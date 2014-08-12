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
using System.IO;

namespace Turn_off_display
{
    public static class CrashDumper
    {
        private static string header, mesage, footer,path;
        private static aboutTurnoff about=new aboutTurnoff();
        private static StreamWriter writer;

        public static string dumpCrash(Exception exception)
        {
            path = Path.GetTempPath() + about.AssemblyCompany + Path.DirectorySeparatorChar + about.AssemblyTitle + Path.DirectorySeparatorChar;
            path = path.Replace(' ' , '_');
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            header = DateTime.Now.ToString() + Environment.NewLine;
            try
            {                
                mesage = String.Format(@"Application name: {0}{9}Application version: {1}{9}OS version: {2}{9}CLR version: {3}{9}Error type: {4}{9}Message: {5}{9}Source: {6}{9}Inner exception: {7}{9}Stack trace: {8}{9}", about.AssemblyTitle,
                                                          about.AssemblyVersion,
                                                          Environment.OSVersion.VersionString,
                                                          Environment.Version.ToString(),
                                                          exception.GetType().ToString(),
                                                          exception.Message,
                                                          exception.Source,
                                                          (exception.InnerException!=null)?exception.InnerException.ToString():"none",
                                                          exception.StackTrace,
                                                          Environment.NewLine);
                footer = "*********End of report*************" + Environment.NewLine;
                string fileName = about.AssemblyTitle + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + "dump.crash";
                string reportPath = path + fileName;
                reportPath = reportPath.Replace(" ", "_");
                //System.Windows.Forms.MessageBox.Show(reportPath);
                writer = new StreamWriter(reportPath, true);
                writer.WriteLine(header);
                writer.WriteLine(mesage);
                writer.WriteLine(footer);
                writer.Close();
                return reportPath;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Some thing went wrong" + Environment.NewLine + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return string.Empty;
        }
                                    
    }
}
