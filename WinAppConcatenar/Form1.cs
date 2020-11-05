using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppConcatenar
{
    public partial class Form1 : Form
    {
        private TextBox[] textboxs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCadena1.Focus();
        }

        private void buttonConcatenar_Click(object sender, EventArgs e)
        {
            textboxs = new TextBox[] { textBoxCadena1, textBoxCadena2, textBoxCadena3};
            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));


            if (datosCorrectos)
            {
                String cadena = textBoxCadena1.Text + textBoxCadena2.Text + textBoxCadena3.Text;
                MessageBox.Show("La cadena concatenada es: "+cadena,"Cadena concatenada", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxCadena1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxCadena2.Focus();
            }
            Validar.validarletras(e);
        }

        private void textBoxCadena2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxCadena3.Focus();
            }
            Validar.validarletras(e);
        }

        private void textBoxCadena3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonConcatenar.Focus();
            }
            Validar.validarletras(e);
        }
    }
}
