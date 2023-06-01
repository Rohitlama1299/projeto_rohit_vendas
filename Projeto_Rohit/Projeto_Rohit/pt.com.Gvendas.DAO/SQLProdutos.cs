
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
    internal class SQLProdutos
    {
        static public void Insert(MODEL.Produto produtos)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"produtos\" "
                        + "(nome,  qtd, preco) "
                        + "VALUES (@nome, @qtd, @preco);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", produtos.Nome_produtos));
                        sqlCommand.Parameters.Add(new SqlParameter("@qtd", produtos.Qtd_produtos));
                        sqlCommand.Parameters.Add(new SqlParameter("@preco", produtos.Preco));
                       


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

        public static List<MODEL.Produto> GetAll()
        {
            List<MODEL.Produto> produtoLista = new List<MODEL.Produto>();
            MODEL.Produto produtos = new MODEL.Produto();
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from produtos;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                produtos = new MODEL.Produto(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),
                                    int.Parse(reader["Qtd"].ToString()),
                                    int.Parse(reader["Preco"].ToString())


                                    );
                                produtoLista.Add(produtos);
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

            return produtoLista;
        }
    }
}
