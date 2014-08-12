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

namespace About_Turn_off
{
    public partial class Form1 : Form
    {
        Turn_off_display.aboutTurnoff about = new Turn_off_display.aboutTurnoff();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("About {0}", about.AssemblyTitle);
            productName.Text = about.AssemblyTitle;
            productVersion.Text = String.Format("Version {0}", about.AssemblyVersion);
            publsiherName.Text = String.Format("Publisher {0}", about.AssemblyCompany);
            copyRight.Text = about.AssemblyCopyright;
            logoPicture.Image = about.Logo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
