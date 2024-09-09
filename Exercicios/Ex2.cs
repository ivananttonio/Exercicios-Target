using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex2
    {
        public void Executar()
        {

            Console.Write("Digite um numero para verificar se pertence à sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

  
            bool pertence = false;

            if (numero == 0 || numero == 1)
            {
                pertence = true;
            }
            else
            {   
                while (b <= numero)
                {
                    if (b == numero)
                    {
                        pertence = true;
                        break;
                    }
                    int valorFibo = a + b;
                    a = b;
                    b = valorFibo;
                }
            }

            if (pertence)
            {
                Console.WriteLine($"{numero} pertence a sequencia de Fibonacci.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{numero} não pertence a sequencia de Fibonacci.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }
            
        }
    }
}
