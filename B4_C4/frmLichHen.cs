using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhongKhamMiniDemo
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string thongTin = dtpNgayGio.Value.ToString("dd/MM/yyyy HH:mm") + " - " + txtTenBenhNhan.Text;
            danhSachLichHen.Add(thongTin);
            lstLichHen.Items.Add(thongTin);

            txtTenBenhNhan.Clear();
        }
    }
}