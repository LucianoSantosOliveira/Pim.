using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelo
{
    class CriptoMoedas
    {
        private string nome;
        private float cotacao;
        private string idMoeda;
        private int id;

        public CriptoMoedas(string nome, float cotacao, string idMoeda, int id)
        {
            this.Nome = nome;
            this.Cotacao = cotacao;
            this.IdMoeda = idMoeda;
            this.Id = id;
        }


        public string IdMoeda { get => idMoeda; set => idMoeda = value; }
        public int Id { get => id; set => id = value; }
        public float Cotacao { get => cotacao; set => cotacao = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
