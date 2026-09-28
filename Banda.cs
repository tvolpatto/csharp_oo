class Banda
{
    public string Nome { get; set; }
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    
        
   /* Add an album to the band's discography */ 
   public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    /* Display the discography of the band, including albums and their respective songs */
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Banda: {Nome}");
        Console.WriteLine("Discografia:\n");
        foreach (Album album in albums)
        {
            album.ExibirMusicasDoAlbum();
           
        }
    }
}