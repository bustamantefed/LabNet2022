using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_POO
{
    public partial class Form1 : Form
    {

        ArrayList pasajerosTaxi = new ArrayList();
        ArrayList pasajerosOmnibus = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarPasajeros_Click(object sender, EventArgs e)
        {
            

            try
            {
               
                verificaCamposvacios();

                Omnibus omnibus1 = new Omnibus() ; 
                Omnibus omnibus2 = new Omnibus();
                Omnibus omnibus3 = new Omnibus();
                Omnibus omnibus4 = new Omnibus();
                Omnibus omnibus5 = new Omnibus();
                omnibus1.pasajeros = Convert.ToInt32(cboxOmnibus1.Text);
                omnibus2.pasajeros = Convert.ToInt32(cboxOmnibus2.Text);
                omnibus3.pasajeros = Convert.ToInt32(cboxOmnibus3.Text);
                omnibus4.pasajeros = Convert.ToInt32(cboxOmnibus4.Text);
                omnibus5.pasajeros = Convert.ToInt32(cboxOmnibus5.Text);
                pasajerosOmnibus.Add(omnibus1);
                pasajerosOmnibus.Add(omnibus2);
                pasajerosOmnibus.Add(omnibus3);
                pasajerosOmnibus.Add(omnibus4);
                pasajerosOmnibus.Add(omnibus5);


                taxi taxi1 = new taxi();
                taxi taxi2 = new taxi();
                taxi taxi3 = new taxi();
                taxi taxi4 = new taxi();
                taxi taxi5 = new taxi();               
                taxi1.pasajeros = Convert.ToInt32(cboxTaxi1.Text);
                taxi2.pasajeros = Convert.ToInt32(cboxTaxi2.Text);
                taxi3.pasajeros = Convert.ToInt32(cboxTaxi3.Text);
                taxi4.pasajeros = Convert.ToInt32(cboxTaxi4.Text);
                taxi5.pasajeros = Convert.ToInt32(cboxTaxi5.Text);
                pasajerosTaxi.Add(taxi1);
                pasajerosTaxi.Add(taxi2);
                pasajerosTaxi.Add(taxi3);
                pasajerosTaxi.Add(taxi4);
                pasajerosTaxi.Add(taxi5);

                dataGridPasajerosTaxi.DataSource = null;
                dataGridViewOmnibus.DataSource = null;
                dataGridViewOmnibus.DataSource = pasajerosOmnibus;
                dataGridPasajerosTaxi.DataSource = pasajerosTaxi;
            }
            catch (Exception )
            {
                MessageBox.Show("Intente de nuevo, sucedio un error al ingresar los datos, algún campo vacio. ");
                return;
            }
        }

        private void verificaCamposvacios() 
        {

            if (cboxTaxi1.Text == string.Empty || cboxTaxi2.Text == string.Empty || cboxTaxi3.Text == string.Empty || cboxTaxi4.Text == string.Empty || cboxTaxi5.Text == string.Empty)
            {
                MessageBox.Show("Los pasajeros de los taxis minimo tienen que ser 1.");
                return;
            }

            if (cboxOmnibus1.Text == string.Empty || cboxOmnibus2.Text == string.Empty || cboxOmnibus3.Text == string.Empty || cboxOmnibus4.Text == string.Empty || cboxOmnibus5.Text == string.Empty)
            {
                MessageBox.Show("Los pasajeros de los omnibus minimo tienen que ser 1.");
                return;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
