Menu();

static void Menu()
{
    Console.WriteLine("\n!!CRONOMETRO!!\n");
    Console.WriteLine("\nEscolha uma opção:\n(S) para Segundos\n(M) para Minutos\n(0) para Sair.");
    string valor = Console.ReadLine();
    char tipo = char.Parse(valor.Substring(valor.Length-1,1).ToLower());
    int tempo = int.Parse(valor.Substring(0,valor.Length - 1));
    app(tempo, tipo);


}

static void app(int tempo, char tipo)
{
    int mult = 1;
    int contagem = 0;

    if(tipo == 'm')
    {
        mult = 60;
        tempo *= mult;
    }
    if (tempo == 0)
    {
        System.Environment.Exit(0);
    }

    while (contagem != tempo)
    {
        Console.Clear();
        contagem++;
        Console.WriteLine(contagem);
        Thread.Sleep(1000);
    }
    
}

