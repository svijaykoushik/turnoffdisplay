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

namespace Turn_off_Settings
{
    public partial class Form1 : Form
    {
        Turn_off_display.Setting setting;
        public Form1()
        {
            setting = new Turn_off_display.Setting();
            InitializeComponent();
        }

        private void trayIconOption_CheckedChanged(object sender, EventArgs e)
        {
            if (!saveButton.Enabled)
                saveButton.Enabled = true;
        }

        private void lockOption_CheckedChanged(object sender, EventArgs e)
        {
            if (!saveButton.Enabled)
                saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            setting.ShowTrayIcon = trayIconOption.Checked;
            setting.LockComputer = lockOption.Checked;
            setting.saveSettings();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trayIconOption.Checked = setting.ShowTrayIcon;
            lockOption.Checked = setting.LockComputer;
            saveButton.Enabled = false;
        }
    }
}
