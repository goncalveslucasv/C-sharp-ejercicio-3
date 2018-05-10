using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3ByMe
{
    public partial class frmConfiguracion : Form
    {
        ////Cafeteria Cafeteria;
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void frmConfiguracion_Shown(object sender, EventArgs e)
        {
           Cafeteria Cafeteria = ((Form1)this.MdiParent).Cafeteria;
            comboBox1.Items.Add(Cafeteria.CafeArabigo);
            comboBox1.Items.Add(Cafeteria.CafeRobusto);

            comboBox1.DisplayMember = "NombreCafe";


           


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cafeteria Cafeteria = ((Form1)this.MdiParent).Cafeteria;

            Cafeteria.CrearMaquinaCafe(textBox1.Text, float.Parse(textBox2.Text), (Cafe)comboBox1.SelectedItem);

        }

    }
}
