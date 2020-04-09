using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calculadora
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void Labnumero2_Click(object sender, EventArgs e)
        {

        }

        private void Butdividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 / num2;
            textResultado.Text = resultado.ToString();
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {

        }

        private void Btnsoma_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis do tipo do double, num1, num2, resultado. 
            double num1, num2, resultado;
            /*num 1 e num 2 recebe conteúdo do textbox 
             * (txtNum1.text e textNum2.text)
             * covert.todouble é necessário para que seja convertido o conteúdo do textbox para número*/
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            //varável resultado =  recebe conteúdo de num1 + num2 e realiza o cálculo.
            resultado = num1 + num2;
            //txtResultado.text  = receber conteúdo da variável resultado e converte para número.
            textResultado.Text = resultado.ToString();


        }

        private void Btnmultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 * num2;
            textResultado.Text = resultado.ToString();
        }

        private void Btnsubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 - num2;
            textResultado.Text = resultado.ToString();
        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResultado.Text = "";
            /*o codigo inserido significa que o conteúdo do textbox (txtNum1.text), (txtNum2.text), (txtResultado.text)
             *deve ser limpo por meio do vazio (""), ao clicamos no limpar*/ 
        }

        private void Textnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
