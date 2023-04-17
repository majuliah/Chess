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
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);
        }
    }
}