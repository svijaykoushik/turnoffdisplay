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
using System.Xml;

namespace Turn_off_display_Update_checker
{
    public partial class Form1 : Form
    {
        private Version newVersion, currentVersion;
        private XmlTextReader reader;
        private string url, elementName, xmlUrl;
        public Form1()
        {
            InitializeComponent();
            newVersion = null;
            currentVersion = null;
            reader = null;
            url = string.Empty;
            elementName = string.Empty;
            xmlUrl = string.Empty;
        }

        private void getVersion()
        {
            xmlUrl = "http://turnoffdisplay.sourceforge.net/version.xml";
            try
            {
                reader = new XmlTextReader(xmlUrl);
                reader.MoveToContent();
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "turnoff")
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            if (reader.NodeType == XmlNodeType.Text && reader.HasValue)
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = new Version(reader.Value);
                                        break;
                                    case "url":
                                        url = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Unable to connect to the update server. please try again later","Temproary network problem",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        public bool checkForUpdate()
        {
            if (Turn_off_display.InternetConnection.checkConntection())
            {
                getVersion();
                currentVersion = new Turn_off_display.aboutTurnoff().AssemblyVersionObject;//System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                //MessageBox.Show(currentVersion.ToString());
                if (currentVersion.CompareTo(newVersion) < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (System.Windows.Forms.DialogResult.Retry == System.Windows.Forms.MessageBox.Show("It seems there is no connection to the internet. Please connect to the internet.", "No internet connection", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Exclamation))
                {
                    checkForUpdate();
                }
                else
                {
                    Application.Exit();
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkForUpdate())
            {
                label1.Text = "A new version of Turn off diplay is available\n do you want to download the new version?";
                pictureBox1.Image = Properties.Resources.updateYes;
            }
            else
            {
                label1.Text = "This is already the latest version";
                pictureBox1.Image = Properties.Resources.updateNo;
                button2.Visible = false;
                button1.Text = "Ok";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkForUpdate())
                System.Diagnostics.Process.Start(url);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
