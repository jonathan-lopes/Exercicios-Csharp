using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Amazenamentos_de_vareaveis
{
    public partial class Formteste : Form
    {
        public Formteste()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado!!");

            string nome;
            nome = "Seja Bem Vindo!";
            //a varriavel foi declarda
            textnome.Text = nome;
            //textnome esta recebendo a variavel nome
        }
    }
}
