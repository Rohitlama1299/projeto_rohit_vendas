
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
    internal class SQLFuncionario
    {
        static public void Insert(MODEL.Funcionario funcionarios)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"funcionarios\" "
                        + "(nome, telefone, email, morada,estado,nif) "
                        + "VALUES (@nome, @telefone, @email, @morada,@estado,@nif);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", funcionarios.Nome));
                        sqlCommand.Parameters.Add(new SqlParameter("@telefone", funcionarios.Telefone));
                        sqlCommand.Parameters.Add(new SqlParameter("@email", funcionarios.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("@morada", funcionarios.Morada));
                        sqlCommand.Parameters.Add(new SqlParameter("@estado", funcionarios.Estado));
                        sqlCommand.Parameters.Add(new SqlParameter("@nif", funcionarios.NIF));


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

        public static List<MODEL.Funcionario> GetAll()
        {
            List<MODEL.Funcionario> funcionariosList = new List<MODEL.Funcionario>();
            MODEL.Funcionario funcionarios = new MODEL.Funcionario();
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from Funcionarios;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                funcionarios = new MODEL.Funcionario(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),
                                    reader["Morada"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Estado"].ToString(),
                                    long.Parse(reader["telefone"].ToString()),
                                    long.Parse(reader["NIF"].ToString())
                                    );
                                funcionariosList.Add(funcionarios);
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

            return funcionariosList;
        }
    }
}
