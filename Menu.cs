using System;
using System.Collections.Generic;

namespace FilmesBiblioteca{
	public class Menu : IFilmesFuncao{
		public void menu(){
			Console.WriteLine("Escolha o tipo de salvamento: ");
			Console.WriteLine("[1] - Arquivo txt");
			Console.WriteLine("[2] - Memoria ");
			Console.Write("-------------------------------");

			string escolha = Console.ReadLine();

			switch (escolha){
				case 1:

			}
		}
	}
}