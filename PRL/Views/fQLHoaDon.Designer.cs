namespace PRL.Views
{
    partial class fQLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLHoaDon));
            groupBox1 = new GroupBox();
            dtp_Ngay = new DateTimePicker();
            groupBox2 = new GroupBox();
            btn_an = new Button();
            btn_in = new Button();
            groupBox3 = new GroupBox();
            dtg_view_hoadon = new DataGridView();
            groupBox4 = new GroupBox();
            dtg_view_chitiethoadon = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_chitiethoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_Ngay);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            // 
            // dtp_Ngay
            // 
            dtp_Ngay.CustomFormat = "dd/MM/yyyy";
            dtp_Ngay.Format = DateTimePickerFormat.Custom;
            dtp_Ngay.Location = new Point(43, 25);
            dtp_Ngay.Name = "dtp_Ngay";
            dtp_Ngay.Size = new Size(333, 32);
            dtp_Ngay.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_an);
            groupBox2.Controls.Add(btn_in);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(466, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 63);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btn_an
            // 
            btn_an.Image = (Image)resources.GetObject("btn_an.Image");
            btn_an.ImageAlign = ContentAlignment.MiddleLeft;
            btn_an.Location = new Point(250, 25);
            btn_an.Name = "btn_an";
            btn_an.Size = new Size(213, 29);
            btn_an.TabIndex = 1;
            btn_an.Text = "Ẩn hóa đơn";
            btn_an.UseVisualStyleBackColor = true;
            // 
            // btn_in
            // 
            btn_in.Image = (Image)resources.GetObject("btn_in.Image");
            btn_in.ImageAlign = ContentAlignment.MiddleLeft;
            btn_in.Location = new Point(19, 25);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(213, 29);
            btn_in.TabIndex = 0;
            btn_in.Text = "In hóa đơn";
            btn_in.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_view_hoadon);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(945, 194);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dtg_view_hoadon
            // 
            dtg_view_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_hoadon.Location = new Point(3, 28);
            dtg_view_hoadon.Name = "dtg_view_hoadon";
            dtg_view_hoadon.RowHeadersWidth = 51;
            dtg_view_hoadon.RowTemplate.Height = 29;
            dtg_view_hoadon.Size = new Size(936, 160);
            dtg_view_hoadon.TabIndex = 0;
            dtg_view_hoadon.CellClick += dtg_view_hoadon_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtg_view_chitiethoadon);
            groupBox4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 269);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(945, 217);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dtg_view_chitiethoadon
            // 
            dtg_view_chitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_chitiethoadon.Location = new Point(6, 31);
            dtg_view_chitiethoadon.Name = "dtg_view_chitiethoadon";
            dtg_view_chitiethoadon.RowHeadersWidth = 51;
            dtg_view_chitiethoadon.RowTemplate.Height = 29;
            dtg_view_chitiethoadon.Size = new Size(936, 179);
            dtg_view_chitiethoadon.TabIndex = 1;
            // 
            // fQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLHoaDon";
            Text = "fQLHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_chitiethoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp_Ngay;
        private GroupBox groupBox2;
        private Button btn_an;
        private Button btn_in;
        private GroupBox groupBox3;
        private DataGridView dtg_view_hoadon;
        private GroupBox groupBox4;
        private DataGridView dtg_view_chitiethoadon;
    }
}