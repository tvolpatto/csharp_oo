Genero genero1 = new("Pop");

Banda banda1 = new("Ed Sheeran");

Musica musica1 = new(banda1, "Shape of You", genero1)
{
    Duracao = 240,
    Disponivel = true,
};
    



Musica musica2 = new(banda1, "Perfect", genero1)
{
    Duracao = 263,
    Disponivel = false,
};

Album album1 = new( "Divide");
  
album1.Artista = "Ed Sheeran";
album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);


banda1.AdicionarAlbum(album1);
banda1.ExibirDiscografia(); 
