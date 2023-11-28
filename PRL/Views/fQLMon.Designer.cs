namespace PRL.Views
{
    partial class fQLMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLMon));
            groupBox1 = new GroupBox();
            dtg_mon = new DataGridView();
            groupBox2 = new GroupBox();
            btn_load = new Button();
            btn_an = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            pic_anh = new PictureBox();
            tb_mota = new TextBox();
            label5 = new Label();
            cbb_trangthai = new ComboBox();
            label4 = new Label();
            tb_gia = new TextBox();
            label3 = new Label();
            cb_danhmuc = new ComboBox();
            label2 = new Label();
            tb_tensp = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_mon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_anh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_mon);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 467);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dach sách món";
            // 
            // dtg_mon
            // 
            dtg_mon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_mon.Location = new Point(3, 28);
            dtg_mon.Name = "dtg_mon";
            dtg_mon.RowHeadersWidth = 51;
            dtg_mon.RowTemplate.Height = 29;
            dtg_mon.Size = new Size(509, 433);
            dtg_mon.TabIndex = 0;
            dtg_mon.CellClick += dtg_mon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_load);
            groupBox2.Controls.Add(btn_an);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(pic_anh);
            groupBox2.Controls.Add(tb_mota);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbb_trangthai);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tb_gia);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cb_danhmuc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tb_tensp);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(539, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 467);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // btn_load
            // 
            btn_load.Location = new Point(261, 397);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(125, 43);
            btn_load.TabIndex = 14;
            btn_load.Text = "Làm mới";
            btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_an
            // 
            btn_an.Location = new Point(261, 348);
            btn_an.Name = "btn_an";
            btn_an.Size = new Size(125, 43);
            btn_an.TabIndex = 13;
            btn_an.Text = "Ẩn";
            btn_an.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(261, 299);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(125, 43);
            btn_sua.TabIndex = 12;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(261, 250);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(125, 43);
            btn_them.TabIndex = 11;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // pic_anh
            // 
            pic_anh.Image = (Image)resources.GetObject("pic_anh.Image");
            pic_anh.Location = new Point(261, 44);
            pic_anh.Name = "pic_anh";
            pic_anh.Size = new Size(125, 155);
            pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_anh.TabIndex = 10;
            pic_anh.TabStop = false;
            pic_anh.Click += pic_anh_Click;
            // 
            // tb_mota
            // 
            tb_mota.Location = new Point(7, 359);
            tb_mota.Name = "tb_mota";
            tb_mota.Size = new Size(220, 32);
            tb_mota.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 332);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 8;
            label5.Text = "Mô tả";
            // 
            // cbb_trangthai
            // 
            cbb_trangthai.FormattingEnabled = true;
            cbb_trangthai.Location = new Point(6, 286);
            cbb_trangthai.Name = "cbb_trangthai";
            cbb_trangthai.Size = new Size(220, 32);
            cbb_trangthai.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 259);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 6;
            label4.Text = "Trạng thái";
            // 
            // tb_gia
            // 
            tb_gia.Location = new Point(6, 215);
            tb_gia.Name = "tb_gia";
            tb_gia.Size = new Size(220, 32);
            tb_gia.TabIndex = 5;
            tb_gia.KeyPress += tb_gia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 188);
            label3.Name = "label3";
            label3.Size = new Size(31, 24);
            label3.TabIndex = 4;
            label3.Text = "Giá";
            // 
            // cb_danhmuc
            // 
            cb_danhmuc.FormattingEnabled = true;
            cb_danhmuc.Location = new Point(6, 143);
            cb_danhmuc.Name = "cb_danhmuc";
            cb_danhmuc.Size = new Size(220, 32);
            cb_danhmuc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 116);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 2;
            label2.Text = "Danh mục";
            // 
            // tb_tensp
            // 
            tb_tensp.Location = new Point(6, 71);
            tb_tensp.Name = "tb_tensp";
            tb_tensp.Size = new Size(220, 32);
            tb_tensp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // fQLMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLMon";
            Text = "fQLMon";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_mon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_anh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_mon;
        private GroupBox groupBox2;
        private Label label1;
        private PictureBox pic_anh;
        private TextBox tb_mota;
        private Label label5;
        private ComboBox cbb_trangthai;
        private Label label4;
        private TextBox tb_gia;
        private Label label3;
        private ComboBox cb_danhmuc;
        private Label label2;
        private TextBox tb_tensp;
        private Button btn_load;
        private Button btn_an;
        private Button btn_sua;
        private Button btn_them;
    }
}