Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 20;
    idades[2] = 50;
    idades[3] = 90;
    idades[4] = 10;

    Console.WriteLine($"Tamanho do Array: {idades.Length}");

    int acumulador = 0;

    for ( int i = 0; i < idades.Length; i++ )
    {
        int idade = idades[i];
        Console.WriteLine($"Idade: {idade}");
        acumulador += idade;
    }

    int media = acumulador/idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscaPalavra()
{
    string[] arrayPalavras = new string[5];

    for (int i = 0; i < arrayPalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayPalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    
    var busca = Console.ReadLine();

    foreach (string palavra in arrayPalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
        else
        {
            Console.WriteLine("Palavra não encontrada");
            break;
        }
    }
}

//TestaArrayInt();
TestaBuscaPalavra();