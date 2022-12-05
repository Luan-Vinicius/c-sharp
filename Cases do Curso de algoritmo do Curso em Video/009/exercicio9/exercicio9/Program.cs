using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
// CADASTRAR E VALIDAR A QUANTIDADE DE QUESTOES DO GABARITO - OK
// CADASTRAR E VALIDAR AS QUESTOES DO GABARITO = Ok
// CADASTRAR E VALIDAR A QUANTIDADE DE ALUNOS = OK
// CADASTRAR E VALIDAR O NOME DO ALUNOS = Ok
// CADASTRAR E VALIDAR AS RESPOSTAS DE CADA ALUNO......
//  > cadastrar as resposta na array da class com o LIST - OK
namespace Exer009
{
    class program
    {
        static void Main(string[] Args)
        {
            bool cond1 = true;
            bool cond2 = true;
            string id;
            string q_questoes = null;
            id = "num_questoes";
            frases(id);
            while (true == cond2)//condição: user digitou a quantidade certa?
            {
                while (true == cond1)//condição: user digitou um numero?
                {
                    if (true == cond1)
                    {
                        q_questoes = Console.ReadLine();
                        cond1 = ver_numero(q_questoes);
                        if (cond1 == true)
                        {
                            id = "num_questoes";
                            Console.Clear();
                            Console.WriteLine("Inválido!\nVocê digitou: '" + q_questoes + "'"); frases(id);
                        }
                        else
                        {
                            cond2 = valida_num(Convert.ToInt32(q_questoes));
                            if (true == cond2)
                            {
                                Console.Clear();
                                id = "erro_questoes";
                                Console.WriteLine("Inválido!\nVocê digitou: '" + q_questoes + "'"); frases(id);
                                cond1 = true;
                            }
                        }
                    }
                }
            }// CADASTRAR E VALIDAR A QUANTIDADE DE QUESTOES DO GABARITO

            Console.Clear();
            id = "gabarito";
            string q;
            string[] quest = new string[Convert.ToInt32(q_questoes)];
            Console.WriteLine("=== Cadastrando Gabarito ===\n");
            for (int i = 0; i < Convert.ToInt32(q_questoes); i++)
            {
                cond1 = true;
                while (true == cond1)
                {
                    Console.WriteLine("Questão " + (i + 1) + "º:");
                    q = Console.ReadLine();
                    if (true == ver_letra(q, id))
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando Gabarito ===\n\nDigite uma alternativa válida!\nVocê digitou '" + q + "'.\nDigite novamente!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando Gabarito ===\n");
                        quest[i] = filtra_(q);
                        cond1 = false;
                    }
                }
            }// CADASTRAR E VALIDAR AS QUESTOES DO GABARITO

            Console.Clear();
            Console.WriteLine("=== Cadastrando a quantidade de alunos ===\n");
            Console.WriteLine("Quantos alunos fizeram a prova?\nDigite a quantidade:");
            string q_alunos = null;
            cond1 = true;
            cond2 = true;
            while (true == cond2)//primeira condição: user digitou quant. certa de alunos?
            {
                while (true == cond1)//segunda condição: user digitou o um numero?
                {
                    q_alunos = Console.ReadLine();
                    cond1 = ver_numero(q_alunos);
                    if (true == cond1)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando a quantidade de alunos ===\n");
                        Console.WriteLine("Inválido!\nVocê digitou: '" + q_alunos + "'\n");frases(id);
                    }
                    else
                    {
                        cond2 = valida_num(Convert.ToInt32(q_alunos));
                        if (cond2 == true)
                        {
                            id = ".";
                            Console.Clear();
                            Console.WriteLine("=== Cadastrando a quantidade de alunos ===\n");
                            Console.WriteLine("Inválido!\nVocê digitou: '" + q_alunos + "'\n");frases(id);
                            cond1 = true;
                        }
                    }
                }
            }// CADASTRAR E VALIDAR A QUANTIDADE DE ALUNOS. MAX 10

