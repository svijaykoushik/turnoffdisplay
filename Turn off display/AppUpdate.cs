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
    public partial class AppUpdate : Form
    {
        string message,url;
        bool updateAvailable;
        public AppUpdate(string message,bool isUpdateAvailable, string url)
        {
            InitializeComponent();
            this.message = message;
            this.url = url;
            updateAvailable = isUpdateAvailable;
        }

        private void AppUpdate_Load(object sender, EventArgs e)
        {
            if (updateAvailable)
                pictureBox1.Image = Properties.Resources.updateYes;
            else
            {
                pictureBox1.Image = Properties.Resources.updateNo;
                button2.Visible = false;
                button1.Text = "Ok";
            }
            label1.Text = message;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(updateAvailable)
                System.Diagnostics.Process.Start(url);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
