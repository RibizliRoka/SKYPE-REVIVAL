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

        //FORM SHAPE
        private int borderRadius = 15, borderSize = 2;
        private Color borderColor = Color.FromArgb(1, 1, 1);
        private Boolean mouseInField = false;
        private Size formSize = new Size(1500, 900);
        private Point spawnPoint = new Point(0, 0);

        #region INIT CRAP
        public SKYPE()
        {
            InitializeComponent();
            screenTopLeft = screenSize.X;
            screenTopY = screenSize.Y;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.Size = formSize;
            this.Location = spawnPoint;
        }

    

        #endregion

        #region BASIC TAB FEATURES
        private void tabX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region ROUNDED CORNER
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