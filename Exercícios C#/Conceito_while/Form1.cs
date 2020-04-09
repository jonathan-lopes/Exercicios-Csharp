using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 10000)

            {
                c = c + 1;
                label1.Text = Convert.ToString(c);
                label1.Refresh();
                /*Declaraçao da variavel c, inicializando com zero
                 * condição: enquanto o c for menor que 10000 será executado laço
                 * incremento
                 * Refresh é utilizado para que haja a veriaçao dos numeros.*/
            }
        }
    }
}
