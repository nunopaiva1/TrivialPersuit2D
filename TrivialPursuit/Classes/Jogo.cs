using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using TrivialPursuit.Classes;
using System.Drawing;

namespace TrivialPursuit
{
    public class Jogo
    {
        public static Pergunta[] pergunta = new Pergunta[30];
        public static Jogador[] jogador = new Jogador[4];
        public static List<int> path2 = new List<int>();

        public void NovoJogo()
        {

            Tabuleiro tabuleiro = new Tabuleiro();
            //tabuleiro.desenha();
            Form1 Jogo = new Form1();
            Jogo.Show();
        }

        public static List<T> BFS<T>(Graph<T> graph, T start, int maxDepth, Action<T> preVisit = null)
        {
            var visited = new List<T>();
            var resultado = new List<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
                return visited;

            var queue = new Queue<Tuple<T, int>>();
            // Consider the start is in the depth "0"
            queue.Enqueue(new Tuple<T, int>(start, 0));

            while (queue.Count > 0)
            {
                Tuple<T, int> vertexWithDepth = queue.Dequeue();
                var vertex = vertexWithDepth.Item1;

                if (visited.Contains(vertex))
                    continue;

                if (preVisit != null)
                    preVisit(vertex);

                visited.Add(vertex);

                if (vertexWithDepth.Item2 == maxDepth)
                    resultado.Add(vertex);

                // If the current vertex's level is greater or equals
                // the maximum desired level, skip adding its
                // adjacent vertexes.
                int vertexLevel = vertexWithDepth.Item2;
                if (vertexLevel >= maxDepth)
                    continue;

                foreach (var neighbor in graph.AdjacencyList[vertex])
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(new Tuple<T, int>(neighbor, vertexLevel + 1));
            }

            return resultado;
        }

        public static void andar(int num_jogador, int decisao, int numDado)
        {
            Tabuleiro tab = new Tabuleiro();
            Algorithms algorithms = new Algorithms();

            Casa grafo = new Casa();
            Graph<int> graph = new Graph<int>(grafo.vertices, grafo.edges);
            
            converteCasaPos(num_jogador, grafo);
            
            path2 = BFS(graph, jogador[num_jogador].casa, numDado - 1, v => path2.Add(v));
            Console.WriteLine(string.Join(", ", path2));

            Console.WriteLine("O jogador " + jogador[num_jogador].nome + " esta na casa " + jogador[num_jogador].casa);
            Console.WriteLine("Length of Array " + path2.Count);
            Console.ReadLine();


            //int num = (int)tab.casa[Jogo.jogador[num_jogador].casa].cor;
            //  Pergunta_form novaPergunta = new Pergunta_form(num);
            // novaPergunta.Show();

            //for (i = 1; i <= numDado; i++)
            //Jogo.jogador[num_jogador].casa = tab.casa[Jogo.jogador[num_jogador].casa].casaAdjacente[Jogo.jogador[num_jogador].direcao];
        }

