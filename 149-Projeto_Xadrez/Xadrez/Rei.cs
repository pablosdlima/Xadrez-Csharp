using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei(mdTabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) 
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
