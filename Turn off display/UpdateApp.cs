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
using System.Xml;

namespace Turn_off_display
{
    class UpdateApp
    {
        private Version newVersion, currentVersion;
        private XmlTextReader reader;
        private string url, elementName,xmlUrl;
        public UpdateApp()
        {
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
                reader=new XmlTextReader(xmlUrl);
                reader.MoveToContent();
                if(reader.NodeType==XmlNodeType.Element && reader.Name=="clockalert")
                {
                    while(reader.Read())
                    {
                        if(reader.NodeType==XmlNodeType.Element)
                            elementName=reader.Name;
                        else
                        {
                            if(reader.NodeType==XmlNodeType.Text &&reader.HasValue)
                            {
                                switch(elementName)
                                {
                                    case "version":
                                        newVersion=new Version(reader.Value);
                                        break;
                                    case "url":
                                        url=reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                /*CrashReporterUI reporter=new CrashReporterUI(ex);
                reporter.ShowDialog();*/
                //ErrorLog.logError(ex);
                System.Windows.Forms.MessageBox.Show("Unable to connect to the update server. please try again later", "Temproary network problem", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
        }

        public void checkForUpdate()
        {
            if (InternetConnection.checkConntection())
            {
                getVersion();
                currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                AppUpdate updateWindow;
                if (currentVersion.CompareTo(newVersion) < 0)
                {
                    updateWindow = new AppUpdate("A new version of Turn off diplay is available do you want to download the new version?", true,url);
                    /*if (System.Windows.Forms.DialogResult.Yes == updateWindow.ShowDialog())
                    {
                        System.Diagnostics.Process.Start(url);
                    }*/
                }
                else
                {
                    updateWindow = new AppUpdate("This is already the latest version", false,url);
                   
                }
                updateWindow.ShowDialog();
            }
            else
            {
                if (System.Windows.Forms.DialogResult.Retry == System.Windows.Forms.MessageBox.Show("It seems there is no connection to the internet. Please connect to the internet.", "No internet connection", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Exclamation))
                {
                    checkForUpdate();
                }
            }
        }
    }
}
