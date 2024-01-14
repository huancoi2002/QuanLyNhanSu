namespace QuanLyNhanSu
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.chucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuQLHoSo,
            this.mnuQLHeThong,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.duToolStripMenuItem});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(94, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // chucToolStripMenuItem
            // 
            this.chucToolStripMenuItem.Name = "chucToolStripMenuItem";
            this.chucToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.chucToolStripMenuItem.Text = "Chức vụ";
            this.chucToolStripMenuItem.Click += new System.EventHandler(this.chucToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // duToolStripMenuItem
            // 
            this.duToolStripMenuItem.Name = "duToolStripMenuItem";
            this.duToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.duToolStripMenuItem.Text = "Dự án";
            this.duToolStripMenuItem.Click += new System.EventHandler(this.duToolStripMenuItem_Click);
            // 
            // mnuQLHoSo
            // 
            this.mnuQLHoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơNhânViênToolStripMenuItem,
            this.timToolStripMenuItem});
            this.mnuQLHoSo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLHoSo.Name = "mnuQLHoSo";
            this.mnuQLHoSo.Size = new System.Drawing.Size(118, 24);
            this.mnuQLHoSo.Text = "Quản lý hồ sơ";
            // 
            // hồSơNhânViênToolStripMenuItem
            // 
            this.hồSơNhânViênToolStripMenuItem.Name = "hồSơNhânViênToolStripMenuItem";
            this.hồSơNhânViênToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.hồSơNhânViênToolStripMenuItem.Text = "Hồ sơ nhân viên";
            this.hồSơNhânViênToolStripMenuItem.Click += new System.EventHandler(this.hồSơNhânViênToolStripMenuItem_Click);
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.timToolStripMenuItem.Text = "Tìm Kiếm thông tin nhân viên";
            this.timToolStripMenuItem.Click += new System.EventHandler(this.timToolStripMenuItem_Click);
            // 
            // mnuQLHeThong
            // 
            this.mnuQLHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem1,
            this.bảngThốngKêToolStripMenuItem});
            this.mnuQLHeThong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQLHeThong.Name = "mnuQLHeThong";
            this.mnuQLHeThong.Size = new System.Drawing.Size(143, 24);
            this.mnuQLHeThong.Text = "Quản lý hệ thống";
            this.mnuQLHeThong.Click += new System.EventHandler(this.mnuQLHeThong_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem1
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem1.Name = "quảnLýTàiKhoảnToolStripMenuItem1";
            this.quảnLýTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem1.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem1_Click);
            // 
            // bảngThốngKêToolStripMenuItem
            // 
            this.bảngThốngKêToolStripMenuItem.Name = "bảngThốngKêToolStripMenuItem";
            this.bảngThốngKêToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bảngThốngKêToolStripMenuItem.Text = "Bảng thống kê";
            this.bảngThốngKêToolStripMenuItem.Click += new System.EventHandler(this.bảngThốngKêToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 724);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHoSo;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHeThong;
        private System.Windows.Forms.ToolStripMenuItem chucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem hồSơNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngThốngKêToolStripMenuItem;
    }
}

