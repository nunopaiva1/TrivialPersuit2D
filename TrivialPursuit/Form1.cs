using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TrivialPursuit
{
    public partial class Form1 : Form
    {
        string nome;
        StreamWriter guarda;
        StreamReader carrega;
        List<String> list;
        string[] array;

        int numDado = 1;
        public static int jogador = -1;
        int num_jogadores;

        public Form1()
        {
            num_jogadores = LogIn.jogadores;
            InitializeComponent();

            list = new List<string>();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tabuleiro.desenhaTabuleiro(g);

            for (int i = 0; i < num_jogadores; i++)
            {
                Jogador.desenharJogador(g, i);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (numDado > 3) Jogo.andar(jogador, 0, numDado + 1);
            else Jogo.andar(jogador, 0, numDado + 1);

            if(Jogo.path2.Count == 2)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();
            }
            if (Jogo.path2.Count == 3)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();

                btn_3.Visible = true;
                int value3 = Jogo.path2[2];
                btn_3.Text = value3.ToString();
            }
            if (Jogo.path2.Count == 4)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();

                btn_3.Visible = true;
                int value3 = Jogo.path2[2];
                btn_3.Text = value3.ToString();

                btn_4.Visible = true;
                int value4 = Jogo.path2[3];
                btn_4.Text = value4.ToString();
            }
            if (Jogo.path2.Count == 5)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();

                btn_3.Visible = true;
                int value3 = Jogo.path2[2];
                btn_3.Text = value3.ToString();

                btn_4.Visible = true;
                int value4 = Jogo.path2[3];
                btn_4.Text = value4.ToString();

                btn_5.Visible = true;
                int value5 = Jogo.path2[4];
                btn_5.Text = value5.ToString();
            }
            if (Jogo.path2.Count == 6)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();

                btn_3.Visible = true;
                int value3 = Jogo.path2[2];
                btn_3.Text = value3.ToString();

                btn_4.Visible = true;
                int value4 = Jogo.path2[3];
                btn_4.Text = value4.ToString();

                btn_5.Visible = true;
                int value5 = Jogo.path2[4];
                btn_5.Text = value5.ToString();

                btn_6.Visible = true;
                int value6 = Jogo.path2[5];
                btn_6.Text = value6.ToString();
            }
            if (Jogo.path2.Count == 7)
            {
                btn_1.Visible = true;
                int value = Jogo.path2[0];
                btn_1.Text = value.ToString();

                btn_2.Visible = true;
                int value2 = Jogo.path2[1];
                btn_2.Text = value2.ToString();

                btn_3.Visible = true;
                int value3 = Jogo.path2[2];
                btn_3.Text = value3.ToString();

                btn_4.Visible = true;
                int value4 = Jogo.path2[3];
                btn_4.Text = value4.ToString();

                btn_5.Visible = true;
                int value5 = Jogo.path2[4];
                btn_5.Text = value5.ToString();

                btn_6.Visible = true;
                int value6 = Jogo.path2[5];
                btn_6.Text = value6.ToString();

                btn_7.Visible = true;
                int value7 = Jogo.path2[6];
                btn_7.Text = value7.ToString();
            }

            button1.Enabled = false;
            buttonJogador.Enabled = true;
            pictureBox1.Invalidate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numDado = rand.Next(1, 7);
            pictureBoxDado.Invalidate();
            button10.Enabled = false;
            button1.Enabled = true;
            pictureBox1.Invalidate();
        }

        private void pictureBoxJogador_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < num_jogadores; i++)
            {
                Jogador.desenharBoneco(g, i);
                //mostraPontuacao();
                Jogador.desenhaTriangulo(g, i);
            }

            // pictureBoxJogador.Invalidate();

        }

        private void mostraPontuacao()
        {
            for (int i = 0; i < num_jogadores; i++)
            {
                if (Jogo.jogador[i].casa == 7) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Azul;
                if (Jogo.jogador[i].casa == 42) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Rosa;
                if (Jogo.jogador[i].casa == 35) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Amarelo;
                if (Jogo.jogador[i].casa == 28) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Roxo;
                if (Jogo.jogador[i].casa == 21) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Verde;
                if (Jogo.jogador[i].casa == 14) Jogo.jogador[i].categAcertadas[0] = Casa.Cor.Laranja;
            }
        }

        private void pictureBoxDado_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Dado.desenharDado(g, numDado);
        }

        private void buttonJogador_Click(object sender, EventArgs e)
        {

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            buttonJogador.Enabled = false;
            button10.Enabled = true;
            buttonJogador.Text = "Próximo jogador";

            if (num_jogadores == 2)
            {
                if (jogador >= 0 && jogador <= 1) jogador += 1;
                if (jogador < 0 || jogador > 1) jogador = 0;
            }
            if (num_jogadores == 3)
            {
                if (jogador >= 0 && jogador <= 2) jogador += 1;
                if (jogador < 0 || jogador > 2) jogador = 0;
            }
            if (num_jogadores == 4)
            {
                if (jogador >= 0 && jogador <= 3) jogador += 1;
                if (jogador < 0 || jogador > 3) jogador = 0;
            }

            label2.Text = "A jogar: " + Jogo.jogador[jogador].nome;
            label4.Text = "Questões respondidas: " + Jogo.jogador[jogador].respDadas.ToString();
            label5.Text = "Questões acertadas: " + Jogo.jogador[jogador].respCorretas.ToString();

            pictureBoxJogador.Invalidate();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trivialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prima iniciar jogo para começar o jogo, lance o dado e percorra o tabuleiro!");
        }

        private void acercaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo desenvolvido no ambito da disciplina de Projeto2D, ECGM 2018");
        }

        private void inserirPerguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);

            int xCoordinate = Cursor.Position.X/2;
            int yCoordinate = Cursor.Position.Y/2;
            Console.WriteLine("PosX : " + xCoordinate + " PosY : " + yCoordinate);
            //Console.WriteLine("Jogador " + Jogo.jogador[jogador].respCorretas);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[0];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[1];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[2];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[3];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[4];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[5];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Casa grafo = new Casa();

            Jogo.jogador[jogador].casa = Jogo.path2[6];
            Jogo.converteCasaPos(jogador, grafo);
            pictureBox1.Invalidate();

            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            btn_6.Visible = false;
            btn_7.Visible = false;

            checkQuestion();
        }

        private void checkQuestion()
        {
            Random rand = new Random();
            //laranja
            if (Jogo.jogador[jogador].casa == 2 || Jogo.jogador[jogador].casa == 14 || Jogo.jogador[jogador].casa == 55 ||
                Jogo.jogador[jogador].casa == 55 || Jogo.jogador[jogador].casa == 61 || Jogo.jogador[jogador].casa == 68 ||
                Jogo.jogador[jogador].casa == 34 || Jogo.jogador[jogador].casa == 36 || Jogo.jogador[jogador].casa == 72 ||
                Jogo.jogador[jogador].casa == 45)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(2, 4);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            //roxo
            if (Jogo.jogador[jogador].casa == 6 || Jogo.jogador[jogador].casa == 48 || Jogo.jogador[jogador].casa == 8 ||
                Jogo.jogador[jogador].casa == 52 || Jogo.jogador[jogador].casa == 54 || Jogo.jogador[jogador].casa == 17 ||
                Jogo.jogador[jogador].casa == 28 || Jogo.jogador[jogador].casa == 65 || Jogo.jogador[jogador].casa == 71 ||
                Jogo.jogador[jogador].casa == 39)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(10, 12);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            //amarelo
            if (Jogo.jogador[jogador].casa == 4 || Jogo.jogador[jogador].casa == 53 || Jogo.jogador[jogador].casa == 13 ||
                Jogo.jogador[jogador].casa == 15 || Jogo.jogador[jogador].casa == 57 || Jogo.jogador[jogador].casa == 24 ||
                Jogo.jogador[jogador].casa == 59 || Jogo.jogador[jogador].casa == 70 || Jogo.jogador[jogador].casa == 46 ||
                Jogo.jogador[jogador].casa == 35)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(8, 10);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            //verde
            if (Jogo.jogador[jogador].casa == 5 || Jogo.jogador[jogador].casa == 10 || Jogo.jogador[jogador].casa == 21 ||
                Jogo.jogador[jogador].casa == 60 || Jogo.jogador[jogador].casa == 66 || Jogo.jogador[jogador].casa == 32 ||
                Jogo.jogador[jogador].casa == 41 || Jogo.jogador[jogador].casa == 75 || Jogo.jogador[jogador].casa == 43 ||
                Jogo.jogador[jogador].casa == 49)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(0, 2);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            //rosa
            if (Jogo.jogador[jogador].casa == 3 || Jogo.jogador[jogador].casa == 51 || Jogo.jogador[jogador].casa == 11 ||
                Jogo.jogador[jogador].casa == 13 || Jogo.jogador[jogador].casa == 15 || Jogo.jogador[jogador].casa == 62 ||
                Jogo.jogador[jogador].casa == 31 || Jogo.jogador[jogador].casa == 42 || Jogo.jogador[jogador].casa == 64 ||
                Jogo.jogador[jogador].casa == 22 || Jogo.jogador[jogador].casa == 58 || Jogo.jogador[jogador].casa == 10)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(6, 8);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            //azul
            if (Jogo.jogador[jogador].casa == 7 || Jogo.jogador[jogador].casa == 69 || Jogo.jogador[jogador].casa == 50 ||
                Jogo.jogador[jogador].casa == 56 || Jogo.jogador[jogador].casa == 63 || Jogo.jogador[jogador].casa == 27 ||
                Jogo.jogador[jogador].casa == 29 || Jogo.jogador[jogador].casa == 67 || Jogo.jogador[jogador].casa == 38 ||
                Jogo.jogador[jogador].casa == 18)
            {
                Jogo.iniciaPerguntas();
                int num = rand.Next(4, 6);
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
        }

        public struct SaveGameData
        {
            public string PlayerName;
            public int Level;
            public int Score;
        }

        private void guardarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guarda = new StreamWriter("savedgame.txt");

            for (int i = 0; i < num_jogadores; i++)
            {
                guarda.WriteLine(Jogo.jogador[i].nome);
                guarda.WriteLine(Jogo.jogador[i].casa);
                guarda.WriteLine(Jogo.jogador[i].num_categAcertadas);
                guarda.WriteLine(Jogo.jogador[i].respDadas);
                guarda.WriteLine(Jogo.jogador[i].respCorretas);
            }

            MessageBox.Show("O jogo foi guardado com sucesso!");
            guarda.Close();
        }

        private void carregarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int j;
            Casa grafo = new Casa();

            carrega = new StreamReader("savedgame.txt");

            while ((nome = carrega.ReadLine()) != null)
            {
                list.Add(nome);
                //Console.WriteLine("Entrou" + nome);
            }

            array = list.ToArray();

            carrega.Close();

                for (j = 0; j < (num_jogadores*5); j += 5)
                {
                    Console.WriteLine(array[j]);
                    Jogo.jogador[j/5].nome = array[j];
                    Jogo.jogador[j/5].casa = Int32.Parse(array[j+1]);
                    Jogo.jogador[j/5].num_categAcertadas = Int32.Parse(array[j+2]);
                    Jogo.jogador[j/5].respDadas = Int32.Parse(array[j+3]);
                    Jogo.jogador[j/5].respCorretas = Int32.Parse(array[j+4]);

                Jogo.converteCasaPos(Jogo.jogador[j / 5].num_jogador, grafo);
                }

            MessageBox.Show("Jogo carregado com sucesso!");

            buttonJogador.Text = "Próximo jogador";
            pictureBox1.Invalidate();
            pictureBoxJogador.Invalidate();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
