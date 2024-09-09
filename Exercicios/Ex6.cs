using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex6
    {
        public void Executar()
        {

            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            int count = 0;
 
            foreach (char c in palavra)
            {
  
                if (c == 'a' || c == 'A')
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {count} vez(es) na string.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não foi encontrada na string.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }
           
        }
    }
}
