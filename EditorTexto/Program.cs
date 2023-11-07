using System.Collections;
using System.Security.AccessControl;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

        static void Menu()
        {
            Console.WriteLine("Escolha uma opção:\n");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Editar arquivo");
            Console.WriteLine("0 - Sair\n");

            char opcao = char.Parse(Console.ReadLine());

            switch(opcao)
            {
                case '1': AbrirArquivo();break;
                case '2': EditarArquivo();break;
                case '0': Environment.Exit(0);break;
                default: Menu();break;
            }
        }

        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho ou o nome do arquivo:");

            string caminhoArquivo = Console.ReadLine();

            using (var file = new StreamReader(caminhoArquivo))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadKey();
            Console.Clear();
            Menu();

            
        }

        static void EditarArquivo()
        {
            string texto = "";
            Console.WriteLine("Digite seu texto: (ESC para sair)");


            do
            {
            texto += Console.ReadLine() + Environment.NewLine;
            //texto += Environment.NewLine;
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
    
            Console.WriteLine(texto);
            Console.ReadKey();
            Console.WriteLine("\n---------------\nDeseja Salvar: (S) para sim ou (N) para NÂO e voltar para o menu principal:\n");

            string salvar = (Console.ReadLine().ToUpper());

            if (salvar == "S")
            {
                SalvarArquivo(texto);
            }
            else
            {
                Menu();
            }

        }

        static void SalvarArquivo(string texto)
        {
            Console.Clear();
            Console.WriteLine("Escolha o local'\'nome do arquivo para salvar:");

            var caminhoSalvar = Console.ReadLine();

            using (var arquivo = new StreamWriter(caminhoSalvar))
            {
                arquivo.Write(texto);
            }
            Console.WriteLine($"Arquivo {caminhoSalvar} salvo com sucesso!");
            Console.ReadKey();
            Menu();

        }
    }
}
