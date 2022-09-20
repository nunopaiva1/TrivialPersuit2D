using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrivialPursuit
{
    public class Pergunta
    {
        public int cod_pergun;
        public enum Categoria
        {
            Pessoas_Lugares,
            Historia,
            Ciencias_Natureza,
            Artes_Entertenimento,
            Desporto_Lazer,
            Outros
        }
        public Casa.Cor Cor;
        public string Questao;
        public string op_A;
        public string op_B;
        public string op_C;
        public string op_D;
        public int opCorreta;
        public int resp;

        public Pergunta()
        {

        }
    }
}
