class Musica
{
  
    public string Nome {get; }
    
    public Banda Artista{get; }

    public int Duracao{get; set;}

    public bool Disponivel{get; set;}

    public string Descricao =>  $"{Artista} - {Nome}";

    public Genero Genero { get; }  

    public Musica(Banda artista, string nome, Genero genero)
    {
        Nome = nome;
        Artista = artista;
        Genero = genero;
    }
    
    /* Display the information of the song, including name, artist, duration, genre, and availability */
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        if(Disponivel)
        {
            Console.WriteLine("A música está disponível para reprodução.");
        }
        else
        {
            Console.WriteLine("A música não está disponível para reprodução.");
        }
       
    }
}

