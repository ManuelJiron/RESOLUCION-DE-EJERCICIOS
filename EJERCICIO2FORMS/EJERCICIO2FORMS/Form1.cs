using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO2FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int ObtenerBonificacionSeleccionada()
        {
            // Determinar el porcentaje de bonificación basado en los RadioButtons
            if (rad10.Checked) return 10;
            if (rad20.Checked) return 20;
            if (rad35.Checked) return 35;
            return 0; // Valor por defecto si no se selecciona nada
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rad10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer valores de entrada
                string nombreEmpleado = txtNombre.Text;
                decimal sueldoBasico = decimal.Parse(txtSueldo.Text);

                // Obtener el porcentaje de bonificación seleccionado
                int porcentajeBonificacion = ObtenerBonificacionSeleccionada();
                decimal bonificacion = sueldoBasico * porcentajeBonificacion / 100;

                // Calcular la retención si el salario es mayor o igual a 10000
                decimal retencion = sueldoBasico >= 10000 ? sueldoBasico * 0.05m : 0;

                // Calcular el total a recibir
                decimal total = sueldoBasico + bonificacion - retencion;

                // Mostrar los resultados
                txtBonificacion.Text = bonificacion.ToString("F2");
                txtRetencion.Text = retencion.ToString("F2");
                txtTotal.Text = total.ToString("F2");
            }
            catch 
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos de nombre y salario básico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldo.Clear();
            txtBonificacion.Clear();
            txtRetencion.Clear();
            txtTotal.Clear();

            // Reiniciar la selección de RadioButtons
            rad10.Checked = false;
            rad20.Checked = false;
            rad35.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar nombre y fecha en un MessageBox, luego cerrar la aplicación
            string Nombre = txtNombre.Text;  
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            MessageBox.Show($"{Nombre} {fecha}");
            this.Close();
        }

        private void txtBonificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRetencion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
