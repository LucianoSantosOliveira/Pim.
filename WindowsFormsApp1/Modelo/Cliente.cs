using System;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp1
{
    class Cliente : Usuario
    {
       
        private DataTable dataTable = new DataTable();

        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        public void Inserir() { ConectaSQL conecta = new ConectaSQL(); conecta.InserirCliente(this); }
        public void Deletar(Cliente cliente) { ConectaSQL conecta = new ConectaSQL(); conecta.DeletarCliente(this); }
        public void Alterar(Cliente cliente) { ConectaSQL conecta = new ConectaSQL(); conecta.AlterarCliente(this); }
        public void Selecionar() { ConectaSQL conecta = new ConectaSQL(); conecta.ConsultarClientes(this, false); DataTable = conecta.getDataTable; }
    }
    
}
