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
            borderPatrolHigh = new Panel();
            borderPatrolLow = new Panel();
            FormToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // FormServiceBar
            // 
            FormServiceBar.BackColor = Color.FromArgb(209, 96, 234);
            FormServiceBar.Location = new Point(0, 0);
            FormServiceBar.Name = "FormServiceBar";
            FormServiceBar.Size = new Size(1469, 38);
            FormServiceBar.TabIndex = 0;
            FormServiceBar.MouseDown += FormServiceBar_MouseDown;
            // 
            // FormToolBar
            // 
            FormToolBar.BackColor = Color.FromArgb(18, 18, 18);
            FormToolBar.Controls.Add(ContactsBar);
            FormToolBar.Controls.Add(FunctionsBar);
            FormToolBar.Controls.Add(ProfileBar);
            FormToolBar.Location = new Point(0, 38);
            FormToolBar.Name = "FormToolBar";
            FormToolBar.Size = new Size(402, 845);
            FormToolBar.TabIndex = 1;
            // 
            // ContactsBar
            // 
            ContactsBar.AccessibleRole = AccessibleRole.None;
            ContactsBar.BackColor = Color.FromArgb(1, 1, 1);
            ContactsBar.Location = new Point(0, 260);
            ContactsBar.Name = "ContactsBar";
            ContactsBar.Size = new Size(402, 585);
            ContactsBar.TabIndex = 2;
            ContactsBar.MouseDown += ContactsBar_MouseDown;
            // 
            // FunctionsBar
            // 
            FunctionsBar.BackColor = Color.FromArgb(1, 1, 1);
            FunctionsBar.Location = new Point(0, 159);
            FunctionsBar.Name = "FunctionsBar";
            FunctionsBar.Size = new Size(402, 101);
            FunctionsBar.TabIndex = 1;
            FunctionsBar.MouseDown += FunctionsBar_MouseDown;
            // 
            // ProfileBar
            // 
            ProfileBar.BackColor = Color.FromArgb(45, 2, 55);
            ProfileBar.Location = new Point(0, 0);
            ProfileBar.Name = "ProfileBar";
            ProfileBar.Size = new Size(402, 159);
            ProfileBar.TabIndex = 0;
            ProfileBar.MouseDown += ProfileBar_MouseDown;
            // 
            // NameBar
            // 
            NameBar.BackColor = Color.FromArgb(1, 1, 1);
            NameBar.Location = new Point(402, 38);
            NameBar.Name = "NameBar";
            NameBar.Size = new Size(1067, 82);
            NameBar.TabIndex = 2;
            NameBar.MouseDown += NameBar_MouseDown;
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
            // borderPatrolHigh
            // 
            borderPatrolHigh.BackColor = Color.FromArgb(0, 128, 255, 128);
            borderPatrolHigh.Cursor = Cursors.SizeNS;
            borderPatrolHigh.Location = new Point(20, 0);
            borderPatrolHigh.Name = "borderPatrolHigh";
            borderPatrolHigh.Size = new Size(1460, 20);
            borderPatrolHigh.TabIndex = 4;
            // 
            // borderPatrolLow
            // 
            borderPatrolLow.BackColor = Color.FromArgb(0, 128, 255, 128);
            borderPatrolLow.Cursor = Cursors.SizeNS;
            borderPatrolLow.Location = new Point(20, 880);
            borderPatrolLow.Name = "borderPatrolLow";
            borderPatrolLow.Size = new Size(1460, 20);
            borderPatrolLow.TabIndex = 5;
            // 
            // SKYPE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1500, 900);
            Controls.Add(borderPatrolLow);
            Controls.Add(borderPatrolHigh);
            Controls.Add(tabX);
            Controls.Add(NameBar);
            Controls.Add(FormToolBar);
            Controls.Add(FormServiceBar);
            ForeColor = Color.White;
            Location = new Point(100, 100);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SKYPE";
            SizeGripStyle = SizeGripStyle.Show;
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
        private Panel borderPatrolHigh;
        private Panel borderPatrolLow;
    }

    
}

public class TransparentPanel : Panel
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
            return cp;
        }
    }
    protected override void OnPaintBackground(PaintEventArgs e)
    {
        //base.OnPaintBackground(e);
    }
}