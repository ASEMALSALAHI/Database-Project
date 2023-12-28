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
    public partial class Form2 : MaterialForm
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            int ispayd=1;

            double paidAmount =  Convert.ToInt32(ODENECEKTUTARI.Text) -Convert.ToInt32(indirimOrani.Text);
            odenen_miktartxtbx.Text =Convert.ToString(paidAmount);

            string insertCmd = "INSERT INTO payment  (totalAmount,discountRate,paidAmount,isPaid,CreditCardInfo_id) VALUES (@totalAmount,@discountRate,@paidAmount,@isPaid,@CreditCardInfo_id) ";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = insertCmd;
            cmd.Parameters.Add("@totalAmount", ODENECEKTUTARI.Text);
            cmd.Parameters.Add("@discountRate", indirimOrani.Text);
            cmd.Parameters.Add("@paidAmount", paidAmount);
            cmd.Parameters.Add("@isPaid", ispayd);
            cmd.Parameters.Add("@CreditCardInfo_id", textBox5.Text);
            
            cmd.ExecuteNonQuery();
            conn.Close();


            //MessageBox.Show("odeme tamamlandi");
            //MessageBox.Equals(OnKeyPressn(new Form3().Show(), this.Hide());)
            //n(new Form3().Show(), this.Hide());
            DialogResult result1 = MessageBox.Show("odeme tamamlandi","Başarlı", MessageBoxButtons.OK);
            //n(new Form3().Show(), this.Hide());
            //n(new Form3().Show(), this.Hide());
            if (result1 == DialogResult.OK)
            {

                new Form3().Show(); this.Hide();
            }
            else
            {
                //
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
