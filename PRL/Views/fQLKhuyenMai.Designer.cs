namespace PRL.Views
{
    partial class fQLKhuyenMai
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
            txt_timkiem = new TextBox();
            dtg_khuyenmai = new DataGridView();
            groupBox2 = new GroupBox();
            rd_hethan = new RadioButton();
            rd_dangdung = new RadioButton();
            rd_chuadung = new RadioButton();
            rd_tatca = new RadioButton();
            groupBox3 = new GroupBox();
            btn_load = new Button();
            btn_an = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            cb_sudung = new RadioButton();
            label7 = new Label();
            dt_ngaykt = new DateTimePicker();
            dt_ngaybd = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txt_sotien = new TextBox();
            label4 = new Label();
            txt_phantram = new TextBox();
            label3 = new Label();
            txt_dkgiam = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_tenkm = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_khuyenmai).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_timkiem);
            groupBox1.Controls.Add(dtg_khuyenmai);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 400);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khuyến mại";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_timkiem.ForeColor = SystemColors.HighlightText;
            txt_timkiem.Location = new Point(331, -1);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "tìm kiếm";
            txt_timkiem.Size = new Size(251, 32);
            txt_timkiem.TabIndex = 4;
            // 
            // dtg_khuyenmai
            // 
            dtg_khuyenmai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_khuyenmai.Location = new Point(6, 37);
            dtg_khuyenmai.Name = "dtg_khuyenmai";
            dtg_khuyenmai.RowHeadersWidth = 51;
            dtg_khuyenmai.RowTemplate.Height = 29;
            dtg_khuyenmai.Size = new Size(570, 353);
            dtg_khuyenmai.TabIndex = 0;
            dtg_khuyenmai.CellClick += dtg_khuyenmai_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rd_hethan);
            groupBox2.Controls.Add(rd_dangdung);
            groupBox2.Controls.Add(rd_chuadung);
            groupBox2.Controls.Add(rd_tatca);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(2, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 71);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // rd_hethan
            // 
            rd_hethan.AutoSize = true;
            rd_hethan.Location = new Point(331, 28);
            rd_hethan.Name = "rd_hethan";
            rd_hethan.Size = new Size(80, 28);
            rd_hethan.TabIndex = 3;
            rd_hethan.TabStop = true;
            rd_hethan.Text = "Hết hạn";
            rd_hethan.UseVisualStyleBackColor = true;
            // 
            // rd_dangdung
            // 
            rd_dangdung.AutoSize = true;
            rd_dangdung.Location = new Point(205, 28);
            rd_dangdung.Name = "rd_dangdung";
            rd_dangdung.Size = new Size(120, 28);
            rd_dangdung.TabIndex = 2;
            rd_dangdung.TabStop = true;
            rd_dangdung.Text = "Đang sử dụng";
            rd_dangdung.UseVisualStyleBackColor = true;
            // 
            // rd_chuadung
            // 
            rd_chuadung.AutoSize = true;
            rd_chuadung.Location = new Point(79, 28);
            rd_chuadung.Name = "rd_chuadung";
            rd_chuadung.Size = new Size(120, 28);
            rd_chuadung.TabIndex = 1;
            rd_chuadung.TabStop = true;
            rd_chuadung.Text = "Chửa sử dụng";
            rd_chuadung.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_load);
            groupBox3.Controls.Add(btn_an);
            groupBox3.Controls.Add(btn_sua);
            groupBox3.Controls.Add(btn_them);
            groupBox3.Controls.Add(cb_sudung);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(dt_ngaykt);
            groupBox3.Controls.Add(dt_ngaybd);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txt_sotien);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txt_phantram);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txt_dkgiam);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txt_tenkm);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(590, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(364, 467);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // btn_load
            // 
            btn_load.Location = new Point(208, 385);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(131, 47);
            btn_load.TabIndex = 17;
            btn_load.Text = "Làm mới";
            btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_an
            // 
            btn_an.Location = new Point(28, 385);
            btn_an.Name = "btn_an";
            btn_an.Size = new Size(131, 47);
            btn_an.TabIndex = 16;
            btn_an.Text = "Ẩn";
            btn_an.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(206, 319);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(131, 47);
            btn_sua.TabIndex = 15;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(28, 319);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(131, 47);
            btn_them.TabIndex = 14;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // cb_sudung
            // 
            cb_sudung.AutoSize = true;
            cb_sudung.Location = new Point(128, 262);
            cb_sudung.Name = "cb_sudung";
            cb_sudung.Size = new Size(83, 28);
            cb_sudung.TabIndex = 13;
            cb_sudung.TabStop = true;
            cb_sudung.Text = "sử dụng";
            cb_sudung.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 266);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 12;
            label7.Text = "Trạng thái:";
            // 
            // dt_ngaykt
            // 
            dt_ngaykt.CustomFormat = "dd/MM/yyyy";
            dt_ngaykt.Format = DateTimePickerFormat.Custom;
            dt_ngaykt.Location = new Point(186, 215);
            dt_ngaykt.Name = "dt_ngaykt";
            dt_ngaykt.Size = new Size(153, 32);
            dt_ngaykt.TabIndex = 11;
            // 
            // dt_ngaybd
            // 
            dt_ngaybd.CustomFormat = "dd/MM/yyyy";
            dt_ngaybd.Format = DateTimePickerFormat.Custom;
            dt_ngaybd.Location = new Point(6, 215);
            dt_ngaybd.Name = "dt_ngaybd";
            dt_ngaybd.Size = new Size(153, 32);
            dt_ngaybd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 188);
            label6.Name = "label6";
            label6.Size = new Size(101, 24);
            label6.TabIndex = 9;
            label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 188);
            label5.Name = "label5";
            label5.Size = new Size(96, 24);
            label5.TabIndex = 8;
            label5.Text = "Ngày bắt đầu";
            // 
            // txt_sotien
            // 
            txt_sotien.Location = new Point(186, 141);
            txt_sotien.Name = "txt_sotien";
            txt_sotien.Size = new Size(153, 32);
            txt_sotien.TabIndex = 7;
            txt_sotien.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 114);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 6;
            label4.Text = "Số tiền giảm";
            // 
            // txt_phantram
            // 
            txt_phantram.Location = new Point(6, 141);
            txt_phantram.Name = "txt_phantram";
            txt_phantram.Size = new Size(153, 32);
            txt_phantram.TabIndex = 5;
            txt_phantram.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 4;
            label3.Text = "Phần trăm giảm";
            // 
            // txt_dkgiam
            // 
            txt_dkgiam.Location = new Point(94, 68);
            txt_dkgiam.Name = "txt_dkgiam";
            txt_dkgiam.Size = new Size(243, 32);
            txt_dkgiam.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 2;
            label2.Text = "Điều kiện:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(35, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên:";
            // 
            // txt_tenkm
            // 
            txt_tenkm.Location = new Point(94, 24);
            txt_tenkm.Name = "txt_tenkm";
            txt_tenkm.Size = new Size(243, 32);
            txt_tenkm.TabIndex = 0;
            // 
            // fQLKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLKhuyenMai";
            Text = "Khuyến mại";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_khuyenmai).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_khuyenmai;
        private GroupBox groupBox2;
        private RadioButton rd_tatca;
        private TextBox txt_timkiem;
        private RadioButton rd_hethan;
        private RadioButton rd_dangdung;
        private RadioButton rd_chuadung;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txt_dkgiam;
        private Label label2;
        private Label label1;
        private TextBox txt_tenkm;
        private Button btn_load;
        private Button btn_an;
        private Button btn_sua;
        private Button btn_them;
        private RadioButton cb_sudung;
        private Label label7;
        private DateTimePicker dt_ngaykt;
        private DateTimePicker dt_ngaybd;
        private Label label6;
        private Label label5;
        private TextBox txt_sotien;
        private Label label4;
        private TextBox txt_phantram;
    }
}