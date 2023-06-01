using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Rohit.pt.com.Gvendas.MODEL
{
    public class Fornecedore
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        public long NIF { get; set; }


        public Fornecedore()
        {

        }

        public Fornecedore(int id)
        {
            Id = id;
        }
        public Fornecedore(string nome, string cidade, string email, string morada, long nif)
        {

            Nome = nome;
            Cidade = cidade;
            Email = email;
            Morada = morada;
            NIF = nif;
        }

        public Fornecedore(int id, string nome, string cidade, string email, string morada, long nif)
        {
            Id = id;
            Nome = nome;
            Cidade = cidade;
            Email = email;
            Morada = morada;
            NIF = nif;
        }
    }
}
