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

namespace Turn_off_display
{
    public class StartApp:IDisposable
    {
        private NotifyIcon appIco;
        private ContextMenuStrip menu;
        private ToolStripMenuItem settings, about, help, exit, update;// , support;
        private DisplayPower power;
        private Setting setting;

        public StartApp()
        {
            power = new DisplayPower();
            setting = new Setting();
        }
        private void initializeComponents()
        {
            appIco = new NotifyIcon();
            menu = new ContextMenuStrip();
            settings = new ToolStripMenuItem("Settings");
            about = new ToolStripMenuItem("About");
            help = new ToolStripMenuItem("Help");
            //support = new ToolStripMenuItem("Support");
            exit = new ToolStripMenuItem("Terminate");
            update = new ToolStripMenuItem("Check for updates");

            //about properties
            about.Click += new EventHandler(about_Click);
            menu.Items.Add(about);

            // appIco properties
            appIco.Icon = Properties.Resources.trayIcon;
            appIco.Text = "Turn off your display screen.";
            appIco.Visible = true;
            appIco.ContextMenuStrip = menu;
            appIco.MouseClick += new MouseEventHandler(appIco_MouseClick);
            
            //update properties
            update.Click += new EventHandler(update_Click);
            menu.Items.Add(update);

            //help properties
            help.Click += new EventHandler(help_Click);
            menu.Items.Add(help);

            //settings properties
            settings.Click += new EventHandler(settings_Click);
            menu.Items.Add(settings);

           /* // support properties
            support.Click += new EventHandler(support_Click);
            menu.Items.Add(support);*/
            
            // exit properties
            exit.Click += new EventHandler(exit_Click);
            menu.Items.Add(exit);

        }

        void appIco_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show(setting.LockComputer.ToString());
                if (setting.LockComputer)
                {                    
                    power.lockComputer();
                }
                power.turnOffMonitor(WindowHandle.getCurrentWindowHandle());
            }
        }

        void update_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            UpdateApp upap = new UpdateApp();
            upap.checkForUpdate();
        }

        void support_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void settings_Click(object sender, EventArgs e)
        {
            AppSettings settingsWindow = new AppSettings();
            settingsWindow.ShowDialog();
        }

        void help_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            System.Diagnostics.Process.Start("Trun off display Manual.pdf");
        }

        void exit_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Application.Exit();
        }

        void about_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            aboutTurnoff about = new aboutTurnoff();
            about.ShowDialog();
        }

        public void startApplication()
        {
            initializeComponents();
        }
        #region IDisposable Members

        public void Dispose()
        {
            appIco.Dispose();
        }

        #endregion
    }
}
