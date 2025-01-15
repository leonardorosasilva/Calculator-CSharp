using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int choose = Convert.ToInt32(Console.ReadLine());
            while (choose <= 0 || choose > 4)
            {
                Console.Clear();
                Menu();
                Console.WriteLine("A opção escolhida não existe no Menu, por favor digite novamente: ");
                choose = Convert.ToInt32(Console.ReadLine());
            }

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Você escolheu Soma");
                    break;

                case 2:
                    Console.WriteLine("Você escolheu Subtração");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Divisão");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu Multiplicação");
                    break;
            }
            Console.WriteLine("Digite o primeiro número:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double y = Convert.ToDouble(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("O resultado da sua operação é " + Sum(x,y));
                    break;

                case 2:
                    Console.WriteLine("O resultado da sua operação é " + Subtraction(x,y));
                    break;
                case 3:
                    Console.WriteLine("O resultado da sua operação é " + Divide(x,y));
                    break;
                case 4:
                    Console.WriteLine("O resultado da sua operação é " + Multplicator(x,y));
                    break;
            }
        }

        static void Menu()
        {
            Console.WriteLine("Digite para escolher a operação entre dois números:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
        }

        static double Sum(double x, double y)
        {
            return (x + y);
        }

        static double Subtraction(double x, double y)
        {
            return (x - y);
        }

        static double Divide(double x, double y)
        {
            return (x / y);
        }

        static double Multplicator(double x, double y)
        {
            return (x * y);
        }
    }
}