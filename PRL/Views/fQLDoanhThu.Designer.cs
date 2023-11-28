namespace PRL.Views
{
    partial class fQLDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLDoanhThu));
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            dtg_view_hoadon = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(34, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 32);
            dateTimePicker1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(540, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 71);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 28);
            button1.Name = "button1";
            button1.Size = new Size(396, 37);
            button1.TabIndex = 0;
            button1.Text = "In";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_view_hoadon);
            groupBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(945, 402);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống kê";
            // 
            // dtg_view_hoadon
            // 
            dtg_view_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_hoadon.Location = new Point(3, 28);
            dtg_view_hoadon.Name = "dtg_view_hoadon";
            dtg_view_hoadon.RowHeadersWidth = 51;
            dtg_view_hoadon.RowTemplate.Height = 29;
            dtg_view_hoadon.Size = new Size(936, 368);
            dtg_view_hoadon.TabIndex = 0;
            // 
            // fQLDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "fQLDoanhThu";
            Text = "Doanh thu";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Button button1;
        private GroupBox groupBox3;
        private DataGridView dtg_view_hoadon;
    }
}