using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
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
                Console.Write(8 - i + " ");
                for(int j = 0; j < tabuleiro.NColunas; j++) {
                    if(tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("----  ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write("");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("   a     b     c     d     e     f     g     h");
        }//metodo para imprimir tabuleiro na tela

        public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
