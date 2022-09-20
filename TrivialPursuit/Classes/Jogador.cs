using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    
    public class Jogador
    {
        public int direcao;
        static string dataPath = "../../Imagens/";
        public int num_jogador;

        Casa grafo = new Casa();
        public int casa = 1;

        public int respCorretas;
        public int respDadas;
        public string nome;
        public int num_categAcertadas;
        public Casa.Cor[] categAcertadas = new Casa.Cor[6];
        public int desenhoPos_x, desenhoPos_y;

        public int posX;
        public int posY;

        public int posX_mira;
        public int posY_mira;

        //construtor
        public Jogador()
        {
            direcao = 1;
            num_categAcertadas = 0;
            if (casa == grafo.vertices[0])
            {
                posX = 295;
                posY = 200;
            }

            respCorretas = 0;
            respDadas = 0;
            nome = "";

            for (int i = 0; i < 6; i++)
            {
                categAcertadas[i] = Casa.Cor.Branco;
            }
        }

        public static void desenhaTriangulo(Graphics g,int num_jogador)
        {
            Casa.Cor cor;
            for (int i = 0; i < 6; i++)
            {
                cor = Jogo.jogador[num_jogador].categAcertadas[i];
                switch (cor)
                {
                    case Casa.Cor.Azul: desenhaBitmaps(g, num_jogador, "TrianguloAzul.png", 65, 30);
                        break;
                    case Casa.Cor.Rosa: desenhaBitmaps(g, num_jogador, "TrianguloVermelho.png", 145, 30);
                        break;
                    case Casa.Cor.Verde: desenhaBitmaps(g, num_jogador, "TrianguloVerde.png", 145, 0);
                        break;
                    case Casa.Cor.Amarelo: desenhaBitmaps(g, num_jogador, "TrianguloAmarelo.png", 64, 0);
                        break;
                    case Casa.Cor.Roxo: desenhaBitmaps(g, num_jogador, "TrianguloRoxo.png", 110, 0);
                        break;
                    case Casa.Cor.Laranja: desenhaBitmaps(g, num_jogador, "TrianguloLaranja.png", 105, 30);
                        break;
                    default: break;
                }
            }


        }

        private static void desenhaBitmaps(Graphics g,int num_jogador,string bitmap,int offset_x,int offset_y)
        {
            Bitmap triangulo = new Bitmap(dataPath + bitmap);
            g.DrawImage(triangulo, Jogo.jogador[num_jogador].desenhoPos_x + offset_x, Jogo.jogador[num_jogador].desenhoPos_y + offset_y);
        }

        public static void desenharBoneco(Graphics g, int num_jogador)
        {
            switch (num_jogador) {
                case 0:
                     Bitmap jogador1 = new Bitmap("../../Imagens/boneco1.png");
                     g.DrawImage(jogador1, Jogo.jogador[num_jogador].desenhoPos_x, Jogo.jogador[num_jogador].desenhoPos_y);
                     //desenhaTriangulo(g, num_jogador);
                     escreveTexto(g, num_jogador);
                     break;
                case 1:
                     Bitmap jogador2 = new Bitmap("../../Imagens/boneco2.png");
                     g.DrawImage(jogador2, Jogo.jogador[num_jogador].desenhoPos_x, Jogo.jogador[num_jogador].desenhoPos_y);
                     //desenhaTriangulo(g, num_jogador);
                     escreveTexto(g, num_jogador);
                     break;
                case 2:
                    Bitmap jogador3 = new Bitmap("../../Imagens/boneco3.png");
                    g.DrawImage(jogador3, Jogo.jogador[num_jogador].desenhoPos_x, Jogo.jogador[num_jogador].desenhoPos_y);
                    //desenhaTriangulo(g, num_jogador);
                    escreveTexto(g, num_jogador);
                    break;
                case 3:
                    Bitmap jogador4 = new Bitmap("../../Imagens/boneco4.png");
                    g.DrawImage(jogador4, Jogo.jogador[num_jogador].desenhoPos_x, Jogo.jogador[num_jogador].desenhoPos_y);
                    //desenhaTriangulo(g, num_jogador);
                    escreveTexto(g, num_jogador);
                    break;
            }
        }

        public static void desenhaMira(Graphics g, HashSet<int> n, int num_jogador)
        {
            Bitmap mira = new Bitmap("../../Imagens/proxcasa.png");
            Casa grafo = new Casa();
            foreach (var casa1 in n)
            {
                Jogo.jogador[num_jogador].casa = grafo.vertices[casa1];
                Jogo.converteCasaPos(num_jogador, grafo);
                g.DrawImage(mira, Jogo.jogador[num_jogador].posX, Jogo.jogador[num_jogador].posY);
            }
        }

        public static void desenharJogador(Graphics g, int num_jogador)
        {
            switch (num_jogador)
            {
                case 0: desenharBitmap(g, num_jogador, "jogador1.png");
                    break;
                case 1: desenharBitmap(g, num_jogador, "jogador2.png");
                    break;
                case 2: desenharBitmap(g, num_jogador, "jogador3.png");
                    break;
                case 3: desenharBitmap(g, num_jogador, "jogador4.png");
                    break;
                default: break;
            }
           // desenhaTriangulo(g, num_jogador);
        }

        private static void desenharBitmap(Graphics g, int num_jogador, string bitmap)
        {
            Tabuleiro casas = new Tabuleiro();
            Bitmap jogador = new Bitmap("../../Imagens/" + bitmap);

            g.DrawImage(jogador, Jogo.jogador[num_jogador].posX, Jogo.jogador[num_jogador].posY);

        }

        private static void escreveTexto(Graphics g,int num_jogador)
        {
            Font font = new Font("Britannic", 10, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            SolidBrush pincel = new SolidBrush(Color.White);
            Rectangle area = new Rectangle(
            Jogo.jogador[num_jogador].desenhoPos_x ,Jogo.jogador[num_jogador].desenhoPos_y + 55, 65, 30);
            //Desenha o texto recebe uma string uma fonte um pincel uma area e um formato
            g.DrawString(Jogo.jogador[num_jogador].nome, font, pincel, area, formato);
        }
    }
}
