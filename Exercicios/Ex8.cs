using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex8
    {
        public void Executar()
        {

            double[] faturamento = { 100, 200, 0, 0, 150, 0, 400, 250, 180, 0, 50, 500, 300, 0 };

            var faturamentoValido = faturamento.Where(f => f > 0).ToArray();

            double menorFaturamento = faturamentoValido.Min();
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");

            double maiorFaturamento = faturamentoValido.Max();
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");

            double mediaFaturamento = faturamentoValido.Average();
            Console.WriteLine($"Média de faturamento anual: {mediaFaturamento}");

            int diasAcimaDaMedia = faturamentoValido.Count(f => f > mediaFaturamento);
            Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaDaMedia}");

            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}

