using ComumusicAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesMusica();
    }
    catch (Exception ex)
    { 
        Console.WriteLine($"Houston, temos um problema. Erro: {ex.Message}");
    }
}