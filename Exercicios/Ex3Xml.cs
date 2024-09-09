using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicios
{
    public class Ex3Xml
    {
        public void Executar()
        {  

            string xmlString = System.IO.File.ReadAllText("C:\\Users\\ivan_\\OneDrive\\Área de Trabalho\\Processo seletivos\\Target\\Exercicios\\dados (2).xml");
            xmlString = $"<rows>{xmlString}</rows>";


            XElement xml = XElement.Parse(xmlString);

            var valores = xml.Elements("row")
                             .Select(r => (double)r.Element("valor"))
                             .ToList();

            if (valores.Count == 0)
            {
                Console.WriteLine("Nao tem dados de faturamento.");
                return;
            }

            double menorValor = double.MaxValue;
            double maiorValor = double.MinValue;
            double soma = 0;
            int count = 0;

            foreach (double valor in valores)
            {

                if (valor < menorValor)
                {
                    menorValor = valor;
                }


                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }

                if (valor > 0)
                {
                    soma += valor;
                    count++;
                }
            }

            double mediaMensal = (count > 0) ? soma / count : 0;


            int diasAcimaMedia = 0;
            foreach (double valor in valores)
            {
                if (valor > mediaMensal)
                {
                    diasAcimaMedia++;
                }
            }

   
            Console.WriteLine($"Menor valor: R${menorValor:F2}");
            Console.WriteLine($"Maior valor: R${maiorValor:F2}");
            Console.WriteLine($"Dias acima da media: {diasAcimaMedia}");
            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();



        }
    }
}
