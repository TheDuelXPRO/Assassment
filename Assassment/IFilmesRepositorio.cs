using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesBiblioteca
{
    public interface IFilmesRepositorio 
    {
        void MostrarFilme(Filme filme);
        List<Filme> lista();
        void AdicionarFilme(Filme filme);
        List<Filme> ConsultarFilme(string Pesquisar);
        void ExcluirFilme(Filme filme);
        Filme PesquisarPorId(Guid id);
        void Modificar(Filme filme);
        void AdicionarFilmeText();
    }
}

