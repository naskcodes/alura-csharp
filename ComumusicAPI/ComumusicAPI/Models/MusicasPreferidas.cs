using System.Text.Json;

namespace ComumusicAPI.Models;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas { get; }

    public MusicasPreferidas( string nome)
    {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarFavoritas(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }

    public void ExibirFavoritas()
    {
        Console.WriteLine($"Essas são as mais queridas de {Nome}");

        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($"Música: {musica.Nome} - {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"Json criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }
}
