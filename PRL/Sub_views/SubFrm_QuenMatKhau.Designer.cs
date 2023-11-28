namespace PRL.Sub_views
{
    partial class SubFrm_QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtmxn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtmkmoi = new System.Windows.Forms.TextBox();
            this.tbtnhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email khôi phục mật khẩu";
            // 
            // tbtemail
            // 
            this.tbtemail.Location = new System.Drawing.Point(49, 53);
            this.tbtemail.Name = "tbtemail";
            this.tbtemail.Size = new System.Drawing.Size(316, 27);
            this.tbtemail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Xác Nhận";
            // 
            // tbtmxn
            // 
            this.tbtmxn.Location = new System.Drawing.Point(49, 125);
            this.tbtmxn.Name = "tbtmxn";
            this.tbtmxn.Size = new System.Drawing.Size(316, 27);
            this.tbtmxn.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(421, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lấy Mã";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xacnhan.Location = new System.Drawing.Point(49, 334);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(157, 46);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // tbtmkmoi
            // 
            this.tbtmkmoi.Location = new System.Drawing.Point(49, 201);
            this.tbtmkmoi.Name = "tbtmkmoi";
            this.tbtmkmoi.Size = new System.Drawing.Size(316, 27);
            this.tbtmkmoi.TabIndex = 8;
            // 
            // tbtnhaplaimkmoi
            // 
            this.tbtnhaplaimkmoi.Location = new System.Drawing.Point(49, 276);
            this.tbtnhaplaimkmoi.Name = "tbtnhaplaimkmoi";
            this.tbtnhaplaimkmoi.Size = new System.Drawing.Size(316, 27);
            this.tbtnhaplaimkmoi.TabIndex = 9;
            // 
            // SubFrm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 392);
            this.Controls.Add(this.tbtnhaplaimkmoi);
            this.Controls.Add(this.tbtmkmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtmxn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtemail);
            this.Controls.Add(this.label1);
            this.Name = "SubFrm_QuenMatKhau";
            this.Text = "SubFrm_QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbtemail;
        private Label label2;
        private TextBox tbtmxn;
        private Button button1;
        private Button btn_xacnhan;
        private Label label3;
        private Label label4;
        private TextBox tbtmkmoi;
        private TextBox tbtnhaplaimkmoi;
    }
}