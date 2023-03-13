using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuantidadeAgua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, total;

            Console.WriteLine("******************");
            Console.WriteLine("Quantidade de Água");
            Console.WriteLine("******************");
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Veremos a quantidade de água necessária para você tomar.");
            Thread.Sleep(2000);
            Console.WriteLine("Antes de tudo...");
            Console.WriteLine("Informe-nos o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            total = peso * 0.035;

            Console.WriteLine("A quantidade de água que você deve tomar por dia: " + total.ToString("F2") + "L" );
            Console.WriteLine("Digite qualquer tecla para encerrar...");
            Console.ReadKey();

        }
    }
}
