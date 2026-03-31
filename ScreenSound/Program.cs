Musica musica1 = new Musica();
musica1.Artista = "Rodolfo Abrantes";
musica1.Nome = "Sujo e Descalço";
musica1.Duracao = 240;
musica1.Disponivel = true;
musica1.Genero = new Genero();
musica1.Genero.Nome = "Rock";

Musica musica2 = new Musica();
musica2.Artista = "Rodolfo Abrantes";
musica2.Nome = "Isaías 9";
musica2.Duracao = 720;
musica2.Disponivel = true;
musica2.Genero = new Genero();
musica2.Genero.Nome = "Gospel";

Album album = new Album();
album.Nome = "RABT";

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

album.ExibirMusicasDoAlbum();