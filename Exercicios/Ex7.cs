using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Ex7
    {
        public void Executar()
        {
            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
            Console.WriteLine("Precisone qualquer tecla para continuar");
            Console.ReadKey();

        }
    }
}
