using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Exercicio_6
{
    class program
    {
        static void Main(string[] Args)
        {
            string id = "main";
            bool cond = true;
            string[] nome = new string[10];
            
            while (true == cond)
            {
                for(int i =0; i < 10; i++)
                {
                    Console.Clear();
                    frase(id);
                    nome[i]=Recebe_nome(i);
                }
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    verifica_nome(nome, i);
                }
                cond = recebe_resp();
            }
            Console.WriteLine("Fim do programa!\nTecle qualquer tecla para sair");
            Console.ReadKey();

        }
        static string Recebe_nome(int i)//FUNÇÃO - RECEBE OS 10 NOMES
        {
            string id = "Recebe_nome";
            string nome=null;
            bool cond = true;
            while (true == cond)
            {
                Console.WriteLine("Digite o "+posicao(i)+" nome:");
                nome = Console.ReadLine();
                valida_nome(nome, ref cond);
            }
            return nome;
        }
        static void verifica_nome(string[] nome, int i)//PROCED. - VERIFICA E ARMAZENA OS NOMES QUE COMEÇAM COM C
        {
            char[] char_nome;
            //char firtsLetter;
            char_nome = nome[i].ToCharArray();
            if ('c' == char_nome[0] || 'C' == char_nome[0])
            {
                Console.WriteLine(nome[i]);
            }
        }
        static void frase(string id)//PROCED. - DEPENDENDO DO ID DO METODO, RETORNA UMA FRASE DIFERENTE PARA CADA UM
        {
            switch (id)
            {
                case "main":Console.WriteLine("---- DIGITE DEZ NOMES ----");break;
                case "validanome":Console.WriteLine("Não coloque nenhuma acentuação, numero ou caracteres especiais!");break;
                case "recebe_resp":Console.WriteLine("DIGITA CERTO SEU ARROMBADO!!!\n");break;
            }
        }
        static void valida_nome(string nm, ref bool con) //PROCED. - VALIDA O NOME. QUALQUER CARACTER ESPECIAL, NUMERO OU ACENTUAÇÃO, NÃO SERÁ ACEITO
        {
            string id = "validanome";
            if (Regex.IsMatch(nm, @"^[a-z,A-Z,"" ""]+$"))
            {
                con = false;
            }
            else
            {
                Console.Clear();
                frase(id);
            }
        }
        static string posicao(int i)//FUNÇÃO - RETORNA A DESCRIÇÃO DA POSIÇÃO
        {
            string ret = null;
            switch (i)
            {
                case 0: ret = "primeiro"; break;
                case 1: ret = "segundo"; break;
                case 2: ret = "terceiro"; break;
                case 3: ret = "quarto"; break;
                case 4: ret = "quinto"; break;
                case 5: ret = "sexto"; break;
                case 6: ret =  "sétimo"; break;
                case 7: ret = "oitavo"; break;
                case 8: ret = "nono"; break;
                case 9: ret = "décimo"; break;
            }
            return ret;
        }
        static bool recebe_resp()//FUNÇÃO - RECEBE E VALIDA A RESPOSTA DO USER
        {
            string id = "recebe_resp";
            Console.WriteLine("Quer fazer de novo?\nSe sim, digite 'Sim'\nSe não, digite 'Nao'");
            bool cond = true;
            bool cond_ret = true;
            string r;
            while (true == cond)
            {
                r = Console.ReadLine();
                Console.Clear();
                if (Regex.IsMatch(r, @"^[SIM, Sim, sim, s, S , NAO, Nao, nao, n, N]+$"))
                {
                    if ("SIM" == r || "Sim" == r || "sim" == r || "s" == r || "S" == r)
                    {
                        cond = false;
                        cond_ret = true;
                    }
                    else
                    {
                        cond = false;
                        cond_ret = false;
                    }
                }
                else
                {
                    frase(id);
                    Console.WriteLine("Digite Sim ou Nao:");
                }
            }
            return cond_ret;
        }
    }
}