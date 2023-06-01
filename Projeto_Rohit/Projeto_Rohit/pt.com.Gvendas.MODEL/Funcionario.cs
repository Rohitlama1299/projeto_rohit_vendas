using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Rohit.pt.com.Gvendas.MODEL
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }

        public string Estado { get; set; }
        public long Telefone { get; set; }
        public long NIF { get; set; }


        public Funcionario()
        {

        }

        public Funcionario(int id)
        {
            Id = id;
        }
        public Funcionario(string nome, string morada, string email,string estado, long telefone, long nif)
        {

            Nome = nome;
            Morada = morada;
            Email = email;
            Estado = estado;
            Telefone = telefone;
            NIF = nif;
        }

        public Funcionario(int id, string nome, string morada, string email,string estado, long telefone, long nif)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Email = email;
            Estado= estado;
            Telefone = telefone;
            NIF = nif;
        }
    }
}
