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

        public abstract bool[,] MovimentosPossiveis();
    }
}