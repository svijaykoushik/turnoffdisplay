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
using System.IO;

namespace Turn_off_display
{
    public class Setting
    {
        private bool showTrayIcon, lockComputer;
        private aboutTurnoff about = new aboutTurnoff();
        public bool ShowTrayIcon
        {
            get
            {
                return showTrayIcon;
            }
            set
            {
                showTrayIcon = value;
            }
        }

        public bool LockComputer
        {
            get
            {
                return lockComputer;
            }
            set
            {
                 lockComputer = value;
            }
        }

        private void initializeSettings()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + about.AssemblyCompany + Path.DirectorySeparatorChar + about.AssemblyTitle + Path.DirectorySeparatorChar))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + about.AssemblyCompany + Path.DirectorySeparatorChar + about.AssemblyTitle + Path.DirectorySeparatorChar);
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+Path.DirectorySeparatorChar+about.AssemblyCompany+Path.DirectorySeparatorChar+about.AssemblyTitle+Path.DirectorySeparatorChar+"settings.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + about.AssemblyCompany + Path.DirectorySeparatorChar + about.AssemblyTitle + Path.DirectorySeparatorChar + "settings.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("applicationSettings");
                    writer.WriteStartElement("setting");
                    writer.WriteElementString("ShowTrayIcon",false.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("setting");
                    writer.WriteElementString("LockComputer",false.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            else
            {
                string elementName=string.Empty;
                using (XmlReader reader = XmlReader.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + about.AssemblyCompany + Path.DirectorySeparatorChar + about.AssemblyTitle + Path.DirectorySeparatorChar + "settings.xml"))
                {
                    reader.MoveToContent();
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "applicationSettings")
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
                                        case "ShowTrayIcon":
                                            showTrayIcon = Convert.ToBoolean(reader.Value);
                                            break;
                                        case "LockComputer":
                                            lockComputer = Convert.ToBoolean(reader.Value);
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public Setting()
        {
            initializeSettings();
        }
        
        public void saveSettings()
        {
            string xmlfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+Path.DirectorySeparatorChar+about.AssemblyCompany+Path.DirectorySeparatorChar+about.AssemblyTitle+Path.DirectorySeparatorChar+"settings.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlfile);
            doc.SelectSingleNode("applicationSettings/setting/ShowTrayIcon").InnerText = ShowTrayIcon.ToString();
            doc.SelectSingleNode("applicationSettings/setting/LockComputer").InnerText = LockComputer.ToString();
            doc.Save(xmlfile);
        }


    }
}
