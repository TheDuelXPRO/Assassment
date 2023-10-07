using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesBiblioteca
{
    public class Programa 
    {
        private static IFilmesRepositorio? repositorio1;
        private static IFilmesRepositorio? repositorio2;
        
        public static void Main(String[] args)
        {
            var repositorio = new Funcao();
            String escolha1;
            String escolha2;


                Console.WriteLine("Escolha o tipo de salvamento: ");
                Console.WriteLine("[1] - Arquivo txt");
                Console.WriteLine("[2] - Em Lista ");
                Console.WriteLine("-------------------------------");

                escolha1 = Console.ReadLine();

                switch (escolha1)
                {
                    case "1":
                    Console.WriteLine("Em Arquivo txt");
                    Console.WriteLine("-------------------------------");
                    var repositorio1 = new FuncaoText();
                    break;
                    case "2":
                    Console.WriteLine("Em lista escolhido");
                    Console.WriteLine("-------------------------------");
                    var repositorio2 = new Funcao();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(1500);
                        Console.Clear();
                    break;
                }
                 while (true)
                {
                Console.WriteLine("Escolha umas das opções abaixo: ");
                Console.WriteLine("[1] - Procurar Filme");
                Console.WriteLine("[2] - Incluir Filme");
                Console.WriteLine("[3] - Editar Filme");
                Console.WriteLine("[4] - Excluir Filme");
                Console.WriteLine("[5] - Sair desse menu");
                Console.WriteLine("-------------------------------");

                escolha2 = Console.ReadLine();
                switch (escolha2)
                {
                    case "1":
                        if(escolha1 == "1")
                        {
                            
                        }
                        else if(escolha1 == "2")
                        {
                            Console.Write("Pesquisar filme: ");
                            var PequisarFilme = Console.ReadLine();
                            var FilmesEncontrados = repositorio.ConsultarFilme(PequisarFilme);

                            Console.WriteLine("Filmes encontrados:");
                            Console.WriteLine("-------------------------------");
                            for (int i = 0; i < FilmesEncontrados.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {FilmesEncontrados[i].NomeFilme}");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Selecionar Filme para mais informações");
                            }
                            var SelecionarFilme = int.Parse(Console.ReadLine());
                            Filme FilmeSelecionado = null;
                            if (SelecionarFilme > 0 && SelecionarFilme <= FilmesEncontrados.Count)
                            {
                                FilmeSelecionado = FilmesEncontrados[SelecionarFilme - 1];
                                repositorio.MostrarFilme(FilmeSelecionado);
                            }
                        }
                        break;
                    case "2":
                        if (escolha1 == "1")
                        {

                        }
                        else if (escolha1 == "2")
                        {
                            Console.WriteLine("Nome do filme: ");
                            var nomeFilme = Console.ReadLine();
                            Console.WriteLine("Data de lançamento (yyyy-MM-dd): ");
                            var dataLancamento = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Disponivel para locação (true/false): ");
                            var disponivelLocacao = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Faixa etaria do filme: ");
                            var faixaEtaria = int.Parse(Console.ReadLine());

                            var novoFilme = new Filme(nomeFilme, dataLancamento, disponivelLocacao, faixaEtaria);
                            repositorio.AdicionarFilme(novoFilme);
                            Console.WriteLine("Filme incluído com sucesso!");
                            Console.WriteLine("-------------------------------");
                        }
                        break;
                    case "3":
                        if (escolha1 == "1")
                        {
                             
                        }
                        else if (escolha1 == "2")
                        {
                            Console.Write("Pesquisar filme: ");
                            var PequisarFilme = Console.ReadLine();
                            var FilmesEncontrados = repositorio.ConsultarFilme(PequisarFilme);

                            Console.WriteLine("Filmes encontrados:");
                            Console.WriteLine("-------------------------------");
                            for (int i = 0; i < FilmesEncontrados.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {FilmesEncontrados[i].NomeFilme}");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Selecionar Filme para modificação");
                            }
                            var SelecionarFilme = int.Parse(Console.ReadLine());
                            Filme FilmeSelecionado = null;
                            if (SelecionarFilme > 0 && SelecionarFilme <= FilmesEncontrados.Count)
                            {
                                FilmeSelecionado = FilmesEncontrados[SelecionarFilme - 1];
                                repositorio.Modificar(FilmeSelecionado);
                                Console.WriteLine("Filme modificado com sucesso!");
                                Console.WriteLine("-------------------------------");
                            }
                        }
                        break;
                    case "4":
                        if (escolha1 == "1")
                        {
                            
                        }
                        else if (escolha1 == "2")
                        {
                            Console.Write("Pesquisar filme: ");
                            var PequisarFilme = Console.ReadLine();
                            var FilmesEncontrados = repositorio.ConsultarFilme(PequisarFilme);

                            Console.WriteLine("Filmes encontrados:");
                            Console.WriteLine("-------------------------------");
                            for (int i = 0; i < FilmesEncontrados.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {FilmesEncontrados[i].NomeFilme}");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("Selecionar Filme para exclusão");
                            }
                            var SelecionarFilme = int.Parse(Console.ReadLine());
                            Filme FilmeSelecionado = null;
                            if (SelecionarFilme > 0 && SelecionarFilme <= FilmesEncontrados.Count)
                            {
                                FilmeSelecionado = FilmesEncontrados[SelecionarFilme - 1];
                                repositorio.ExcluirFilme(FilmeSelecionado);
                                Console.WriteLine("Filme excluído com sucesso!");
                                Console.WriteLine("-------------------------------");
                            }
                        }
                        break;
                    case "5":
                        return;
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
            }
            }
        }
    }
}