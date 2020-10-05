using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Usuario
    {
        String nome;
        String consultor;
        int id = 0;
        String cpf;
        String dataNacimento;
        float valorContaCriptoativo;

        public void contrutorCliente()
        {
            nome = "";
            consultor = "";
            id = 0;
            cpf = "";
            dataNacimento = "";
        }



        public void setNome(string nome) { this.nome = nome; }
        public void setConsultor(string consultor) { this.consultor = consultor; }
        public void setDataNacimento(string datanacimento) { this.dataNacimento = datanacimento; }
        public void setCpf(string cpf) { this.cpf = cpf; }
        public void setID(int ID) { this.id = ID; }

        public void setValorContaCritoAtivo(float conta) { this.valorContaCriptoativo = conta; }


        //get

        public int getID() { return this.id; }
        public string getNome() { return this.nome; }
        public float getValorConta() { return this.valorContaCriptoativo; }
        public string getCpf() { return this.cpf; }

    }
}
