namespace PRL.Views
{
    partial class fBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanHang));
            panel1 = new Panel();
            btn_QuanLy = new Button();
            btn_khuvuc = new Button();
            btn_mangve = new Button();
            pn_MangVe = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            pn_MangVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_QuanLy);
            panel1.Controls.Add(btn_khuvuc);
            panel1.Controls.Add(btn_mangve);
            panel1.Location = new Point(1, 620);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 75);
            panel1.TabIndex = 0;
            // 
            // btn_QuanLy
            // 
            btn_QuanLy.BackColor = SystemColors.ButtonFace;
            btn_QuanLy.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QuanLy.Location = new Point(828, 3);
            btn_QuanLy.Name = "btn_QuanLy";
            btn_QuanLy.Size = new Size(419, 65);
            btn_QuanLy.TabIndex = 2;
            btn_QuanLy.Text = "Quản Lý";
            btn_QuanLy.UseVisualStyleBackColor = false;
            btn_QuanLy.Click += btn_QuanLy_Click;
            // 
            // btn_khuvuc
            // 
            btn_khuvuc.BackColor = SystemColors.ButtonHighlight;
            btn_khuvuc.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khuvuc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khuvuc.Location = new Point(415, 3);
            btn_khuvuc.Name = "btn_khuvuc";
            btn_khuvuc.Size = new Size(419, 65);
            btn_khuvuc.TabIndex = 1;
            btn_khuvuc.Text = "Khu Vực";
            btn_khuvuc.UseVisualStyleBackColor = false;
            btn_khuvuc.Click += btn_khuvuc_Click;
            // 
            // btn_mangve
            // 
            btn_mangve.BackColor = SystemColors.ButtonFace;
            btn_mangve.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_mangve.Location = new Point(0, 3);
            btn_mangve.Name = "btn_mangve";
            btn_mangve.Size = new Size(419, 65);
            btn_mangve.TabIndex = 0;
            btn_mangve.Text = "Bán Hàng";
            btn_mangve.UseVisualStyleBackColor = false;
            btn_mangve.Click += btn_mangve_Click;
            // 
            // pn_MangVe
            // 
            pn_MangVe.Controls.Add(pictureBox3);
            pn_MangVe.Location = new Point(1, 66);
            pn_MangVe.Name = "pn_MangVe";
            pn_MangVe.Size = new Size(1247, 551);
            pn_MangVe.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1170, 545);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brush Script MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(87, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 34);
            label1.TabIndex = 5;
            label1.Text = "Coffee Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(966, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1039, 36);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 8;
            label2.Text = "Xin chào: Hoàng Long";
            // 
            // fBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1249, 686);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pn_MangVe);
            Controls.Add(panel1);
            Name = "fBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fBanHang";
            panel1.ResumeLayout(false);
            pn_MangVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_QuanLy;
        private Button btn_khuvuc;
        private Button btn_mangve;
        private Panel pn_MangVe;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
    }
}