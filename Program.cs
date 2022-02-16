using System;

namespace Calculator
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

            Console.WriteLine("Qual operação deseja realizar? ");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - sair");

            Console.WriteLine("------------------------");
            Console.WriteLine("selecione uma opção: ");
            var res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtratacao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            var v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var resultado = v1 + v2;

            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();

            Menu();
        }

        static void Subtratacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            var v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var resultado = v1 - v2;

            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da subtração é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();

            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            var v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var resultado = v1 / v2;

            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da divisão é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            var v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var resultado = v1 * v2;

            //Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();

            Menu();
        }
    }
}
