using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    public class Tabuleiro
    {

        Casa grafo = new Casa();

        #region criar_Tabuleiro
        public Tabuleiro() {

            Graph<int> graph = new Graph<int>(grafo.vertices, grafo.edges);
            Algorithms algorithms = new Algorithms();
            #endregion
        }

        public static void desenhaTabuleiro(Graphics g)
        {
            Bitmap tabuleiro = new Bitmap("../../Imagens/tabuleiro2.png");
            g.DrawImage(tabuleiro, 0, 0);
        }

    }
}
