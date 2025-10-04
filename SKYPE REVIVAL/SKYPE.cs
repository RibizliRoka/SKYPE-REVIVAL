using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace SKYPE_REVIVAL
{
    public partial class SKYPE : Form
    {
        //GENERAL KNOW HOW
        private int globalMouseX = Cursor.Position.X, globalMouseY = Cursor.Position.Y;
        Rectangle screenSize = SystemInformation.WorkingArea;
        private int screenTopLeft, screenTopY;

        //FORM COLORS
        private int borderRadius = 15, borderSize = 2;
        private Color borderColor = Color.FromArgb(1, 1, 1);

        //FORM SIZES AND RATIOS
        private Size formSize = new Size(1500, 900);
        private Point formLocation = new Point(0, 0);
        private Point spawnPoint = new Point(0, 0);
        private int FSBVeriLength, serviceBThickness = 40, profileBThickness, functionsBThickness, nameBThickness;
        private int FSBHoriLength;

        //TIMERS
        private enum dragDirection
        {
            HIGH, LOW, LEFT, RIGHT, TOPLEFT, TOPRIGHT, BOTTOMLEFT, BOTTOMRIGHT
        }
        private static dragDirection curserDragDir;
        private static System.Timers.Timer dragTime;

        #region INIT
        public SKYPE()
        {
            InitializeComponent();
            initBorderPatrol();
            initMainPanels();
            screenTopLeft = screenSize.X;
            screenTopY = screenSize.Y;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }
        public void initMainPanels()
        {
            FSBVeriLength = formSize.Height;
            FSBHoriLength = 480;
            profileBThickness = 190;
            functionsBThickness = 140;
            nameBThickness = 85;

            //constants
            this.Size = formSize;
            this.Location = formLocation;
            this.FormServiceBar.Size = new Size(formSize.Width, serviceBThickness);
            this.FormServiceBar.Location = spawnPoint;

            //sidebar
            int startpProfB = spawnPoint.Y + serviceBThickness;
            int startpFuncB = startpProfB + profileBThickness;
            int startpContB = startpFuncB + functionsBThickness;

            this.FSB.Size = new Size(FSBHoriLength, FSBVeriLength);
            this.FSB.Location = new Point(spawnPoint.X, startpProfB);

            this.ProfileBar.Size = new Size(FSBHoriLength, startpFuncB - startpProfB);
            this.ProfileBar.Location = new Point(0, 0);

            this.FunctionsBar.Size = new Size(FSBHoriLength, startpContB - startpFuncB);
            this.FunctionsBar.Location = new Point(0, startpFuncB - serviceBThickness);

            this.ContactsBar.Size = new Size(FSBHoriLength, formSize.Height - startpContB);
            this.ContactsBar.Location = new Point(spawnPoint.X, startpContB - serviceBThickness);

            //other
            this.NameBar.Size = new Size(formSize.Width - FSBHoriLength, nameBThickness);
            this.NameBar.Location = new Point(spawnPoint.X + FSBHoriLength, startpProfB);
        }
        public void initBorderPatrol()
        {
            int draggerThickness = 20;
            this.borderPatrolHigh.Size = new Size(formSize.Width - (2 * draggerThickness), draggerThickness);
            this.borderPatrolHigh.Location = new Point(spawnPoint.X + draggerThickness, spawnPoint.Y);

            this.borderPatrolLow.Size = new Size(formSize.Width - (2 * draggerThickness), draggerThickness);
            this.borderPatrolLow.Location = new Point(spawnPoint.X + draggerThickness, (spawnPoint.Y + formSize.Height) - draggerThickness);

            this.borderPatrolRight.Size = new Size(draggerThickness, formSize.Height - (2 * draggerThickness));
            this.borderPatrolRight.Location = new Point((spawnPoint.X + formSize.Width) - draggerThickness, spawnPoint.Y + draggerThickness);

            this.borderPatrolLeft.Size = new Size(draggerThickness, formSize.Height - (2 * draggerThickness));
            this.borderPatrolLeft.Location = new Point(spawnPoint.X, spawnPoint.Y + draggerThickness);

            this.borderPatrolTopLeft.Size = new Size(draggerThickness, draggerThickness);
            this.borderPatrolTopLeft.Location = spawnPoint;

            this.borderPatrolTopRight.Size = new Size(draggerThickness, draggerThickness);
            this.borderPatrolTopRight.Location = new Point(spawnPoint.X + formSize.Width - draggerThickness, spawnPoint.Y);

            this.borderPatrolBottomRight.Size = new Size(draggerThickness, draggerThickness);
            this.borderPatrolBottomRight.Location = new Point(spawnPoint.X + formSize.Width - draggerThickness, spawnPoint.Y + formSize.Height - draggerThickness);

            this.borderPatrolBottomLeft.Size = new Size(draggerThickness, draggerThickness);
            this.borderPatrolBottomLeft.Location = new Point(spawnPoint.X, spawnPoint.Y + formSize.Height - draggerThickness);

            dragTime = new System.Timers.Timer(200);
            dragTime.Elapsed += OnTimedEvent;
            dragTime.AutoReset = true;
            dragTime.Enabled = false;
        }
        #endregion

        #region FORM RESIZE
        private void updateMainPanels()
        {
            this.Size = formSize;
            this.Location = formLocation;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            switch (curserDragDir)
            {
                case dragDirection.HIGH:
                    {
                        formLocation = new Point(formLocation.X, globalMouseY);
                        formSize = new Size(formSize.Width, formSize.Height);
                        break;
                    }
                case dragDirection.LOW:
                    {
                        break;
                    }
                case dragDirection.RIGHT:
                    {
                        break;
                    }
                case dragDirection.LEFT:
                    {
                        break;
                    }
                case dragDirection.TOPLEFT:
                    {
                        break;
                    }
                case dragDirection.TOPRIGHT:
                    {
                        break;
                    }
                case dragDirection.BOTTOMLEFT:
                    {
                        break;
                    }
                case dragDirection.BOTTOMRIGHT:
                    {
                        break;
                    }
                default: break;
            }
        }
        private void borderPatrolHigh_MouseDown(object sender, MouseEventArgs e)
        {
            curserDragDir = dragDirection.HIGH;
            dragTime.Enabled = true;
        }
        private void borderPatrolHigh_MouseUp(object sender, MouseEventArgs e)
        {
            dragTime.Enabled = false;
            updateMainPanels();
        }
        #endregion

        #region CLOSE, MAXIMIZE, MINIMIZE
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