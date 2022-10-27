using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Digite a operação que deseja realizar.");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("(1) Adição\n(2) Subtração\n(3) Multiplicação\n(4) Divisão");
            int operação = Convert.ToInt32(Console.ReadLine());
            double num1;
            double num2;
            double result;
            string op;

            while(operação < 1 || operação > 4)// ESTRUTURA DE REPETIÇÃO WHILE
// ELE REPETE O CODIGO ATÉ QUE A VALIDAÇÃO SEJA FALSA. OU SEJA, ELE REPETE ENQUANTO A VALIDAÇÃO É VERDADEIRA
            {
                valida val = new valida();
                Console.WriteLine(val.validacao());
                operação = Convert.ToInt32(Console.ReadLine());
            }
            switch (operação)
            {
                case 1:
                    Console.WriteLine("Você escolheu adição");
                    Console.WriteLine("Digite o primeiro numero da operação:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero da operação:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine("O resultado da Adição é "+ result);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu subtração");
                    Console.WriteLine("Digite o primeiro numero da operação:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero da operação:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    op = "Subtração";
                    Console.WriteLine("O resultado da Subtração é " + result);
                    break;
                case 3:
                    Console.WriteLine("Você escolheu multiplicação");
                    Console.WriteLine("Digite o primeiro numero da operação:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero da operação:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    op = "Multiplicação";
                    Console.WriteLine("O resultado da Multiplicação é " + result);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu Divisão");
                    Console.WriteLine("Digite o primeiro numero da operação:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero da operação:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / num2;
                    op = "Divisão";
                    Console.WriteLine("O resultado da Divisão é " + result);
                    break;
            }
        }
    }
    class valida
    {
        public string validacao()
        {
            return "opção invalida, digite novamente";
        }
    }
}