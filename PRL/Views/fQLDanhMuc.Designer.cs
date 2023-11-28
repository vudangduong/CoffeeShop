namespace PRL.Views
{
    partial class fQLDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLDanhMuc));
            groupBox1 = new GroupBox();
            dtg_danhmuc = new DataGridView();
            groupBox2 = new GroupBox();
            txt_mota = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_tenloaisp = new TextBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            btn_load = new Button();
            btn_an = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhmuc).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_danhmuc);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 467);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách danh mục";
            // 
            // dtg_danhmuc
            // 
            dtg_danhmuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_danhmuc.Location = new Point(3, 28);
            dtg_danhmuc.Name = "dtg_danhmuc";
            dtg_danhmuc.RowHeadersWidth = 51;
            dtg_danhmuc.RowTemplate.Height = 29;
            dtg_danhmuc.Size = new Size(509, 433);
            dtg_danhmuc.TabIndex = 0;
            dtg_danhmuc.CellClick += dtg_danhmuc_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_mota);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_tenloaisp);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(539, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 226);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(54, 156);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(299, 32);
            txt_mota.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 2;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên danh mục";
            // 
            // txt_tenloaisp
            // 
            txt_tenloaisp.Location = new Point(54, 83);
            txt_tenloaisp.Name = "txt_tenloaisp";
            txt_tenloaisp.Size = new Size(299, 32);
            txt_tenloaisp.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(btn_load);
            groupBox3.Controls.Add(btn_an);
            groupBox3.Controls.Add(btn_sua);
            groupBox3.Controls.Add(btn_them);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(539, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(406, 235);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(210, 100);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(143, 40);
            btn_load.TabIndex = 7;
            btn_load.Text = "Làm mới";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_an
            // 
            btn_an.Location = new Point(39, 100);
            btn_an.Name = "btn_an";
            btn_an.Size = new Size(143, 40);
            btn_an.TabIndex = 6;
            btn_an.Text = "Ẩn";
            btn_an.UseVisualStyleBackColor = true;
            btn_an.Click += btn_an_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(210, 45);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(143, 40);
            btn_sua.TabIndex = 5;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(39, 45);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(143, 40);
            btn_them.TabIndex = 4;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // fQLDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLDanhMuc";
            Text = "Danh Mục";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_danhmuc).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtg_danhmuc;
        private GroupBox groupBox2;
        private TextBox txt_mota;
        private Label label2;
        private Label label1;
        private TextBox txt_tenloaisp;
        private GroupBox groupBox3;
        private Button btn_load;
        private Button btn_an;
        private Button btn_sua;
        private Button btn_them;
        private PictureBox pictureBox1;
    }
}