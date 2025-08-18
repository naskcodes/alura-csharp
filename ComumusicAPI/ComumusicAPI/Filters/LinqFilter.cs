using ComumusicAPI.Models;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace ComumusicAPI.Filters;

internal class LinqFilter
{

    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var generosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in generosMusicais)
        {
            Console.WriteLine($"Gênero: {genero}");
        }
    }

    public static void FiltrarArtistasGenerosMusicais(List<Musica> musicas, string genero)
    {
        var artistasGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        
        Console.WriteLine($"Artistas filtrados por gênero: {genero}");

        foreach (var artista in artistasGenero)
        {
            Console.WriteLine($"Artista: {artista}");
        }
    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        
        Console.WriteLine($"Artista: {nomeArtista}");

        foreach (var musica in musicasArtista)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }

    public static void FiltrarTonalidadeMusicas(List<Musica> musicas, string tonalidade)
    {
        var musicasTom = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).ToList();

        Console.WriteLine($"Tom: {tonalidade}");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        string json = JsonSerializer.Serialize(musicasTom);
        string nomeArquivo = $"musicas-tonalidade.json";

        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"Json criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
    }
}
