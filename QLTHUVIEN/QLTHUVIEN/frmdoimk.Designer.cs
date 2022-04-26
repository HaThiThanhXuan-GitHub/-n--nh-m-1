
namespace WindowsFormsApplication1
{
    partial class frmdoimk
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
            this.txtpasscu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bthuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bthuy.Location = new System.Drawing.Point(302, 354);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(78, 35);
            this.bthuy.TabIndex = 58;
            this.bthuy.Tag = "";
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btlai
            // 
            this.btlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btlai.Location = new System.Drawing.Point(390, 354);
            this.btlai.Name = "btlai";
            this.btlai.Size = new System.Drawing.Size(75, 35);
            this.btlai.TabIndex = 57;
            this.btlai.Text = "Nhập lại";
            this.btlai.UseVisualStyleBackColor = false;
            this.btlai.Click += new System.EventHandler(this.btlai_Click);
            // 
            // btok
            // 
            this.btok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btok.Location = new System.Drawing.Point(475, 354);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 35);
            this.btok.TabIndex = 56;
            this.btok.Text = "Đổi";
            this.btok.UseVisualStyleBackColor = false;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // txtlmk
            // 
            this.txtlmk.Location = new System.Drawing.Point(304, 257);
            this.txtlmk.Name = "txtlmk";
            this.txtlmk.Size = new System.Drawing.Size(246, 22);
            this.txtlmk.TabIndex = 55;
            this.txtlmk.UseSystemPasswordChar = true;
            this.txtlmk.TextChanged += new System.EventHandler(this.txtlmk_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 40);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nhập lại \r\nmật khẩu mới\r\n";
            // 
            // cbhienan
            // 
            this.cbhienan.AutoSize = true;
            this.cbhienan.Location = new System.Drawing.Point(486, 285);
            this.cbhienan.Name = "cbhienan";
            this.cbhienan.Size = new System.Drawing.Size(79, 21);
            this.cbhienan.TabIndex = 53;
            this.cbhienan.Text = "Hiển/ẩn";
            this.cbhienan.UseVisualStyleBackColor = true;
            this.cbhienan.CheckedChanged += new System.EventHandler(this.cbhienan_CheckedChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(304, 197);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(246, 22);
            this.txtmk.TabIndex = 52;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(304, 94);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(246, 22);
            this.txttk.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(325, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 34);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mật khẩu không trùng\r\n\r\n";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(262, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "ĐỔI MẬT KHẨU\r\n";
            // 
            // txtpasscu
            // 
            this.txtpasscu.Location = new System.Drawing.Point(304, 145);
            this.txtpasscu.Name = "txtpasscu";
            this.txtpasscu.Size = new System.Drawing.Size(246, 22);
            this.txtpasscu.TabIndex = 60;
            this.txtpasscu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthoat.Location = new System.Drawing.Point(173, 354);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(78, 35);
            this.btthoat.TabIndex = 61;
            this.btthoat.Tag = "";
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // frmdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 428);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtpasscu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btlai);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.txtlmk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbhienan);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "frmdoimk";
            this.Text = "frmdoimk";
            this.Load += new System.EventHandler(this.frmdoimk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btlai;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.TextBox txtlmk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbhienan;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpasscu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat;
    }
}