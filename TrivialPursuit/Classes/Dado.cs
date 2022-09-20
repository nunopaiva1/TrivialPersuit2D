using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    public static class Dado
    {

        public static void desenharDado(Graphics g,int numero)
        {

            switch (numero)
            {
                case 1:
                    desenharBitmap(g,"dado1.png");
                    break;
                case 2:
                    desenharBitmap(g, "dado2.png");
                    break;
                case 3:
                    desenharBitmap(g, "dado3.png");
                    break;
                case 4:
                    desenharBitmap(g, "dado4.png");
                    break;
                case 5:
                    desenharBitmap(g, "dado5.png");
                    break;
                case 6:
                    desenharBitmap(g, "dado6.png");
                    break;
                default: break;

            }
        }
        private static void desenharBitmap(Graphics g,string nome)
        {
            Bitmap dado = new Bitmap("../../Imagens/" + nome);

            g.DrawImage(dado, 50, 50);
        }
    }
}
