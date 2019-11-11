using System;
using System.Collections.Generic;
using System.Text;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez
{
    class Rei : Peca
    {
        public Rei(XadrezConsole.Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
