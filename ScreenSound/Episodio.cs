class Episodio
{
    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }

    private List<string> convidados = new List<string>();
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao} minutos) - {string.Join(", ", convidados)}";

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}