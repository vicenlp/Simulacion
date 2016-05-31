using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    class Validacion
    {
        public void soloNumeros (KeyPressEventArgs e)
        {
            try
            {
                // condicion de ingresar solo datos numericos
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                //condicion que nos pèrmite utilizar blackspace
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Ingrese solo numeros!!", "Entrada incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
