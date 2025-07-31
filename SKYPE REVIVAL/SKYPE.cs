using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace SKYPE_REVIVAL
{
    public partial class SKYPE : Form
    {
        //GENERAL KNOW HOW
        private int mouseX = Cursor.Position.X, mouseY = Cursor.Position.Y;
        Rectangle screenSize = SystemInformation.WorkingArea;
        private int screenTopLeft, screenTopY;

        //FORM COLORS
        private int borderRadius = 15, borderSize = 2;
        private Color borderColor = Color.FromArgb(1, 1, 1);
        private Color invisibleColor = Color.FromArgb(0, 1, 1, 1);

        //FORM SIZES AND RATIOS
        private Size formSize = new Size(1500, 900);
        private Point spawnPoint = new Point(0, 0);
        private Size formSideBarSize;

        #region INIT CRAP
        public SKYPE()
        {
            InitializeComponent();
            initBorderPatrol();
            screenTopLeft = screenSize.X;
            screenTopY = screenSize.Y;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.Size = formSize;
            this.Location = spawnPoint;
        }
        public void initElements()
        {
            this.FormServiceBar.Size = new Size(formSize.Width, 25);
            formSideBarSize = new Size(480, formSize.Height);

            this.ProfileBar.Size = new Size(formSideBarSize.Width, 190);
            this.FunctionsBar.Size = new Size(formSideBarSize.Width, 140);
            this.ContactsBar.Size = new Size(formSideBarSize.Width, 680);

            this.NameBar.Size = new Size(formSize.Width - formSideBarSize.Width, 85);
        }
        public void initBorderPatrol()
        {
            int draggerThickness = 20;
            this.borderPatrolHigh.Size = new Size(formSize.Width-(2*draggerThickness), draggerThickness);
            this.borderPatrolHigh.Location = new Point(spawnPoint.X+draggerThickness, spawnPoint.Y);
            this.borderPatrolHigh.BackColor = invisibleColor;

            this.borderPatrolLow.Size = new Size(formSize.Width - (2 * draggerThickness), draggerThickness);
            this.borderPatrolLow.Location = new Point(spawnPoint.X+draggerThickness, (spawnPoint.Y+formSize.Height)-draggerThickness);
            this.borderPatrolLow.BackColor = invisibleColor;
        }

        #endregion

        #region BASIC TAB FEATURES
        private void tabX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SKYPE_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            try
            {
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (ObjectDisposedException)
            {
            }
        }
        private void ContactsBar_MouseDown(object sender, MouseEventArgs e)
        {
            SKYPE_MouseDown(sender, e);
        }
        private void FunctionsBar_MouseDown(object sender, MouseEventArgs e)
        {
            SKYPE_MouseDown(sender, e);
        }
        private void ProfileBar_MouseDown(object sender, MouseEventArgs e)
        {
            SKYPE_MouseDown(sender, e);
        }
        private void NameBar_MouseDown(object sender, MouseEventArgs e)
        {
            SKYPE_MouseDown(sender, e);
        }
        private void FormServiceBar_MouseDown(object sender, MouseEventArgs e)
        {
            SKYPE_MouseDown(sender, e);
        }
        #endregion

        #region ROUNDED CORNER
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = 0x20000;
                return cp;
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 190, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            return path;
        }

        private void SKYPE_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }        
    }
    #endregion
}