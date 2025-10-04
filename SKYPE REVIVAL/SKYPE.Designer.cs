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
            FSB = new Panel();
            ContactsBar = new Panel();
            FunctionsBar = new Panel();
            ProfileBar = new Panel();
            NameBar = new Panel();
            tabX = new Panel();
            borderPatrolHigh = new TransparentPanel();
            borderPatrolLow = new TransparentPanel();
            borderPatrolRight = new TransparentPanel();
            borderPatrolLeft = new TransparentPanel();
            borderPatrolTopLeft = new TransparentPanel();
            borderPatrolBottomLeft = new TransparentPanel();
            borderPatrolTopRight = new TransparentPanel();
            borderPatrolBottomRight = new TransparentPanel();
            FSB.SuspendLayout();
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
            // FSB
            // 
            FSB.BackColor = Color.Lime;
            FSB.Controls.Add(ContactsBar);
            FSB.Controls.Add(FunctionsBar);
            FSB.Controls.Add(ProfileBar);
            FSB.Location = new Point(0, 38);
            FSB.Name = "FSB";
            FSB.Size = new Size(402, 845);
            FSB.TabIndex = 1;
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
            FunctionsBar.BackColor = Color.FromArgb(14, 1, 14);
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
            borderPatrolHigh.BackColor = Color.Lime;
            borderPatrolHigh.Cursor = Cursors.SizeNS;
            borderPatrolHigh.Location = new Point(20, 0);
            borderPatrolHigh.Name = "borderPatrolHigh";
            borderPatrolHigh.Size = new Size(1460, 20);
            borderPatrolHigh.TabIndex = 4;
            borderPatrolHigh.MouseDown += borderPatrolHigh_MouseDown;
            borderPatrolHigh.MouseUp += borderPatrolHigh_MouseUp;
            // 
            // borderPatrolLow
            // 
            borderPatrolLow.BackColor = Color.Lime;
            borderPatrolLow.Cursor = Cursors.SizeNS;
            borderPatrolLow.Location = new Point(20, 880);
            borderPatrolLow.Name = "borderPatrolLow";
            borderPatrolLow.Size = new Size(1460, 20);
            borderPatrolLow.TabIndex = 5;
            // 
            // borderPatrolRight
            // 
            borderPatrolRight.BackColor = Color.Lime;
            borderPatrolRight.Cursor = Cursors.SizeWE;
            borderPatrolRight.Location = new Point(1475, 12);
            borderPatrolRight.Name = "borderPatrolRight";
            borderPatrolRight.Size = new Size(31, 871);
            borderPatrolRight.TabIndex = 6;
            // 
            // borderPatrolLeft
            // 
            borderPatrolLeft.BackColor = Color.Lime;
            borderPatrolLeft.Cursor = Cursors.SizeWE;
            borderPatrolLeft.Location = new Point(0, 12);
            borderPatrolLeft.Name = "borderPatrolLeft";
            borderPatrolLeft.Size = new Size(25, 868);
            borderPatrolLeft.TabIndex = 7;
            // 
            // borderPatrolTopLeft
            // 
            borderPatrolTopLeft.BackColor = Color.Magenta;
            borderPatrolTopLeft.Cursor = Cursors.SizeNWSE;
            borderPatrolTopLeft.Location = new Point(0, 0);
            borderPatrolTopLeft.Name = "borderPatrolTopLeft";
            borderPatrolTopLeft.Size = new Size(25, 32);
            borderPatrolTopLeft.TabIndex = 8;
            // 
            // borderPatrolBottomLeft
            // 
            borderPatrolBottomLeft.BackColor = Color.Magenta;
            borderPatrolBottomLeft.Cursor = Cursors.SizeNESW;
            borderPatrolBottomLeft.Location = new Point(0, 868);
            borderPatrolBottomLeft.Name = "borderPatrolBottomLeft";
            borderPatrolBottomLeft.Size = new Size(25, 32);
            borderPatrolBottomLeft.TabIndex = 9;
            // 
            // borderPatrolTopRight
            // 
            borderPatrolTopRight.BackColor = Color.Magenta;
            borderPatrolTopRight.Cursor = Cursors.SizeNESW;
            borderPatrolTopRight.Location = new Point(1475, 0);
            borderPatrolTopRight.Name = "borderPatrolTopRight";
            borderPatrolTopRight.Size = new Size(28, 20);
            borderPatrolTopRight.TabIndex = 10;
            // 
            // borderPatrolBottomRight
            // 
            borderPatrolBottomRight.BackColor = Color.Magenta;
            borderPatrolBottomRight.Cursor = Cursors.SizeNWSE;
            borderPatrolBottomRight.Location = new Point(1475, 868);
            borderPatrolBottomRight.Name = "borderPatrolBottomRight";
            borderPatrolBottomRight.Size = new Size(28, 32);
            borderPatrolBottomRight.TabIndex = 11;
            // 
            // SKYPE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1500, 900);
            Controls.Add(borderPatrolBottomRight);
            Controls.Add(borderPatrolTopRight);
            Controls.Add(borderPatrolBottomLeft);
            Controls.Add(borderPatrolTopLeft);
            Controls.Add(borderPatrolLeft);
            Controls.Add(borderPatrolRight);
            Controls.Add(borderPatrolLow);
            Controls.Add(borderPatrolHigh);
            Controls.Add(tabX);
            Controls.Add(NameBar);
            Controls.Add(FSB);
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
            FSB.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel FormServiceBar;
        private Panel FSB;
        private Panel ProfileBar;
        private Panel NameBar;
        private Panel ContactsBar;
        private Panel FunctionsBar;
        private Panel tabX;
        private TransparentPanel borderPatrolHigh;
        private TransparentPanel borderPatrolLow;
        private TransparentPanel borderPatrolRight;
        private TransparentPanel borderPatrolLeft;
        private TransparentPanel borderPatrolTopLeft;
        private TransparentPanel borderPatrolBottomLeft;
        private TransparentPanel borderPatrolTopRight;
        private TransparentPanel borderPatrolBottomRight;
    }

    
}

public class TransparentPanel : Panel
{
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x00000020;
            return cp;
        }
    }
    protected override void OnPaintBackground(PaintEventArgs e)
    {
        //base.OnPaintBackground(e);
    }
}