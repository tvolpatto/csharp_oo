Genero genero1 = new();
genero1.Nome = "Pop";   

Musica musica1 = new();
musica1.Nome = "Shape of You";
musica1.Artista = "Ed Sheeran";
musica1.Duracao = 240;  
musica1.Disponivel = true;
musica1.Genero = genero1;

Musica musica2 = new();
musica2.Nome = "Perfect";
musica2.Artista = "Ed Sheeran";
musica2.Duracao = 263;
musica2.Disponivel = false;
musica2.Genero = genero1;

Album album1 = new();
album1.Nome = "Divide";     
album1.Artista = "Ed Sheeran";
album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
album1.ExibirMusicasDoAlbum();        
