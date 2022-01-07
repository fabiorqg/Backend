using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSimples Simples = new CalculadoraSimples();
            CalculadoraCientifica Cientifica = new CalculadoraCientifica();

            Console.WriteLine(Simples.Somar(1, 2));
            Console.WriteLine(Simples.Somar(1, 2, 3));
            Console.WriteLine(Simples.Subtrair(1, 2));
            Console.WriteLine(Simples.Multiplicar(1, 2));
            Console.WriteLine(Simples.Dividir(1, 2));
            Console.WriteLine(Simples.Multiplicar(1, 2, 4));
            Console.WriteLine(Simples.Multiplicar(1, 2, 3, 4));

            Console.WriteLine("\n\n");

            Console.WriteLine(Cientifica.Somar(1, 2));
            Console.WriteLine(Cientifica.Subtrair(1, 2));
            Console.WriteLine(Cientifica.Multiplicar(1, 2));
            Console.WriteLine(Cientifica.Dividir(1, 2));
            Console.WriteLine(Cientifica.RaizQuadrada(1));
            Console.WriteLine(Cientifica.ValorAbs(-10));
            Console.ReadKey();


        }
    }
}
