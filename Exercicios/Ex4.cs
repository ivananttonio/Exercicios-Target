using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex4
    {
        public void Executar()
        {

            double faturamentoSP = 67836.43;
            double faturamentoRJ = 36678.66;
            double faturamentoMG = 29229.88;
            double faturamentoES = 27165.48;
            double faturamentoOutros = 19849.53;


            double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;


            Console.WriteLine("Percentual de representação por estado:");

            Console.WriteLine($"SP: {CalcularPercentual(faturamentoSP, faturamentoTotal):F2}%");
            Console.WriteLine($"RJ: {CalcularPercentual(faturamentoRJ, faturamentoTotal):F2}%");
            Console.WriteLine($"MG: {CalcularPercentual(faturamentoMG, faturamentoTotal):F2}%");
            Console.WriteLine($"ES: {CalcularPercentual(faturamentoES, faturamentoTotal):F2}%");
            Console.WriteLine($"Outros: {CalcularPercentual(faturamentoOutros, faturamentoTotal):F2}%");
            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();
            
        }

        static double CalcularPercentual(double valorEstado, double valorTotal)
        {
            return (valorEstado / valorTotal) * 100;


        }
    }
    }

