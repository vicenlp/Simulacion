using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class Vonneuman : Form
    {
        Validacion v2 = new Validacion();
        public Vonneuman()
        {
            InitializeComponent();
            numericUpDown_n.Visible = false;
            //checkBox_intervalo.Checked = false;
            //panel_intervalo.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericUpDown_n.Visible = true;
            v2.soloNumeros(e);

        }

        private void textBox_semilla_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox_semilla_Validated(object sender, EventArgs e)
        {
            if (textBox_semilla.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox_semilla, "ingrese un numero");
                textBox_semilla.Focus();
            }
            else if (textBox_semilla.Text.Length != 4)
            {
                errorProvider1.SetError(textBox_semilla, "ingrese un numero de 4 cifras");
                textBox_semilla.Focus();
            }
            else if (Convert.ToInt32(textBox_semilla.Text) < 1000)
            {
                errorProvider1.SetError(textBox_semilla, "ingrese un numero mayor a 1000");
                textBox_semilla.Focus();
            }
            else
            {
                errorProvider1.Clear();
                //int inicial = Convert.ToInt32(textBox_semilla.Text.Length);
                //numericUpDown_n.Minimum = inicial;
            }
        }

        private void button_generar_Click(object sender, EventArgs e) // validar que cuando toma los cuatro valores del medio no sean todos ceros 0000
        {
            String semilla = textBox_semilla.Text;
            int n = Convert.ToInt32(numericUpDown_n.Value);
            int cuadrado;

            //int a = Convert.ToInt32(numericUpDown3);
            //int b = Convert.ToInt32(numericUpDown2);
            int semillaCantidad = semilla.Length;

            //if (semillaCantidad != 4 & checkBox_intervalo.Checked != true)
            //{
            //   MessageBox.Show("Debe ingresar una Semilla de 4 digitos", "Error de Semilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (semilla.Substring(1,semillaCantidad) == "0" & semilla.Substring(4, semillaCantidad) == "0")
            //{
            //    MessageBox.Show("El primer y ultimo digito deben ser distinto de 0", "Error de Semilla", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            String xn = null;
                for (int i = 0; i <= n; i = i + 4)
                {
                    cuadrado = Convert.ToInt32(semilla) * Convert.ToInt32(semilla);

                    if (cuadrado.ToString().Length < 8) 
                    {

                        int leFalta = 8 - cuadrado.ToString().Length;
                        String ceros = null;    

                        for (int j = 0 ; j < leFalta; j++) // hacer un for para agregar ceros
                        {
                            ceros += "0";
                        }
                        String cerosDelante =ceros+Convert.ToString(cuadrado);
                        String cadenaDelMedio = cerosDelante.Substring(2, 4);
                        xn += cadenaDelMedio;
                        semilla = cadenaDelMedio;


                    }
                    else
                    {
                        String cadenaDelMedio = cuadrado.ToString().Substring(2, 4);
                        xn += cadenaDelMedio;
                        semilla = cadenaDelMedio;
                    }
                }
                String salidaMod = null;
                if (xn.Length > n)
                {
                    salidaMod = xn.Substring(0, n);
                    textBox_resultado.Text = salidaMod;
                }
            //}
             //--------------------------------------------------------------------------------------------------------------------
            // -------------------------- INTERVALO (a,b) -------------------------------------------------------------------------
             //--------------------------------------------------------------------------------------------------------------------
             if (checkBox_intervalo.Checked == true)
             {
                int a = Convert.ToInt32(numericUpDown2.Value);
                int b = Convert.ToInt32(numericUpDown3.Value);

                String cadenaIntervalo = null;
                //int cont = 0;
                int longitudResultado = salidaMod.Length;
                //int x = 1;
                ;

                foreach (var numeroCadena in salidaMod.ToCharArray())
                {
                    int obtengoNumero = Int32.Parse(numeroCadena.ToString());
                    int operacionIntervalo = (obtengoNumero * (b - a) + a);
                    cadenaIntervalo += operacionIntervalo;
                }

                //for (int i = 0; i < longitudResultado; i++)
                //{
                //    int obtengoNumero = Convert.ToInt32(salidaMod.Substring(0,i));
                //    int operacionIntervalo = (obtengoNumero * (b - a) + a);
                //    cadenaIntervalo += operacionIntervalo;
                //    //x++;
                //}
                textBox_resultado.Text = cadenaIntervalo;
             }
          }

        private void checkBox_intervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_intervalo.Checked == true)
            {
                panel_intervalo.Visible = true;
            }
            else
            {
                panel_intervalo.Visible = false;
            }
                
        }

        private void Vonneuman_Load(object sender, EventArgs e)
        {

        }
    }
}