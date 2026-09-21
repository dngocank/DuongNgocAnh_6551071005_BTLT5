using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class FormBangVe : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Bitmap drawBitmap;
        private Graphics bmpGraphics;

        public FormBangVe()
        {
            InitializeComponent();
        }

        private void FormBangVe_Load(object sender, EventArgs e)
        {
            drawBitmap = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);
            bmpGraphics = Graphics.FromImage(drawBitmap);
            bmpGraphics.Clear(Color.White);
            bmpGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
                lblTrangThai.Text = "Trạng thái: Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = $"Tọa độ: X={e.X}, Y={e.Y}";

            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (Pen pen = new Pen(Color.Black, 2f))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    bmpGraphics.DrawLine(pen, previousPoint, e.Location);
                    previousPoint = e.Location;
                    pnlCanvas.Invalidate();
                }
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lblTrangThai.Text = "Trạng thái: Sẵn sàng";
            }
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (drawBitmap != null)
            {
                e.Graphics.DrawImage(drawBitmap, Point.Empty);
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bmpGraphics.Clear(Color.White);
                pnlCanvas.Invalidate();
                lblTrangThai.Text = "Trạng thái: Sẵn sàng";
            }
        }
    }
}