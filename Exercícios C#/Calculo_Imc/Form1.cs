using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Imc
{
    public partial class fomr1 : Form
    {
        public fomr1()
        {
            InitializeComponent();
        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            textBoxAltura.Text = "";
            textBoxImc.Text = "";
            textBoxpeso.Text = "";


        }

        private void Fomr1_Load(object sender, EventArgs e)
        {

        }

        private void LabPeso_Click(object sender, EventArgs e)
        {

        }

        private void Btnverificar_Click(object sender, EventArgs e)
        {
            /* Declaração de variáveis
             * variável receber conteúdo o textbox*/
            double peso, altura, imc;
            peso = Convert.ToDouble(textBoxpeso.Text);
            altura = Convert.ToDouble(textBoxAltura.Text);
            imc = peso / (altura * altura);
            /* textbox recebe conteúdo doa variável imc =
             * resultado do cálculo
             * definição da utilização de 2 casas decimais*/
            textBoxImc.Text = imc.ToString("0.00");
            /*condições de acordo com os resultados dos cálculos 
             * serão exibidas mensagens,
             * configuração das messegebox, (mensagens, botões, icones)
             * como são váriaveis condições temos um encadeamrnto de ifs*/

            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com peso dentro da normalidade", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                     MessageBox.Show("SITUÇÃO: Você está acima do peso", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("ATENÇÃO! Você esta com obesidade Grau I", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("ATENÇÃO Você está com obesidade Grau II", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO Você está com obesidade Grau III (Mórbida)", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);









        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
