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
    public partial class kullanci_ekranlari : MaterialForm
    {
        public kullanci_ekranlari()
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

        private void kullanci_ekranlari_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new uey_ol().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new uye_giris_ekran().Show();
    
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new yönetici_giris_ekran().Show();
            this.Hide();
        }
    }
}
