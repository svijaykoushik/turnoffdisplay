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
namespace About_Turn_off
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.copyRight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.productLink = new System.Windows.Forms.LinkLabel();
            this.publisherLink = new System.Windows.Forms.LinkLabel();
            this.publsiherName = new System.Windows.Forms.Label();
            this.productVersion = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // copyRight
            // 
            this.copyRight.AutoSize = true;
            this.copyRight.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRight.Location = new System.Drawing.Point(14, 137);
            this.copyRight.Name = "copyRight";
            this.copyRight.Size = new System.Drawing.Size(59, 15);
            this.copyRight.TabIndex = 15;
            this.copyRight.Text = "{Copyright}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 58);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(344, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productLink
            // 
            this.productLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.productLink.AutoSize = true;
            this.productLink.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLink.Location = new System.Drawing.Point(166, 36);
            this.productLink.Name = "productLink";
            this.productLink.Size = new System.Drawing.Size(99, 14);
            this.productLink.TabIndex = 13;
            this.productLink.TabStop = true;
            this.productLink.Text = "{Product website}";
            this.productLink.Visible = false;
            // 
            // publisherLink
            // 
            this.publisherLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.publisherLink.AutoSize = true;
            this.publisherLink.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLink.Location = new System.Drawing.Point(166, 117);
            this.publisherLink.Name = "publisherLink";
            this.publisherLink.Size = new System.Drawing.Size(108, 14);
            this.publisherLink.TabIndex = 12;
            this.publisherLink.TabStop = true;
            this.publisherLink.Text = "{publisher website}";
            this.publisherLink.Visible = false;
            // 
            // publsiherName
            // 
            this.publsiherName.AutoSize = true;
            this.publsiherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publsiherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.publsiherName.Location = new System.Drawing.Point(166, 92);
            this.publsiherName.Name = "publsiherName";
            this.publsiherName.Size = new System.Drawing.Size(127, 16);
            this.publsiherName.TabIndex = 11;
            this.publsiherName.Text = "{Publisher name}";
            // 
            // productVersion
            // 
            this.productVersion.AutoSize = true;
            this.productVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.productVersion.Location = new System.Drawing.Point(166, 62);
            this.productVersion.Name = "productVersion";
            this.productVersion.Size = new System.Drawing.Size(130, 16);
            this.productVersion.TabIndex = 10;
            this.productVersion.Text = "{Product Version}";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.productName.Location = new System.Drawing.Point(166, 9);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(118, 16);
            this.productName.TabIndex = 9;
            this.productName.Text = "{Product Name}";
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(17, 9);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(128, 128);
            this.logoPicture.TabIndex = 8;
            this.logoPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 213);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel productLink;
        private System.Windows.Forms.LinkLabel publisherLink;
        private System.Windows.Forms.Label publsiherName;
        private System.Windows.Forms.Label productVersion;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.PictureBox logoPicture;
    }
}

