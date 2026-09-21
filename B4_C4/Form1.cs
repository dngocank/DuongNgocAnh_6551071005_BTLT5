using System;
using System.Windows.Forms;

namespace PhongKhamMiniDemo
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void thongTinBenhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenhNhan f = new frmBenhNhan();
            f.MdiParent = this;
            f.Show();
        }

        private void datLichHenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen f = new frmLichHen();
            f.MdiParent = this;
            f.Show();
        }
    }
}