using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tabuleiro { get; protected set; }

        public Peca( Tabuleiro tabuleiro ,Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qteMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
