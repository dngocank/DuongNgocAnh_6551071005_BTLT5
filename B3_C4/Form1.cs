using System;
using System.Windows.Forms;

namespace GymDangKyDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = "Họ tên: " + txtHoTen.Text + Environment.NewLine +
                               "SĐT: " + txtSDT.Text + Environment.NewLine +
                               "Gói tập: " + cboGoiTap.SelectedItem.ToString() + Environment.NewLine +
                               "Số buổi/tuần: " + numSoBuoiTuan.Value.ToString();

            MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}