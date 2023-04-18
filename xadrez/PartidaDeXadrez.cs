﻿using tabuleiro;
namespace xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool finalizada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            finalizada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementoQtdeMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }
        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('c',1).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('c',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('d',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('e',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Azul), new PosicaoXadrez('e',1).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Azul), new PosicaoXadrez('d',1).toPosicao());
                
            tab.ColocarPeca(new Torre(tab, Cor.Amarela), new PosicaoXadrez('c',7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarela), new PosicaoXadrez('c',8).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarela), new PosicaoXadrez('d',7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Amarela), new PosicaoXadrez('e',8).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Amarela), new PosicaoXadrez('d',8).toPosicao());
        }
    }
}    