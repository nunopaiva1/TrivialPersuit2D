using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace TrivialPursuit
{

    public class Casa
    {
        public Casa()
        {
        }

        public int[] vertices = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
        16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
        37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
        58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73};

        public Tuple<int,int>[] edges = {Tuple.Create(1,2), Tuple.Create(1, 49), Tuple.Create(1, 54), Tuple.Create(1, 59),
        Tuple.Create(1, 64), Tuple.Create(1, 69),
        Tuple.Create(2,3), Tuple.Create(3, 4), Tuple.Create(4, 5), Tuple.Create(5, 6),
        Tuple.Create(6, 7), Tuple.Create(7, 8), Tuple.Create(8, 9), Tuple.Create(9, 10), Tuple.Create(10, 11), Tuple.Create(11, 12),
        Tuple.Create(12, 13), Tuple.Create(13, 14), Tuple.Create(14, 15), Tuple.Create(15, 16), Tuple.Create(16, 17), Tuple.Create(17, 18),
        Tuple.Create(18, 19), Tuple.Create(19, 20), Tuple.Create(20, 21), Tuple.Create(21, 22), Tuple.Create(22, 23), Tuple.Create(23, 24),
        Tuple.Create(24, 25), Tuple.Create(25, 26), Tuple.Create(26, 27), Tuple.Create(27, 28), Tuple.Create(28, 29), Tuple.Create(29, 30),
        Tuple.Create(30, 31), Tuple.Create(31, 32), Tuple.Create(32, 33), Tuple.Create(33, 34), Tuple.Create(34, 35), Tuple.Create(35, 36),
        Tuple.Create(36, 37), Tuple.Create(37, 38), Tuple.Create(38, 39), Tuple.Create(39, 40), Tuple.Create(40, 41), Tuple.Create(41, 42),
        Tuple.Create(42, 43), Tuple.Create(43, 44), Tuple.Create(44, 45), Tuple.Create(45, 46), Tuple.Create(46, 47), Tuple.Create(47, 48),
        Tuple.Create(48, 7), Tuple.Create(49, 50), Tuple.Create(50, 51), Tuple.Create(51, 52), Tuple.Create(52, 53), Tuple.Create(53, 14),
        Tuple.Create(54, 55), Tuple.Create(55, 56), Tuple.Create(56, 57), Tuple.Create(57, 58), Tuple.Create(58, 21),
        Tuple.Create(59, 60), Tuple.Create(60, 61), Tuple.Create(61, 62), Tuple.Create(62, 63), Tuple.Create(63, 28),
        Tuple.Create(64, 65), Tuple.Create(65, 66), Tuple.Create(66, 67), Tuple.Create(67, 68), Tuple.Create(68, 35),
        Tuple.Create(69, 70), Tuple.Create(70, 71), Tuple.Create(71, 72), Tuple.Create(72, 73), Tuple.Create(73, 42)};

        public enum Cor
        {
            Rosa,
            Amarelo,
            Azul,
            Verde,
            Laranja,
            Roxo,
            Branco,
            AzulEscuro
        };   
        public int num;
        public int[] casaAdjacente;
        public Cor cor;

        public int[] pos_x;
        public int[] pos_y;

    Point casa1 = new Point(335, 0);
    Point casa2 = new Point(360, 15);
    Point casa3 = new Point(395, 30);
    Point casa4 = new Point(490, 200);
    Point casa5 = new Point(490, 235);
    Point casa6 = new Point(480, 260);

}
}
