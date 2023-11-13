using System;

namespace EditorHtml
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            DesenhoTela();
            Escrita();

            var opcao = short.Parse(Console.ReadLine());
            SelecaoMenu(opcao);
        }

        public static void DesenhoTela()
        {
            Console.Write("\n");
            Console.Write("|");

            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("|");
            Console.Write("\n");
            for (int linhas = 0; linhas < 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i < 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            for (int i = 0; i <= 31; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }
        public static void Escrita()
        {
        Console.SetCursorPosition(10, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(10, 3);
        Console.WriteLine("+++++++++++");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Ler arquivo");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");
        }

        public static void SelecaoMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Show();break;
                case 2: Visualizador.Show("");break;
                case 0: { Console.Clear(); Environment.Exit(0);};break;
            }
        }
    }
}
