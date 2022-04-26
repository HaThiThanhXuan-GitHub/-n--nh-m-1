
namespace WindowsFormsApplication1
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbhien = new System.Windows.Forms.CheckBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongbao = new System.Windows.Forms.Label();
            this.btdangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.rdnnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.btlai = new System.Windows.Forms.Button();
            this.btok = new System.Windows.Forms.Button();
            this.txtlmk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbhienan = new System.Windows.Forms.CheckBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btdoimk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbhien);
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.btnhaplai);
            this.panel1.Controls.Add(this.btdangnhap);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbThongbao);
            this.panel1.Location = new System.Drawing.Point(274, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 356);
            this.panel1.TabIndex = 20;
            // 
            // cbhien
            // 
            this.cbhien.AutoSize = true;
            this.cbhien.Location = new System.Drawing.Point(342, 215);
            this.cbhien.Name = "cbhien";
            this.cbhien.Size = new System.Drawing.Size(79, 21);
            this.cbhien.TabIndex = 23;
            this.cbhien.Text = "Hiển/ẩn";
            this.cbhien.UseVisualStyleBackColor = true;
            this.cbhien.CheckedChanged += new System.EventHandler(this.cbhien_CheckedChanged);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthoat.Location = new System.Drawing.Point(164, 295);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(78, 35);
            this.btthoat.TabIndex = 22;
            this.btthoat.Tag = "";
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btnhaplai
            // 
            this.btnhaplai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhaplai.Location = new System.Drawing.Point(248, 295);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(75, 35);
            this.btnhaplai.TabIndex = 21;
            this.btnhaplai.Text = "Nhập lại";
            this.btnhaplai.UseVisualStyleBackColor = false;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangnhap.Location = new System.Drawing.Point(329, 295);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(92, 35);
            this.btdangnhap.TabIndex = 20;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(160, 187);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(246, 22);
            this.txtpass.TabIndex = 19;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(160, 116);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(246, 22);
            this.txtuser.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // lbThongbao
            // 
            this.lbThongbao.AutoSize = true;
            this.lbThongbao.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao.Location = new System.Drawing.Point(109, 216);
            this.lbThongbao.Name = "lbThongbao";
            this.lbThongbao.Size = new System.Drawing.Size(224, 17);
            this.lbThongbao.TabIndex = 14;
            this.lbThongbao.Text = "Tên đăng nhập hoặc mật khẩu sai\r\n";
            this.lbThongbao.Visible = false;
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangky.Location = new System.Drawing.Point(92, 320);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(90, 54);
            this.btdangky.TabIndex = 18;
            this.btdangky.Text = "Đăng ký tài khoản";
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.iconlog1;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.iconlog;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtma);
            this.panel2.Controls.Add(this.rdnnu);
            this.panel2.Controls.Add(this.rdnam);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bthuy);
            this.panel2.Controls.Add(this.btlai);
            this.panel2.Controls.Add(this.btok);
            this.panel2.Controls.Add(this.txtlmk);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbhienan);
            this.panel2.Controls.Add(this.txtmk);
            this.panel2.Controls.Add(this.txttk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(274, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 468);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Mã";
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(157, 357);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(99, 22);
            this.txtma.TabIndex = 45;
            // 
            // rdnnu
            // 
            this.rdnnu.AutoSize = true;
            this.rdnnu.Location = new System.Drawing.Point(286, 280);
            this.rdnnu.Name = "rdnnu";
            this.rdnnu.Size = new System.Drawing.Size(47, 21);
            this.rdnnu.TabIndex = 44;
            this.rdnnu.TabStop = true;
            this.rdnnu.Text = "Nữ";
            this.rdnnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(184, 280);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(58, 21);
            this.rdnam.TabIndex = 43;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Giới tính";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(156, 316);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(246, 22);
            this.txtemail.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Email";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 236);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(246, 22);
            this.txtname.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Full name";
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bthuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bthuy.Location = new System.Drawing.Point(156, 400);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(78, 35);
            this.bthuy.TabIndex = 37;
            this.bthuy.Tag = "";
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btlai
            // 
            this.btlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlai.Location = new System.Drawing.Point(244, 400);
            this.btlai.Name = "btlai";
            this.btlai.Size = new System.Drawing.Size(75, 35);
            this.btlai.TabIndex = 36;
            this.btlai.Text = "Nhập lại";
            this.btlai.UseVisualStyleBackColor = false;
            this.btlai.Click += new System.EventHandler(this.btlai_Click);
            // 
            // btok
            // 
            this.btok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btok.Location = new System.Drawing.Point(329, 400);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 35);
            this.btok.TabIndex = 35;
            this.btok.Text = "Đăng ký";
            this.btok.UseVisualStyleBackColor = false;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // txtlmk
            // 
            this.txtlmk.Location = new System.Drawing.Point(157, 173);
            this.txtlmk.Name = "txtlmk";
            this.txtlmk.Size = new System.Drawing.Size(246, 22);
            this.txtlmk.TabIndex = 32;
            this.txtlmk.UseSystemPasswordChar = true;
            this.txtlmk.TextChanged += new System.EventHandler(this.txtlmk_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 40);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nhập lại \r\nmật khẩu";
            // 
            // cbhienan
            // 
            this.cbhienan.AutoSize = true;
            this.cbhienan.Location = new System.Drawing.Point(339, 201);
            this.cbhienan.Name = "cbhienan";
            this.cbhienan.Size = new System.Drawing.Size(79, 21);
            this.cbhienan.TabIndex = 30;
            this.cbhienan.Text = "Hiển/ẩn";
            this.cbhienan.UseVisualStyleBackColor = true;
            this.cbhienan.CheckedChanged += new System.EventHandler(this.cbhienan_CheckedChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(157, 120);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(246, 22);
            this.txtmk.TabIndex = 29;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(157, 69);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(246, 22);
            this.txttk.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(178, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mật khẩu không trùng\r\n\r\n";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(94, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Đăng ký tài khoản\r\n";
            // 
            // btdoimk
            // 
            this.btdoimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btdoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdoimk.Location = new System.Drawing.Point(74, 394);
            this.btdoimk.Name = "btdoimk";
            this.btdoimk.Size = new System.Drawing.Size(124, 29);
            this.btdoimk.TabIndex = 22;
            this.btdoimk.Text = "Đổi mật khẩu";
            this.btdoimk.UseVisualStyleBackColor = false;
            this.btdoimk.Click += new System.EventHandler(this.btdoimk_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.Controls.Add(this.btdoimk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btdangky);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbhien;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btnhaplai;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongbao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlmk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbhienan;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btlai;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdnnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btdoimk;
    }
}