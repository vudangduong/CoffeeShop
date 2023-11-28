namespace PRL.Views
{
    partial class fQuanLyTaiKhoan
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
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            dtg_view_nv = new DataGridView();
            groupBox4 = new GroupBox();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_gioitinh = new ComboBox();
            cb_chucvu = new ComboBox();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            txt_email = new TextBox();
            txt_sdt = new TextBox();
            txt_tennv = new TextBox();
            txt_manv = new TextBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            rd_danghi = new RadioButton();
            rd_hoatdong = new RadioButton();
            rd_tatca = new RadioButton();
            cb_trangthai = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_nv).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 490);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtg_view_nv);
            groupBox5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(12, 103);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(587, 381);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách";
            // 
            // dtg_view_nv
            // 
            dtg_view_nv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_nv.Location = new Point(3, 28);
            dtg_view_nv.Name = "dtg_view_nv";
            dtg_view_nv.RowHeadersWidth = 51;
            dtg_view_nv.RowTemplate.Height = 29;
            dtg_view_nv.Size = new Size(578, 347);
            dtg_view_nv.TabIndex = 0;
            dtg_view_nv.CellClick += dtg_view_nv_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cb_trangthai);
            groupBox4.Controls.Add(btn_xoa);
            groupBox4.Controls.Add(btn_sua);
            groupBox4.Controls.Add(btn_them);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(cb_gioitinh);
            groupBox4.Controls.Add(cb_chucvu);
            groupBox4.Controls.Add(txt_matkhau);
            groupBox4.Controls.Add(txt_taikhoan);
            groupBox4.Controls.Add(txt_email);
            groupBox4.Controls.Add(txt_sdt);
            groupBox4.Controls.Add(txt_tennv);
            groupBox4.Controls.Add(txt_manv);
            groupBox4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(605, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(342, 478);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(107, 424);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(142, 45);
            btn_xoa.TabIndex = 22;
            btn_xoa.Text = "Ẩn";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(178, 373);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(142, 45);
            btn_sua.TabIndex = 21;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(30, 373);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(142, 45);
            btn_them.TabIndex = 20;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 343);
            label9.Name = "label9";
            label9.Size = new Size(23, 24);
            label9.TabIndex = 19;
            label9.Text = "tt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1, 305);
            label8.Name = "label8";
            label8.Size = new Size(73, 24);
            label8.TabIndex = 18;
            label8.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 267);
            label7.Name = "label7";
            label7.Size = new Size(75, 24);
            label7.TabIndex = 17;
            label7.Text = "Tài khoản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 191);
            label6.Name = "label6";
            label6.Size = new Size(51, 24);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 153);
            label5.Name = "label5";
            label5.Size = new Size(35, 24);
            label5.TabIndex = 15;
            label5.Text = "Sđt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 77);
            label4.Name = "label4";
            label4.Size = new Size(35, 24);
            label4.TabIndex = 14;
            label4.Text = "Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 39);
            label3.Name = "label3";
            label3.Size = new Size(32, 24);
            label3.TabIndex = 13;
            label3.Text = "Mã:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 229);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 12;
            label2.Text = "Chức vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 11;
            label1.Text = "Giới tính:";
            // 
            // cb_gioitinh
            // 
            cb_gioitinh.FormattingEnabled = true;
            cb_gioitinh.Location = new Point(71, 107);
            cb_gioitinh.Name = "cb_gioitinh";
            cb_gioitinh.Size = new Size(265, 32);
            cb_gioitinh.TabIndex = 10;
            // 
            // cb_chucvu
            // 
            cb_chucvu.FormattingEnabled = true;
            cb_chucvu.Location = new Point(71, 221);
            cb_chucvu.Name = "cb_chucvu";
            cb_chucvu.Size = new Size(265, 32);
            cb_chucvu.TabIndex = 9;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(71, 297);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PlaceholderText = "Mật khẩu";
            txt_matkhau.Size = new Size(265, 32);
            txt_matkhau.TabIndex = 7;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(71, 259);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.PlaceholderText = "Tài khoản";
            txt_taikhoan.Size = new Size(265, 32);
            txt_taikhoan.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(71, 183);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email";
            txt_email.Size = new Size(265, 32);
            txt_email.TabIndex = 4;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(71, 145);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.PlaceholderText = "Số điện thoại";
            txt_sdt.Size = new Size(265, 32);
            txt_sdt.TabIndex = 3;
            // 
            // txt_tennv
            // 
            txt_tennv.Location = new Point(71, 69);
            txt_tennv.Name = "txt_tennv";
            txt_tennv.PlaceholderText = "Tên nhân viên";
            txt_tennv.Size = new Size(265, 32);
            txt_tennv.TabIndex = 1;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(71, 31);
            txt_manv.Name = "txt_manv";
            txt_manv.PlaceholderText = "Mã nhân viên";
            txt_manv.Size = new Size(265, 32);
            txt_manv.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(325, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(274, 63);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 32);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rd_danghi);
            groupBox2.Controls.Add(rd_hoatdong);
            groupBox2.Controls.Add(rd_tatca);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 63);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // rd_danghi
            // 
            rd_danghi.AutoSize = true;
            rd_danghi.Location = new Point(201, 28);
            rd_danghi.Name = "rd_danghi";
            rd_danghi.Size = new Size(80, 28);
            rd_danghi.TabIndex = 2;
            rd_danghi.TabStop = true;
            rd_danghi.Text = "Đã nghỉ";
            rd_danghi.UseVisualStyleBackColor = true;
            // 
            // rd_hoatdong
            // 
            rd_hoatdong.AutoSize = true;
            rd_hoatdong.Location = new Point(90, 28);
            rd_hoatdong.Name = "rd_hoatdong";
            rd_hoatdong.Size = new Size(96, 28);
            rd_hoatdong.TabIndex = 1;
            rd_hoatdong.TabStop = true;
            rd_hoatdong.Text = "Hoạt động";
            rd_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rd_tatca
            // 
            rd_tatca.AutoSize = true;
            rd_tatca.Location = new Point(3, 28);
            rd_tatca.Name = "rd_tatca";
            rd_tatca.Size = new Size(70, 28);
            rd_tatca.TabIndex = 0;
            rd_tatca.TabStop = true;
            rd_tatca.Text = "Tất cả";
            rd_tatca.UseVisualStyleBackColor = true;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(71, 335);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(265, 32);
            cb_trangthai.TabIndex = 23;
            // 
            // fQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox1);
            Name = "fQuanLyTaiKhoan";
            Text = "fQuanLyTaiKhoan";
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_nv).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rd_danghi;
        private RadioButton rd_hoatdong;
        private RadioButton rd_tatca;
        private GroupBox groupBox4;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private TextBox txt_email;
        private TextBox txt_sdt;
        private TextBox txt_tennv;
        private TextBox txt_manv;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_gioitinh;
        private ComboBox cb_chucvu;
        private GroupBox groupBox5;
        private DataGridView dtg_view_nv;
        private ComboBox cb_trangthai;
    }
}