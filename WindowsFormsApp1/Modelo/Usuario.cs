using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Usuario
    {
        String nome;
        String consultor;
        int id;
        String cpf;
        String dataNacimento;
        string Telefone;
        string Email;
        float valorContaCriptoativo;
        string uf;
        bool login;
        bool senha;

   

        public void contrutorCliente()
        {
            nome = "";
            consultor = "";
            id = 0;
            cpf = "";
            dataNacimento = "";
        }


        public void VerificaLogin(string login)
        {
            string sqlConsulta;
            string sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            sqlConsulta = "SELECT Login From Usuario WHERE Login = '" + login + "'";
            sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);

            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            this.login = dataReader.HasRows;
            sqlConnection.Close();
        }

        public void VerificaSenha(string senha)
        {
            string sqlConsulta;
            string sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            sqlConsulta = "SELECT Senha From Usuario WHERE Senha = '" + senha + "'";
            sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);

            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            this.senha = dataReader.HasRows;
            sqlConnection.Close();
        }

        public bool Senha { get => senha; set => senha = value; }
        public bool Login { get => login; set => login = value; }
        public void setUf(string uf) { this.uf = uf; }
        public void setNome(string nome) { this.nome = nome; }
        public void setConsultor(string consultor) { this.consultor = consultor; }
        public void setDataNacimento(string datanacimento) { this.dataNacimento = datanacimento; }
        public void setCpf(string cpf) { this.cpf = cpf; }
        public void setID(int ID) { this.id = ID; }
        public void setTelefone(string telefone) { this.Telefone = telefone; }
        public void setEmail(string email) { this.Email = email; }

        public void setValorContaCritoAtivo(float conta) { this.valorContaCriptoativo = conta; }


        //get

        public void InserirUser() { ConectaSQL conecta = new ConectaSQL(); }
        public void DeletarUser(Cliente cliente) { ConectaSQL conecta = new ConectaSQL();  }
        public void AlterarUser(Cliente cliente) { ConectaSQL conecta = new ConectaSQL();  }
        public void SelecionarUser() { ConectaSQL conecta = new ConectaSQL(); }

        public float getValorContaCriptoAtivo() { return this.valorContaCriptoativo; }
        public string getUF() { return this.uf; }
        public int getID() { return this.id; }
        public string getNome() { return this.nome; }
        public float getValorConta() { return this.valorContaCriptoativo; }
        public string getCpf() { return this.cpf; }
        public string getTelefone() { return this.Telefone; }
        public string getEmail() { return this.Email; }

    }
}
