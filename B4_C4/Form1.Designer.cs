namespace PhongKhamMiniDemo
{
    partial class frmParent
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinBenhNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datLichHenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuaSoToolStripMenuItem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinBenhNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datLichHenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuaSoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.nghiepVuToolStripMenuItem,
                this.cuaSoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MdiWindowListItem = this.cuaSoToolStripMenuItem;

            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.thongTinBenhNhanToolStripMenuItem,
                this.datLichHenToolStripMenuItem});
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.nghiepVuToolStripMenuItem.Text = "Nghiệp vụ";

            this.thongTinBenhNhanToolStripMenuItem.Name = "thongTinBenhNhanToolStripMenuItem";
            this.thongTinBenhNhanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thongTinBenhNhanToolStripMenuItem.Text = "Thông tin bệnh nhân";
            this.thongTinBenhNhanToolStripMenuItem.Click += new System.EventHandler(this.thongTinBenhNhanToolStripMenuItem_Click);

            this.datLichHenToolStripMenuItem.Name = "datLichHenToolStripMenuItem";
            this.datLichHenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datLichHenToolStripMenuItem.Text = "Đặt lịch hẹn";
            this.datLichHenToolStripMenuItem.Click += new System.EventHandler(this.datLichHenToolStripMenuItem_Click);

            this.cuaSoToolStripMenuItem.Name = "cuaSoToolStripMenuItem";
            this.cuaSoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cuaSoToolStripMenuItem.Text = "Cửa sổ";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.Text = "Phần mềm quản lý phòng khám mini";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}