Banda banda = new Banda("Rodolfo Abrantes");

Album album = new Album("RABT");

Musica musica1 = new Musica(banda, "Sujo e Descalço")
{
    Duracao = 240,
    Disponivel = true
};

Musica musica2 = new Musica(banda, "Isaías 9")
{
    Duracao = 720,
    Disponivel = false
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
banda.AdicionarAlbum(album);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album.ExibirMusicasDoAlbum();
banda.ExibirDiscografia();