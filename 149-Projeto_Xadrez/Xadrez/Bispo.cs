using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Xadrez
{
    class Bispo : Peca
    {
        public Bispo(mdTabuleiro tab, Cor cor) : base (tab, cor)
        {

        }

        public override string ToString()
        {
            return "B";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.Peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.NLinhas, tabuleiro.NColunas];

            Posicao pos = new Posicao(0, 0);

            //NO
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //SE
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //SO
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;
        }
    }
}
