using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Ex9
    {
        public void Executar()
        {      
            double distanciaTotal = 125.0; 
            double velocidadeCarro = 90.0; 
            double velocidadeCaminhao = 80.0; 
            double atrasoCarro = 0.25;
    
            double tempoParaCruzar = distanciaTotal / (velocidadeCarro + velocidadeCaminhao);
    
            double distanciaCaminhao = velocidadeCaminhao * tempoParaCruzar;
     
            double tempoCarroComAtraso = tempoParaCruzar + atrasoCarro;
            double distanciaCarro = velocidadeCarro * tempoCarroComAtraso;
         
            if (distanciaCarro < distanciaCaminhao)
            {
                Console.WriteLine("O carro está mais próximo de Ribeirão Preto.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O caminhão está mais próximo de Ribeirão Preto.");
                Console.WriteLine("Precisone qualquer tecla para continuar");
                Console.ReadKey();
            }

        }
    }
}
