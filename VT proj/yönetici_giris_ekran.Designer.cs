
namespace VT_proj
{
    partial class yönetici_giris_ekran
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yoneticisifreTxtBox = new System.Windows.Forms.TextBox();
            this.yoneticiemailTxtBox = new System.Windows.Forms.TextBox();
            this.yoneticisifreTxt = new System.Windows.Forms.Label();
            this.yoneticimailTxtemailTxtemailTxt = new System.Windows.Forms.Label();
            this.yoneticigirisBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VT_proj.Properties.Resources.icons8_admin_settings_male_96;
            this.pictureBox1.Location = new System.Drawing.Point(57, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // yoneticisifreTxtBox
            // 
            this.yoneticisifreTxtBox.Location = new System.Drawing.Point(496, 233);
            this.yoneticisifreTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yoneticisifreTxtBox.Name = "yoneticisifreTxtBox";
            this.yoneticisifreTxtBox.Size = new System.Drawing.Size(191, 24);
            this.yoneticisifreTxtBox.TabIndex = 14;
            // 
            // yoneticiemailTxtBox
            // 
            this.yoneticiemailTxtBox.Location = new System.Drawing.Point(496, 185);
            this.yoneticiemailTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yoneticiemailTxtBox.Name = "yoneticiemailTxtBox";
            this.yoneticiemailTxtBox.Size = new System.Drawing.Size(191, 24);
            this.yoneticiemailTxtBox.TabIndex = 13;
            // 
            // yoneticisifreTxt
            // 
            this.yoneticisifreTxt.AutoSize = true;
            this.yoneticisifreTxt.Location = new System.Drawing.Point(413, 241);
            this.yoneticisifreTxt.Name = "yoneticisifreTxt";
            this.yoneticisifreTxt.Size = new System.Drawing.Size(39, 17);
            this.yoneticisifreTxt.TabIndex = 12;
            this.yoneticisifreTxt.Text = "Şifre:";
            // 
            // yoneticimailTxtemailTxtemailTxt
            // 
            this.yoneticimailTxtemailTxtemailTxt.AutoSize = true;
            this.yoneticimailTxtemailTxtemailTxt.Location = new System.Drawing.Point(413, 188);
            this.yoneticimailTxtemailTxtemailTxt.Name = "yoneticimailTxtemailTxtemailTxt";
            this.yoneticimailTxtemailTxtemailTxt.Size = new System.Drawing.Size(44, 17);
            this.yoneticimailTxtemailTxtemailTxt.TabIndex = 11;
            this.yoneticimailTxtemailTxtemailTxt.Text = "Email:";
            // 
            // yoneticigirisBttn
            // 
            this.yoneticigirisBttn.Location = new System.Drawing.Point(496, 293);
            this.yoneticigirisBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yoneticigirisBttn.Name = "yoneticigirisBttn";
            this.yoneticigirisBttn.Size = new System.Drawing.Size(192, 38);
            this.yoneticigirisBttn.TabIndex = 10;
            this.yoneticigirisBttn.Text = "GİRİŞ YAP";
            this.yoneticigirisBttn.UseVisualStyleBackColor = true;
            // 
            // yönetici_giris_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yoneticisifreTxtBox);
            this.Controls.Add(this.yoneticiemailTxtBox);
            this.Controls.Add(this.yoneticisifreTxt);
            this.Controls.Add(this.yoneticimailTxtemailTxtemailTxt);
            this.Controls.Add(this.yoneticigirisBttn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "yönetici_giris_ekran";
            this.Text = "yönetici_giris_ekran";
            this.Load += new System.EventHandler(this.yönetici_giris_ekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox yoneticisifreTxtBox;
        private System.Windows.Forms.TextBox yoneticiemailTxtBox;
        private System.Windows.Forms.Label yoneticisifreTxt;
        private System.Windows.Forms.Label yoneticimailTxtemailTxtemailTxt;
        private System.Windows.Forms.Button yoneticigirisBttn;
    }
}