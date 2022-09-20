namespace TrivialPursuit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBoxJogador = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDado = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonJogador = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirPerguntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trivialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(654, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "JOGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Location = new System.Drawing.Point(678, 167);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 38);
            this.button10.TabIndex = 10;
            this.button10.Text = "Lançar Dado!";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBoxJogador
            // 
            this.pictureBoxJogador.BackgroundImage = global::TrivialPursuit.Properties.Resources.newScore;
            this.pictureBoxJogador.ErrorImage = null;
            this.pictureBoxJogador.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxJogador.Name = "pictureBoxJogador";
            this.pictureBoxJogador.Size = new System.Drawing.Size(624, 160);
            this.pictureBoxJogador.TabIndex = 11;
            this.pictureBoxJogador.TabStop = false;
            this.pictureBoxJogador.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxJogador_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 433);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pontuações";
            // 
            // pictureBoxDado
            // 
            this.pictureBoxDado.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDado.InitialImage = null;
            this.pictureBoxDado.Location = new System.Drawing.Point(642, 30);
            this.pictureBoxDado.Name = "pictureBoxDado";
            this.pictureBoxDado.Size = new System.Drawing.Size(170, 131);
            this.pictureBoxDado.TabIndex = 13;
            this.pictureBoxDado.TabStop = false;
            this.pictureBoxDado.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDado_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jogador";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonJogador
            // 
            this.buttonJogador.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonJogador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJogador.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonJogador.Location = new System.Drawing.Point(654, 552);
            this.buttonJogador.Name = "buttonJogador";
            this.buttonJogador.Size = new System.Drawing.Size(146, 77);
            this.buttonJogador.TabIndex = 16;
            this.buttonJogador.Text = "INICIAR JOGO!";
            this.buttonJogador.UseVisualStyleBackColor = false;
            this.buttonJogador.Click += new System.EventHandler(this.buttonJogador_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarJogoToolStripMenuItem,
            this.carregarJogoToolStripMenuItem,
            this.voltarAoMenuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // carregarJogoToolStripMenuItem
            // 
            this.carregarJogoToolStripMenuItem.Name = "carregarJogoToolStripMenuItem";
            this.carregarJogoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.carregarJogoToolStripMenuItem.Text = "Carregar jogo";
            this.carregarJogoToolStripMenuItem.Click += new System.EventHandler(this.carregarJogoToolStripMenuItem_Click);
            // 
            // guardarJogoToolStripMenuItem
            // 
            this.guardarJogoToolStripMenuItem.Name = "guardarJogoToolStripMenuItem";
            this.guardarJogoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.guardarJogoToolStripMenuItem.Text = "Guardar jogo";
            this.guardarJogoToolStripMenuItem.Click += new System.EventHandler(this.guardarJogoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirPerguntaToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // inserirPerguntaToolStripMenuItem
            // 
            this.inserirPerguntaToolStripMenuItem.Name = "inserirPerguntaToolStripMenuItem";
            this.inserirPerguntaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inserirPerguntaToolStripMenuItem.Text = "Inserir pergunta";
            this.inserirPerguntaToolStripMenuItem.Click += new System.EventHandler(this.inserirPerguntaToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trivialToolStripMenuItem,
            this.acercaToolStripMenuItem1});
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.acercaToolStripMenuItem.Text = "Acerca";
            // 
            // trivialToolStripMenuItem
            // 
            this.trivialToolStripMenuItem.Name = "trivialToolStripMenuItem";
            this.trivialToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.trivialToolStripMenuItem.Text = "Trivial";
            this.trivialToolStripMenuItem.Click += new System.EventHandler(this.trivialToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem1
            // 
            this.acercaToolStripMenuItem1.Name = "acercaToolStripMenuItem1";
            this.acercaToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.acercaToolStripMenuItem1.Text = "Acerca";
            this.acercaToolStripMenuItem1.Click += new System.EventHandler(this.acercaToolStripMenuItem1_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.Location = new System.Drawing.Point(651, 346);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 27);
            this.btn_1.TabIndex = 19;
            this.btn_1.Text = "button2";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Visible = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2.Location = new System.Drawing.Point(732, 346);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 27);
            this.btn_2.TabIndex = 20;
            this.btn_2.Text = "button4";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Visible = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_3.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3.Location = new System.Drawing.Point(651, 375);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 27);
            this.btn_3.TabIndex = 21;
            this.btn_3.Text = "button5";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Visible = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_4.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4.Location = new System.Drawing.Point(732, 375);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 27);
            this.btn_4.TabIndex = 22;
            this.btn_4.Text = "button6";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Visible = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5.Location = new System.Drawing.Point(651, 403);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 27);
            this.btn_5.TabIndex = 23;
            this.btn_5.Text = "button7";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Visible = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_6.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_6.Location = new System.Drawing.Point(732, 403);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 27);
            this.btn_6.TabIndex = 24;
            this.btn_6.Text = "button8";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Visible = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_7.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_7.Location = new System.Drawing.Point(691, 432);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 27);
            this.btn_7.TabIndex = 25;
            this.btn_7.Text = "button8";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Visible = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Escolher casa";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Questões respondidas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Questões acertadas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estatísticas";
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao menu";
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(819, 641);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.buttonJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxDado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxJogador);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBoxJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonJogador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirPerguntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trivialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuToolStripMenuItem;
    }
}

