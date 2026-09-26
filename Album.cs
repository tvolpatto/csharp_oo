class Album
{

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Álbum: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração total: {DuracaoTotal} segundos");
        Console.WriteLine("Músicas do álbum:");
        foreach (var musica in musicas)
        {
            musica.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}

  