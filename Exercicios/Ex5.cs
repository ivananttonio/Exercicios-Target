using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex5
    {
        public void Executar()
        {
 
            Console.Write("Digite uma palavra para inverter: ");
            string palavra = Console.ReadLine();

  
            string resultadoInvertido = "";

   
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                resultadoInvertido += palavra[i];
            }

            Console.WriteLine($"Palavra invertida: {resultadoInvertido}");
            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();

        }
    }
}
