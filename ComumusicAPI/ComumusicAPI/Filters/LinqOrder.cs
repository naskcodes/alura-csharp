using ComumusicAPI.Models;
using System.Collections.Concurrent;

namespace ComumusicAPI.Filters;

internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados:");
        
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"Artista: {artista}");
        }
    }
}
