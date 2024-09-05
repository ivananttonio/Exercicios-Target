using Exercicios;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {  
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Exercicio 1: Soma");
            Console.WriteLine("2 - Exercicio 2: Fibonacci");
            Console.WriteLine("3 - Exercicio 3: Faturamento diário de uma distribuidora JSON");
            Console.WriteLine("4 - Exercicio 4: Faturamento diário de uma distribuidora XML");
            Console.WriteLine("5 - Exercicio 5: Faturamento mensal de uma distribuidora, detalhado por estado");
            Console.WriteLine("6 - Exercicio 6: Inverta os caracteres de uma palavra.");
            Console.WriteLine("7 - Exercicio 7: Programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula.");
            Console.WriteLine("8 - Exercicio 8: Valor da variável SOMA.");

            Console.WriteLine("0 - Sair");

            int numero = 0;

            while (true)
            {
                Console.Write("Digite o número da opção desejada (0 a 8): ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    if (numero >= 0 && numero <= 8)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número fora do intervalo. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
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
                case 7:
                    Ex6 exec6 = new Ex6();
                    exec6.Executar();
                    break;
                case 8:
                    Ex7 exec7 = new Ex7();
                    exec7.Executar();
                    break;
                case 0:     
                    Console.WriteLine("Saindo...");
                    return;
            }
        }
    }
}