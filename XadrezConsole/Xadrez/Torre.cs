using System;
using System.Collections.Generic;
using System.Text;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez
{
    class Torre : Peca
    {
        public Torre(XadrezConsole.Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}