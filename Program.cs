// Genero genero1 = new("Pop");

// Banda banda1 = new("Ed Sheeran");

// Musica musica1 = new(banda1, "Shape of You", genero1)
// {
//     Duracao = 240,
//     Disponivel = true,
// };
    



// Musica musica2 = new(banda1, "Perfect", genero1)
// {
//     Duracao = 263,
//     Disponivel = false,
// };

// Album album1 = new( "Divide");
  
// album1.Artista = "Ed Sheeran";
// album1.AdicionarMusica(musica1);
// album1.AdicionarMusica(musica2);


// banda1.AdicionarAlbum(album1);
// banda1.ExibirDiscografia(); 

Episodios episodios1 = new(1, "Descrição do episódio 1", 30);
episodios1.AdicionarConvidado("Convidado 1");
episodios1.AdicionarConvidado("Convidado 2");


Episodios episodios2 = new(2, "Descrição do episódio 2", 45);
episodios2.AdicionarConvidado("Convidado 3");
episodios2.AdicionarConvidado("Convidado 4");


Podcast podcast = new("Nome do Podcast", "Host do Podcast");
podcast.AdicionarEpisodio(episodios1);
podcast.AdicionarEpisodio(episodios2);
podcast.ExibirEpisodios();
