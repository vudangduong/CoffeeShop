namespace PRL.Views
{
    partial class fQLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLBan));
            groupBox1 = new GroupBox();
            dtg_view_ban = new DataGridView();
            groupBox2 = new GroupBox();
            cb_trangthai = new ComboBox();
            label2 = new Label();
            txt_tenban = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            btn_load = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_ban).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_view_ban);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 467);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bàn";
            // 
            // dtg_view_ban
            // 
            dtg_view_ban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_ban.Location = new Point(3, 28);
            dtg_view_ban.Name = "dtg_view_ban";
            dtg_view_ban.RowHeadersWidth = 51;
            dtg_view_ban.RowTemplate.Height = 29;
            dtg_view_ban.Size = new Size(552, 433);
            dtg_view_ban.TabIndex = 0;
            dtg_view_ban.CellClick += dtg_view_ban_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_trangthai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_tenban);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(597, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(33, 153);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(287, 32);
            cb_trangthai.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 2;
            label2.Text = "Trạng thái";
            // 
            // txt_tenban
            // 
            txt_tenban.Location = new Point(33, 68);
            txt_tenban.Name = "txt_tenban";
            txt_tenban.Size = new Size(287, 32);
            txt_tenban.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(btn_load);
            groupBox3.Controls.Add(btn_xoa);
            groupBox3.Controls.Add(btn_sua);
            groupBox3.Controls.Add(btn_them);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(597, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 229);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 170);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(16, 169);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(132, 40);
            btn_load.TabIndex = 3;
            btn_load.Text = "Tải lại";
            btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(16, 123);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(132, 40);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Ẩn";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(16, 77);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(132, 40);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(16, 31);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(132, 40);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // fQLBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLBan";
            Text = "fQLBan";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_ban).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtg_view_ban;
        private ComboBox cb_trangthai;
        private Label label2;
        private TextBox txt_tenban;
        private Label label1;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Button btn_load;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}