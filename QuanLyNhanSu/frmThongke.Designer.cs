namespace QuanLyNhanSu
{
    partial class frmThongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongke));
            this.lblSoluongnv = new System.Windows.Forms.Label();
            this.lblSoluongphongban = new System.Windows.Forms.Label();
            this.lblSoluongduan = new System.Windows.Forms.Label();
            this.lblSoluongtk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoluongnv
            // 
            this.lblSoluongnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongnv.Location = new System.Drawing.Point(67, 63);
            this.lblSoluongnv.Name = "lblSoluongnv";
            this.lblSoluongnv.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongnv.TabIndex = 0;
            this.lblSoluongnv.Text = "Số lượng nhân viên : \r\n";
            // 
            // lblSoluongphongban
            // 
            this.lblSoluongphongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongphongban.Location = new System.Drawing.Point(67, 170);
            this.lblSoluongphongban.Name = "lblSoluongphongban";
            this.lblSoluongphongban.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongphongban.TabIndex = 1;
            this.lblSoluongphongban.Text = "Số lượng phòng ban : \r\n";
            // 
            // lblSoluongduan
            // 
            this.lblSoluongduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongduan.Location = new System.Drawing.Point(67, 263);
            this.lblSoluongduan.Name = "lblSoluongduan";
            this.lblSoluongduan.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongduan.TabIndex = 2;
            this.lblSoluongduan.Text = "Số lượng các dự án lớn : \r\n";
            // 
            // lblSoluongtk
            // 
            this.lblSoluongtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongtk.Location = new System.Drawing.Point(450, 91);
            this.lblSoluongtk.Name = "lblSoluongtk";
            this.lblSoluongtk.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongtk.TabIndex = 3;
            this.lblSoluongtk.Text = "Số lượng tài khoản đã cấp : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoluongtk);
            this.groupBox1.Controls.Add(this.lblSoluongnv);
            this.groupBox1.Controls.Add(this.lblSoluongphongban);
            this.groupBox1.Controls.Add(this.lblSoluongduan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 101);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Magneto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nguyễn Minh Thái\r\n";
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongke";
            this.Text = "frmThongke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSoluongnv;
        private System.Windows.Forms.Label lblSoluongphongban;
        private System.Windows.Forms.Label lblSoluongduan;
        private System.Windows.Forms.Label lblSoluongtk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}