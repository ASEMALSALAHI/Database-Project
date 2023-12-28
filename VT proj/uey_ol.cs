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
    public partial class uey_ol : MaterialForm
    {
        SqlConnection conn;
        public uey_ol()
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

        private void uey_ol_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=Reservation;Trusted_Connection=True";
            conn = new SqlConnection(connString);
        }

        private void uyeol_butt_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id FROM Users WHERE email = '" + emailTxtBox.Text + "' ",conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isAdd = reader.Read();
            if (!isAdd)
            {
                string insertCmd = "INSERT INTO Users (firstName,lastName,email,phoneNumber,password,UserRole_id) VALUES (@firstName,@lastName,@email,@phoneNumber,@password,@role) ";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = insertCmd;
                cmd.Parameters.Add("@firstName", SqlDbType.VarChar);
                cmd.Parameters["@firstName"].Value = adTxtBox.Text;
                cmd.Parameters.Add("@lastName", SqlDbType.VarChar);
                cmd.Parameters["@lastName"].Value = soyadTxtBox.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = emailTxtBox.Text;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters["@phoneNumber"].Value = telefonTxtBox.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = sifreTxtBox.Text;
                cmd.Parameters.Add("@role", SqlDbType.Int);
                cmd.Parameters["@role"].Value = 1;
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bu email adresi zaten kayıtlı. Lütfen giriş yapın!");
            }
            conn.Close();

        }
    }
}
