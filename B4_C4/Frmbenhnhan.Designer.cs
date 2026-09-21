namespace PhongKhamMiniDemo
{
    partial class frmBenhNhan
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
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.NumericUpDown numTuoi;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Button btnLuuTam;
        private System.Windows.Forms.ListBox lstBenhNhan;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.numTuoi = new System.Windows.Forms.NumericUpDown();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.btnLuuTam = new System.Windows.Forms.Button();
            this.lstBenhNhan = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Họ tên";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Text = "Tuổi";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Text = "Triệu chứng";

            this.txtHoTen.Location = new System.Drawing.Point(120, 17);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 20);

            this.numTuoi.Location = new System.Drawing.Point(120, 52);
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(80, 20);
            this.numTuoi.Minimum = 0;
            this.numTuoi.Maximum = 120;

            this.txtTrieuChung.Location = new System.Drawing.Point(120, 87);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(220, 20);

            this.btnLuuTam.Location = new System.Drawing.Point(120, 125);
            this.btnLuuTam.Name = "btnLuuTam";
            this.btnLuuTam.Size = new System.Drawing.Size(100, 26);
            this.btnLuuTam.Text = "Lưu tạm";
            this.btnLuuTam.UseVisualStyleBackColor = true;
            this.btnLuuTam.Click += new System.EventHandler(this.btnLuuTam_Click);

            this.lstBenhNhan.FormattingEnabled = true;
            this.lstBenhNhan.Location = new System.Drawing.Point(20, 165);
            this.lstBenhNhan.Name = "lstBenhNhan";
            this.lstBenhNhan.Size = new System.Drawing.Size(360, 160);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.numTuoi);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.btnLuuTam);
            this.Controls.Add(this.lstBenhNhan);
            this.Name = "frmBenhNhan";
            this.Text = "Thông tin bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}