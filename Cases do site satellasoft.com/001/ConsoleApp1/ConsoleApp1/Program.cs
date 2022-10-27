using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Digite um numero");
            //int num2 = Convert.ToInt32(Console.ReadLine()); >> OUTRA OPÇÃO PARA O USUARIO ENTRAR COM UM VALOR
            string? num = Console.ReadLine();
            int result = Convert.ToInt32(num) % 2;
            if (result == 1)
            {
                Console.WriteLine("O numero " + num + " é Impar");
            }
            else
            {
                Console.WriteLine("O numero " + num + " é Par");
            }
        }
    }
}

