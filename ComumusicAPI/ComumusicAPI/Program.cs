using ComumusicAPI.Models;
using System.Text.Json;
using ComumusicAPI.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesMusica();
        //LinqFilter.FiltrarGenerosMusicais(musicas);
        //LinqOrder.ExibirListaArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasGenerosMusicais(musicas, "pop");
        //LinqFilter.FiltrarMusicasArtista(musicas, "The Strokes");

        //var musicasPreferidas = new MusicasPreferidas("Preferidas");

        //musicasPreferidas.AdicionarFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarFavoritas(musicas[28]);
        //musicasPreferidas.AdicionarFavoritas(musicas[97]);
        //musicasPreferidas.AdicionarFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarFavoritas(musicas[543]);
        //musicasPreferidas.AdicionarFavoritas(musicas[129]);
        //musicasPreferidas.AdicionarFavoritas(musicas[32]);

        //musicasPreferidas.ExibirFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        LinqFilter.FiltrarTonalidadeMusicas(musicas, "C#");
    }
    catch (Exception ex)
    { 
        Console.WriteLine($"Houston, temos um problema. Erro: {ex.Message}");
    }
}