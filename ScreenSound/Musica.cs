class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"{Nome} - {Artista}";

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        
        if (Disponivel)
            Console.WriteLine($"Música disponível");
        else
            Console.WriteLine($"Adquira o plano");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine(DescricaoResumida);
    }
}

