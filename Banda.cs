class Banda
{
    public string Nome { get; set; }
    private List<Album> albums = new List<Album>();

   public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

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