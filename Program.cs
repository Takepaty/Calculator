using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.Clear();

            Console.WriteLine("Qual calculo deseja fazer?");
            Console.WriteLine(" ");

            Console.WriteLine("* - * - * - * - * - * - * - * - * ");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("* - * - * - * - * - * - * - * - * ");

            Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da SOMA é {resultado}.");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da SUBTRAÇÃO é {resultado}.");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {

            Console.Clear();


            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da DIVISÃO é {resultado}.");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine(" ");

            Console.WriteLine($"O resultado da MULTIPLICAÇÃO é {resultado}.");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {

            Console.Clear();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(" ");
            Console.WriteLine("Obrigado por utilizar nosso sistema!");
            Console.WriteLine(" ");
            Console.WriteLine("VOLTE SEMPRE :) ");
            Console.WriteLine(" ");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }
    }
}