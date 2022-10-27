using System;
namespace Console005
{
    class progrma
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Digite como você gostaria de ser chamado:");
            string nome = Console.ReadLine();
            Console.WriteLine(fraseNome(nome));
        }
        static string fraseNome(string nome)
        {
            return "Olá, meu nome é " + nome;
        }
    }
}