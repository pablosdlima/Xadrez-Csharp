﻿using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(mdTabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "C";
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

            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if(tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;

        }
    }
}
