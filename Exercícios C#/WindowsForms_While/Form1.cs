using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numero = 1;
            while (numero <= 50)
            {
                listBox1.Items.Add(numero);
                numero++;

                /*Declaraçao da vareável numero do tipo inteiro, a veriável foi inicializada com número 1.
                 * "enquanto" o numero for menor ou igual a 5 o listbox sera preenchido 
                 * expressãp = numero + numero1 é o incremento*/

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
