
namespace VT_proj
{
    partial class uye_giris_ekran
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
            this.sifreTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.Label();
            this.uyegirisBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifreTxtBox
            // 
            this.sifreTxtBox.Location = new System.Drawing.Point(521, 254);
            this.sifreTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTxtBox.Name = "sifreTxtBox";
            this.sifreTxtBox.Size = new System.Drawing.Size(191, 24);
            this.sifreTxtBox.TabIndex = 9;
            this.sifreTxtBox.TextChanged += new System.EventHandler(this.sifreTxtBox_TextChanged);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(521, 206);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(191, 24);
            this.emailTxtBox.TabIndex = 8;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // sifreTxt
            // 
            this.sifreTxt.AutoSize = true;
            this.sifreTxt.Location = new System.Drawing.Point(438, 262);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(39, 17);
            this.sifreTxt.TabIndex = 7;
            this.sifreTxt.Text = "Şifre:";
            this.sifreTxt.Click += new System.EventHandler(this.sifreTxt_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.AutoSize = true;
            this.emailTxt.Location = new System.Drawing.Point(438, 209);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(44, 17);
            this.emailTxt.TabIndex = 6;
            this.emailTxt.Text = "Email:";
            this.emailTxt.Click += new System.EventHandler(this.emailTxt_Click);
            // 
            // uyegirisBttn
            // 
            this.uyegirisBttn.Location = new System.Drawing.Point(521, 314);
            this.uyegirisBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyegirisBttn.Name = "uyegirisBttn";
            this.uyegirisBttn.Size = new System.Drawing.Size(192, 38);
            this.uyegirisBttn.TabIndex = 5;
            this.uyegirisBttn.Text = "GİRİŞ YAP";
            this.uyegirisBttn.UseVisualStyleBackColor = true;
            this.uyegirisBttn.Click += new System.EventHandler(this.uyegirisBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VT_proj.Properties.Resources.clipart47511671;
            this.pictureBox1.Location = new System.Drawing.Point(57, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // uye_giris_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifreTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.uyegirisBttn);
            this.Name = "uye_giris_ekran";
            this.Text = "uye_giris_ekran";
            this.Load += new System.EventHandler(this.uye_giris_ekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label sifreTxt;
        private System.Windows.Forms.Label emailTxt;
        private System.Windows.Forms.Button uyegirisBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}