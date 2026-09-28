class Album
{

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public string Artista { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
        
    }
   
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    /* Display the information of the album, including name, artist, total duration, and the list of songs */
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Álbum: {Nome} ");
        
        Console.WriteLine($"Duração total: {DuracaoTotal} segundos\n");
        Console.WriteLine("Músicas do álbum:");
        foreach (var musica in musicas)
        {
            musica.ExibirInformacoes();
            
        }
    }
}

  