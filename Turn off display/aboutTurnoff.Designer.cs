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
namespace Turn_off_display
{
    partial class aboutTurnoff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutTurnoff));
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.productVersion = new System.Windows.Forms.Label();
            this.publsiherName = new System.Windows.Forms.Label();
            this.publisherLink = new System.Windows.Forms.LinkLabel();
            this.productLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.copyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(28, 12);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(128, 128);
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.productName.Location = new System.Drawing.Point(177, 12);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(118, 16);
            this.productName.TabIndex = 1;
            this.productName.Text = "{Product Name}";
            // 
            // productVersion
            // 
            this.productVersion.AutoSize = true;
            this.productVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.productVersion.Location = new System.Drawing.Point(177, 68);
            this.productVersion.Name = "productVersion";
            this.productVersion.Size = new System.Drawing.Size(130, 16);
            this.productVersion.TabIndex = 2;
            this.productVersion.Text = "{Product Version}";
            // 
            // publsiherName
            // 
            this.publsiherName.AutoSize = true;
            this.publsiherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publsiherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.publsiherName.Location = new System.Drawing.Point(177, 98);
            this.publsiherName.Name = "publsiherName";
            this.publsiherName.Size = new System.Drawing.Size(127, 16);
            this.publsiherName.TabIndex = 3;
            this.publsiherName.Text = "{Publisher name}";
            // 
            // publisherLink
            // 
            this.publisherLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.publisherLink.AutoSize = true;
            this.publisherLink.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLink.Location = new System.Drawing.Point(177, 123);
            this.publisherLink.Name = "publisherLink";
            this.publisherLink.Size = new System.Drawing.Size(108, 14);
            this.publisherLink.TabIndex = 4;
            this.publisherLink.TabStop = true;
            this.publisherLink.Text = "{publisher website}";
            this.publisherLink.Visible = false;
            // 
            // productLink
            // 
            this.productLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.productLink.AutoSize = true;
            this.productLink.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLink.Location = new System.Drawing.Point(177, 42);
            this.productLink.Name = "productLink";
            this.productLink.Size = new System.Drawing.Size(99, 14);
            this.productLink.TabIndex = 5;
            this.productLink.TabStop = true;
            this.productLink.Text = "{Product website}";
            this.productLink.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 50);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(344, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyRight
            // 
            this.copyRight.AutoSize = true;
            this.copyRight.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRight.Location = new System.Drawing.Point(25, 145);
            this.copyRight.Name = "copyRight";
            this.copyRight.Size = new System.Drawing.Size(59, 15);
            this.copyRight.TabIndex = 7;
            this.copyRight.Text = "{Copyright}";
            // 
            // aboutTurnoff
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.copyRight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productLink);
            this.Controls.Add(this.publisherLink);
            this.Controls.Add(this.publsiherName);
            this.Controls.Add(this.productVersion);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.logoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutTurnoff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{Application name}";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productVersion;
        private System.Windows.Forms.Label publsiherName;
        private System.Windows.Forms.LinkLabel publisherLink;
        private System.Windows.Forms.LinkLabel productLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label copyRight;
    }
}

