using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            do
            {
                c = c + 1;
                label1.Text = Convert.ToString(c);
                label1.Refresh();
            }
            while (c < 10000);
            /*Sempre executa pois a condiçao so vai aparece no final, so é utiliazado quando é necessario testar
             * a condição depos*/






            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
