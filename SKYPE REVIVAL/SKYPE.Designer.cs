namespace SKYPE_REVIVAL
{
    partial class SKYPE
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContactsBar = new System.Windows.Forms.Panel();
            this.FunctionsBar = new System.Windows.Forms.Panel();
            this.ProfileBar = new System.Windows.Forms.Panel();
            this.NameBar = new System.Windows.Forms.Panel();
            this.tabX = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(96)))), ((int)(((byte)(234)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.ContactsBar);
            this.panel2.Controls.Add(this.FunctionsBar);
            this.panel2.Controls.Add(this.ProfileBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 845);
            this.panel2.TabIndex = 1;
            // 
            // ContactsBar
            // 
            this.ContactsBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ContactsBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactsBar.Location = new System.Drawing.Point(0, 260);
            this.ContactsBar.Name = "ContactsBar";
            this.ContactsBar.Size = new System.Drawing.Size(402, 585);
            this.ContactsBar.TabIndex = 2;
            // 
            // FunctionsBar
            // 
            this.FunctionsBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.FunctionsBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionsBar.Location = new System.Drawing.Point(0, 159);
            this.FunctionsBar.Name = "FunctionsBar";
            this.FunctionsBar.Size = new System.Drawing.Size(402, 101);
            this.FunctionsBar.TabIndex = 1;
            // 
            // ProfileBar
            // 
            this.ProfileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(2)))), ((int)(((byte)(55)))));
            this.ProfileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileBar.Location = new System.Drawing.Point(0, 0);
            this.ProfileBar.Name = "ProfileBar";
            this.ProfileBar.Size = new System.Drawing.Size(402, 159);
            this.ProfileBar.TabIndex = 0;
            // 
            // NameBar
            // 
            this.NameBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.NameBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameBar.Location = new System.Drawing.Point(402, 38);
            this.NameBar.Name = "NameBar";
            this.NameBar.Size = new System.Drawing.Size(1067, 82);
            this.NameBar.TabIndex = 2;
            // 
            // tabX
            // 
            this.tabX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(2)))), ((int)(((byte)(55)))));
            this.tabX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabX.Location = new System.Drawing.Point(1404, 3);
            this.tabX.Name = "tabX";
            this.tabX.Size = new System.Drawing.Size(53, 32);
            this.tabX.TabIndex = 3;
            this.tabX.Click += new System.EventHandler(this.tabX_Click);
            this.tabX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SKYPE_MouseDown);
            // 
            // SKYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1469, 883);
            this.Controls.Add(this.tabX);
            this.Controls.Add(this.NameBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SKYPE";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SKYPE_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SKYPE_MouseDown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel ProfileBar;
        private Panel NameBar;
        private Panel ContactsBar;
        private Panel FunctionsBar;
        private Panel tabX;
    }
}