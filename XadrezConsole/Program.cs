using System;
using XadrezConsole.Tabuleiro;
using XadrezConsole.Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                //Console.WriteLine(pos);

                //Console.WriteLine(pos.toPosicao());
                Console.WriteLine("Jogo de xadrez");

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();

                        //Tela.imprimirTabuleiro(partida.tab);
                        //Console.WriteLine();
                        //Console.WriteLine("Turno: " + partida.turno);
                        //Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Tela.imprimirPartida(partida);

                        Console.Write("origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        Tela.imprimirPartida(partida);

                        bool[,] possicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, possicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.imprimirPartida(partida);


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
