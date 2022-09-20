namespace TrivialPursuit
{
    partial class Pergunta_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta_form));
            this.Questao1 = new System.Windows.Forms.Label();
            this.resp_A = new System.Windows.Forms.Button();
            this.resp_B = new System.Windows.Forms.Button();
            this.resp_C = new System.Windows.Forms.Button();
            this.resp_D = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Questao1
            // 
            this.Questao1.AutoSize = true;
            this.Questao1.BackColor = System.Drawing.Color.Transparent;
            this.Questao1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questao1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Questao1.Location = new System.Drawing.Point(14, 47);
            this.Questao1.Name = "Questao1";
            this.Questao1.Size = new System.Drawing.Size(62, 16);
            this.Questao1.TabIndex = 0;
            this.Questao1.Text = "Questão";
            this.Questao1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resp_A
            // 
            this.resp_A.BackColor = System.Drawing.Color.MediumVioletRed;
            this.resp_A.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp_A.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resp_A.Location = new System.Drawing.Point(100, 103);
            this.resp_A.Name = "resp_A";
            this.resp_A.Size = new System.Drawing.Size(120, 34);
            this.resp_A.TabIndex = 1;
            this.resp_A.Text = "Opção A";
            this.resp_A.UseVisualStyleBackColor = false;
            this.resp_A.Click += new System.EventHandler(this.resp_A_Click);
            // 
            // resp_B
            // 
            this.resp_B.BackColor = System.Drawing.Color.DarkViolet;
            this.resp_B.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp_B.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resp_B.Location = new System.Drawing.Point(100, 153);
            this.resp_B.Name = "resp_B";
            this.resp_B.Size = new System.Drawing.Size(120, 34);
            this.resp_B.TabIndex = 2;
            this.resp_B.Text = "Opção B";
            this.resp_B.UseVisualStyleBackColor = false;
            this.resp_B.Click += new System.EventHandler(this.resp_B_Click);
            // 
            // resp_C
            // 
            this.resp_C.BackColor = System.Drawing.Color.DarkGreen;
            this.resp_C.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp_C.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resp_C.Location = new System.Drawing.Point(100, 202);
            this.resp_C.Name = "resp_C";
            this.resp_C.Size = new System.Drawing.Size(120, 34);
            this.resp_C.TabIndex = 3;
            this.resp_C.Text = "Opção C";
            this.resp_C.UseVisualStyleBackColor = false;
            this.resp_C.Click += new System.EventHandler(this.resp_C_Click);
            // 
            // resp_D
            // 
            this.resp_D.BackColor = System.Drawing.Color.RoyalBlue;
            this.resp_D.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp_D.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.resp_D.Location = new System.Drawing.Point(100, 253);
            this.resp_D.Name = "resp_D";
            this.resp_D.Size = new System.Drawing.Size(120, 34);
            this.resp_D.TabIndex = 4;
            this.resp_D.Text = "Opção D";
            this.resp_D.UseVisualStyleBackColor = false;
            this.resp_D.Click += new System.EventHandler(this.resp_D_Click);
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.BackColor = System.Drawing.Color.Transparent;
            this.categoria.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoria.Location = new System.Drawing.Point(12, 9);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(99, 27);
            this.categoria.TabIndex = 5;
            this.categoria.Text = "Categoria";
            // 
            // Pergunta_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrivialPursuit.Properties.Resources.newScore;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 340);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.resp_D);
            this.Controls.Add(this.resp_C);
            this.Controls.Add(this.resp_B);
            this.Controls.Add(this.resp_A);
            this.Controls.Add(this.Questao1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pergunta_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Questao1;
        private System.Windows.Forms.Button resp_A;
        private System.Windows.Forms.Button resp_B;
        private System.Windows.Forms.Button resp_C;
        private System.Windows.Forms.Button resp_D;
        private System.Windows.Forms.Label categoria;
    }
}