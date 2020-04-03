using _149_Projeto_Xadrez.tabuleiro;
using _149_Projeto_Xadrez.Tabuleiro;
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
            mdTabuleiro tabuleiro = new mdTabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);

            Console.ReadLine();


        }
    }
}
