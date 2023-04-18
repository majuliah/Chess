using System;
using System.Collections.Generic;
using static System.Console;
using tabuleiro;
using xadrez;

namespace xadrez
{
    public class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.tab);
            WriteLine();
            ImprimirPecasCapturadas(partida);
            WriteLine($"Turno: {partida.turno}");
            WriteLine($"Aguardando jogada: {partida.jogadorAtual}");

            if (partida.xeque)
            {
                WriteLine($"XEQUE!");
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            WriteLine($"Peças capturadas:");
            WriteLine($"Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            WriteLine();
            WriteLine($"Pretas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
        }

        static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Write($"[");
            foreach (Peca x in conjunto)
            {
                Write($"{x} ");
            }
            Write($"]");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int linhas = 0; linhas < tab.linhas; linhas++)
            {
                Write($"{8 - linhas}   ");
                for (int colunas = 0; colunas < tab.colunas; colunas++)
                {
                    ImprimirPeca(tab.peca(linhas, colunas));
                }

                WriteLine(" ");
            }

            WriteLine($"    a b c d e f g h");
        }        
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkCyan;
            
            for (int linhas = 0; linhas < tab.linhas; linhas++)
            {
                Write($"{8 - linhas}   ");
                for (int colunas = 0; colunas < tab.colunas; colunas++)
                {
                    if (posicoesPossiveis[linhas,colunas])
                    {
                        BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(linhas, colunas));
                    BackgroundColor = fundoOriginal;
                }
                WriteLine(" ");
            }
            WriteLine($"    a b c d e f g h");
            BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + " ");
            return new PosicaoXadrez(coluna, linha);
        }


        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
                Write("- ");
            else
            {
                if (peca.cor == Cor.Preta)
                {
                    ConsoleColor auxiliar = ForegroundColor;
                    ForegroundColor = ConsoleColor.Magenta;
                    Write(peca);
                    ForegroundColor = auxiliar;
                }
                else if (peca.cor == Cor.Azul)
                {
                    ConsoleColor auxiliar = ForegroundColor;
                    ForegroundColor = ConsoleColor.Blue;
                    Write(peca);
                    ForegroundColor = auxiliar;
                }
                else if (peca.cor == Cor.Amarela)
                {
                    ConsoleColor auxiliar = ForegroundColor;
                    ForegroundColor = ConsoleColor.Yellow;
                    Write(peca);
                    ForegroundColor = auxiliar;
                }
                else
                    Write(peca);
            }
        }
    }
}