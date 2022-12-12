using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro,cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
