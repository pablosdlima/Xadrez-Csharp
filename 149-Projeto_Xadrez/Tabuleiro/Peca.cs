using _149_Projeto_Xadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Tabuleiro
{
    class Peca
    {

        public int QteMovimentos { get; set; }
        public Cor Cor { get; set; } //associação da ENUM Cor
        public Posicao Posicao { get; set; } //associação da classe Posicao
        public mdTabuleiro Tabuleiro { get; set; } //associação da classe Tabuleiro

        public Peca()
        {

        }

        public Peca(Cor cor, Posicao posicao, mdTabuleiro tabuleiro)
        {
            int qteMovimentos = 0;
            QteMovimentos = qteMovimentos;
            Cor = cor;
            Posicao = posicao;
            Tabuleiro = tabuleiro;
        }
    }
}
