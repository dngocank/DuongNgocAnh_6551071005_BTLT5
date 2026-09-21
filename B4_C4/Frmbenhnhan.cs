using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhongKhamMiniDemo
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string thongTin = txtHoTen.Text + " - " + numTuoi.Value.ToString() + " tuổi - " + txtTrieuChung.Text;
            danhSachBenhNhan.Add(thongTin);
            lstBenhNhan.Items.Add(thongTin);

            txtHoTen.Clear();
            numTuoi.Value = 0;
            txtTrieuChung.Clear();
        }
    }
}