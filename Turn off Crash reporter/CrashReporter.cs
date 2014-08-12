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

namespace Turn_off_Crash_reporter
{
    class CrashReporter
    {
        private string filePath;
        private Mailer mailer;

        public CrashReporter(string reportPath)
        {
            mailer=new Mailer();
            filePath=reportPath;            
        }

        private void setProperties()
        {
            mailer.Host = "smtp.gmail.com";//"127.0.0.1";
            mailer.PortNumber = 587;//25;
            mailer.UserName = "crashreporterforclockalert@gmail.com";//"webmaster@clockalertapp.co.nr";
            mailer.Password = "123clockalert456";//"koushik";
            mailer.Sender = "crashreporterforclockalert@gmail.com";//"webmaster@clockalertapp.co.nr";
            mailer.Reciever = "moon01man@gmail.com";//"info@clockalertapp.co.nr";
            mailer.Subject = "Crash report" + DateTime.Now.ToString();
            mailer.Message = readReport(filePath);
            mailer.EnableSSL = true;//false;
            mailer.configure();
        }
        private string readReport(string reportPath)
        {
            StreamReader reader = new StreamReader(reportPath);
            string report = reader.ReadToEnd();
            return report;
        }
        public void sendReport()
        {
            setProperties();
            mailer.send();
        }

    }
}
