using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Gabriel_Luis_2003_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int y = int.Parse(Console.ReadLine());
            int soma = x + y;
            Console.WriteLine("O resultado é" + " " + soma);
            Console.ReadKey();

            Console.WriteLine("Digite o valor que deseja");
            int number = int.Parse(Console.ReadLine());
            double radiciacao = Math.Sqrt(number);
            Console.WriteLine("O resultado é" + " " + radiciacao);
            Console.ReadKey();

            Console.Write("Digite o primeiro valor");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            int b = int.Parse(Console.ReadLine());
            double potenciacao = Math.Pow(a, b);
            Console.WriteLine("O resultado é" + " " + potenciacao);
            Console.ReadKey();
            Console.Clear();



            //Ass: Gabriel da Silva Santos
        }
    }
}
