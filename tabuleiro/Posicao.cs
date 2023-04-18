namespace tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void DefinirValores(int lin, int col)
        {
            this.linha = lin;
            this.coluna = col;
        }

        public override string ToString()
        {
            return $"{linha}, {coluna}";
        }
    }
}