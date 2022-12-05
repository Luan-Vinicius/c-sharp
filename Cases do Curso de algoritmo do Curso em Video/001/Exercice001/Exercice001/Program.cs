using System;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Exercise008
{
    class program
    {
        static void Main(string[] Args)// PROGRAMA PRINCIPAL
        {
            Console.WriteLine("Vamos ver se é o par ou impar?");
            float num = digite_numero();
            Console.WriteLine(verifica_numero(num));
            string resp = "Sim";
            resposta(ref resp, num);
        }
        static float digite_numero()//FUNÇÃO: SOLICITA A ENTRADA DE UM NUMERO, PELO USER
        {
            Console.WriteLine("Digite um numero:");
            string n = Console.ReadLine();
            float nn;
            while (false == float.TryParse(n, out nn))//REPETIÇÃO: REPETE ENQUANTO O USER DIGITAR QUALQUER COISA QUE NÃO SEJA UM NUMERO
            {
                Console.Clear();
                Console.WriteLine("DIGITE UM NUMERO SEU IDIOTA!!!");
                n = Console.ReadLine();
            }
            return nn;

        }
        static string verifica_numero(float n)// FUNÇÃO: VERIFICA SE O NUMERO É PAR OU IMPAR E IMPRIMI NA TELA
        {
            Console.Clear();
            if (0 == n % 2)
            {
                return "Você digitou "+n+"\nO numero digitado é PAR";
            }
            else
            {
                return "Você digitou "+n+"\nO numero digitado é impar";
            }
        }
        static void resposta(ref string r, float n) // PROCEDIMENTO: SOLICITA RESPOSTA DO USER, PARA VALIDAR SE QUER CONTINUAR
        {
            Console.WriteLine("Gostaria de tentar outro numero?");
            r = Console.ReadLine();
            while (valida(r) == true)
            {
                n = digite_numero();
                Console.WriteLine(verifica_numero(n));//verifica se o numero é par ou impar
                Console.WriteLine("Gostaria de tentar outro numero?");
                r = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Fim do programa. Tecle qualquer tecla para sair...");
        }
        static bool valida(string rr) // FUNÇÃO: VALIDA SE O USER QUER CONTINUAR NO PROGRAMA OU NÃO
        {
            while (rr != "SIM" && rr != "sim" && rr != "Sim" && rr != "s" && rr != "S" && rr != "NÃO" && rr != "não" && rr != "Não" && rr != "n" && rr != "N")
            {
                Console.Clear();
                Console.WriteLine("Digite uma resposta valida!");
                rr = Console.ReadLine();
            }
            if (rr == "SIM" || rr == "sim" || rr == "Sim" || rr == "s" || rr == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}