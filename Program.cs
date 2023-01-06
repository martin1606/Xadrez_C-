using tabuleiro;
using System;
using xadrez;

namespace _12ChessGameConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Tabuleiro tab = new Tabuleiro(8, 8);
				tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(1, 2));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(3, 2));
                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
			}
			catch (TabuleiroException e)
			{
				Console.WriteLine(e.Message);
                Console.ReadLine();
            }
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}

        }
    }
}