namespace PRL.Views
{
    partial class fMangVe
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
            panel1 = new Panel();
            lsvHoaDon = new ListView();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            fl_sanpham = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            cb_loaisp = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            btn_thanhtoan = new Button();
            lb_tienthua = new Label();
            txt_tientra = new TextBox();
            cb_khuyenmai = new ComboBox();
            lb_tongtien = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lsvHoaDon);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(746, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 364);
            panel1.TabIndex = 0;
            // 
            // lsvHoaDon
            // 
            lsvHoaDon.Location = new Point(3, 44);
            lsvHoaDon.Name = "lsvHoaDon";
            lsvHoaDon.Size = new Size(474, 317);
            lsvHoaDon.TabIndex = 1;
            lsvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 5);
            label1.Name = "label1";
            label1.Size = new Size(95, 36);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 542);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(fl_sanpham);
            groupBox2.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(3, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 418);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Món";
            // 
            // fl_sanpham
            // 
            fl_sanpham.AutoScroll = true;
            fl_sanpham.Location = new Point(6, 25);
            fl_sanpham.Name = "fl_sanpham";
            fl_sanpham.Size = new Size(722, 385);
            fl_sanpham.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(cb_loaisp);
            groupBox1.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(737, 77);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục";
            // 
            // cb_loaisp
            // 
            cb_loaisp.FormattingEnabled = true;
            cb_loaisp.Location = new Point(22, 35);
            cb_loaisp.Name = "cb_loaisp";
            cb_loaisp.Size = new Size(697, 36);
            cb_loaisp.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 5);
            label2.Name = "label2";
            label2.Size = new Size(69, 36);
            label2.TabIndex = 2;
            label2.Text = "Menu";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(btn_thanhtoan);
            panel3.Controls.Add(lb_tienthua);
            panel3.Controls.Add(txt_tientra);
            panel3.Controls.Add(cb_khuyenmai);
            panel3.Controls.Add(lb_tongtien);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(746, 369);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 172);
            panel3.TabIndex = 1;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thanhtoan.Location = new Point(355, 14);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(94, 127);
            btn_thanhtoan.TabIndex = 10;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // lb_tienthua
            // 
            lb_tienthua.AutoSize = true;
            lb_tienthua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tienthua.Location = new Point(131, 121);
            lb_tienthua.Name = "lb_tienthua";
            lb_tienthua.Size = new Size(18, 20);
            lb_tienthua.TabIndex = 9;
            lb_tienthua.Text = "0";
            // 
            // txt_tientra
            // 
            txt_tientra.Location = new Point(131, 76);
            txt_tientra.Name = "txt_tientra";
            txt_tientra.Size = new Size(151, 27);
            txt_tientra.TabIndex = 8;
            // 
            // cb_khuyenmai
            // 
            cb_khuyenmai.FormattingEnabled = true;
            cb_khuyenmai.Location = new Point(131, 42);
            cb_khuyenmai.Name = "cb_khuyenmai";
            cb_khuyenmai.Size = new Size(151, 28);
            cb_khuyenmai.TabIndex = 7;
            // 
            // lb_tongtien
            // 
            lb_tongtien.AutoSize = true;
            lb_tongtien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tongtien.Location = new Point(131, 14);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new Size(18, 20);
            lb_tongtien.TabIndex = 6;
            lb_tongtien.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 121);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "Tiền thừa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 82);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Tiền khách trả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 50);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Khuyến mại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Tổng tiền:";
            // 
            // fMangVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1229, 545);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fMangVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView lsvHoaDon;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox cb_loaisp;
        private Label label2;
        private GroupBox groupBox2;
        private Panel panel3;
        private Button btn_thanhtoan;
        private Label lb_tienthua;
        private TextBox txt_tientra;
        private ComboBox cb_khuyenmai;
        private Label lb_tongtien;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel fl_sanpham;
    }
}