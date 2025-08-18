using System.Text.Json.Serialization;

namespace ComumusicAPI.Models;

internal class Musica
{
    //Correção Desafio #1: Segue como feito pelos instrutores
    private string[] tons = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    public int Tom { get; set; }
    //Correção Desafio #1: Segue como feito pelos instrutores
    public string Tonalidade
    {
        get
        {
            return tons[Tom];
        }
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em milisegundos:  {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tom: {Tonalidade}");
    }
}