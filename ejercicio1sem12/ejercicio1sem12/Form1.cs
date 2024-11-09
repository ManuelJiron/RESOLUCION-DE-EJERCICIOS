using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1sem12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("saliendo del programa");
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cargo;
             cargo = txtcarg.Text.ToLower();
            if ( cargo == "gerente")
            {
                txtsueld.Text = "12,500";
            }
            if ( cargo == "administrador")
            {
                txtsueld.Text = "10,000";

            }
            if (cargo == "secretaria")
            {
                txtsueld.Text = "5,500";
            }
            if (cargo == "contador")
            {
                txtsueld.Text = "6,000";
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtsueld.Clear();
            txtname.Clear();
            txtcarg.Clear();    
            txtname.Focus();
        }
    }
}
