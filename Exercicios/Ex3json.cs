using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace Exercicios
{
    public class Ex3json
    {
        public class FaturamentoDiario
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }
        public void Executar()
        {

            string json = File.ReadAllText("C:\\Users\\ivan_\\OneDrive\\Área de Trabalho\\Processo seletivos\\Target\\Exercicios\\dados.json");
            List<FaturamentoDiario> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

            double menorFaturamento = double.MaxValue;
            double maiorFaturamento = double.MinValue;
            double somaFaturamento = 0;
            int diasComFaturamento = 0;

            foreach (var dia in faturamento)
            {
                if (dia.valor > 0)
                {

                    if (dia.valor < menorFaturamento)
                        menorFaturamento = dia.valor;

                    if (dia.valor > maiorFaturamento)
                        maiorFaturamento = dia.valor;

                    somaFaturamento += dia.valor;
                    diasComFaturamento++;
                }
            }


            double mediaMensal = somaFaturamento / diasComFaturamento;


            int diasAcimaDaMedia = 0;
            foreach (var dia in faturamento)
            {
                if (dia.valor > mediaMensal)
                    diasAcimaDaMedia++;
            }

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Numero de dias com faturamento acima da média: {diasAcimaDaMedia}");
            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();
        }

    }
}
