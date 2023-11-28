namespace PRL.Sub_views
{
    partial class SubFrm_AddSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_xacnhan);
            this.groupBox1.Controls.Add(this.num_soluong);
            this.groupBox1.Controls.Add(this.lb_gia);
            this.groupBox1.Controls.Add(this.lb_tensp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.IndianRed;
            this.btn_huy.Location = new System.Drawing.Point(162, 192);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(100, 37);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_xacnhan.Location = new System.Drawing.Point(44, 192);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(100, 37);
            this.btn_xacnhan.TabIndex = 6;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            // 
            // num_soluong
            // 
            this.num_soluong.Location = new System.Drawing.Point(162, 126);
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(90, 35);
            this.num_soluong.TabIndex = 5;
            this.num_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(162, 88);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(51, 28);
            this.lb_gia.TabIndex = 4;
            this.lb_gia.Text = "0VND";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Location = new System.Drawing.Point(162, 48);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(90, 28);
            this.lb_tensp.TabIndex = 3;
            this.lb_tensp.Text = "Phóng lợn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên :";
            // 
            // SubFrm_AddSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubFrm_AddSanPham";
            this.Text = "SubFrm_AddSanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_tensp;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown num_soluong;
        private Label lb_gia;
        private Button btn_huy;
        private Button btn_xacnhan;
    }
}