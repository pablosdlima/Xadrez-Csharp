using _149_Projeto_Xadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(mdTabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.NLinhas; i++)
            {
                for(int j = 0; j < tabuleiro.NColunas; j++) {
                    if(tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("----  ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.Peca(i,j) + "   ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }//metodo para imprimir tabuleiro na tela
    }
}
