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
    internal class SQLEncomenda
    {
        static public void Insert(Encomenda encomendas)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"encomendas\" "
                        + "(nome, qtd) "
                        + "VALUES (@nome, @qtd);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", encomendas.Nome_de_Encomendas));
                        sqlCommand.Parameters.Add(new SqlParameter("@qtd", encomendas.Qdt_de_Produto));
                       


                        if (sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new System.Exception("[SQLEncomendas] - Ocorreu um erro na query sql");
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }

        public static List<Encomenda> GetAll()
        {
            List<Encomenda> encomendaLista = new List<Encomenda>();
            Encomenda encomendas = new Encomenda();
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from encomendas;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                encomendas = new Encomenda(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),
                                    int.Parse(reader["Qtd"].ToString())
                                    );
                                encomendaLista.Add(encomendas);
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

            return encomendaLista;
        }
    }
}
