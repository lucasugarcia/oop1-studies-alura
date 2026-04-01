class Podcast
{
    public string Host { get; }
    public string Nome { get; }

    private List<Episodio> episodios = new List<Episodio>();
    public int TotalEpisodios => episodios.Count;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} - Host: {Host}");

        foreach(var episodio in episodios.OrderBy(e => e.Ordem))
            Console.WriteLine($"{episodio.Resumo}");

        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}