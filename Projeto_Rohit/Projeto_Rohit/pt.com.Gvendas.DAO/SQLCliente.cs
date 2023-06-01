
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using Projeto_Rohit.pt.com.Gvendas.MODEL;
using static Projeto_Rohit.pt.com.Gvendas.DAO.SQLConnection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Projeto_Rohit.pt.com.Gvendas.DAO
{
    internal class SQLCliente
    {
        static public void Insert(Clientes cliente)
        {

            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"clientes\" "
                        + "(nome, telefone, email, morada,estado) "
                        + "VALUES (@nome, @telefone, @email, @morada,@estado);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", cliente.Nome));
                        sqlCommand.Parameters.Add(new SqlParameter("@telefone", cliente.Telefone));
                        sqlCommand.Parameters.Add(new SqlParameter("@email", cliente.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("@morada", cliente.Morada));
                        sqlCommand.Parameters.Add(new SqlParameter("@estado", cliente.Estado));


                        if (sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new System.Exception("[SQLCliente] - Ocorreu um erro na query sql");
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }

        internal static List<Clientes> GetAll()
        {
            List<Clientes> clienteLista = new List<Clientes>();
            Clientes cliente = new Clientes();
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from Clientes;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                cliente = new Clientes(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),
                                    reader["Morada"].ToString(),
                                    reader["Email"].ToString(),
                                    long.Parse(reader["telefone"].ToString()),
                                    reader["Estado"].ToString()
                                    );
                                clienteLista.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro ocorreu -  contacte do administrador de sistema." + ex.Message);
                return null;
            }

            return clienteLista;
        }

    }
}
