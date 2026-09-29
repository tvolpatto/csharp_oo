class Episodios
{
    public int Numero { get; }
    public string Nome { get;  }
    public int Duracao { get;  }    

    private List<string> convidados = new List<string>();

    public string Resumo => $"Episódio {Numero}: {Nome} - Duração: {Duracao} minutos. \nConvidados: {string.Join(", ", convidados)}.";

    public Episodios(int numero, string nome, int duracao)
    {
        Numero = numero;
        Nome = nome;
        Duracao = duracao;
      
    }
    /* Add a guest to the episode's list of guests */   
    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}