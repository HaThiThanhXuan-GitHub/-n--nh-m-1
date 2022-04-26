namespace WindowsFormsApplication1
{
    partial class dangnhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.dannhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // taikhoan
            // 
            this.taikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taikhoan.Location = new System.Drawing.Point(220, 132);
            this.taikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(200, 22);
            this.taikhoan.TabIndex = 3;
            // 
            // matkhau
            // 
            this.matkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matkhau.Location = new System.Drawing.Point(220, 185);
            this.matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(200, 22);
            this.matkhau.TabIndex = 4;
            // 
            // dannhap
            // 
            this.dannhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dannhap.Location = new System.Drawing.Point(188, 252);
            this.dannhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dannhap.Name = "dannhap";
            this.dannhap.Size = new System.Drawing.Size(100, 28);
            this.dannhap.TabIndex = 5;
            this.dannhap.Text = "Đăng nhập";
            this.dannhap.UseVisualStyleBackColor = true;
            this.dannhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // thoat
            // 
            this.thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.Location = new System.Drawing.Point(365, 252);
            this.thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 28);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dangnhap
            // 
            this.AcceptButton = this.dannhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(555, 322);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dannhap);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button dannhap;
        private System.Windows.Forms.Button thoat;
    }
}

