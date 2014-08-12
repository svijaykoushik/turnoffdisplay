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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace Turn_off_Crash_reporter
{
    class Mailer
    {
        #region Mailer Attributes
        private string sender, receiver, subject, message;
        private string host, userName, password;
        private int port;
        private bool ssl;
        private SmtpClient client;
        #endregion
        #region Mailer Properties
        public string Sender
        {
            set
            {
                if (Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                    sender = value;
            }
        }

        public string Reciever
        {
            set
            {
                if (Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                    receiver = value;
            }
        }

        public string Subject
        {
            set { subject = value; }
        }

        public string Message
        {
            set { message = value; }
        }

        public string Host
        {
            set { host = value; }
        }

        public string UserName
        {
            set { userName = value; }
        }

        public string Password
        {
            set { password = value; }
        }

        public int PortNumber
        {
            set{port=value;}
        }

        public bool EnableSSL
        {
            set { ssl = value; }
        }
        #endregion

        public Mailer()
        {
            sender = string.Empty;
            receiver = string.Empty;
            subject = string.Empty;
            message = string.Empty;
            host = string.Empty;
            userName = string.Empty;
            password = string.Empty;
            port = 0;
            ssl = false;
        }

        public void configure()
        {
            client = new SmtpClient(host);
            client.Port = port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(userName, password);
            client.EnableSsl = ssl;
        }
        public void send()
        {
            MailMessage message = new MailMessage(sender,receiver);
            message.Subject = subject;
            message.Body = this.message;
            if (Turn_off_display.InternetConnection.checkConntection())
            {
                try
                {
                    client.Send(message);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("There might be a temproary network problem\nUnable to send report", "Unable to send report", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                System.Windows.Forms.DialogResult rslt = System.Windows.Forms.MessageBox.Show("There is no internet connection!\nPlease connect the computer to connect to the internet or check your connection settings.\n After connecting to the internet click \"Retry\".", "No internet connection", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Exclamation);
                if (rslt == System.Windows.Forms.DialogResult.Retry)
                {
                    send();
                }
            }
        }

    }
}
