using System;

namespace Exercicios
{
    public class Ex1
    {
        public void Executar()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine("O valor da variável SOMA ao final do processamento é: " + SOMA);
           
        }
    }
}
