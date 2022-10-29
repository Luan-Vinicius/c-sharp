using System;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Exercise005
{
    class program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Iniciando programa");
            bool resp = true;
            while (true == resp)
            {
                proc_receb_aluno(ref resp);
            }
            Console.Clear();
            Console.WriteLine("Fim do Programa!\nDigite qualquer tecla para sair....");
            Console.ReadKey();
        }
        static void proc_receb_aluno(ref bool r)//PROCED. - PARAMETRO POR REF. - RECEBE O NOME E AS NOTAS DOS ALUNOS E MOSTRA A MEDIA
        {
            string id = "proc_receb_aluno1";
            string id2 = "proc_receb_aluno2";
            string[] alunos = new string[4];
            float[] nota1 = new float[4];
            float[] nota2 = new float[4];
            float[] media = new float[4];
            float media_turma = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do " + posi(i, id) + " aluno");
                alunos[i] = receb_aluno();
                media[i] = receb_nota_calc_media(ref nota1, ref nota2, i, ref media_turma);
                Console.Clear();
            }
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                int i1 = 0; int i2 = 1;
                Console.WriteLine("Aluno: " + alunos[i]);
                Console.WriteLine(posi(i1, id2) + " nota: " + nota1[i]);
                Console.WriteLine(posi(i2, id2) + " nota: " + nota2[i]);
                Console.WriteLine("Média: " + media[i] + "\n");
            }
            Console.WriteLine("A media da turma é " + (media_turma/4)+"\n");
            aluno_media(alunos, media, media_turma);
            r = receb_resp();
        }
        static string receb_aluno()//FUNCÃO - RECEBE E VALIDA O NOME DO ALUNO
        {
            bool test = true;
            string aluno = null;
            while (true == test)
            {
                aluno = Console.ReadLine();
                if (Regex.IsMatch(aluno, @"^[a-z,A-Z,"" "",ã,Ã,í,Í,é,É,õ,Õ]+$"))
                {
                    test = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Digite um nome válido");
                    test = true;
                }
            }
            return aluno;
        }
        static float receb_nota_calc_media(ref float[] n1, ref float[] n2, int c, ref float MT)//FUNÇÃO - RECEBE E VALIDA A NOTA. TAMBÉM VALIDA PARA QUE A NOTA SEJA ENTRE 0 E 10
        {
            bool status = true;
            string id = "receb_nota";
            for (int i = 0; i < 2; i++)
            {
                float nota_certa = 0;
                Console.WriteLine("Digite a " + posi(i, id) + " nota");
                while (true == status)
                {
                    string nota1 = Console.ReadLine();
                    if (false == float.TryParse(nota1, out nota_certa))
                    {
                        Console.Clear();
                        Console.WriteLine("ERRO! VALOR INVÁLIDO!\nDigite um valor numérico!");
                        Console.WriteLine("você digitou: " + nota1);
                    }
                    else
                    {
                        if (nota_certa < 0 || nota_certa > 10)
                        {
                            Console.Clear();
                            Console.WriteLine("ERRO! VALOR INVÁLIDO!\nDigite um valor de 0 a 10:");
                            Console.WriteLine("Você digitou: " + nota_certa);
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
                if (i == 0)
                {
                    n1[c] = nota_certa;
                    status = true;
                }
                else
                {
                    n2[c] = nota_certa;
                }
            }
            return calc_media(n1, n2, c, ref MT);
        }
        static void aluno_media(string[] aluno, float[] m_aluno, float media_t)//PROCED. - PARAMETROS VALOR E REF - COMPARA E MOSTRA QUAIS ALUNOS FICARAM ACIMA DA MEDIA DA TURMA
        {
            int cont = 0;
            for (int i=0; i < 4; i++)
            {
                if (m_aluno[i] > (media_t/4))
                {
                    cont = +1;
                    Console.WriteLine("\n"+aluno[i] + " está acima da média da turma");
                }
            }
            if(cont == 0)
            {
                Console.WriteLine("Nenhum aluno ficou acima da média da turma");
            }
        }
        static float calc_media(float[] n1, float[] n2, int c, ref float MT)//FUNÇÃO - PARAMETROS VALOR E REF - CALCULA A MEDIA DA TURMA
        {
            MT = MT + ((n1[c] + n2[c])/2);
            return (n1[c] + n2[c]) / 2;
        }
        static string posi(int i, string id)// FUNÇÃO - PARAMETROS VALOR - VERIFICA A POSIÇÃO PARA RETORNAR A DESCRIÇÃO DA POSIÇÃO
        {
            string resp = null;
            switch (i)
            {
                case 0:
                    if (id == "proc_receb_aluno1")
                    {
                        resp = "primeiro";
                    }
                    else
                    {
                        resp = "primeira";
                    }
                    break;
                case 1:
                    if (id == "proc_receb_aluno1")
                    {
                        resp = "segundo";
                    }
                    else
                    {
                        resp = "segunda";
                    }
                    break;
                case 2: resp = "terceiro"; break;
                case 3: resp = "quarto"; break;
            }
            return resp;
        }
        static bool receb_resp()//FUNÇÃO - RECEBE E VALIDA A RESPOSTA DO USER
        {
            bool resp_return = true;
            bool cond = true;
            string resp;
            int op;
            Console.WriteLine("\nGostaria de recomeçar o programa?\nSe sim, digite 1\nSe não, digite 2");
            while (true == cond)
            {
                resp = Console.ReadLine();
                if (false == int.TryParse(resp, out op))
                {
                    Console.Clear();
                    Console.WriteLine("Digite 1 ou 2!\n1 para sim\n2 para não");
                }
                else
                {
                    if (op < 1 || op > 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite 1 ou 2!\n1 para sim\n2 para não");
                    }
                    else
                    {
                        if (op == 1)
                        {
                            resp_return = true;
                        }
                        else
                        {
                            resp_return = false;
                        }
                        cond = false;
                    }
                }
            }
            return resp_return;
        }
    }
}