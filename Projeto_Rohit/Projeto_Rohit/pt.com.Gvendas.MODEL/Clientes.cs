using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Rohit.pt.com.Gvendas.MODEL
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public string Estado { get; set; }
        

        public Clientes()
        {

        }

        public Clientes(int id)
        {
            Id = id;
        }
        public Clientes( string nome, string morada, string email, long telefone, string estado)
        {
            
            Nome = nome;
            Morada = morada;
            Email = email;
            Telefone = telefone;
            Estado = estado;
        }

        public Clientes(int id, string nome, string morada, string email, long telefone ,string estado)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Email = email;
            Telefone = telefone;
            Estado = estado;
        }
    }
}
