using System;

namespace ConsoleApp
{
    class program
    {
        static void Main(string[] Args)
        {
            int x = 10;
            decimal d = 1.33m; // decimal - utilizado para calculos financeiros (Moeda)
            double d2 = 1.33; // double - utilizado para calculos cientificos e medições
            float f = 1.33f; // float - engines de jogos como o Unity devido a performance

            int y = x + 2;
            string s = "Olá";
            s = s + " Mundo"; // contatenação

            Console.WriteLine("Olá Mundo");
            Console.WriteLine(s);

            int[] a = new int[] { 2, 5, 8 };

            int result = 0;
            result += a[0];
            result = result + a[1];
            result = result + a[2];

            Console.WriteLine(result);
            foreach (int number in a)
            {
                result += number;
            }
            Console.WriteLine(result);

            Test t = new Test(); // 't' recebeu uma instancia da classe Test, que foi criado abaixo.

            t.name = "fredi";
            string hello = t.Sayhello();
            Console.WriteLine(hello + ", como você está?");

            if (t.name == "fredi")
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");

            }
            int num = 7;
            num = num % 2;
            Console.WriteLine(num);

        }
    }
    class Test
    {
        public string name; // uma variavel é atribuido como publico(public) para que as outras classe possam acessa-la, atraves da instancia
        public string Sayhello() // Método
        {
            return "Olá " + name;
        }

    }
}