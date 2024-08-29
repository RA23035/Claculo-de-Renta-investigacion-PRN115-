using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renta_Mensual_Tarea_Ctrl.de_Versiones
{
    public partial class Form1 : Form
    {
        //Prueba1
        //Prueba02
        //Prueba03
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldo.Clear();
            
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            Double Sueldo, Renta=0.00;
           int seleccion = cbxPeriodo.SelectedIndex;

            switch (seleccion)
            {
                case 0:
                    Sueldo = Int32.Parse(txtSueldo.Text);
                    if (Sueldo >= 2058.68)
                    {
                        Renta = (Sueldo - 2058.67) * 0.3 + 288.57;
                        MessageBox.Show(Renta.ToString(),Nombre);
                    }
                    else if (Sueldo >= 487.61 && Sueldo <= 642.85)
                    {
                        Renta = (Sueldo - 487.60) * 0.1 + 17.48;
                        MessageBox.Show(Renta.ToString(), Nombre);
                    }
                    else if (Sueldo >= 642.86 && Sueldo <= 915.81)
                    {
                        Renta = (Sueldo - 642.85) * 0.1 + 32.70;
                        MessageBox.Show(Renta.ToString(), Nombre);
                    }
                    else if (Sueldo >= 915.82 && Sueldo <= 2058.68)
                    {
                        Renta = (Sueldo - 915.81) * 0.2 + 60.00;
                        MessageBox.Show(Renta.ToString(), Nombre);
                    }
                    else
                    {
                        Renta = 0.00;
                        MessageBox.Show(Nombre + Renta.ToString());
                    }
                    break;
                case 1:
                    MessageBox.Show("Esta tabla solo calcula Sueldos pagaderos Mensualmente");
                    break;
                case 2:
                    MessageBox.Show("Esta tabla solo calcula Sueldos pagaderos Mensualmente");
                    break;            
                default:
                    MessageBox.Show("Por favor Click en boton borrar y Seleccione el Periodo de Pago");
                    break;

            }

        }
    }
}
