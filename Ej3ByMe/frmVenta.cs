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
    public partial class frmVenta : Form
    {
        MaquinaCafe MaquinaCafe;
        VasoCafe VasoCafe;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Shown(object sender, EventArgs e)
        {
            Cafeteria Cafeteria = ((Form1)this.MdiParent).Cafeteria;

            foreach (var maquinaCafe in Cafeteria.maquinaCafe)
                listBox1.Items.Add(maquinaCafe);

            listBox1.DisplayMember = "Nombre";

            comboBox1.Items.Add(Cafeteria.VasoChico);
            comboBox1.Items.Add(Cafeteria.VasoMediano);
            comboBox1.Items.Add(Cafeteria.VasoGrande);

            comboBox1.DisplayMember = "Nombre";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaquinaCafe = (MaquinaCafe)listBox1.SelectedItem;
            label1.Text = "Nombre: " + MaquinaCafe.Nombre;
            label2.Text = "Cafe: " + MaquinaCafe.Cafe.NombreCafe;
            label3.Text = "Capacidad: " + MaquinaCafe.Capacidad + " Litros";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cafeteria Cafeteria = ((Form1)this.MdiParent).Cafeteria;

            MaquinaCafe = (MaquinaCafe)listBox1.SelectedItem;
            VasoCafe = (VasoCafe)comboBox1.SelectedItem;

            bool venta = Cafeteria.GenerarVenta(MaquinaCafe, VasoCafe);

            if (venta)
                MessageBox.Show("Venta exitosa");
            else
                MessageBox.Show("Recargue la cafetera");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaquinaCafe = (MaquinaCafe)listBox1.SelectedItem;
            MaquinaCafe.Recargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cafeteria Cafeteria = ((Form1)this.MdiParent).Cafeteria;

            label6.Text = "1)" + Cafeteria.RecaudacionTotal;
            label7.Text = "2)" + ((MaquinaCafe)listBox1.SelectedItem).DineroRecaudado;
            label8.Text = "3)" + Cafeteria.MaquinaMasSirvio().Nombre;
            label9.Text = "4)" + Cafeteria.MaquinaMenosSirvio().Nombre;
            label10.Text = "5)" + Cafeteria.MaquinaMasVendio().Nombre;
            label11.Text = "6)" + Cafeteria.MaquinaMenosVendio().Nombre;
            label12.Text = "7)" + Cafeteria.CafeMasServido().NombreCafe;
            label13.Text = "8)" + Cafeteria.CafeMenosServido().NombreCafe;
            label14.Text = "9)" + Cafeteria.CafeMasVendido().NombreCafe;
            label15.Text = "10)" + Cafeteria.CafeMenosVendido().NombreCafe;
            label16.Text = "11)" + Cafeteria.porcentajeCafe(((MaquinaCafe)listBox1.SelectedItem).Cafe);
            label17.Text = "12)" + Cafeteria.porcentajeMaquina((MaquinaCafe)listBox1.SelectedItem);
            label18.Text = "13)" + Cafeteria.maquinaMasRecargada().Nombre;


        }
    }
}
