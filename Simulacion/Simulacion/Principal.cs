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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void vonNeumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Vonneuman vgenerador = new Vonneuman();
            vgenerador.MdiParent = this;
            vgenerador.Show();
        }

        private void fibonachiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Fibonacci fgenerador = new Fibonacci();
            fgenerador.MdiParent = this;
            fgenerador.Show();
        }

        private void otroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Congruencia ogenerador = new Congruencia();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa de Cristian Gimenez :) Contacto:cristiangimenez1869@gmail.com", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
