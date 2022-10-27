using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise007
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("========= AJUSTE SALÁRIAL =========");
            Console.WriteLine("\nDigite o valor atual do seu Salário:");
            double sal = Convert.ToDouble(Console.ReadLine());
            double sal_ant = sal;
            Console.Clear();
            Console.WriteLine("Seu salário foi reajustado para " + verificaSalario(sal));
            double ajuste = verificaSalario(sal) - sal_ant;
            Console.WriteLine("Você teve um ajuste de R$ " + ajuste + ",00");
            Console.WriteLine("\nDigite qualquer tecla para sair...");
            Console.ReadKey();
        }
        static double verificaSalario(double sal)//FUNÇÃO: RETORNA O AJUSTE DO SALÁRIO
        {
            if(sal > 1700)
            {
                sal = sal + 200;
            }
            else
            {
                sal += 300;
            }
            return sal;
        }
    }
}