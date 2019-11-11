using System;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jogo de xadrez");

            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
