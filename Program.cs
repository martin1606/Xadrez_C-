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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                    Console.WriteLine();
                    Console.Write("Origem: ");

                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicaoPossivel = partida.tab.peca(origem).movimentosPossiveis();
                    partida.validarPosicaoOrigem(origem);
                    
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicaoPossivel);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Write("Tente novamente...");
                        Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Ação inválida. {e.Message}");
                        Console.Write("Tente novamente...");
                        Console.ReadLine();
                    }
                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}