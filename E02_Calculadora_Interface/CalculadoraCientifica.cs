using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{
    class CalculadoraCientifica : ICalculadora
    {

            public double Valor01 { get; set; }
            public double Valor02 { get; set; }
            public double Resultado { get; set; }

            public double Dividir(double v1, double v2)
            {
                Valor01 = v1;
                Valor02 = v2;
                Resultado = v1 / v2;
                return Resultado;
            }

            public double Multiplicar(double v1, double v2)
            {
                Valor01 = v1;
                Valor02 = v2;
                Resultado = v1 * v2;
                return Resultado;
            }

            public double Somar(double v1, double v2)
            {
                Valor01 = v1;
                Valor02 = v2;
                Resultado = v1 * v2;
                return Resultado;
            }

            public double Subtrair(double v1, double v2)
            {
                Valor01 = v1;
                Valor02 = v2;
                Resultado = v1 - v2;
                return Resultado;
            }

            public double RaizQuadrada(double v1)
            {
                Valor01 = v1;
                Resultado = Math.Sqrt(Valor01);
                return Resultado;
            }

            public double ValorAbs(double v1)
            {
            Valor01 = v1;
            Resultado = Math.Abs(Valor01);
            return Resultado;
            }

    }
}
