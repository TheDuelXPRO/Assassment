using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesBiblioteca
{
    public class Funcao
    {
        private List<Filme> lista;
        public Funcao()
        {
            lista = new List<Filme>();
        }
        public void AdicionarFilme(Filme filme)
        {
            lista.Add(filme);
        }
        
        public List<Filme> ConsultarFilme(string Pesquisar)
        {
            return lista.Where(f => f.NomeFilme.Contains(Pesquisar)).ToList();
        }

        public void ExcluirFilme(Filme filme)
        {
            var ExcluirFilme = PesquisarPorId(filme.ID);
            if (ExcluirFilme != null)
            {
                lista.Remove(ExcluirFilme);
            }
        }
        public Filme PesquisarPorId(Guid id)
        {
            return lista.FirstOrDefault(f => f.ID == id);
        }
        public void Modificar(Filme filme)
        {
            var FilmeNoSistema = PesquisarPorId(filme.ID);
            if (FilmeNoSistema != null)
            {
                Console.Write("Nome do filme: ");
                FilmeNoSistema.NomeFilme = Console.ReadLine();

                Console.Write("Data de lançamento do filme (yyyy-MM-dd): ");
                FilmeNoSistema.DataLancamento = DateTime.Parse(Console.ReadLine());

                Console.Write("Filme disponível para locação (true/false): ");
                FilmeNoSistema.DisponivelLocacao = bool.Parse(Console.ReadLine());

                Console.Write("Faixa etária do filme: ");
                FilmeNoSistema.FaixaEtaria = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
            }
        } 
        public void MostrarFilme(Filme filme)
        {
            Console.WriteLine("Informações do filme:");
            Console.WriteLine($"Nome do filme: {filme.NomeFilme}");
            Console.WriteLine($"Data de lançamento do filme: {filme.DataLancamento}");
            Console.WriteLine($"Filme disponível para locação: {filme.DisponivelLocacao}");
            Console.WriteLine($"Faixa etária do filme: {filme.FaixaEtaria}");
            Console.WriteLine("-------------------------------");

        }

    }
}