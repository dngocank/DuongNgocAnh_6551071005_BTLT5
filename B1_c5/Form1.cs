using System;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void txtChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnThem.PerformClick();
                    e.Handled = true;
                    break;

                case Keys.F5:
                    btnXoaTrang.PerformClick();
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    e.Handled = true;
                    break;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dongKetQua = $"{maSP} | {soLuong} | {donGia}";
            lstKetQua.Items.Add(dongKetQua);

            btnXoaTrang.PerformClick();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }
    }
}