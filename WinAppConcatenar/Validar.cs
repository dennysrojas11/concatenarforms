using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppConcatenar
{
    class Validar
    {
        public static void validarletras(KeyPressEventArgs n)
        {
            int codigo = Convert.ToInt32(n.KeyChar);
            if (codigo == 08)
            {
                n.Handled = false;
            }
            else if (Char.IsLetter(n.KeyChar))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
            }
        }
    }
}
