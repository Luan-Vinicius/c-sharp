using System;
namespace ConsoleApp4
{
    class program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            string resposta = "a";
            
            resposta = validaIdade(idade, resposta);
            Console.WriteLine(resposta);
        }
        static string validaIdade(int idade, string resposta)
        {
            while (idade <= 0 || idade > 120)
            {
                Console.WriteLine("Idade invalida, digite novamente:");
                idade = Convert.ToInt32(Console.ReadLine());
            }
            if(idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                resposta = "Sem permissão";
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;
                resposta = "Permissão Concedida";
            }
            return resposta;
        }
    }
}