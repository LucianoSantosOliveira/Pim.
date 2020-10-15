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
        
        public CriptoMoedas()
        {
            this.Nome = nome;
            this.Cotacao = cotacao;
            this.IdMoeda = idMoeda;
            this.Id = id;
        }

        public void AtualizarCotacao(float cotacao)
        {
            this.cotacao = cotacao;
        }

        public void CadastrarCripmoeda()
        {

        }

        public string IdMoeda { get => idMoeda; set => idMoeda = value; }
        public int Id { get => id; set => id = value; }
        public float Cotacao { get => cotacao; set => cotacao = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
