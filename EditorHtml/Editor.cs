using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show(){
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("____________");
            Inicio();
        }

        public static void Inicio()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("--------------");
            Console.WriteLine("\nDeseja salvar o arquivo?");
            Visualizador.Show(arquivo.ToString());
            
        }
    }
}
