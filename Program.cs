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
                    Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    
                    Write($"Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    Write($"Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                    
                    partida.ExecutaMovimento(origem, destino);
                }
                
            }
            catch (TabuleiroException exception)
            {
                WriteLine(exception.Message);
                throw;
            }

        }
    }
}