using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO1WINDOWSFORM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Datos Guardados");
            
        }
        private int ObtenerDescuentoSeleccionado()
        {
            // Determinar el descuento seleccionado basado en los RadioButtons
            if (rad0.Checked) return 0;
            if (rad1.Checked) return 1;
            if (rad5.Checked) return 5;
            if (rad10.Checked) return 10;
            if (rad15.Checked) return 15;
            return 0;
        }
 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer valores de entrada
                int precio = int.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                // Calcular el subtotal
                int subtotal = precio * cantidad;

                // Obtener el descuento en porcentaje
                int porcentajeDescuento = ObtenerDescuentoSeleccionado();
                decimal descuento = subtotal * porcentajeDescuento / 100;

                // Calcular el IVA (15% sobre el subtotal)
                decimal iva = subtotal * 0.15m;

                // Calcular el total
                decimal total = subtotal - descuento + iva;

                // Mostrar resultados en los TextBox correspondientes
                txtSubtotal.Text = subtotal.ToString("F2");
                txtDescuento.Text = descuento.ToString("F2");
                txtIVA.Text = iva.ToString("F2");
                txtTotal.Text = total.ToString("F2");
            }
            catch 
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos de precio y cantidad.");
            }

        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtIVA.Clear();
            txtTotal.Clear();

            // Reiniciar la selección de RadioButton al 0%
            rad0.Checked = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            MessageBox.Show("Manuel Jiron"+ fecha);
            this.Close();
        }
    }
}
