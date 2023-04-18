namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantidadeMovimentos = 0;
        }
        
        public void IncrementoQtdeMovimentos()
        {
            quantidadeMovimentos++;
        }        
        public void DecrementoQtdeMovimentos()
        {
            quantidadeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int linha = 0; linha < tab.linhas; linha++)
            {
                for (int coluna = 0; coluna < tab.colunas; coluna++)
                {
                    if (mat[linha, coluna])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}