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
    public partial class Mixto : Form
    {
        public Mixto()
        {
            InitializeComponent();
            panel1.Visible = false;

        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            int x0 = int.Parse(textBox_semilla.Text);
            int m = int.Parse(textBox_m.Text);
            int c = int.Parse(textBox_c.Text);
            int a = int.Parse(textBox_a.Text);
            int n = int.Parse(textBox_n.Text);

            String salida;
            int sem;
            sem = x0;
            //int salida;

            salida = Convert.ToString(sem);
            //listBox_resultado.Items.Add("x" + cont + ":        " + Convert.ToString(x0));

            int incrementoI;
            for (int i = x0.ToString().Length; i <= n; i += incrementoI)
            {
                int x = (a * sem + c) % m;
                sem = x;
                salida += sem.ToString();
                incrementoI = sem.ToString().Length;

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

        private void checkBox_intervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_intervalo.Checked == true)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void panel1_Validated(object sender, EventArgs e)
        {
            
        }

        private void panel1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            textBox_a.Clear();
            textBox_c.Clear();
            textBox_m.Clear();
            textBox_semilla.Clear();
            listBox_resultado.Items.Clear();
            textBox_resultado.Clear();
            textBox_n.Clear();
        }

        private void textBox_m_Validated(object sender, EventArgs e)
        {
    
            if (textBox_m.Text.Trim() == "" || int.Parse(textBox_m.Text) == 0)
            {
                errorProvider1.SetError(textBox_m, "ingrese un numero mayor a 0");
                textBox_m.Focus();
            }
            else if ((int.Parse(textBox_m.Text) < int.Parse(textBox_semilla.Text)) ||
                    (int.Parse(textBox_m.Text) < int.Parse(textBox_a.Text)) ||
                    (int.Parse(textBox_m.Text) < int.Parse(textBox_c.Text)))
            {
                errorProvider1.SetError(textBox_m, "El modulo debe ser mayor a la semilla, a y c");
                textBox_m.Focus();
            }
            //else if ((int.Parse(textBox_m.Text) % 2) == 0 )
            //{
            //    errorProvider1.SetError(textBox_m, "ingrese un numero Impar");
            //    textBox_m.Focus();
            //}
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox_a_Validated(object sender, EventArgs e)
        {
            //if (((int.Parse(textBox_a.Text) % 2) == 0) || ((int.Parse(textBox_a.Text) % 3) == 0) || ((int.Parse(textBox_a.Text) % 5) == 0))
            //{
            //    errorProvider1.SetError(textBox_a, "ingrese un numero Impar que no sea divisible por 3 ni por 5");
            //    textBox_a.Focus();
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }
    }
}
