using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Xadrez
{
    class PosicaoXadrez
    {
        public char PxColuna { get; set; }
        public char PxLinha { get; set; }

        public PosicaoXadrez(char pxColuna, char pxLinha)
        {
            PxColuna = pxColuna;
            PxLinha = pxLinha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - PxLinha, PxColuna - 'a');
        }

        public override string ToString()
        {
            return " " + PxColuna + PxLinha;
        }//retorna em texto. metodo tostring
    }
}