        public static void converteCasaPos(int num_jogador, Casa grafo)
        {
            //CASA 2
            if (jogador[num_jogador].casa == grafo.vertices[1]){
                jogador[num_jogador].posX = 323;
                jogador[num_jogador].posY = 240;
            }
            if (jogador[num_jogador].casa == grafo.vertices[2]){
                jogador[num_jogador].posX = 335;
                jogador[num_jogador].posY = 265;
            }
            if (jogador[num_jogador].casa == grafo.vertices[3]){
                jogador[num_jogador].posX = 349;
                jogador[num_jogador].posY = 290;
            }
            if (jogador[num_jogador].casa == grafo.vertices[4]){
                jogador[num_jogador].posX = 364;
                jogador[num_jogador].posY = 315;
            }
            if (jogador[num_jogador].casa == grafo.vertices[5]){
                jogador[num_jogador].posX = 380;
                jogador[num_jogador].posY = 335;
            }//CASA 7 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[6]){
                jogador[num_jogador].posX = 394;
                jogador[num_jogador].posY = 365;
            }
            if (jogador[num_jogador].casa == grafo.vertices[7]){
                jogador[num_jogador].posX = 423;
                jogador[num_jogador].posY = 347;
            }
            if (jogador[num_jogador].casa == grafo.vertices[8]){
                jogador[num_jogador].posX = 443;
                jogador[num_jogador].posY = 323;
            }
            if (jogador[num_jogador].casa == grafo.vertices[9]){
                jogador[num_jogador].posX = 463;
                jogador[num_jogador].posY = 310;
            }
            if (jogador[num_jogador].casa == grafo.vertices[10]){
                jogador[num_jogador].posX = 470;
                jogador[num_jogador].posY = 287;
            }
            if (jogador[num_jogador].casa == grafo.vertices[11]){
                jogador[num_jogador].posX = 478;
                jogador[num_jogador].posY = 260;
            }
            if (jogador[num_jogador].casa == grafo.vertices[12]){
                jogador[num_jogador].posX = 486;
                jogador[num_jogador].posY = 238;
            }//CASA 14 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[13]){
                jogador[num_jogador].posX = 490;
                jogador[num_jogador].posY = 205;
            }
            if (jogador[num_jogador].casa == grafo.vertices[14]){
                jogador[num_jogador].posX = 487;
                jogador[num_jogador].posY = 165;
            }
            if (jogador[num_jogador].casa == grafo.vertices[15]){
                jogador[num_jogador].posX = 480;
                jogador[num_jogador].posY = 138;
            }
            if (jogador[num_jogador].casa == grafo.vertices[16]){
                jogador[num_jogador].posX = 473;
                jogador[num_jogador].posY = 115;
            }
            if (jogador[num_jogador].casa == grafo.vertices[17]){
                jogador[num_jogador].posX = 460;
                jogador[num_jogador].posY = 90;
            }
            if (jogador[num_jogador].casa == grafo.vertices[18]){
                jogador[num_jogador].posX = 445;
                jogador[num_jogador].posY = 70;
            }
            if (jogador[num_jogador].casa == grafo.vertices[19]){
                jogador[num_jogador].posX = 425;
                jogador[num_jogador].posY = 52;
            }//CASA 21 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[20]){
                jogador[num_jogador].posX = 395;
                jogador[num_jogador].posY = 28;
            }
            if (jogador[num_jogador].casa == grafo.vertices[21]){
                jogador[num_jogador].posX = 360;
                jogador[num_jogador].posY = 17;
            }
            if (jogador[num_jogador].casa == grafo.vertices[22]){
                jogador[num_jogador].posX = 335;
                jogador[num_jogador].posY = 13;
            }
            if (jogador[num_jogador].casa == grafo.vertices[23]){
                jogador[num_jogador].posX = 310;
                jogador[num_jogador].posY = 7;
            }
            if (jogador[num_jogador].casa == grafo.vertices[24]){
                jogador[num_jogador].posX = 285;
                jogador[num_jogador].posY = 7;
            }
            if (jogador[num_jogador].casa == grafo.vertices[25]){
                jogador[num_jogador].posX = 260;
                jogador[num_jogador].posY = 10;
            }
            if (jogador[num_jogador].casa == grafo.vertices[26]){
                jogador[num_jogador].posX = 235;
                jogador[num_jogador].posY = 16;
            }//CASA 28 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[27]){
                jogador[num_jogador].posX = 200;
                jogador[num_jogador].posY = 30;
            }
            if (jogador[num_jogador].casa == grafo.vertices[28]){
                jogador[num_jogador].posX = 170;
                jogador[num_jogador].posY = 53;
            }
            if (jogador[num_jogador].casa == grafo.vertices[29]){
                jogador[num_jogador].posX = 155;
                jogador[num_jogador].posY = 70;
            }
            if (jogador[num_jogador].casa == grafo.vertices[30]){
                jogador[num_jogador].posX = 135;
                jogador[num_jogador].posY = 93;
            }
            if (jogador[num_jogador].casa == grafo.vertices[31]){
                jogador[num_jogador].posX = 120;
                jogador[num_jogador].posY = 114;
            }
            if (jogador[num_jogador].casa == grafo.vertices[32]){
                jogador[num_jogador].posX = 112;
                jogador[num_jogador].posY = 135;
            }
            if (jogador[num_jogador].casa == grafo.vertices[33]){
                jogador[num_jogador].posX = 108;
                jogador[num_jogador].posY = 165;
            }//CASA 35 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[34]){
                jogador[num_jogador].posX = 105;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[35]){
                jogador[num_jogador].posX = 108;
                jogador[num_jogador].posY = 235;
            }
            if (jogador[num_jogador].casa == grafo.vertices[36]){
                jogador[num_jogador].posX = 112;
                jogador[num_jogador].posY = 260;
            }
            if (jogador[num_jogador].casa == grafo.vertices[37]){
                jogador[num_jogador].posX = 125;
                jogador[num_jogador].posY = 285;
            }
            if (jogador[num_jogador].casa == grafo.vertices[38]){
                jogador[num_jogador].posX = 135;
                jogador[num_jogador].posY = 310;
            }
            if (jogador[num_jogador].casa == grafo.vertices[39]){
                jogador[num_jogador].posX = 155;
                jogador[num_jogador].posY = 330;
            }
            if (jogador[num_jogador].casa == grafo.vertices[40]){
                jogador[num_jogador].posX = 170;
                jogador[num_jogador].posY = 345;
            }//CASA 42 QUEIJO
            if (jogador[num_jogador].casa == grafo.vertices[41]){
                jogador[num_jogador].posX = 200;
                jogador[num_jogador].posY = 365;
            }
            if (jogador[num_jogador].casa == grafo.vertices[42]){
                jogador[num_jogador].posX = 235;
                jogador[num_jogador].posY = 380;
            }
            if (jogador[num_jogador].casa == grafo.vertices[43]){
                jogador[num_jogador].posX = 260;
                jogador[num_jogador].posY = 390;
            }
            if (jogador[num_jogador].casa == grafo.vertices[44]){
                jogador[num_jogador].posX = 285;
                jogador[num_jogador].posY = 395;
            }
            if (jogador[num_jogador].casa == grafo.vertices[45]){
                jogador[num_jogador].posX = 310;
                jogador[num_jogador].posY = 395;
            }
            if (jogador[num_jogador].casa == grafo.vertices[46]){
                jogador[num_jogador].posX = 335;
                jogador[num_jogador].posY = 390;
            }
            if (jogador[num_jogador].casa == grafo.vertices[47]){
                jogador[num_jogador].posX = 360;
                jogador[num_jogador].posY = 380;
            }//CASA 49
            if (jogador[num_jogador].casa == grafo.vertices[48]){
                jogador[num_jogador].posX = 345;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[49]){
                jogador[num_jogador].posX = 373;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[50]){
                jogador[num_jogador].posX = 401;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[51]){
                jogador[num_jogador].posX = 427;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[52]){
                jogador[num_jogador].posX = 455;
                jogador[num_jogador].posY = 200;
            }//CASA 54
            if (jogador[num_jogador].casa == grafo.vertices[53]){
                jogador[num_jogador].posX = 323;
                jogador[num_jogador].posY = 160;
            }
            if (jogador[num_jogador].casa == grafo.vertices[54]){
                jogador[num_jogador].posX = 335;
                jogador[num_jogador].posY = 135;
            }
            if (jogador[num_jogador].casa == grafo.vertices[55]){
                jogador[num_jogador].posX = 349;
                jogador[num_jogador].posY = 110;
            }
            if (jogador[num_jogador].casa == grafo.vertices[56]){
                jogador[num_jogador].posX = 364;
                jogador[num_jogador].posY = 85;
            }
            if (jogador[num_jogador].casa == grafo.vertices[57]){
                jogador[num_jogador].posX = 375;
                jogador[num_jogador].posY = 60;
            }//CASA 59
            if (jogador[num_jogador].casa == grafo.vertices[58]){
                jogador[num_jogador].posX = 275;
                jogador[num_jogador].posY = 160;
            }
            if (jogador[num_jogador].casa == grafo.vertices[59]){
                jogador[num_jogador].posX = 263;
                jogador[num_jogador].posY = 135;
            }
            if (jogador[num_jogador].casa == grafo.vertices[60]){
                jogador[num_jogador].posX = 247;
                jogador[num_jogador].posY = 110;
            }
            if (jogador[num_jogador].casa == grafo.vertices[61]){
                jogador[num_jogador].posX = 232;
                jogador[num_jogador].posY = 85;
            }
            if (jogador[num_jogador].casa == grafo.vertices[62]){
                jogador[num_jogador].posX = 220;
                jogador[num_jogador].posY = 60;
            }//CASA 64 
            if (jogador[num_jogador].casa == grafo.vertices[63]){
                jogador[num_jogador].posX = 250;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[64]){
                jogador[num_jogador].posX = 220;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[65]){
                jogador[num_jogador].posX = 195;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[66]){
                jogador[num_jogador].posX = 165;
                jogador[num_jogador].posY = 200;
            }
            if (jogador[num_jogador].casa == grafo.vertices[66]){
                jogador[num_jogador].posX = 140;
                jogador[num_jogador].posY = 200;
            }//CASA 69
            if (jogador[num_jogador].casa == grafo.vertices[67])
            {
                jogador[num_jogador].posX = 275;
                jogador[num_jogador].posY = 245;
            }
            if (jogador[num_jogador].casa == grafo.vertices[68])
            {
                jogador[num_jogador].posX = 260;
                jogador[num_jogador].posY = 265;
            }
            if (jogador[num_jogador].casa == grafo.vertices[69])
            {
                jogador[num_jogador].posX = 247;
                jogador[num_jogador].posY = 290;
            }
            if (jogador[num_jogador].casa == grafo.vertices[70])
            {
                jogador[num_jogador].posX = 232;
                jogador[num_jogador].posY = 315;
            }
            if (jogador[num_jogador].casa == grafo.vertices[71])
            {
                jogador[num_jogador].posX = 220;
                jogador[num_jogador].posY = 337;
            }

            /*
            double ang = 2 * Math.PI / 41; 

            for(int i = 0; i<= 41; i++)
            {
                double angle = ang * i;
                double raio = 192;

                for (int j = 7; j <= 48; j++)
                {
                    if (jogador[num_jogador].casa == grafo.vertices[j])
                    {
                        jogador[num_jogador].posX = (int)(raio * Math.Cos(angle));
                        jogador[num_jogador].posY = (int)(raio * Math.Sin(angle));
                    }
                }
            }
            Console.WriteLine(jogador[num_jogador].posX + " " + jogador[num_jogador].posY);
            */
        }

        //Converte cor em categoria
        public Pergunta.Categoria Categoria_Cor(Casa.Cor cor)
        {
            Pergunta.Categoria categ = new Pergunta.Categoria();
            switch (cor)
            {
                case Casa.Cor.Verde:
                    categ = Pergunta.Categoria.Ciencias_Natureza;
                    break;
                case Casa.Cor.Laranja:
                    categ = Pergunta.Categoria.Desporto_Lazer;
                    break;
                case Casa.Cor.Azul:
                    categ = Pergunta.Categoria.Pessoas_Lugares;
                    break;
                case Casa.Cor.Roxo:
                    categ = Pergunta.Categoria.Artes_Entertenimento;
                    break;
                case Casa.Cor.Amarelo:
                    categ = Pergunta.Categoria.Historia;
                    break;
                case Casa.Cor.Rosa:
                    categ = Pergunta.Categoria.Outros;
                    break;
                default: break;
            }
            return categ;
        }

        public static void criaJogadores(int numJogadores)
        {
            for (int i = 0; i < numJogadores; i++)
            {
                jogador[i] = new Jogador();
                jogador[i].num_jogador = i;
                if (i <= 1)
                {
                    jogador[i].desenhoPos_x = 70;
                    jogador[i].desenhoPos_y = 0 + i * 80;
                }
                else
                {
                    jogador[i].desenhoPos_x = 70 + 275;
                    jogador[i].desenhoPos_y = 0 + (i - 2) * 80;
                }
                //jogador[i].casa = 71;
            }
        }

        public static void iniciaPerguntas()
        {
            for (int i = 0; i < 13; i++)
            {
                pergunta[i] = new Pergunta();
                pergunta[i].cod_pergun = i;
                pergunta[i].Questao = "Pergunta de teste";
                pergunta[i].op_A = "Funciona";
                pergunta[i].op_B = "Não funciona";
                pergunta[i].op_C = "Não funciona";
                pergunta[i].op_D = "Não funciona";
                pergunta[i].opCorreta = 1;
                pergunta[i].Cor = Casa.Cor.Azul;
            }

            pergunta[0].cod_pergun = 0;
            pergunta[0].Questao = "Quantos ossos tem o corpo humano?";
            pergunta[0].op_A = "302";
            pergunta[0].op_B = "260";
            pergunta[0].op_C = "180";
            pergunta[0].op_D = "206";
            pergunta[0].opCorreta = 4;
            pergunta[0].Cor = Casa.Cor.Verde;

            pergunta[1].cod_pergun = 1;
            pergunta[1].Questao = "Qual é o maior orgão do corpo humano?";
            pergunta[1].op_A = "Pele";
            pergunta[1].op_B = "Estômago";
            pergunta[1].op_C = "Esófago";
            pergunta[1].op_D = "Fígado";
            pergunta[1].opCorreta = 1;
            pergunta[1].Cor = Casa.Cor.Verde;

            pergunta[2].cod_pergun = 2;
            pergunta[2].Questao = "Qual é o primeiro nome do jogador Messi?";
            pergunta[2].op_A = "Cristian";
            pergunta[2].op_B = "Pablo";
            pergunta[2].op_C = "Lionel";
            pergunta[2].op_D = "Juan";
            pergunta[2].opCorreta = 3;
            pergunta[2].Cor = Casa.Cor.Laranja;

            pergunta[3].cod_pergun = 3;
            pergunta[3].Questao = "Quem foi o campeão europeu de futebol no EURO 2016?";
            pergunta[3].op_A = "França";
            pergunta[3].op_B = "Espanha";
            pergunta[3].op_C = "Alemanha";
            pergunta[3].op_D = "Portugal";
            pergunta[3].opCorreta = 4;
            pergunta[3].Cor = Casa.Cor.Laranja;

            pergunta[4].cod_pergun = 4;
            pergunta[4].Questao = "Qual desta músicas pertence ao cantor Quim Barreiros?";
            pergunta[4].op_A = "A garagem da vizinha";
            pergunta[4].op_B = "Malhão malhão";
            pergunta[4].op_C = "Eu gosto é do verão";
            pergunta[4].op_D = "Filho do recluso";
            pergunta[4].opCorreta = 1;
            pergunta[4].Cor = Casa.Cor.Azul;

            pergunta[5].cod_pergun = 5;
            pergunta[5].Questao = "Quem pintou o famoso quadro 'Mona Lisa'?";
            pergunta[5].op_A = "Leonardo DaVinci";
            pergunta[5].op_B = "Leonardo DiCaprio";
            pergunta[5].op_C = "Vicent Van Gogh";
            pergunta[5].op_D = "Pablo Escobar";
            pergunta[5].opCorreta = 1;
            pergunta[5].Cor = Casa.Cor.Azul;


            pergunta[6].cod_pergun = 6;
            pergunta[6].Questao = "O que é que a aranha tece?";
            pergunta[6].op_A = "Mel";
            pergunta[6].op_B = "Areia";
            pergunta[6].op_C = "Teia";
            pergunta[6].op_D = "Algodão";
            pergunta[6].opCorreta = 3;
            pergunta[6].Cor = Casa.Cor.Rosa;

            pergunta[7].cod_pergun = 7;
            pergunta[7].Questao = "Primeiro nome do revolucionário cubano Guevara";
            pergunta[7].op_A = "Nhe";
            pergunta[7].op_B = "Che";
            pergunta[7].op_C = "John";
            pergunta[7].op_D = "Paco";
            pergunta[7].opCorreta = 2;
            pergunta[7].Cor = Casa.Cor.Rosa;


            pergunta[8].cod_pergun = 8;
            pergunta[8].Questao = "Em que ano ocorreu a revolução do 25 de Abril?";
            pergunta[8].op_A = "1974";
            pergunta[8].op_B = "1975";
            pergunta[8].op_C = "1983";
            pergunta[8].op_D = "1964";
            pergunta[8].opCorreta = 1;
            pergunta[8].Cor = Casa.Cor.Amarelo;

            pergunta[9].cod_pergun = 9;
            pergunta[9].Questao = "Que navegador portugues dobrou o Cabo Bojador?";
            pergunta[9].op_A = "Nuno Alvares Pereira";
            pergunta[9].op_B = "Gil Eanes";
            pergunta[9].op_C = "Bartolomeu Dias";
            pergunta[9].op_D = "Eça de Queirós";
            pergunta[9].opCorreta = 1;
            pergunta[9].Cor = Casa.Cor.Amarelo;


            pergunta[10].cod_pergun = 10;
            pergunta[10].Questao = "Quantas letras tem o alfabeto?";
            pergunta[10].op_A = "23";
            pergunta[10].op_B = "24";
            pergunta[10].op_C = "25";
            pergunta[10].op_D = "26";
            pergunta[10].opCorreta = 1;
            pergunta[10].Cor = Casa.Cor.Roxo;

            pergunta[11].cod_pergun = 11;
            pergunta[11].Questao = "Como se representa o número 18 em numeração romana?";
            pergunta[11].op_A = "XV";
            pergunta[11].op_B = "XX";
            pergunta[11].op_C = "XIX";
            pergunta[11].op_D = "XVIII";
            pergunta[11].opCorreta = 4;
            pergunta[11].Cor = Casa.Cor.Roxo;

        }

        public static void adicionaPerguntas()
        {
            for (int i = 0; i < 20; i++)
            {
                pergunta[i] = new Pergunta();
                pergunta[i].cod_pergun = i;
                pergunta[i].Questao = "";
                pergunta[i].op_A = "";
                pergunta[i].op_B = "";
                pergunta[i].op_C = "";
                pergunta[i].op_D = "";
                pergunta[i].opCorreta = 1;
                pergunta[i].Cor = Casa.Cor.Azul;
            }


        }
    }   
}
