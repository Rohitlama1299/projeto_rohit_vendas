
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
    internal class SQLFornecedore
    {
        static public void Insert(Fornecedore fornecedores)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"fornecedores\" "
                        + "(nomeEmpresa, nif, email,morada,cidade) "
                        + "VALUES (@nomeEmpresa, @nif, @email, @morada,@cidade);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nomeEmpresa", fornecedores.Nome));
                        sqlCommand.Parameters.Add(new SqlParameter("@nif", fornecedores.NIF));
                        sqlCommand.Parameters.Add(new SqlParameter("@email", fornecedores.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("@morada", fornecedores.Morada));
                        sqlCommand.Parameters.Add(new SqlParameter("@cidade", fornecedores.Cidade));


                        if (sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new System.Exception("[SQLFornecedore] - Ocorreu um erro na query sql");
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }

        public static List<Fornecedore> GetAll()
        {
            List<Fornecedore> fornecedoresLista = new List<Fornecedore>();
            Fornecedore fornecedores = new Fornecedore();
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from fornecedores;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                fornecedores = new Fornecedore(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),
                                    reader["cidade"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Morada"].ToString(),
                                    long.Parse(reader["NIF"].ToString())
                                    );
                                fornecedoresLista.Add(fornecedores);
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

            return fornecedoresLista;
        }

        internal static Fornecedore GetById(int id)
        {
            Fornecedore fornecedore = null;

            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);

                        sqlCommand.CommandText = "SELECT * FROM fornecedore where ID=@id;";
                        sqlCommand.Parameters.Add(new SqlParameter("@id", id));

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fornecedore = new Fornecedore(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["nome"].ToString(),
                                    reader["morada"].ToString(),
                                    reader["email"].ToString(),
                                    reader["cidade"].ToString(),
                                    long.Parse(reader["Nif"].ToString())
                                    
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: SQLFornecedore - get() - \n" + e.ToString());
                MessageBox.Show(
                    "SQLfornecedore - Get() - \n Ocorreram problemas com a ligação à Base de Dados: \n" + e.ToString(),
                    "SQLfornecedore - Get() - Catch",   // Título
                    MessageBoxButtons.OK,       // Botões
                    MessageBoxIcon.Error  // Icon
                );
                return null;
            }
            return fornecedore;
        }
    }
}
