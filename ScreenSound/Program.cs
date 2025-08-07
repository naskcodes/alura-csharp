using Comumusic.Menus;
using Comumusic.Models;

Banda idris = new Banda("Idris Elba");
idris.AdicionarNota(new Avaliacao(10));
idris.AdicionarNota(new Avaliacao(2));
idris.AdicionarNota(new Avaliacao(7));
Banda pink = new("Pink Floyd");

Dictionary<string, Banda> bandasRegistrados = new();
bandasRegistrados.Add(idris.Nome, idris);
bandasRegistrados.Add(pink.Nome, pink);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistraAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(7, new MenuAvaliarMusica());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗██╗░░░██╗███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██╔══██╗████╗░████║██║░░░██║████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██║░░╚═╝██║░░██║██╔████╔██║██║░░░██║██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██║░░██╗██║░░██║██║╚██╔╝██║██║░░░██║██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
╚█████╔╝╚█████╔╝██║░╚═╝░██║╚██████╔╝██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░
");
    Console.WriteLine("Boas vindas ao Comumusic 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 6 para avaliar um álbum");
    Console.WriteLine("Digite 7 para avaliar uma música");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibir = opcoes[opcaoEscolhidaNumerica];
        menuExibir.Executar(bandasRegistrados);
        if(opcaoEscolhidaNumerica > 0)
        {
            ExibirOpcoesDoMenu();
        }
    } 
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();