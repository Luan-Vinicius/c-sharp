using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq.Expressions;

namespace Exercise007
{
    internal class program
    {
        static void Main(string[] args)
        {
            bool cond = true;
            string quant = null;
            while (true == cond)
            {
                int func = 1;
                Console.WriteLine("Determine uma quantidade de 2 até 20 numeros, e digite em qualquer sequência.\nEu, programa super bem desenvolvido, deixarei em ordem para você ;D");
                recebe_numero(func, ref quant);
                func = 2;
                recebe_numero(func, ref quant);
                cond = recebe_resp();
            }
            Console.WriteLine("Fim do programa");

            /*func = 3;
            recebe_numero(func, ref quant);
            Console.WriteLine("teste"); Console.ReadKey();*/
        }
        static void recebe_numero(int f, ref string q)//PROCED. - RECEBE NUMERO DO USER
        {
            int[] numero = new int[20];
            string id = "recebe_numeros";
            bool cond;
            if (1 == f)//PRIMEIRA PARTE: RECEBE A QUANTIDADE DE NUMEROS QUE O USER QUER DIGITAR
            {
                id = null;
                cond = true;
                Console.WriteLine("Digite quantos numeros você quer digitar:\n(20 numeros no maximo)");


                while (true == cond)
                {
                    q = Console.ReadLine();
                    Console.Clear();
                    cond = valida_numero(ref q, id);
                }
            }
            else
            {
                if (2 == f)//SEGUNDA PARTE: RECEBE OS NUMEROS
                {
                    string num = null;
                    Console.WriteLine("Agora vamos aos numeros!");
                    for (int i = 0; i < Convert.ToInt32(q); i++)
                    {
                        cond = true;
                        while (true == cond)
                        {
                            Console.WriteLine("Digite o " + (i + 1) + "° numero:");
                            num = Console.ReadLine();
                            Console.Clear();
                            cond = valida_numero(ref num, id);
                        }
                        numero[i] = Convert.ToInt32(num);
                    }
                    Console.Clear();
                    /*for (int i = 0; i < Convert.ToInt32(q); i++)
                    {
                        Console.WriteLine(numero[i]);
                    }*/
                    org_numeros(numero, q);
                    for (int i = 0; i < Convert.ToInt32(q); i++)
                    {
                        Console.WriteLine(numero[i]);
                    }
                }
                /*else
                {
                    org_numeros(numero, q);
                    for (int i = 0; i < Convert.ToInt32(q); i++)
                    {
                        Console.WriteLine(numero[i]);
                    }
                }*/
            }
        }
        static bool valida_numero(ref string num_in, string id)//FUNÇÃO - VALIDA OS NUMEROS DIGITADOS PELO USER
        {
            bool cond = true;
            int num_out;
            if (false == int.TryParse(num_in, out num_out))//VALIDA SE O USER DIGITOU UM NUMERO
            {
                Console.Clear();
                Console.WriteLine("Inválido!\nVocê digitou: " + num_in + "\nDigite um numero:");
                /*cond = true;*/
            }
            else
            {
                if (id == "recebe_numeros")
                {
                    cond = false;
                }
                else
                {
                    if (id== "recebe_resp")//SE O USER ESTIVER VINDO DO METODO RECEBE_RESP, ESSA PARTE VALIDA A RESPOSTA
                    {
                        bool cond2 = true;
                        num_in = Convert.ToString(num_out);
                        while (true == cond2)
                        {
                            if (false == int.TryParse(num_in, out num_out))
                            {
                                Console.Clear();
                                Console.WriteLine("Inválido!\nVocê digitou: " + num_in + "\nDigite um numero:");
                                num_in = Console.ReadLine();
                            }
                            else
                            {
                                if (1<=num_out && 2>=num_out)
                                {
                                    num_in = Convert.ToString(num_out);
                                    cond2 = false;
                                    cond = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Inválido!\nVocê digitou: " + num_out + "\nDigite 1 ou 2\n1, para 'sim'\n2, para 'não'");
                                    num_in = Console.ReadLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (2 > num_out || 20 < num_out)//VALIDA SE O USER DIGITOU UM NUMERO ENTRE 2 E 20
                        {
                            Console.WriteLine("Você poderá calcular de 2 até 20 numeros! Digite novamente:");
                            cond = true;
                        }
                        else
                        {
                            Console.Clear();
                            cond = false;
                        }
                    }
                }
                /*if (id == "recebe_resp")
                {
                    
                }*/
            }
            return cond;
        }
        static void org_numeros(int[] nums, string q)//PROCED. - ORGANIZA OS NUMEROS, COLOCANDO EM ORDEM CRESCENTE
        {
            int num1;
            int num2;
            int count = Convert.ToInt32(q) - 1;
            int ii;
            for (int i = 0; i < count; i++)
            {
                ii = i + 1;
                for (int c = ii; c < Convert.ToInt32(q); c++)
                {
                    num1 = nums[i];
                    num2 = nums[c];
                    if (num1 < num2)
                    {

                    }
                    else
                    {
                        nums[i] = nums[c];
                        nums[c] = num1;
                    }
                }
            }
        }
        static bool recebe_resp()//FUNÇÃO - RECEBE A RESPOSTA DO USER E RETORNA UM VALOR TRUE OU FALSE
        {
            string resp = null;
            string id = "recebe_resp";
            bool cond = true;
            Console.WriteLine("\nQuer fazer novamente?\nSe sim, digite 1\nSe não, digite 2");
            while (true == cond)
            {
                resp = Console.ReadLine();
                cond = valida_numero(ref resp, id);
            }
            if (1==Convert.ToInt32(resp))
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
