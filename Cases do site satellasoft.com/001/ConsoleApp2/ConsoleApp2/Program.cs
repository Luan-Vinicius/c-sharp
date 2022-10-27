using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Digite o seu nome");
            var name = Console.ReadLine();
            // string name = Console.ReadLine();  PODERIA UMA VARIAVEL DO TIPO STRING TAMBÉM
            Console.WriteLine("O seu nome de usuário é: "+name);
        }
    }
}