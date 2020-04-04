using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
using _149_Projeto_Xadrez.Xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            mdTabuleiro tabuleiro = new mdTabuleiro(8, 8);//tamanho do tabuleiro.

            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0)); //add peça em
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3)); //add peça em
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4)); //add peça em

            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadLine();


        }
    }
}
