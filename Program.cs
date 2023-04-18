using System;
using tabuleiro;
using xadrez;
using static System.Console;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.finalizada)
                {
                    try
                    { 
                        Clear();    
                        Tela.ImprimirPartida(partida);
                        Write($"");
                        Write($"Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();
                        
                        Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);
                        
                        Write($"");
                        Write($"Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        
                        partida.ValidarPosicaoDestino(origem, destino);
                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException exception)
                    {
                        WriteLine(exception.Message);
                        ReadLine();
                    }
                }
                Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (TabuleiroException exception)
            {
                WriteLine(exception.Message);
            }
        }
    }
}