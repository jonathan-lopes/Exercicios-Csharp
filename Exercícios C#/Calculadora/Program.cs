using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double soma;
            string operacao;

            Console.Write("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação: ");
            operacao = (Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" ");

             soma = 0;

            switch (operacao)
            {
                case "+":
                    soma = numero1 + numero2;
                    break;

                case "-":
                    soma = numero1 - numero2;
                    break;

                case "*":
                    soma = numero1 * numero2;
                    break;

                case "/":
                    soma = numero1 / numero2;
                    break;

            }
            Console.Write(" ");

            Console.WriteLine("O resultado é:" + soma);

            Console.ReadKey();
        }
    }