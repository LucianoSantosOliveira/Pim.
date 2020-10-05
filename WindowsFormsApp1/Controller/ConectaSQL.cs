using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class ConectaSQL
    {
        string sqlConsulta;
        string sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
        DataTable dataTable = new DataTable();

 
        
        public void ConsultarClientes(Cliente cliente,bool todos)//Read
        {
            //conecta com sql
        
            //sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);

            if (todos == true)
            {
                sqlConsulta = "SELECT * FROM CLIENTE1 ";
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

            if (string.IsNullOrEmpty(cliente.getNome()))
            {
                sqlConsulta = "SELECT * FROM CLIENTE1 WHERE ID = " + cliente.getID();
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
            else if (cliente.getID() > 0 && string.IsNullOrEmpty(cliente.getNome()) == false) 

            {
                sqlConsulta = "SELECT * FROM CLIENTE1 WHERE ID = " + cliente.getID() + "AND Nome = '" + cliente.getNome() + "'";
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
              

            }else if (cliente.getID() == 0)
            {
                sqlConsulta = "SELECT * FROM CLIENTE1 WHERE NOME = '" + cliente.getNome() + "'";
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
        }

        public void DeletarCliente(Cliente cliente)//delete
        {
            sqlConsulta = "DELETE FROM CLIENTE1 WHERE NOME = '" + cliente.getNome() + "'" + "AND ID = '" + cliente.getID() + "'";
            sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);
   

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InserirCliente(Cliente cliente)//Create
        {

            sqlConsulta = "INSERT INTO CLIENTE1 (Nome, Telefone1, Email1, CPFc) VALUES (  '" + cliente.getNome() + "','" + cliente.getTelefone() + "','" + cliente.getEmail() + "','" + cliente.getCpf() + "')";
            sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        public void AlterarCliente(Cliente cliente)//Update
        {
            sqlConsulta = "UPDATE CLIENTE1 SET TELEFONE = '" + cliente.getTelefone() + "' WHERE ID = '" + cliente.getID(); 
            sqlCon = "Data Source =.; Initial Catalog = Pim; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(sqlCon);
            SqlCommand sqlCommand = new SqlCommand(sqlConsulta, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //new reposs
             public DataTable getDataTable { get => dataTable;}
    }
}
