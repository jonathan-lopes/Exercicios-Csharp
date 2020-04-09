using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
                i = 1;
            numero = int.Parse(textBox1.Text);
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(string.Concat(numero, " * ", i, " = ", resultado));
                i = i + 1;
                /*Declaração das varaveis do tipo inteiro
                 * cconversão para int
                 * condição, enquanto o i for menor ou igual 10 
                 * variavel resultado realiza o calculo de i
                 * multiplicado pelo numero digitado.
                 * listbox adiciona o item e concatena com (número i * = resultado)
                 * incremento
                 * */
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            
            
            


        }
    }
}
