using System;
using static System.Console;
using tabuleiro;

namespace xadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int linhas = 0; linhas < tab.linhas; linhas++)
            {
                Write($"{8 - linhas}   ");
                for(int colunas = 0; colunas < tab.colunas; colunas++)
                {
                    if(tab.peca(linhas, colunas) ==  null)
                        Write("- ");
                    else
                    {
                        //ImprimirPeca(tabuleiro.peca(linhas, colunas));
                        Write(tab.peca(linhas, colunas));
                        Write(" ");
                    }
                }
                WriteLine(" ");
            }
            WriteLine($"    a b c d e f g h"); 
        }
    }
}