            Console.Clear();
            id = "recebe_aluno";
            string[] aluno = new string[Convert.ToInt32(q_alunos)];
            string rec_aluno = null; //variavel onde será armazenado o dado do user, antes de armazenar na array
            Console.WriteLine("=== Cadastrando os alunos ===\n");
            for (int i = 0; i < Convert.ToInt32(q_alunos); i++)
            {
                cond2 = true;
                while (true == cond2)
                {
                    Console.WriteLine("Digite o " + (i + 1) + "º aluno:");
                    rec_aluno = Console.ReadLine();
                    if (true == ver_letra(rec_aluno, id))
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando os alunos ===\n\nInválido!\nNão digite nenhum numero, letra Maiuscula ou caracter especial!\nVocê digitou: '" + rec_aluno + "'");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando os alunos ===\n");
                        aluno[i] = rec_aluno;
                        cond2 = false;
                    }
                }
            }// CADASTRAR E VALIDAR O NOME DO ALUNOS

            //CADASTRAR AS RESPOSTAS DOS ALUNOS
            Console.Clear();
            List<aluno> listaAluno = new();
            aluno aluno1 = new(); aluno aluno2 = new(); aluno aluno3 = new();
            aluno aluno4 = new(); aluno aluno5 = new(); aluno aluno6 = new();
            aluno aluno7 = new(); aluno aluno8 = new(); aluno aluno9 = new();
            aluno aluno10 = new();
            id = "gabarito";
            switch (Convert.ToInt32(q_alunos))
            {
                //SWITCH DE 10 CASOS. CADA CASO, VAI DEPENDER DA QUANTIDADE DE ALUNOS CADASTRADO
                case 1:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);
                    break;

                case 2:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);
                    break;

                case 3:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);
                    break;

                case 4:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);
                    break;

                case 5:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);
                    break;

                case 6:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno6, 5);
                    aluno6.nome_aluno = aluno[5];
                    listaAluno.Add(aluno6);
                    break;

                case 7:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno6, 5);
                    aluno6.nome_aluno = aluno[5];
                    listaAluno.Add(aluno6);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno7, 6);
                    aluno7.nome_aluno = aluno[6];
                    listaAluno.Add(aluno7);
                    break;

                case 8:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno6, 5);
                    aluno6.nome_aluno = aluno[5];
                    listaAluno.Add(aluno6);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno7, 6);
                    aluno7.nome_aluno = aluno[6];
                    listaAluno.Add(aluno7);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno8, 7);
                    aluno8.nome_aluno = aluno[7];
                    listaAluno.Add(aluno8);
                    break;

                case 9:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno6, 5);
                    aluno6.nome_aluno = aluno[5];
                    listaAluno.Add(aluno6);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno7, 6);
                    aluno7.nome_aluno = aluno[6];
                    listaAluno.Add(aluno7);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno8, 7);
                    aluno8.nome_aluno = aluno[7];
                    listaAluno.Add(aluno8);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno9, 8);
                    aluno9.nome_aluno = aluno[8];
                    listaAluno.Add(aluno9);
                    break;

                default:
                    armazena(Convert.ToInt32(q_questoes), aluno, aluno1, 0);
                    aluno1.nome_aluno = aluno[0];
                    listaAluno.Add(aluno1);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno2, 1);
                    aluno2.nome_aluno = aluno[1];
                    listaAluno.Add(aluno2);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno3, 2);
                    aluno3.nome_aluno = aluno[2];
                    listaAluno.Add(aluno3);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno4, 3);
                    aluno4.nome_aluno = aluno[3];
                    listaAluno.Add(aluno4);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno5, 4);
                    aluno5.nome_aluno = aluno[4];
                    listaAluno.Add(aluno5);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno6, 5);
                    aluno6.nome_aluno = aluno[5];
                    listaAluno.Add(aluno6);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno7, 6);
                    aluno7.nome_aluno = aluno[6];
                    listaAluno.Add(aluno7);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno8, 7);
                    aluno8.nome_aluno = aluno[7];
                    listaAluno.Add(aluno8);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno9, 8);
                    aluno9.nome_aluno = aluno[8];
                    listaAluno.Add(aluno9);

                    armazena(Convert.ToInt32(q_questoes), aluno, aluno10, 9);
                    aluno10.nome_aluno = aluno[9];
                    listaAluno.Add(aluno10);
                    break;
            }

            //MOSTRAR O RESULTADO DOS ALUNOS
            Console.WriteLine("=== RESULTADO FINAL ===\n");
            float point_quest = calc_point_quest(Convert.ToInt32(q_questoes));//para calcular a quantidade
                                                                         //de pontos por questoes corretas
            float media_turma=0;
            foreach (aluno puxaaluno in listaAluno)
            {
                float acerto = 0;//para somar a quantidade de pontos do aluno
                int cont = 0;//para contar a quantidade de acertos do aluno
                int c = 0;//para controlar e puxar as respostas do gabarito na array quest
                Console.WriteLine("==="+(puxaaluno.nome_aluno)+"===");
                for(int i = 0; i < Convert.ToInt32(q_questoes);i++)
                {
                    if (puxaaluno.resps[i] == quest[c])
                    {
                        cont++;
                        acerto += point_quest;
                    }
                    c++;
                }
                media_turma += acerto;
                Console.WriteLine("Questões acertadas: " + cont + "\nNota total: " + acerto + "\n");
            }
            Console.WriteLine("==================\nMédia da turma: " + (media_turma / Convert.ToInt32(q_alunos)));

        }
        static bool ver_numero(string num)//FUNÇÃO - RETORNA FALSE SE O USER DIGITAR CORRETAMENTE
                                          // APENAS NUMEROS
        {
            bool cond = true;
            int num_out;
            if (false != int.TryParse(num, out num_out))
            {
                cond = false;
            }
            return cond;
        }
        static bool ver_letra(string questao, string id)//FUNÇAO - RETORNA FALSE SE O USER DIGITAR CORRETAMENTE
                               //APENAS LETRA
        {
            bool cond = true;
            if (id == "gabarito")//AQUI VERIFICAMOS SE USER DIGITOU APENAS AS LETRAS DE A a E
            {
                if (Regex.IsMatch(questao, @"^[a-e]+$"))
                {
                    cond = false;
                }
            }
            else//AQUI VERIFICAMOS SE O USER, AO DIGITAR O NOME DOS ALUNOS,
                //SE ELE ESTÁ DIGITANDO APENAS LETRAS
            {
                if (Regex.IsMatch(questao, @"^(?i)[a-z,"" ""]+$"))//(?i) > habilita o modo case insensitive
                                                                  //o que faz com que o regex não diferencie
                                                                  // letra maiuscula e minuscula 
                {
                    cond = false;
                }
            }
            return cond;
        }
        static string filtra_(string questao)//FUNÇÃO - RETORNA APENAS A PRIMEIRA LETRA INFORMADO PELO USER CASO ELE
                                             //DIGITE MAIS DE UMA LETRA VÁLIDA
        {
            char[] one_letter;
            one_letter = questao.ToCharArray();
            return Convert.ToString(one_letter[0]);
        }
        static bool valida_num(int num)//FUNÇÃO - RETORNA FALSE SE O USER DIGITAR CORRETAMENTE
                                                  //APENAS UM QUANTIDADE CERTA DE NUMEROS
        {
            bool cond = true;
            if (1 <= num && 10 >= num)
            {
                cond = false;
            }
            return cond;
        }
        static void frases(string id)
        {
            switch (id)
            {
                case "erro_questoes":
                    {
                        Console.WriteLine("Digite o numero de questões da prova(max. 10):");
                        break;
                    }
                case "num_questoes":
                    {
                        Console.WriteLine("Digite o numero de questões da prova:");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Digite o numero de alunos da prova(max. 10):");
                        break;
                    }
            }
        }//PROCEDIMENTO: ESCREVE UMA FRASE, DE ACORDO COM O ID PASSADO NO PARÂMETRO
        static void armazena(int quant, string[] nome, aluno alunos, int local)
        {
            string id = "gabarito";
            for (int i = 0; i < Convert.ToInt32(quant); i++)
            {
                bool cond = true;
                while (true==cond)
                {
                    Console.WriteLine("=== Cadastrando respostas dos alunos ===\n");
                    Console.WriteLine("Digite a " + (i + 1) + "º resposta do aluno(a) " + nome[local]);
                    string resp = Console.ReadLine();
                    cond = ver_letra(resp, id);
                    if (true == cond)
                    {
                        Console.Clear();
                        Console.WriteLine("=== Cadastrando respostas dos alunos ===\n");
                        Console.WriteLine("invalido!\nVocê digitou: '" + resp + "'\n");
                    }
                    else
                    {
                        Console.Clear();
                        alunos.resps[i] = filtra_(resp);
                    }
                }
            }
        }
        static float calc_point_quest(float questoes)
        {
            return 10 / questoes;
        }
    }
    public class aluno
    {
        public string nome_aluno { get; set; }
        public string[] resps = new string[10];
    }
}