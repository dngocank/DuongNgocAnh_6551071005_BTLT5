namespace GymDangKyDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGoiTap = new System.Windows.Forms.ComboBox();
            this.numSoBuoiTuan = new System.Windows.Forms.NumericUpDown();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Họ tên";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Số điện thoại";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Text = "Email";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Text = "Ngày sinh";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Text = "Gói tập";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Text = "Số buổi/tuần";

            this.txtHoTen.Location = new System.Drawing.Point(150, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 20);

            this.txtSDT.Location = new System.Drawing.Point(150, 67);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 20);

            this.txtEmail.Location = new System.Drawing.Point(150, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);

            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 147);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 20);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.cboGoiTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            this.cboGoiTap.Location = new System.Drawing.Point(150, 187);
            this.cboGoiTap.Name = "cboGoiTap";
            this.cboGoiTap.Size = new System.Drawing.Size(220, 21);
            this.cboGoiTap.SelectedIndex = 0;

            this.numSoBuoiTuan.Location = new System.Drawing.Point(150, 227);
            this.numSoBuoiTuan.Name = "numSoBuoiTuan";
            this.numSoBuoiTuan.Size = new System.Drawing.Size(220, 20);
            this.numSoBuoiTuan.Minimum = 1;
            this.numSoBuoiTuan.Maximum = 7;
            this.numSoBuoiTuan.Value = 1;

            this.btnDangKy.Location = new System.Drawing.Point(150, 270);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 30);
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.toolTip1.SetToolTip(this.txtHoTen, "Nhập họ và tên đầy đủ của hội viên");
            this.toolTip1.SetToolTip(this.txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            this.toolTip1.SetToolTip(this.txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            this.toolTip1.SetToolTip(this.dtpNgaySinh, "Chọn ngày sinh của hội viên");
            this.toolTip1.SetToolTip(this.cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            this.toolTip1.SetToolTip(this.numSoBuoiTuan, "Số buổi tập mỗi tuần, tối thiểu 1 và tối đa 7 buổi");

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboGoiTap);
            this.Controls.Add(this.numSoBuoiTuan);
            this.Controls.Add(this.btnDangKy);
            this.Name = "Form1";
            this.Text = "Đăng ký hội viên - Gym FitLife";
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}