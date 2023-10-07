using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesBiblioteca
{
    public class Filme
    {
        public String NomeFilme { get; set; }
        public DateTime DataLancamento { get; set; }
        public int FaixaEtaria { get; set; }
        public Guid ID { get; set; }
        public bool DisponivelLocacao { get; set; }
        public Filme(string nomeFilme, DateTime dataLancamento, bool disponivelLocacao, int faixaEtaria)
        {
            NomeFilme = nomeFilme;
            DataLancamento = dataLancamento;
            DisponivelLocacao = disponivelLocacao;
            FaixaEtaria = faixaEtaria;
            ID = Guid.NewGuid();
        }
    }
    }