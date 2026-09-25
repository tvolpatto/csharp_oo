class Musica
{
  
    public string Nome {get; set;}
    
    public string Artista{get; set;}

    public int Duracao{get; set;}

    public bool Disponivel{get; set;}

    public string Descricao =>  $"{Artista} - {Nome}";
   
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if(Disponivel)
        {
            Console.WriteLine("A música está disponível para reprodução.");
        }
        else
        {
            Console.WriteLine("A música não está disponível para reprodução.");
        }
       
    }
}

