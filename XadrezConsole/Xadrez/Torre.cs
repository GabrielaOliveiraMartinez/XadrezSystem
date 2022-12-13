using System;
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
        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);

            return p != null || p.cor != cor;

        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] m = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.definirValores(pos.Linha - 1, pos.Coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
                if(tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }

                pos.Linha = pos.Linha - 1;
            }

            //Sul
            pos.definirValores(pos.Linha + 1, pos.Coluna);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }

                pos.Linha = pos.Linha + 1;
            }

            //Leste
            pos.definirValores(pos.Linha , pos.Coluna + 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }

                pos.Coluna = pos.Coluna + 1;
            }

            //Oeste
            pos.definirValores(pos.Linha, pos.Coluna - 1);
            while (tabuleiro.posicaoValida(pos) && podeMover(pos))
            {
                m[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }

                pos.Coluna = pos.Coluna - 1;
            }
            return m;
        }
    }
}
