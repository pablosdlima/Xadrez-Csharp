using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.tabuleiro
{
    class mdTabuleiro
    {
        public int NLinhas { get; set; }
        public int NColunas { get; set; }
        private Peca[,] pecas; //matriz do tipo associado 'Peca' / só a classe tabuleiro mexe(private)

        public mdTabuleiro(int nLinhas, int nColunas)
        {
            NLinhas = nLinhas;
            NColunas = nColunas;
            pecas = new Peca[nLinhas, nColunas]; //instancia da matriz associada Peca.
        }

        public Peca Peca(int nLinhas, int nColunas) //metodo para exibir propriedade privada.
        {
            return pecas[nLinhas, nColunas];
        }

        public Peca Peca(Posicao pos)//sobrecarga no metodo peca.
        {
            return pecas[pos.Linha, pos.Coluna];

        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }

            pecas[pos.Linha, pos.Coluna] = p; //joga a peça P na posição indicada.
            p.posicao = pos; //posição de p = pos
        }

        public Peca retirarPeca(Posicao pos)
        {
            if(Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return Peca(pos) != null;
        }//verifica se a peça existe em determinada posição.

        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= NLinhas || pos.Coluna < 0 || pos.Coluna >= NColunas)
            {
                return false;
            }
            return true;
        }//testa a posição se é valida e retorna ao metodo acima.

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }//cria a exceção caso o metodo posicaoValida for false.
    }
}
