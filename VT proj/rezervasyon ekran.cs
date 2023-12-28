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
    public partial class Form3 : MaterialForm
    {
        SqlConnection conn;
        SqlCommand cmd;
        uye_giris_ekran ugirek = new uye_giris_ekran();

        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reservationDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.reservationDataSet.Reservation);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        { string chekin= dateTimePicker1.Value.ToShortDateString();
          string chekout= dateTimePicker2.Value.ToShortDateString();
            int ReservationType_iid;
            int iscancel=0;

            if (comboBox1.Text== "Ön ödemeli rezervasyon")
            {
                ReservationType_iid = 1;
            }
            else if (comboBox1.Text == "60 gün önceden rezervasyon")
            {
                ReservationType_iid = 2;
            }
            else if (comboBox1.Text== "Standart rezervasyon")
            {
                ReservationType_iid = 3;
            }
            else
            {
                ReservationType_iid = 4;
            }
           

            conn.Open();

            string insertCmd = "INSERT INTO Reservation  (startDate,endDate,reservationDate,User_id,Hotel_id,ReservationType_id,isCancel) VALUES (@hstartDate,@endDate,@reservationDate,@User_id,@Hotel_id,@ReservationType_id,@isCancel) ";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertCmd;
            cmd.Parameters.Add("@startDate", chekin);
            cmd.Parameters.Add("@endDate",chekout);
            cmd.Parameters.Add("@reservationDate", DateTime.Now);
            cmd.Parameters.Add("@User_id", ugirek.user_id);
            cmd.Parameters.Add("@Hotel_id", SqlDbType.TinyInt);
            cmd.Parameters.Add("@ReservationType_id", ReservationType_iid);
            cmd.Parameters.Add("@isCancel", iscancel);
            cmd.ExecuteNonQuery();
            conn.Close();
            new Form2().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
