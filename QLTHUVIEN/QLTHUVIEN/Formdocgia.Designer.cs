﻿namespace WindowsFormsApplication1
{
    partial class Formdocgia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comgioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendocgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comgioitinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.txtlop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttendocgia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmadocgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(753, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin";
            // 
            // comgioitinh
            // 
            this.comgioitinh.FormattingEnabled = true;
            this.comgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comgioitinh.Location = new System.Drawing.Point(240, 194);
            this.comgioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.comgioitinh.Name = "comgioitinh";
            this.comgioitinh.Size = new System.Drawing.Size(103, 24);
            this.comgioitinh.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(71, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giới tính";
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(579, 241);
            this.luu.Margin = new System.Windows.Forms.Padding(4);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(100, 38);
            this.luu.TabIndex = 41;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.thoat.Location = new System.Drawing.Point(579, 311);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 38);
            this.thoat.TabIndex = 40;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xoa.Location = new System.Drawing.Point(579, 160);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 38);
            this.xoa.TabIndex = 39;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sua.Location = new System.Drawing.Point(579, 96);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 36);
            this.sua.TabIndex = 38;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.them.Location = new System.Drawing.Point(579, 23);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 36);
            this.them.TabIndex = 37;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.CustomFormat = "";
            this.ngaysinh.Location = new System.Drawing.Point(240, 145);
            this.ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(231, 22);
            this.ngaysinh.TabIndex = 7;
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(240, 249);
            this.txtlop.Margin = new System.Windows.Forms.Padding(4);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(231, 22);
            this.txtlop.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(71, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(71, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txttendocgia
            // 
            this.txttendocgia.Location = new System.Drawing.Point(240, 96);
            this.txttendocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txttendocgia.Name = "txttendocgia";
            this.txttendocgia.Size = new System.Drawing.Size(231, 22);
            this.txttendocgia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Enabled = false;
            this.txtmadocgia.Location = new System.Drawing.Point(240, 39);
            this.txtmadocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(231, 22);
            this.txtmadocgia.TabIndex = 1;
            this.txtmadocgia.TextChanged += new System.EventHandler(this.txtmadocgia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(64, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(207, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CẬP NHẬT THÔNG TIN ĐỘC GIẢ";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madocgia,
            this.tendg,
            this.ngaysinhs,
            this.gioitinh,
            this.lop});
            this.luoi.Location = new System.Drawing.Point(16, 492);
            this.luoi.Margin = new System.Windows.Forms.Padding(4);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.Size = new System.Drawing.Size(753, 245);
            this.luoi.TabIndex = 25;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 459);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng số độc giả";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(208, 459);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 17);
            this.l.TabIndex = 27;
            // 
            // madocgia
            // 
            this.madocgia.DataPropertyName = "madocgia";
            this.madocgia.HeaderText = "Mã độc giả";
            this.madocgia.MinimumWidth = 6;
            this.madocgia.Name = "madocgia";
            this.madocgia.Width = 80;
            // 
            // tendg
            // 
            this.tendg.DataPropertyName = "hoten";
            this.tendg.HeaderText = "Tên độc giả";
            this.tendg.MinimumWidth = 6;
            this.tendg.Name = "tendg";
            this.tendg.Width = 125;
            // 
            // ngaysinhs
            // 
            this.ngaysinhs.DataPropertyName = "ngaysinh";
            this.ngaysinhs.HeaderText = "Ngày sinh";
            this.ngaysinhs.MinimumWidth = 6;
            this.ngaysinhs.Name = "ngaysinhs";
            this.ngaysinhs.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 80;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // Formdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 752);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formdocgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formdocgia";
            this.Load += new System.EventHandler(this.Formdocgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comgioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
    }
}