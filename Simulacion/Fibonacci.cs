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
    public partial class Fibonacci : Form
    {
        private object txtvalprest;

        Validacion v = new Validacion();
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox_ingreseA.Text);
            int v1 = Convert.ToInt32(textBox_ingreseV1.Text);
            int v2 = Convert.ToInt32(textBox_ingreseV2.Text);
            int n = Convert.ToInt32(numericUpDown1.Value);


            //salida += (1 + "\t" + v1 + "\r\n");
            //salida += (2 + "\t" + v2 + "\r\n");
            int inicial = (v1.ToString().Length + v2.ToString().Length);
            int cadena = (v1.ToString().Length + v2.ToString().Length);
            String salida = (v1.ToString()+v2.ToString());
            int incrementoI;
            for (int i = inicial; i <= n; i += incrementoI)
            {
                if (v1 + v2 <= a)
                {
                    int k = -1;
                    int v3 = v1 + v2 + (k * a);
                    v1 = v2;
                    v2 = v3;
                    //int cadena2 = cadena;
                    incrementoI = (v2.ToString().Length);
                    //Math.Abs(v2) devuelve valor absoluto
                    cadena += v2.ToString().Length;
                    salida += Math.Abs(v2).ToString();
                    //salida += (i + "\t" + v2 + "\r\n");
                    // hacer 2 salidas
                }
                else
                {
                    int k = 0;
                    int v3 = v1 + v2 + (k * a);
                    v1 = v2;
                    v2 = v3;
                    incrementoI = v2.ToString().Length;
                    cadena += v2.ToString().Length;
                    salida += v2.ToString();
                    //salida += (i + "\t" + v2 + "\r\n");
                }
            }

            if (salida.Length > n)
            {
                String salidaMod = salida.Substring(0, n);
                textBox_resultado.Text = salidaMod;
            }
            else
            {
                textBox_resultado.Text = salida;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // no acceder directamente a N sin ingresar v1 y v2 primero
            ////if (textBox_ingreseV1.Text == " " & textBox_ingreseV2.Text == " ")
            ////{
            ////    numericUpDown1.Visible = false;
            ////}
            int v1 = Convert.ToInt32(textBox_ingreseV1.Text);
            int v2 = Convert.ToInt32(textBox_ingreseV2.Text);
            int inicial = v1.ToString().Length + v2.ToString().Length;
            numericUpDown1.Minimum = inicial;
        }

        private void textBox_ingreseA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_ingreseA_Validated(object sender, EventArgs e)
        {
            if (textBox_ingreseA.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox_ingreseA, "ingrese un numero");
                textBox_ingreseA.Focus();
            }
            else if (textBox_ingreseA.Text.Length > 8)
            {
                errorProvider1.SetError(textBox_ingreseA, "ingrese un numero menor de 9 cifras");
                textBox_ingreseA.Focus();
            }
            else if (Convert.ToInt32(textBox_ingreseA.Text) == 0)
            {
                errorProvider1.SetError(textBox_ingreseA, "ingrese un numero mayor que 0");
                textBox_ingreseA.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox_ingreseV1_Validated(object sender, EventArgs e)
        {
            if (textBox_ingreseV1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox_ingreseV1, "ingrese un numero");
                textBox_ingreseV1.Focus();
            }
            else if (textBox_ingreseV1.Text.Length > 8)
            {
                errorProvider1.SetError(textBox_ingreseV1, "ingrese un numero menor de 9 cifras");
                textBox_ingreseV1.Focus();
            }
            else if (Convert.ToInt32(textBox_ingreseV1.Text) == 0)
            {
                errorProvider1.SetError(textBox_ingreseV1, "ingrese un numero mayor que 0");
                textBox_ingreseV1.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox_ingreseV2_Validated(object sender, EventArgs e)
        {
            if (textBox_ingreseV2.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox_ingreseV2, "ingrese un numero");
                textBox_ingreseV2.Focus();
            }
            else if (textBox_ingreseV2.Text.Length > 8)
            {
                errorProvider1.SetError(textBox_ingreseV2, "ingrese un numero menor de 9 cifras");
                textBox_ingreseV2.Focus();
            }
            else if (Convert.ToInt32(textBox_ingreseV2.Text) == 0)
            {
                errorProvider1.SetError(textBox_ingreseV2, "ingrese un numero mayor que 0");
                textBox_ingreseV2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_TabIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox_ingreseA_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
        private void textBox_ingreseV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
        private void textBox_ingreseV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void numericUpDown1_VisibleChanged(object sender, EventArgs e)
        {
    
        }
    }
}
