using System;
using System.Windows.Forms;

namespace TodoListDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
            }
        }

        private void danhDauHoanThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string noiDung = lstCongViec.SelectedItem.ToString();
                int chiSo = lstCongViec.SelectedIndex;

                if (!noiDung.StartsWith("[Hoàn thành] "))
                {
                    lstCongViec.Items[chiSo] = "[Hoàn thành] " + noiDung;
                }
            }
        }

        private void xoaCongViecNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một công việc trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoaTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có chắc muốn xóa tất cả công việc không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}