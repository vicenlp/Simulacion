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

        public Fibonacci()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_generar_Click(object sender, EventArgs e)
        {
            int a;
            int v1;
            int v2;
            int n;

            a = Convert.ToInt16(textBox_ingreseA.Text);
            v1 = Convert.ToInt16(textBox_ingreseV1.Text);
            v2 = Convert.ToInt16(textBox_ingreseV2.Text);
            n = Convert.ToInt32(numericUpDown1.Value);

            String salida = "N\tNumero generado\r\n";

            salida += (1 + "\t" + v1 + "\r\n");
            salida += (2 + "\t" + v2 + "\r\n");
            for (int i = 3; i <= n; i++)
            {
                if (v1 + v2 <= a)
                {
                    int k = -1;
                    int v3 = v1 + v2 + (k * a);
                    v1 = v2;
                    v2 = v3;
                    salida += (i + "\t" + v2 + "\r\n");
                    // hacer 2 salidas
                }
                else
                {
                    int k = 0;
                    int v3 = v1 + v2 + (k * a);
                    v1 = v2;
                    v2 = v3;
                    salida += (i + "\t" + v2 + "\r\n");
                }
            }
            textBox_resultado.Text = salida;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
