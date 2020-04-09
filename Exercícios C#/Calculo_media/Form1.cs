using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(textNota1.Text);
            n2 = Convert.ToDouble(textNota2.Text);
            n3 = Convert.ToDouble(textNota3.Text);
            media = (n1 + n2 + n3) / 3;
            textMedia.Text = media.ToString();
            /* No código, estamos declarando as variáveis do tipo double: n1, n2, n3 e media.
             * nas linhas seguintes, as variáveis recebem o conteúdo dos textbox e são convertidos para double.
             * A variável média recebe a fórmula (n1+n2+n3)/3
             * textmedia recebe o conteudo da variável média que é o resultado do cáclculo*/

            if (media < 5)
                MessageBox.Show("Aluno foi reprovado!" , "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (media >= 7)
                MessageBox.Show("Aluno foi aprovado.", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Aluno em recuperação.", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

             

        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            textNota1.Text = "";
            textNota2.Text = "";
            textNota3.Text = "";
            textMedia.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
