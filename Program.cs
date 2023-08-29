using ScreenSound_2.Modelos;
using System.Text.Json;
using ScreenSound_2.Filtros;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.Clear();
        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[1].ExibirDetalhesDaMusica();  
        //LinqFilter.FiltrarTodosOsGenerosMusicas(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasPeloAno(musicas,  2020);

        // var MusicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        // MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        // MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[5]);
        // MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[8]);
        // MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1914]);
        // MusicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1993]);

        //MusicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        // var MusicasPreferidasDoHenrique = new MusicasPreferidas("Henrique");
        // MusicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[10]);
        // MusicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[93]);
        // MusicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[300]);
        // MusicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[1945]);
        // MusicasPreferidasDoHenrique.AdicionarMusicasFavoritas(musicas[1974]);

        // MusicasPreferidasDoHenrique.ExibirMusicasFavoritas();

        // MusicasPreferidasDoHenrique.GerarArquivoJson();
        // MusicasPreferidasDoHenrique.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}