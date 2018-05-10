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
    public partial class Form1 : Form
    {
        public Cafeteria Cafeteria = new Cafeteria();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion frm = new frmConfiguracion();
            frm.MdiParent = this;

            frm.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
