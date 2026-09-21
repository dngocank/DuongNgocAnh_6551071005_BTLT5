namespace PhongKhamMiniDemo
{
    partial class frmLichHen
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
        private System.Windows.Forms.DateTimePicker dtpNgayGio;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.ListBox lstLichHen;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayGio = new System.Windows.Forms.DateTimePicker();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.lstLichHen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Ngày giờ hẹn";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Text = "Tên bệnh nhân";

            this.dtpNgayGio.Location = new System.Drawing.Point(140, 17);
            this.dtpNgayGio.Name = "dtpNgayGio";
            this.dtpNgayGio.Size = new System.Drawing.Size(220, 20);
            this.dtpNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";

            this.txtTenBenhNhan.Location = new System.Drawing.Point(140, 52);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(220, 20);

            this.btnDatLich.Location = new System.Drawing.Point(140, 90);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(100, 26);
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);

            this.lstLichHen.FormattingEnabled = true;
            this.lstLichHen.Location = new System.Drawing.Point(20, 130);
            this.lstLichHen.Name = "lstLichHen";
            this.lstLichHen.Size = new System.Drawing.Size(380, 160);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayGio);
            this.Controls.Add(this.txtTenBenhNhan);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.lstLichHen);
            this.Name = "frmLichHen";
            this.Text = "Đặt lịch hẹn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}