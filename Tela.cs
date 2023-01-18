using System;
using System.Security.Cryptography.X509Certificates;
using tabuleiro;
using xadrez;

namespace _12ChessGameConsole
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine($"  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] possicoesPossiveis)
        {
            ConsoleColor original = Console.BackgroundColor;
            ConsoleColor altered = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (possicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = altered;
                    }
                    else
                    {
                        Console.BackgroundColor = original;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = original;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"  a b c d e f g h");
            Console.BackgroundColor = original;
        }
        public static void imprimirPeca(Peca peca)
        {

            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branco)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
