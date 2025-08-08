using Comumusic.Models;

namespace Comumusic.Menus;

internal class MenuAvaliarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar música");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {

                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write("Qual música você quer avaliar?");
                string musicaEscolhida = Console.ReadLine()!;
                Musica musica = album.Musicas.First(m => m.Nome.Equals(musicaEscolhida));
                Console.Write($"Qual a nota que a música {musica} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                musica.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a música {musica}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA música não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}