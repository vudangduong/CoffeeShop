namespace PRL
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            btn_dangnhap = new Button();
            label2 = new Label();
            panel3 = new Panel();
            txtPassWord = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            txtUserName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(709, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.PapayaWhip;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_dangnhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(378, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 358);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(191, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 18);
            label1.Name = "label1";
            label1.Size = new Size(199, 36);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập";
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangnhap.Location = new Point(86, 276);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(131, 45);
            btn_dangnhap.TabIndex = 2;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 54);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 2;
            label2.Text = "___________________________________";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassWord);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(11, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 76);
            panel3.TabIndex = 5;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(3, 42);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(283, 27);
            txtPassWord.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtUserName);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(11, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(292, 73);
            panel4.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(3, 42);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(283, 27);
            txtUserName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 441);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private TextBox txtUserName;
        private Label label3;
        private Button btn_dangnhap;
        private Panel panel3;
        private TextBox txtPassWord;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
