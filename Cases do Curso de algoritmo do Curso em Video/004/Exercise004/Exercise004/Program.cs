using System;
using System.Transactions;

namespace Exercise_vetor
{
    class program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Digite SETE numeros diferentes e descubra quem é par ou impar");
            bool resp = true;
            while (true == resp)
            {
                proc_receb_numero();
                resp = receb_resp();
            }
            Console.WriteLine("Fim do Programa..\nTecle qualquer tecla para sair.");
            Console.ReadKey();
        }
        static void proc_receb_numero()//PROCED. - RECEBE DO USER, OS 7 NUMEROS
        {
            string id_phrase = "DIGITE UM NUMERO!!!";
            int count = 0;
            int[] numeros = new int[7];
            for (int i = 0; i <= 6; i++)
            {
                count += 1;
                Console.WriteLine("Digite o " + count + "º numero:");
                numeros[i] = valida_numero(id_phrase);
            }
            Console.Clear();
            verifica_parimpar(numeros);
        }
        static int valida_numero(string id)//FUNÇÃO - PARAMETROS POR VALOR - PRIMEIRA TAREFA É VALIDAR SE O USER DIGITOU UM NUMERO, SEGUNDA TAREFA É VERIFICAR SE O USER DIGITOU 1 OU 2
        {
            string num = Console.ReadLine();
            int num_retorno;
            if (id == "DIGITE UM NUMERO!!!")
            {
                while (false == int.TryParse(num, out num_retorno))
                {
                    Console.WriteLine(id);
                    num = Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                while (false == int.TryParse(num, out num_retorno))
                {
                    Console.WriteLine(id);
                    num = Console.ReadLine();
                    Console.Clear();
                }
                while (num_retorno < 1 || num_retorno > 2)
                {
                    Console.WriteLine("TU É BURRO?? DIGITE 1 OU 2 !!!!");
                    num_retorno = valida_numero(id);
                }
            }
            return num_retorno;
        }
        static void verifica_parimpar(int[] nums)//PROCED. - PARAMETRO ARRAY POR VALOR - VERIFICA QUAIS NUMEROS SÃO PARES OU IMPARES
        {
            int count_par = 0;
            int count_impar = 0;
            for (int i = 0; i <= 6; i++)
            {
                if (0 != nums[i] % 2)
                {
                    count_impar += 1;
                    Console.WriteLine("O numero " + nums[i] + " é Impar");
                }
                else
                {
                    count_par += 1;
                    Console.WriteLine("O numero " + nums[i] + " é Par");
                }
            }
            verifica_quant(count_impar, count_par, ref nums);
        }
        static void verifica_quant(int im, int par, ref int[] nums)//PROCED. - PARAMETROS POR VALOR E REF - VERIFICA A QUANT. DE NUMEROS PARES E IMPARES, DIGITADOS
        {
            Console.WriteLine("\nNumeros Impares");
            for(int i = 0; i < 7; i++)
            {
                if (0 != nums[i] % 2)
                {
                    Console.WriteLine(nums[i] + " está na posição " + i);
                }
            }
            Console.WriteLine("\nNumeros Pares");
            for (int i = 0; i < 7; i++)
            {
                if (0 == nums[i] % 2)
                {
                    Console.WriteLine(nums[i] + " está na posição " + i);
                }
            }
            if (im == 0)
            {
                Console.WriteLine("\n\nNenhum numero impar");
            }
            else
            {
                if(im == 1)
                {
                    Console.WriteLine("\n\n"+im +" numero impar");
                }
                else
                {
                    Console.WriteLine("\n\n"+im + " numeros impares");
                }
            }
            if (par == 0)
            {
                Console.WriteLine("Nenhum numero par");
            }
            else
            {
                if (par == 1)
                {
                    Console.WriteLine(+par + " numero par");
                }
                else
                {
                    Console.WriteLine(+par + " numeros pares\n");
                }
            }
        }
        static bool receb_resp()//FUNÇÃO - RECEBE UMA RESPOSTA DO USER
        {
            string id_phrase = "DIGITE 1 OU 2 CARAMBA!";
            Console.WriteLine("\ntentar de novo?\n\nSe sim, digite 1\nSe não, digite 2\n");
            int r = valida_numero(id_phrase);
            if(r == 1)
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
        }
    }
}