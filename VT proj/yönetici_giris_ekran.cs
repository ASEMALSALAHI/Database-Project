using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VT_proj
{
    public partial class yönetici_giris_ekran : MaterialForm
    {
        SqlConnection conn;
        public yönetici_giris_ekran()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManger = MaterialSkinManager.Instance;
            materialSkinManger.AddFormToManage(this);
            materialSkinManger.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManger.ColorScheme = new ColorScheme
                (
                                 Primary.Blue600, Primary.Blue800,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void yönetici_giris_ekran_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=Reservation;Trusted_Connection=True";
            conn = new SqlConnection(connString);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cmdStr = @"SELECT password FROM Users WHERE email= '" + yoneticiemailTxtBox.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string password = (string)reader[0];
                if (yoneticisifreTxtBox.Text == password)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış!!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı! Lütfen kayıt olun!");
            }
            conn.Close();
        }
    }
}
