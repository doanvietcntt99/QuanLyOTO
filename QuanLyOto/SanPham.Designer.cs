namespace QuanLyOto
{
    partial class SanPham
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
            this.btnXem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_bh_luu = new System.Windows.Forms.Button();
            this.button_bh_xoa = new System.Windows.Forms.Button();
            this.button_bh_sua = new System.Windows.Forms.Button();
            this.button_bh_them = new System.Windows.Forms.Button();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.label_nv_manv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_DVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_GIABAN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_GIANHAP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbB_NCC = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_timkiem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_SL = new System.Windows.Forms.TextBox();
            this.CBB_MN = new System.Windows.Forms.ComboBox();
            this.TenSanPham = new System.Windows.Forms.TextBox();
            this.cbB_MSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(971, 12);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(104, 97);
            this.btnXem.TabIndex = 108;
            this.btnXem.Text = "Hiển Thị";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Image = global::QuanLyOto.Properties.Resources.d1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(971, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 105);
            this.button1.TabIndex = 107;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_bh_luu
            // 
            this.button_bh_luu.BackColor = System.Drawing.Color.Transparent;
            this.button_bh_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bh_luu.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_bh_luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_bh_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_bh_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bh_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bh_luu.ForeColor = System.Drawing.Color.Lime;
            this.button_bh_luu.Image = global::QuanLyOto.Properties.Resources.Save_as_icon;
            this.button_bh_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bh_luu.Location = new System.Drawing.Point(851, 67);
            this.button_bh_luu.Name = "button_bh_luu";
            this.button_bh_luu.Size = new System.Drawing.Size(114, 44);
            this.button_bh_luu.TabIndex = 106;
            this.button_bh_luu.Text = "Lưu";
            this.button_bh_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bh_luu.UseVisualStyleBackColor = false;
            // 
            // button_bh_xoa
            // 
            this.button_bh_xoa.BackColor = System.Drawing.Color.Transparent;
            this.button_bh_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bh_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_bh_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_bh_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_bh_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bh_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bh_xoa.ForeColor = System.Drawing.Color.Lime;
            this.button_bh_xoa.Image = global::QuanLyOto.Properties.Resources._48px_Crystal_Clear_action_stop;
            this.button_bh_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bh_xoa.Location = new System.Drawing.Point(851, 175);
            this.button_bh_xoa.Name = "button_bh_xoa";
            this.button_bh_xoa.Size = new System.Drawing.Size(114, 47);
            this.button_bh_xoa.TabIndex = 105;
            this.button_bh_xoa.Text = "Xóa";
            this.button_bh_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bh_xoa.UseVisualStyleBackColor = false;
            this.button_bh_xoa.Click += new System.EventHandler(this.button_bh_xoa_Click);
            // 
            // button_bh_sua
            // 
            this.button_bh_sua.BackColor = System.Drawing.Color.Transparent;
            this.button_bh_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bh_sua.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_bh_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_bh_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_bh_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bh_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bh_sua.ForeColor = System.Drawing.Color.Lime;
            this.button_bh_sua.Image = global::QuanLyOto.Properties.Resources._48px_Crystal_Clear_app_package_settings;
            this.button_bh_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bh_sua.Location = new System.Drawing.Point(851, 117);
            this.button_bh_sua.Name = "button_bh_sua";
            this.button_bh_sua.Size = new System.Drawing.Size(114, 44);
            this.button_bh_sua.TabIndex = 104;
            this.button_bh_sua.Text = "Sửa";
            this.button_bh_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bh_sua.UseVisualStyleBackColor = false;
            this.button_bh_sua.Click += new System.EventHandler(this.button_bh_sua_Click);
            // 
            // button_bh_them
            // 
            this.button_bh_them.BackColor = System.Drawing.Color.Transparent;
            this.button_bh_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bh_them.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.button_bh_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_bh_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_bh_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bh_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bh_them.ForeColor = System.Drawing.Color.Lime;
            this.button_bh_them.Image = global::QuanLyOto.Properties.Resources._48px_Crystal_Clear_action_db_add;
            this.button_bh_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bh_them.Location = new System.Drawing.Point(851, 12);
            this.button_bh_them.Name = "button_bh_them";
            this.button_bh_them.Size = new System.Drawing.Size(114, 44);
            this.button_bh_them.TabIndex = 103;
            this.button_bh_them.Text = "Thêm";
            this.button_bh_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bh_them.UseVisualStyleBackColor = false;
            this.button_bh_them.Click += new System.EventHandler(this.button_bh_them_Click);
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(12, 239);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.Size = new System.Drawing.Size(1063, 359);
            this.dgv_SanPham.TabIndex = 109;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // label_nv_manv
            // 
            this.label_nv_manv.AutoSize = true;
            this.label_nv_manv.BackColor = System.Drawing.Color.Transparent;
            this.label_nv_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nv_manv.ForeColor = System.Drawing.Color.Brown;
            this.label_nv_manv.Location = new System.Drawing.Point(13, 19);
            this.label_nv_manv.Name = "label_nv_manv";
            this.label_nv_manv.Size = new System.Drawing.Size(158, 25);
            this.label_nv_manv.TabIndex = 110;
            this.label_nv_manv.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Mã Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(390, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // TXT_DVT
            // 
            this.TXT_DVT.Enabled = false;
            this.TXT_DVT.Location = new System.Drawing.Point(531, 60);
            this.TXT_DVT.Name = "TXT_DVT";
            this.TXT_DVT.Size = new System.Drawing.Size(89, 20);
            this.TXT_DVT.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Giá Bán";
            // 
            // TXT_GIABAN
            // 
            this.TXT_GIABAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_GIABAN.Location = new System.Drawing.Point(178, 143);
            this.TXT_GIABAN.Name = "TXT_GIABAN";
            this.TXT_GIABAN.Size = new System.Drawing.Size(208, 26);
            this.TXT_GIABAN.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(420, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 110;
            this.label5.Text = "Giá Nhập";
            // 
            // TXT_GIANHAP
            // 
            this.TXT_GIANHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_GIANHAP.Location = new System.Drawing.Point(584, 139);
            this.TXT_GIANHAP.Name = "TXT_GIANHAP";
            this.TXT_GIANHAP.Size = new System.Drawing.Size(208, 26);
            this.TXT_GIANHAP.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(409, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 25);
            this.label6.TabIndex = 110;
            this.label6.Text = "Mã Nhà Cung Cấp";
            // 
            // cbB_NCC
            // 
            this.cbB_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbB_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB_NCC.FormattingEnabled = true;
            this.cbB_NCC.IntegralHeight = false;
            this.cbB_NCC.ItemHeight = 24;
            this.cbB_NCC.Location = new System.Drawing.Point(619, 16);
            this.cbB_NCC.Name = "cbB_NCC";
            this.cbB_NCC.Size = new System.Drawing.Size(208, 32);
            this.cbB_NCC.TabIndex = 111;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 33);
            this.button3.TabIndex = 115;
            this.button3.Text = "Tìm Kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_timkiem
            // 
            this.comboBox_timkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_timkiem.FormattingEnabled = true;
            this.comboBox_timkiem.IntegralHeight = false;
            this.comboBox_timkiem.ItemHeight = 24;
            this.comboBox_timkiem.Location = new System.Drawing.Point(147, 184);
            this.comboBox_timkiem.Name = "comboBox_timkiem";
            this.comboBox_timkiem.Size = new System.Drawing.Size(597, 32);
            this.comboBox_timkiem.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(15, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 113;
            this.label7.Text = "Tìm kiếm :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(626, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 110;
            this.label8.Text = "Số Lượng";
            // 
            // TXT_SL
            // 
            this.TXT_SL.Location = new System.Drawing.Point(739, 62);
            this.TXT_SL.Name = "TXT_SL";
            this.TXT_SL.Size = new System.Drawing.Size(89, 20);
            this.TXT_SL.TabIndex = 112;
            // 
            // CBB_MN
            // 
            this.CBB_MN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBB_MN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_MN.FormattingEnabled = true;
            this.CBB_MN.IntegralHeight = false;
            this.CBB_MN.ItemHeight = 24;
            this.CBB_MN.Location = new System.Drawing.Point(178, 54);
            this.CBB_MN.Name = "CBB_MN";
            this.CBB_MN.Size = new System.Drawing.Size(208, 32);
            this.CBB_MN.TabIndex = 111;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSanPham.Location = new System.Drawing.Point(178, 95);
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Size = new System.Drawing.Size(650, 31);
            this.TenSanPham.TabIndex = 116;
            // 
            // cbB_MSP
            // 
            this.cbB_MSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbB_MSP.Location = new System.Drawing.Point(177, 17);
            this.cbB_MSP.Name = "cbB_MSP";
            this.cbB_MSP.Size = new System.Drawing.Size(209, 31);
            this.cbB_MSP.TabIndex = 116;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 610);
            this.Controls.Add(this.cbB_MSP);
            this.Controls.Add(this.TenSanPham);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox_timkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXT_GIANHAP);
            this.Controls.Add(this.TXT_GIABAN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT_SL);
            this.Controls.Add(this.TXT_DVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbB_NCC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBB_MN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nv_manv);
            this.Controls.Add(this.dgv_SanPham);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_bh_luu);
            this.Controls.Add(this.button_bh_xoa);
            this.Controls.Add(this.button_bh_sua);
            this.Controls.Add(this.button_bh_them);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_bh_luu;
        private System.Windows.Forms.Button button_bh_xoa;
        private System.Windows.Forms.Button button_bh_sua;
        private System.Windows.Forms.Button button_bh_them;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.Label label_nv_manv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_DVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_GIABAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_GIANHAP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbB_NCC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_SL;
        private System.Windows.Forms.ComboBox CBB_MN;
        private System.Windows.Forms.TextBox TenSanPham;
        private System.Windows.Forms.TextBox cbB_MSP;
    }
}