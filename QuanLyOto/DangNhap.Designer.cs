namespace QuanLyOto
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.button_thoatdangnhap = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label_tennguoidung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_thoatdangnhap
            // 
            this.button_thoatdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoatdangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_thoatdangnhap.Location = new System.Drawing.Point(275, 214);
            this.button_thoatdangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_thoatdangnhap.Name = "button_thoatdangnhap";
            this.button_thoatdangnhap.Size = new System.Drawing.Size(147, 55);
            this.button_thoatdangnhap.TabIndex = 35;
            this.button_thoatdangnhap.Text = "Thoát";
            this.button_thoatdangnhap.UseVisualStyleBackColor = true;
            this.button_thoatdangnhap.Click += new System.EventHandler(this.Button_thoatdangnhap_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.White;
            this.button_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_dangnhap.Location = new System.Drawing.Point(113, 214);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(132, 55);
            this.button_dangnhap.TabIndex = 34;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.Button_dangnhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.HideSelection = false;
            this.txtMatKhau.Location = new System.Drawing.Point(287, 143);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatKhau.MaxLength = 20;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(137, 26);
            this.txtMatKhau.TabIndex = 33;
            this.txtMatKhau.Text = "admin";
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(287, 94);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDangNhap.MaxLength = 20;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(137, 26);
            this.txtDangNhap.TabIndex = 32;
            this.txtDangNhap.Text = "admin";
            this.txtDangNhap.TextChanged += new System.EventHandler(this.Txtidngdung_TextChanged);
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.BackColor = System.Drawing.Color.DimGray;
            this.label_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matkhau.ForeColor = System.Drawing.Color.Yellow;
            this.label_matkhau.Location = new System.Drawing.Point(109, 143);
            this.label_matkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(94, 24);
            this.label_matkhau.TabIndex = 31;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // label_tennguoidung
            // 
            this.label_tennguoidung.AutoSize = true;
            this.label_tennguoidung.BackColor = System.Drawing.Color.DimGray;
            this.label_tennguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tennguoidung.ForeColor = System.Drawing.Color.Yellow;
            this.label_tennguoidung.Location = new System.Drawing.Point(109, 94);
            this.label_tennguoidung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tennguoidung.Name = "label_tennguoidung";
            this.label_tennguoidung.Size = new System.Drawing.Size(160, 24);
            this.label_tennguoidung.TabIndex = 30;
            this.label_tennguoidung.Text = "Tên người dùng";
            // 
            // DangNhap
            // 
            this.AcceptButton = this.button_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyOto.Properties.Resources._2018_vinfast_vietnams_first_carmaker_reveals_logo_design;
            this.ClientSize = new System.Drawing.Size(522, 311);
            this.Controls.Add(this.button_thoatdangnhap);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_tennguoidung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_thoatdangnhap;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label_tennguoidung;
    }
}