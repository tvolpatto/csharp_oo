class Podcast
{
    public string Nome { get; }
    public string Host { get; }

    private List<Episodios> episodios = new List<Episodios>();

    public int numeroEpisodios => episodios.Count;

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    /* Add an episode to the podcast's list of episodes */
    public void AdicionarEpisodio(Episodios episodio)
    {
        episodios.Add(episodio);
    }

    /* Display the information of the podcast, including name, host, number of episodes, and the list of episodes */
    public void ExibirEpisodios()
    {
        Console.WriteLine($"Podcast: {Nome} - Host: {Host}");
        Console.WriteLine($"Número de episódios: {numeroEpisodios}\n");
        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
            Console.WriteLine();
        }
    }
}