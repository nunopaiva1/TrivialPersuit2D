using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrivialPursuit
{
    public partial class Pergunta_form : Form
    {
        int numPergunta;
        public Pergunta_form(int codigo)
        {
            Jogo conv = new Jogo();
            numPergunta = codigo;
            InitializeComponent();
            categoria.Text = conv.Categoria_Cor(Jogo.pergunta[codigo].Cor).ToString();
            Questao1.Text = Jogo.pergunta[codigo].Questao;
            resp_A.Text = Jogo.pergunta[codigo].op_A;
            resp_B.Text = Jogo.pergunta[codigo].op_B;
            resp_C.Text = Jogo.pergunta[codigo].op_C;
            resp_D.Text = Jogo.pergunta[codigo].op_D;
            
        }

        private void resp_A_Click(object sender, EventArgs e)
        {
            Jogo.jogador[Form1.jogador].respDadas += 1;
            Jogo.pergunta[numPergunta].resp = 1;
            testaStats(1);
            this.Close();
        }

        private void resp_B_Click(object sender, EventArgs e)
        {
            Jogo.jogador[Form1.jogador].respDadas += 1;
            Jogo.pergunta[numPergunta].resp = 2;
            testaStats(2);
            this.Close();
        }

        private void resp_C_Click(object sender, EventArgs e)
        {
            Jogo.jogador[Form1.jogador].respDadas += 1;
            Jogo.pergunta[numPergunta].resp = 3;
            testaStats(3);
            this.Close();
        }

        private void resp_D_Click(object sender, EventArgs e)
        {
            Jogo.jogador[Form1.jogador].respDadas += 1;
            Jogo.pergunta[numPergunta].resp = 4;
            testaStats(4);
            this.Close();
        }

        public void testaStats(int num)
        {
            if (Jogo.pergunta[numPergunta].opCorreta == num)
            {
                if (Jogo.jogador[Form1.jogador].casa == 7)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Azul;
                }
                if (Jogo.jogador[Form1.jogador].casa == 42)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Rosa;
                }
                if (Jogo.jogador[Form1.jogador].casa == 35)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Amarelo;
                }
                if (Jogo.jogador[Form1.jogador].casa == 28)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Roxo;
                }
                if (Jogo.jogador[Form1.jogador].casa == 21)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Verde;
                }
                if (Jogo.jogador[Form1.jogador].casa == 14)
                {
                    Jogo.jogador[Form1.jogador].num_categAcertadas += 1;
                    Jogo.jogador[Form1.jogador].categAcertadas[0] = Casa.Cor.Laranja;
                }

                Console.WriteLine("Certo");
                Jogo.jogador[Form1.jogador].respCorretas += 1;

                if (Jogo.jogador[Form1.jogador].num_categAcertadas == 6)
                {
                    MessageBox.Show(Jogo.jogador[Form1.jogador].nome + " venceu o jogo!");
                    Application.Exit();
                }
            }
            else { Console.WriteLine("Errado"); }
        }

    }
}
