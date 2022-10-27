using System;
using System.ComponentModel.DataAnnotations;

namespace Exer_010
{
    class program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Vamos descobrir o fatorial de um numero?");
            string resp = "SIM";
            while ("SIM" == resp)
            {
                float num = valida_numero();
                calc_fatorial(ref num, ref resp);
            }
            Console.WriteLine("Fim do programa!\nAperte qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
        static void calc_fatorial(ref float n, ref string r)// PROCEDIMENTO - PARAMETROS POR REFERENCIA - CALCULA O FATORIAL DO NUMERO
        {
            if (n == 0)
            {
                Console.WriteLine("O fatorial de " + n + " é 0");
                receb_resp(ref r);
            }
            else
            {
                float count = n;
                n = 1;
                for (float i = 1; i <= count; i++)
                {
                    n *= i;
                }
                Console.WriteLine("O fatorial de " + count + " é " + n);
                receb_resp(ref r);
            }
        }
        static float valida_numero()// FUNÇÃO - SEM PARAMETROS - RECEBE DO USER UM NUMERO E VALIDA SE FOI DIGITADO CERTO
        {
            Console.WriteLine("Digite um numero, e descubra o valor do seu fatorial:"); string n = Console.ReadLine();
            float val_return;
            while (false == float.TryParse(n, out val_return))
            {
                Console.WriteLine("Tu é burro ou quer um doce? Digite um valor numérico:");
                n = Console.ReadLine();
                Console.Clear();
            }
            return val_return;
        }
        static void receb_resp(ref string r)// PROCEDIMENTO - PARAMETRO POR REFERENCIA - SOLICITA E VALIDA UMA RESPOSTA DO USER
        {
            Console.WriteLine("\nVocê quer calcular outro numero?");
            Console.WriteLine("\nSe sim, digite SIM\nSe não, digite NAO");
            string resp = Console.ReadLine();
            while (resp != "SIM" && resp != "NAO")
            {
                Console.WriteLine("Digite SIM ou NAO, cabaço!!"); resp = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            r = resp;
        }
    }
}