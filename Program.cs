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
                Tabuleiro tab = new Tabuleiro(8, 8);
                Tela.ImprimirTabuleiro(tab);
            
                tab.ColocarPeca(new Torre(tab, Cor.Azul), new Posicao(0,0));
                tab.ColocarPeca(new Torre(tab, Cor.Azul), new Posicao(1,3));
                tab.ColocarPeca(new Rei(tab, Cor.Azul), new Posicao(0,9));

            }
            catch (TabuleiroException exception)
            {
                WriteLine(exception.Message);
                throw;
            }

        }
    }
}