using System;
using System.ComponentModel;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization;

namespace Exer_008
{
    class program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Vamos somar dois numero?");
            int[] valor = new int[2];
            int i;
            for (i = 0; i < 2; i++)
            {
                valor[i] = recebe_num(i);
            }
            // for(i=0; i < 2;i++) // ESTE CODIGO ERA PARA TESTAR SE A LISTA ESTAVA FUNCIONANDO
            //{
            //   int count = i + 1;
            //   Console.WriteLine("Valor" + count + ": " + valor[i]);
            //}
            Console.Clear();
            Console.WriteLine("Resultado: " + valor[0] + " + " + valor[1] + " = " + soma(valor));
            bool resp = true;
            while (true == resp)
            {
                Console.WriteLine("\nVocê quer fazer outra somatória?");
                Console.WriteLine("Se sim, digite: SIM");
                Console.WriteLine("Se não, digite: NAO");
                resp = resposta();
                if (true == resp)
                {
                    Console.Clear();
                    for (i = 0; i < 2; i++)
                    {
                        valor[i] = recebe_num(i);
                    }
                    Console.Clear();
                    Console.WriteLine("Resultado: " + valor[0] + " + " + valor[1] + " = " + soma(valor));
                }
            }
            Console.WriteLine("Fim do programa. Tecle qualquer tecla para sair...");
            Console.ReadKey();
        }
        static int recebe_num(int cont) // FUNÇÃO: PARAMETROS POR VALOR - PEDE E RECEBE UM VALOR, PELO USUARIO
        {
            cont = cont + 1;
            Console.WriteLine("Digite o " + cont + "º numero:");
            string receb_num = Console.ReadLine();
            return valida_num(receb_num);
        }
        static int valida_num(string v)// FUNÇÃO: PARAMETRO POR VALOR - VALIDA SE O USUARIO DIGITOU UM NUMERO
        {
            int valor_retorno;
            while (false == int.TryParse(v, out valor_retorno))
            {
                Console.WriteLine("TU SABE O QUE É UM NUMERO?");
                Console.WriteLine("digite o numero:");
                v = Console.ReadLine();
                Console.Clear();
            }
            return valor_retorno;
        }
        static int soma(int[] v)// FUNÇÃO: PARAMETRO ARRAY POR VALOR - FAZ A SOMA ENTRE OS DOIS NUMEROS
        {
            int soma = 0;
            for (int i = 0; i < 2; i++)
            {
                soma += v[i];
            }
            return soma;
        }
        static bool resposta()//FUNÇÃO: SEM PARAMETROS - VALIDA A RESPOSTA DO USER, PARA VER SE QUER CONTINUAR
        {
            string resp = Console.ReadLine();
            while (resp != "SIM" && resp != "NAO")
            {
                Console.WriteLine("Digite uma das opções: SIM ou NAO");
                resp = Console.ReadLine();
                Console.Clear();
            }
            if (resp == "SIM")
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