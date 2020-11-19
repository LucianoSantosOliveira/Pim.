using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.Modelo
{
    class Transacao
    {
        int id;
        String cliente;
        String tipo;
        float valor;

        DataTable dataTable = new DataTable();

        string sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
        public void SelecionaTransacao(int id,string nomecliente)
        {

            String sqlConsulta = "SELECT * FROM trasacoes WHERE nomeCliente = " + nomecliente;
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlConsulta, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;               

            }
        }
        public DataTable GetDataTable()
        {
            return dataTable;
        }
    }
}
