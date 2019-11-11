using System;
using System.Collections.Generic;
using System.Text;

namespace XadrezConsole.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
