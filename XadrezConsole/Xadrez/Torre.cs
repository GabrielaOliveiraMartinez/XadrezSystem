﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro, cor)
        {
            
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
