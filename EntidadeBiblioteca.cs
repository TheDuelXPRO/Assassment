using System;

namespace FilmesBiblioteca{
    public class Filmes{
        public string NomeFilme { get; set; }
        public DateTime DataLancamento { get; set; }
        public int FaixaEtaria { get; set; }
        public Guid ID { get; set; }
        public bool DisponivelLocacao { get; set; }
        
    }
    public Filme(string nomeFilme, DateTime dataLancamento, bool disponivelLocacao, int faixaEtaria){
        NomeFilme = nomeFilme;
        DataLancamento = dataLancamento;
        DisponivelLocacao = disponivelLocacao;
        FaixaEtaria = faixaEtaria;
        ID = Guid.NewGuid();
    }

    public void MostrarFilme(){
        Console.WriteLine("Informações do filme:");
        Console.WriteLine($"Nome do filme: {NomeFilme}");
        Console.WriteLine($"Data de lançamento do filme: {Datalancamento}");
        Console.WriteLine($"Filme disponível para locação: {DisponivelLocacao}");
        Console.WriteLine($"Faixa etária do filme: {FaixaEtaria}");
    }
}