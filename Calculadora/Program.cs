using System;


namespace Calculadora
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
            Console.WriteLine("\n!!! CALCULADORA !!! \n");
            Console.WriteLine("Escolha a opção desejada:\n1 = Somar\n2 = Subtrair\n3 = Multiplicar \n4 = Dividir \n0 = Sair\n");

            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Soma();break;
                case 2: Subtracao();break;
                case 3: Multiplicacao();break;
                case 4: Divisao();break;
                case 0: Console.WriteLine("Saindo..."); break;
                default: Menu();break;
            }
        }

        static void Soma()
        {
            float n1;
            float n2;
            float result;

            Console.Clear();
            Console.WriteLine("SOMA:");
            Console.WriteLine("Digite o primeiro numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("SOMA:");
            Console.WriteLine($"{n1} + ");
            Console.WriteLine("Digite o segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            result = n1 + n2;
            Console.WriteLine("---------\nRESULTADO:\n");
            Console.WriteLine($"{n1} + {n2} = {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            float n1;
            float n2;
            float result;

            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO:");
            Console.WriteLine("Digite o primeiro numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO:");
            Console.WriteLine($"{n1} - ");
            Console.WriteLine("Digite o segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            result = n1 - n2;
            Console.WriteLine("---------\nRESULTADO:\n");
            Console.WriteLine($"{n1} - {n2} = {result}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            float n1;
            float n2;
            float result;

            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO:");
            Console.WriteLine("Digite o primeiro numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO:");
            Console.WriteLine($"{n1} * ");
            Console.WriteLine("Digite o segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            result = n1 * n2;
            Console.WriteLine("---------\nRESULTADO:\n");
            Console.WriteLine($"{n1} * {n2} = {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            float n1;
            float n2;
            float result;

            Console.Clear();
            Console.WriteLine("DIVISÃO:");
            Console.WriteLine("Digite o primeiro numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("DIVISÃO:");
            Console.WriteLine($"{n1} / ");
            Console.WriteLine("Digite o segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            result = n1 / n2;
            Console.WriteLine("---------\nRESULTADO:\n");
            Console.WriteLine($"{n1} / {n2} = {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
