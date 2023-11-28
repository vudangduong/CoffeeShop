namespace PRL.Sub_views
{
    partial class SubFrm_DoiMK
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbttaikhoan = new System.Windows.Forms.TextBox();
            this.tbtmkmoi = new System.Windows.Forms.TextBox();
            this.btnxacnhandoimk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // tbttaikhoan
            // 
            this.tbttaikhoan.Location = new System.Drawing.Point(78, 41);
            this.tbttaikhoan.Name = "tbttaikhoan";
            this.tbttaikhoan.Size = new System.Drawing.Size(365, 27);
            this.tbttaikhoan.TabIndex = 3;
            // 
            // tbtmkmoi
            // 
            this.tbtmkmoi.Location = new System.Drawing.Point(78, 104);
            this.tbtmkmoi.Name = "tbtmkmoi";
            this.tbtmkmoi.Size = new System.Drawing.Size(365, 27);
            this.tbtmkmoi.TabIndex = 4;
            // 
            // btnxacnhandoimk
            // 
            this.btnxacnhandoimk.Location = new System.Drawing.Point(168, 156);
            this.btnxacnhandoimk.Name = "btnxacnhandoimk";
            this.btnxacnhandoimk.Size = new System.Drawing.Size(180, 29);
            this.btnxacnhandoimk.TabIndex = 5;
            this.btnxacnhandoimk.Text = "Đổi mật khẩu";
            this.btnxacnhandoimk.UseVisualStyleBackColor = true;
            this.btnxacnhandoimk.Click += new System.EventHandler(this.btnxacnhandoimk_Click);
            // 
            // SubFrm_DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 222);
            this.Controls.Add(this.btnxacnhandoimk);
            this.Controls.Add(this.tbtmkmoi);
            this.Controls.Add(this.tbttaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubFrm_DoiMK";
            this.Text = "SubFrm_DoiMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbttaikhoan;
        private TextBox tbtmkmoi;
        private Button btnxacnhandoimk;
    }
}