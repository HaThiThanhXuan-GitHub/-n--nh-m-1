namespace WindowsFormsApplication1
{
    partial class Formcapnhatsach
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.ramasach = new System.Windows.Forms.RadioButton();
            this.ratensach = new System.Windows.Forms.RadioButton();
            this.grcapnhat = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnamxb = new System.Windows.Forms.DateTimePicker();
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.commatacgia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comtheloai = new System.Windows.Forms.ComboBox();
            this.comnhaxb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbghichu = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvnxb = new System.Windows.Forms.DataGridView();
            this.manxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvtl = new System.Windows.Forms.DataGridView();
            this.matl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvtg = new System.Windows.Forms.DataGridView();
            this.matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grcapnhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.gbghichu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtl)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.ramasach);
            this.groupBox1.Controls.Add(this.ratensach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(485, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(148, 56);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(317, 22);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // ramasach
            // 
            this.ramasach.AutoSize = true;
            this.ramasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ramasach.Location = new System.Drawing.Point(38, 34);
            this.ramasach.Margin = new System.Windows.Forms.Padding(4);
            this.ramasach.Name = "ramasach";
            this.ramasach.Size = new System.Drawing.Size(82, 21);
            this.ramasach.TabIndex = 1;
            this.ramasach.TabStop = true;
            this.ramasach.Text = "Mã sách";
            this.ramasach.UseVisualStyleBackColor = true;
            // 
            // ratensach
            // 
            this.ratensach.AutoSize = true;
            this.ratensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratensach.Location = new System.Drawing.Point(38, 78);
            this.ratensach.Margin = new System.Windows.Forms.Padding(4);
            this.ratensach.Name = "ratensach";
            this.ratensach.Size = new System.Drawing.Size(88, 21);
            this.ratensach.TabIndex = 0;
            this.ratensach.TabStop = true;
            this.ratensach.Text = "Tên sách";
            this.ratensach.UseVisualStyleBackColor = true;
            // 
            // grcapnhat
            // 
            this.grcapnhat.Controls.Add(this.txtsoluong);
            this.grcapnhat.Controls.Add(this.label7);
            this.grcapnhat.Controls.Add(this.txtnamxb);
            this.grcapnhat.Controls.Add(this.luu);
            this.grcapnhat.Controls.Add(this.thoat);
            this.grcapnhat.Controls.Add(this.xoa);
            this.grcapnhat.Controls.Add(this.sua);
            this.grcapnhat.Controls.Add(this.them);
            this.grcapnhat.Controls.Add(this.commatacgia);
            this.grcapnhat.Controls.Add(this.label6);
            this.grcapnhat.Controls.Add(this.comtheloai);
            this.grcapnhat.Controls.Add(this.comnhaxb);
            this.grcapnhat.Controls.Add(this.label4);
            this.grcapnhat.Controls.Add(this.label5);
            this.grcapnhat.Controls.Add(this.label3);
            this.grcapnhat.Controls.Add(this.txttensach);
            this.grcapnhat.Controls.Add(this.label2);
            this.grcapnhat.Controls.Add(this.txtmasach);
            this.grcapnhat.Controls.Add(this.label1);
            this.grcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grcapnhat.Location = new System.Drawing.Point(16, 583);
            this.grcapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.grcapnhat.Name = "grcapnhat";
            this.grcapnhat.Padding = new System.Windows.Forms.Padding(4);
            this.grcapnhat.Size = new System.Drawing.Size(1097, 202);
            this.grcapnhat.TabIndex = 1;
            this.grcapnhat.TabStop = false;
            this.grcapnhat.Text = "Cập nhật sách";
            this.grcapnhat.Enter += new System.EventHandler(this.grcapnhat_Enter);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(994, 98);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(77, 30);
            this.txtsoluong.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(912, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số lượng";
            // 
            // txtnamxb
            // 
            this.txtnamxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnamxb.Location = new System.Drawing.Point(421, 44);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(173, 22);
            this.txtnamxb.TabIndex = 38;
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(618, 156);
            this.luu.Margin = new System.Windows.Forms.Padding(4);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(100, 38);
            this.luu.TabIndex = 36;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(799, 156);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 38);
            this.thoat.TabIndex = 35;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(451, 156);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 38);
            this.xoa.TabIndex = 34;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(279, 156);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 36);
            this.sua.TabIndex = 33;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(135, 156);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 36);
            this.them.TabIndex = 32;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // commatacgia
            // 
            this.commatacgia.FormattingEnabled = true;
            this.commatacgia.Location = new System.Drawing.Point(709, 96);
            this.commatacgia.Margin = new System.Windows.Forms.Padding(4);
            this.commatacgia.Name = "commatacgia";
            this.commatacgia.Size = new System.Drawing.Size(176, 33);
            this.commatacgia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(614, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã tác giả";
            // 
            // comtheloai
            // 
            this.comtheloai.FormattingEnabled = true;
            this.comtheloai.Location = new System.Drawing.Point(723, 34);
            this.comtheloai.Margin = new System.Windows.Forms.Padding(4);
            this.comtheloai.Name = "comtheloai";
            this.comtheloai.Size = new System.Drawing.Size(176, 33);
            this.comtheloai.TabIndex = 9;
            // 
            // comnhaxb
            // 
            this.comnhaxb.FormattingEnabled = true;
            this.comnhaxb.Location = new System.Drawing.Point(421, 95);
            this.comnhaxb.Margin = new System.Windows.Forms.Padding(4);
            this.comnhaxb.Name = "comnhaxb";
            this.comnhaxb.Size = new System.Drawing.Size(173, 33);
            this.comnhaxb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(303, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhà XB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(614, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(303, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(101, 92);
            this.txttensach.Margin = new System.Windows.Forms.Padding(4);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(163, 30);
            this.txttensach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtmasach
            // 
            this.txtmasach.Enabled = false;
            this.txtmasach.Location = new System.Drawing.Point(101, 39);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(163, 30);
            this.txtmasach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.tentg,
            this.soluong,
            this.nhaxb,
            this.namxb,
            this.theloai,
            this.ghichu});
            this.luoi.Location = new System.Drawing.Point(16, 152);
            this.luoi.Margin = new System.Windows.Forms.Padding(4);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.Size = new System.Drawing.Size(1106, 423);
            this.luoi.TabIndex = 23;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 6;
            this.masach.Name = "masach";
            this.masach.Width = 80;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.MinimumWidth = 6;
            this.tensach.Name = "tensach";
            this.tensach.Width = 125;
            // 
            // tentg
            // 
            this.tentg.DataPropertyName = "tentacgia";
            this.tentg.HeaderText = "Tên tác giả";
            this.tentg.MinimumWidth = 6;
            this.tentg.Name = "tentg";
            this.tentg.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 70;
            // 
            // nhaxb
            // 
            this.nhaxb.DataPropertyName = "tennxb";
            this.nhaxb.HeaderText = "Nhà XB";
            this.nhaxb.MinimumWidth = 6;
            this.nhaxb.Name = "nhaxb";
            this.nhaxb.Width = 125;
            // 
            // namxb
            // 
            this.namxb.DataPropertyName = "namxb";
            this.namxb.HeaderText = "Năm XB";
            this.namxb.MinimumWidth = 6;
            this.namxb.Name = "namxb";
            this.namxb.Width = 125;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "tentheloai";
            this.theloai.HeaderText = "Thể loại";
            this.theloai.MinimumWidth = 6;
            this.theloai.Name = "theloai";
            this.theloai.Width = 125;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // gbghichu
            // 
            this.gbghichu.Controls.Add(this.txtghichu);
            this.gbghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbghichu.Location = new System.Drawing.Point(671, 3);
            this.gbghichu.Name = "gbghichu";
            this.gbghichu.Size = new System.Drawing.Size(454, 141);
            this.gbghichu.TabIndex = 24;
            this.gbghichu.TabStop = false;
            this.gbghichu.Text = "Ghi chú (Nếu có)";
            // 
            // txtghichu
            // 
            this.txtghichu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtghichu.Location = new System.Drawing.Point(3, 26);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(448, 112);
            this.txtghichu.TabIndex = 0;
            this.txtghichu.TextChanged += new System.EventHandler(this.txtghichu_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvnxb);
            this.groupBox3.Location = new System.Drawing.Point(1143, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 250);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhà xuất bản";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvnxb
            // 
            this.dgvnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manxb,
            this.tennhaxb,
            this.diachi,
            this.sdt});
            this.dgvnxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnxb.Location = new System.Drawing.Point(3, 18);
            this.dgvnxb.Name = "dgvnxb";
            this.dgvnxb.RowHeadersWidth = 51;
            this.dgvnxb.RowTemplate.Height = 24;
            this.dgvnxb.Size = new System.Drawing.Size(694, 229);
            this.dgvnxb.TabIndex = 0;
            this.dgvnxb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnxb_CellContentClick);
            // 
            // manxb
            // 
            this.manxb.DataPropertyName = "manxb";
            this.manxb.HeaderText = "Mã nhà XB";
            this.manxb.MinimumWidth = 6;
            this.manxb.Name = "manxb";
            this.manxb.Width = 125;
            // 
            // tennhaxb
            // 
            this.tennhaxb.DataPropertyName = "tennxb";
            this.tennhaxb.HeaderText = "Tên nhà XB";
            this.tennhaxb.MinimumWidth = 6;
            this.tennhaxb.Name = "tennhaxb";
            this.tennhaxb.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "dienthoai";
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvtl);
            this.groupBox4.Location = new System.Drawing.Point(1146, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(700, 240);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thể loại";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgvtl
            // 
            this.dgvtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matl,
            this.tentl});
            this.dgvtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtl.Location = new System.Drawing.Point(3, 18);
            this.dgvtl.Name = "dgvtl";
            this.dgvtl.RowHeadersWidth = 51;
            this.dgvtl.RowTemplate.Height = 24;
            this.dgvtl.Size = new System.Drawing.Size(694, 219);
            this.dgvtl.TabIndex = 1;
            // 
            // matl
            // 
            this.matl.DataPropertyName = "matheloai";
            this.matl.HeaderText = "Mã thể loại";
            this.matl.MinimumWidth = 6;
            this.matl.Name = "matl";
            this.matl.Width = 125;
            // 
            // tentl
            // 
            this.tentl.DataPropertyName = "tentheloai";
            this.tentl.HeaderText = "Tên thể loại";
            this.tentl.MinimumWidth = 6;
            this.tentl.Name = "tentl";
            this.tentl.Width = 125;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvtg);
            this.groupBox5.Location = new System.Drawing.Point(1148, 520);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(700, 299);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tác giả";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // dgvtg
            // 
            this.dgvtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matg,
            this.tentacgia});
            this.dgvtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtg.Location = new System.Drawing.Point(3, 18);
            this.dgvtg.Name = "dgvtg";
            this.dgvtg.RowHeadersWidth = 51;
            this.dgvtg.RowTemplate.Height = 24;
            this.dgvtg.Size = new System.Drawing.Size(694, 278);
            this.dgvtg.TabIndex = 1;
            // 
            // matg
            // 
            this.matg.DataPropertyName = "matacgia";
            this.matg.HeaderText = "Mã tác giả";
            this.matg.MinimumWidth = 6;
            this.matg.Name = "matg";
            this.matg.Width = 125;
            // 
            // tentacgia
            // 
            this.tentacgia.DataPropertyName = "tentacgia";
            this.tentacgia.HeaderText = "Tên tác giả";
            this.tentacgia.MinimumWidth = 6;
            this.tentacgia.Name = "tentacgia";
            this.tentacgia.Width = 125;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btthoat.Location = new System.Drawing.Point(530, 66);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(100, 38);
            this.btthoat.TabIndex = 36;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Formcapnhatsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 831);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbghichu);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.grcapnhat);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formcapnhatsach";
            this.Text = "Quản lý sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formcapnhatsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grcapnhat.ResumeLayout(false);
            this.grcapnhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.gbghichu.ResumeLayout(false);
            this.gbghichu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnxb)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtl)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ratensach;
        private System.Windows.Forms.RadioButton ramasach;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox grcapnhat;
        private System.Windows.Forms.ComboBox comnhaxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox commatacgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.DateTimePicker txtnamxb;
        private System.Windows.Forms.GroupBox gbghichu;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvnxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn manxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhaxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn matl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentacgia;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}