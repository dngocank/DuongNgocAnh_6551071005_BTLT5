namespace TodoListDemo
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

        private System.Windows.Forms.TextBox txtCongViecMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.ContextMenuStrip cmsCongViec;
        private System.Windows.Forms.ToolStripMenuItem danhDauHoanThanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaCongViecNayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaTatCaToolStripMenuItem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCongViecMoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstCongViec = new System.Windows.Forms.ListBox();
            this.cmsCongViec = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhDauHoanThanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaCongViecNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaTatCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCongViec.SuspendLayout();
            this.SuspendLayout();

            this.txtCongViecMoi.Location = new System.Drawing.Point(12, 12);
            this.txtCongViecMoi.Name = "txtCongViecMoi";
            this.txtCongViecMoi.Size = new System.Drawing.Size(360, 20);

            this.btnThem.Location = new System.Drawing.Point(380, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.lstCongViec.ContextMenuStrip = this.cmsCongViec;
            this.lstCongViec.FormattingEnabled = true;
            this.lstCongViec.Location = new System.Drawing.Point(12, 45);
            this.lstCongViec.Name = "lstCongViec";
            this.lstCongViec.Size = new System.Drawing.Size(458, 290);
            this.lstCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));

            this.cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.danhDauHoanThanhToolStripMenuItem,
                this.xoaCongViecNayToolStripMenuItem,
                this.xoaTatCaToolStripMenuItem});
            this.cmsCongViec.Name = "cmsCongViec";
            this.cmsCongViec.Size = new System.Drawing.Size(200, 70);

            this.danhDauHoanThanhToolStripMenuItem.Name = "danhDauHoanThanhToolStripMenuItem";
            this.danhDauHoanThanhToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.danhDauHoanThanhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            this.danhDauHoanThanhToolStripMenuItem.Click += new System.EventHandler(this.danhDauHoanThanhToolStripMenuItem_Click);

            this.xoaCongViecNayToolStripMenuItem.Name = "xoaCongViecNayToolStripMenuItem";
            this.xoaCongViecNayToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.xoaCongViecNayToolStripMenuItem.Text = "Xóa công việc này";
            this.xoaCongViecNayToolStripMenuItem.Click += new System.EventHandler(this.xoaCongViecNayToolStripMenuItem_Click);

            this.xoaTatCaToolStripMenuItem.Name = "xoaTatCaToolStripMenuItem";
            this.xoaTatCaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.xoaTatCaToolStripMenuItem.Text = "Xóa tất cả";
            this.xoaTatCaToolStripMenuItem.Click += new System.EventHandler(this.xoaTatCaToolStripMenuItem_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 347);
            this.Controls.Add(this.lstCongViec);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtCongViecMoi);
            this.Name = "Form1";
            this.Text = "To-do list hằng ngày";
            this.cmsCongViec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}