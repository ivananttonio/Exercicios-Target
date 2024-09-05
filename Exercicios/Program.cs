using Exercicios;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Exercicio 1: Soma");
        Console.WriteLine("2 - Exercicio 2: Fibonacci");
        Console.WriteLine("3 - Exercicio 3: Faturamento diário de uma distribuidora json");
        Console.WriteLine("4 - Exercicio 4: Faturamento diário de uma distribuidora xml");
        Console.WriteLine("5 - Exercicio 5: Faturamento mensal de uma distribuidora, detalhado por estado");
        Console.WriteLine("6 - Exercicio 6: Inverta os caracteres de uma palavra.");

        int numero = 0;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("Digite o numero da opção desejada: ");           
            numero = int.Parse(Console.ReadLine());
 

            if (numero < 1 || numero > 6)
            {
                Console.WriteLine("Digite um numero valido de 1 a 6.");
                entradaValida = false;
            }
        }


        switch (numero)
        {
            case 1:
                Ex1 exec1 = new Ex1();
                exec1.Executar();
                break;
            case 2:
                Ex2 exec2 = new Ex2();
                exec2.Executar();
                break;
            case 3:
                Ex3json exec3json = new Ex3json();
                exec3json.Executar();
                break;
            case 4:
                Ex3Xml exec3xml = new Ex3Xml();
                exec3xml.Executar();
                break;
            case 5:
                Ex4 exec4 = new Ex4();
                exec4.Executar();
                break;
            case 6:
                Ex5 exec5 = new Ex5();
                exec5.Executar();
                break;
        }
    }
}