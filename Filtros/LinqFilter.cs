
using ScreenSound_2.Modelos;
namespace ScreenSound_2.Filtros;

internal class LinqFilter
{
  public static void FiltrarTodosOsGenerosMusicas(List<Musica> musicas)
  {
    var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
    foreach(var genero in todosOsGenerosMusicais)
    {
      Console.WriteLine($"- {genero}");
    }
  }

  public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
  {
    var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
    Console.WriteLine(nomeDoArtista);
    foreach (var musica in musicasDoArtista)
    {
      Console.WriteLine($"- {musica.Nome}");
    }
  }

  public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
  {
    var musicasDoAno = musicas
    .Where(musica => musica.Ano == ano)
    .OrderBy(musicas => musicas.Nome)
    .Select(musicas => musicas.Nome)
    .Distinct()
    .ToList();

    Console.WriteLine($"Músicas de {ano}");
    foreach (var musica in musicasDoAno)
    {
      Console.WriteLine($"- {musica}");
    }
  }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
       var FiltrarMusicasEmCSharp = musicas
       .Where(musica => musica.Tonalidade.Equals("C#"))
       .Select(musica => musica.Nome) //pegar o nome das musicas
       .ToList();
      Console.WriteLine("Músicas em C#: ");
      foreach (var musica in FiltrarMusicasEmCSharp)
      {
        Console.WriteLine($"- {musica}");
      }
    }
}