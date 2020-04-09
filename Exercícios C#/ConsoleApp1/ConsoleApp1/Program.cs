using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula 01

    class Program
    {
        static void Main(string[] args)
        {
            string nomepessoa;
            string sobrenomepessoa;

            Console.Write("Digite seu nome:");
           nomepessoa = Console.ReadLine();

            Console.Write("Digite seu sobrenome:");
            sobrenomepessoa = Console.ReadLine();

            Console.WriteLine("O nome escrito foi " + nomepessoa + " " + sobrenomepessoa);
            Console.ReadKey();
        }
    }
}
