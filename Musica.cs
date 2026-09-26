class Musica
{
  
    public string Nome {get; set;}
    
    public string Artista{get; set;}

    public int Duracao{get; set;}

    public bool Disponivel{get; set;}

    public string Descricao =>  $"{Artista} - {Nome}";

    public Genero Genero { get; set; }  
   
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Gênero: {Genero.Nome}");
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

