using _149_Projeto_Xadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Tabuleiro
{
    abstract class Peca
    {

        public int qteMovimentos { get; set; }
        public Cor cor { get; set; } //associação da ENUM Cor
        public Posicao posicao { get; set; } //associação da classe Posicao
        public mdTabuleiro tabuleiro { get; set; } //associação da classe Tabuleiro

        public Peca()
        {

        }

        public Peca(mdTabuleiro tabuleiro, Cor cor)
        {
            this.qteMovimentos = qteMovimentos;
            this.cor = cor;
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tabuleiro.NLinhas; i++)
            {
                for (int j = 0; j < tabuleiro.NColunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
