using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

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
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo de mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[]) array.Clone();

    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho/2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

    Console.WriteLine($"Com base na amostra a mediana é igual {mediana}");
}

//TestaMediana(amostra);

//int[] valores = {10, 58, 36, 47};

//for (int i = 0;  i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}

void TestaArrayContasCorrentes()
{
    ListaContasCorrentes listaContas = new ListaContasCorrentes();
    listaContas.Adicionar(new ContaCorrente(874));
    listaContas.Adicionar(new ContaCorrente(875));
    listaContas.Adicionar(new ContaCorrente(876));
    listaContas.Adicionar(new ContaCorrente(877));
    listaContas.Adicionar(new ContaCorrente(878));
    listaContas.Adicionar(new ContaCorrente(879));

    var contaAndre = new ContaCorrente(880);

    listaContas.Adicionar(contaAndre);
    //listaContas.ExibeLista();
    //listaContas.Remover(contaAndre);
    //listaContas.ExibeLista();

    //for (int i = 0; i < listaContas.Tamanho; i++)
    //{
    //    ContaCorrente conta = listaContas[i];
    //}

    for (int i = 0; i < listaContas.Tamanho; i++)
    {
        ContaCorrente conta = listaContas[i];
        Console.WriteLine($"Indíce[{i}]");
    }
}

TestaArrayContasCorrentes();