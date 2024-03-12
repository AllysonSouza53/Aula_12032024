using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada

            Console.Write("Peso: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double a = double.Parse(Console.ReadLine());

            //Processamento e saída
            double imc = p/(a*a);

            Console.Write("imc: "+imc+". ");

            if (imc<=16.9) {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc <= 18.4)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("peso normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("obesidade grau 1");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("obesidade grau 2");
            }
            else
            {
                Console.WriteLine("obesidade grau 3");
            }
            Console.ReadKey();
        }
    }
}
