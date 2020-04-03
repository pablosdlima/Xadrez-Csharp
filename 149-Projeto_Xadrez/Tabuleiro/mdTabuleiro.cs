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
    }
}
