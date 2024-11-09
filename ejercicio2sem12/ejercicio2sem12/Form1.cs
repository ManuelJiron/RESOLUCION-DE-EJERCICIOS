using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2sem12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, numero, resultado;

            numero = int.Parse(txtnumero.Text);
            for (i = 0; i <= 10; i++)
            {

                resultado = numero * i;
                lstbtabla.Items.Add(numero + " * " + i + "=    " + resultado);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            lstbtabla.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("saliendo del programa");
            Close();
        }
    }
}
