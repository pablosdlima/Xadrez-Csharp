using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Xadrez
{
    class PartidaDeXadrez
    {
        public mdTabuleiro tab { get; private set;}
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new mdTabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            terminada = false;
            ColocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
           Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if(tab.Peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de Origem escolhida!");
            }
            if (jogadorAtual != tab.Peca(pos).cor)
            {
                throw new TabuleiroException("Esta peça não é sua!");
            }
            if (!tab.Peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Nenhum movimento Possivel para essa peça.");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.Peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branco)
            {
                jogadorAtual = Cor.Preto;
            }
            else
            {
                jogadorAtual = Cor.Branco;
            }
        }

        private void ColocarPecas()
        {       
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c',1).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c',2).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('d',2).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e',2).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e',1).toPosicao()); //add peça em
            tab.colocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d',1).toPosicao()); //add peça em

            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c',8).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c',7).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('d',7).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e',7).toPosicao()); //add peça em
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e',8).toPosicao()); //add peça em
            tab.colocarPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('d',8).toPosicao()); //add peça em

        }


    }
}
