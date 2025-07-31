namespace SKYPE_REVIVAL
{
    partial class SKYPE
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            FormServiceBar = new Panel();
            FormToolBar = new Panel();
            ContactsBar = new Panel();
            FunctionsBar = new Panel();
            ProfileBar = new Panel();
            NameBar = new Panel();
            tabX = new Panel();
            FormToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // FormServiceBar
            // 
            FormServiceBar.BackColor = Color.FromArgb(209, 96, 234);
            FormServiceBar.Dock = DockStyle.Top;
            FormServiceBar.Location = new Point(0, 0);
            FormServiceBar.Name = "FormServiceBar";
            FormServiceBar.Size = new Size(1469, 38);
            FormServiceBar.TabIndex = 0;
            // 
            // FormToolBar
            // 
            FormToolBar.BackColor = Color.FromArgb(18, 18, 18);
            FormToolBar.Controls.Add(ContactsBar);
            FormToolBar.Controls.Add(FunctionsBar);
            FormToolBar.Controls.Add(ProfileBar);
            FormToolBar.Dock = DockStyle.Left;
            FormToolBar.Location = new Point(0, 38);
            FormToolBar.Name = "FormToolBar";
            FormToolBar.Size = new Size(402, 845);
            FormToolBar.TabIndex = 1;
            // 
            // ContactsBar
            // 
            ContactsBar.AccessibleRole = AccessibleRole.None;
            ContactsBar.BackColor = Color.FromArgb(1, 1, 1);
            ContactsBar.Dock = DockStyle.Top;
            ContactsBar.Location = new Point(0, 260);
            ContactsBar.Name = "ContactsBar";
            ContactsBar.Size = new Size(402, 585);
            ContactsBar.TabIndex = 2;
            // 
            // FunctionsBar
            // 
            FunctionsBar.BackColor = Color.FromArgb(1, 1, 1);
            FunctionsBar.Dock = DockStyle.Top;
            FunctionsBar.Location = new Point(0, 159);
            FunctionsBar.Name = "FunctionsBar";
            FunctionsBar.Size = new Size(402, 101);
            FunctionsBar.TabIndex = 1;
            // 
            // ProfileBar
            // 
            ProfileBar.BackColor = Color.FromArgb(45, 2, 55);
            ProfileBar.Dock = DockStyle.Top;
            ProfileBar.Location = new Point(0, 0);
            ProfileBar.Name = "ProfileBar";
            ProfileBar.Size = new Size(402, 159);
            ProfileBar.TabIndex = 0;
            // 
            // NameBar
            // 
            NameBar.BackColor = Color.FromArgb(1, 1, 1);
            NameBar.Dock = DockStyle.Top;
            NameBar.Location = new Point(402, 38);
            NameBar.Name = "NameBar";
            NameBar.Size = new Size(1067, 82);
            NameBar.TabIndex = 2;
            // 
            // tabX
            // 
            tabX.BackColor = Color.FromArgb(42, 2, 55);
            tabX.BackgroundImageLayout = ImageLayout.Center;
            tabX.Location = new Point(1404, 3);
            tabX.Name = "tabX";
            tabX.Size = new Size(53, 32);
            tabX.TabIndex = 3;
            tabX.Click += tabX_Click;
            tabX.MouseClick += SKYPE_MouseDown;
            // 
            // SKYPE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1469, 883);
            Controls.Add(tabX);
            Controls.Add(NameBar);
            Controls.Add(FormToolBar);
            Controls.Add(FormServiceBar);
            ForeColor = Color.White;
            Location = new Point(100, 100);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SKYPE";
            StartPosition = FormStartPosition.Manual;
            Text = "SKYPE REVIVAL";
            Paint += SKYPE_Paint;
            MouseDown += SKYPE_MouseDown;
            FormToolBar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel FormServiceBar;
        private Panel FormToolBar;
        private Panel ProfileBar;
        private Panel NameBar;
        private Panel ContactsBar;
        private Panel FunctionsBar;
        private Panel tabX;
    }

    
}