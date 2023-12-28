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
    public partial class oda_otel_ekran : MaterialForm
    {
        SqlConnection conn;
        private object hotelName;
        public oda_otel_ekran()
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

        private void oda_otel_ekran_Load(object sender, EventArgs e)
        {
            this.hotelTableAdapter.Fill(this.reservationDataSet3.Hotel);
            this.user_has_RoomTableAdapter.Fill(this.reservationDataSet2.User_has_Room);
            this.reservationTableAdapter.Fill(this.reservationDataSet.Reservation);
            string connString = "Server=localhost;Database=Reservation;Trusted_Connection=True";
            conn = new SqlConnection(connString);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Hotel WHERE hotelName = '" + otelAdtxtBox.Text + "' ",conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool isAdd = reader.Read();
            cmd.Dispose();
            reader.Close();
            if (!isAdd)
            {
                string insertCmd = "INSERT INTO Hotel (hotelName,hotelDescription,star,roomCount) VALUES (@hotelName,@hotelDescription,@star,@roomCount) ";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = insertCmd;
                cmd.Parameters.Add("@hotelName", SqlDbType.VarChar);
                cmd.Parameters["@hotelName"].Value = otelAdtxtBox.Text;
                cmd.Parameters.Add("@hotelDescription", SqlDbType.VarChar);
                cmd.Parameters["@hotelDescription"].Value = aciklamatxtBox.Text;
                cmd.Parameters.Add("@star", SqlDbType.TinyInt);
                cmd.Parameters["@star"].Value = yildiztxtBox.Text;
                cmd.Parameters.Add("@roomCount", SqlDbType.SmallInt);
                cmd.Parameters["@roomCount"].Value = odaSayisiTxtBox.Text;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT * FROM Hotel WHERE hotelName = '" + otelAdtxtBox.Text + "' ", conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                if (reader2.Read())
                {
                    int hotelId = (int)reader2[0];
                    reader2.Close();
                    for (int i = 1; i <= Convert.ToInt32(odaSayisiTxtBox.Text); i++)
                    {
                        insertCmd = "INSERT INTO Room (roomNo,Hotel_id,fee) VALUES (@roomNo,@Hotel_id,@fee)";
                        cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = insertCmd;
                        cmd.Parameters.Add("@roomNo", SqlDbType.SmallInt);
                        cmd.Parameters["@roomNo"].Value = i;
                        cmd.Parameters.Add("@Hotel_id", SqlDbType.Int);
                        cmd.Parameters["@Hotel_id"].Value = hotelId;
                        cmd.Parameters.Add("@fee", SqlDbType.Decimal);
                        cmd.Parameters["@fee"].Value = tabanfiyattxtbox.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu otel zaten kayıtlı.");
            }
            conn.Close();
            cmd.Dispose();
            reader.Close();
            
        }
        private void FillGrid()
        {
            List<int> idList = new List<int>();
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id FROM Room WHERE Hotel_id= (SELECT id FROM Hotel WHERE hotelName = '" + hotelName + "' )",conn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                idList.Add((int)reader2["id"]);
            }
            reader2.Close();
            DataView dv = this.reservationDataSet2.User_has_Room.DefaultView;
            dv.RowFilter = "Room_id IN (" + string.Join(",", idList) + ")";
            dataGridView1.DataSource = dv;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                hotelName = comboBox1.SelectedValue;
                FillGrid();
            }
        }
    }
}
