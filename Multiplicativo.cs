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
    public partial class Multiplicativo : Form
    {
        public Multiplicativo()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_generar_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(textBox_semilla.Text);
            int m = int.Parse(textBox_m.Text);
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
                int x = (a * sem) % m;
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
    }
}
