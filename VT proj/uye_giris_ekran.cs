using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace VT_proj
{

    public partial class uye_giris_ekran : MaterialForm
    {
        public int user_id;
        SqlConnection conn;
        public uye_giris_ekran()
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



        private void uye_giris_ekran_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=Reservation;Trusted_Connection=True";
            conn = new SqlConnection(connString);

        }

        private void emailTxt_Click(object sender, EventArgs e)
        {

        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreTxt_Click(object sender, EventArgs e)
        {

        }

        private void sifreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyegirisBttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cmdStr = @"SELECT password,idUser FROM Users WHERE email= '" + emailTxtBox.Text + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataReader reader = cmd.ExecuteReader();

           

            if (reader.Read())
            {
                string password = (string)reader[0];
                 user_id = (int)reader[1];
                if (sifreTxtBox.Text == password)
                {
                    Form3 form = new Form3();
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
       
            


} }

    

    

