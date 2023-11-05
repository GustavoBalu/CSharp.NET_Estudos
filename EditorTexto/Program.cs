using System.Collections;

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
            Console.WriteLine("Digite o caminho para o arquivo:");

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

        }

        static void SalvarArquivo()
        {

        }
    }
}
