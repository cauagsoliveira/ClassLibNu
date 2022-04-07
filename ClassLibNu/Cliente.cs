using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNu
{
    public class Cliente
    {
        // atributos

        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime password;
        private bool ativo;
        
        //propiedades

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime Password { get { return password; } set { password = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }
         
        //construtores

        public  Cliente( string nome, string cpf, string email )
        {
         
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Password = password;
            Ativo = ativo;
        }

        public Cliente(int id, string name, string cpf, string email, DateTime password, bool ativo)
        {
            Id = id;
            Nome = name;
            Cpf = cpf;
            Email = email;
            Password = password;
            Ativo = ativo;
        }

        public Cliente()
        {

        }


        //metodos da classe
        public void Inserir(Cliente cliente)
        {

        }
        public bool Alterar(Cliente cliente)
        {
            return true;
        }
        public static Cliente ConsultarPorId(int id) 
        {

            Cliente cliente = new Cliente();
            return cliente;

        }
        public static Cliente ConsultarPorCpf(string cpf)
        {

            Cliente cliente = new Cliente();
            return cliente;
            
        }
        public static List<Cliente> Listar()
        {

            List<Cliente> cliente = new List<Cliente>();
            return cliente;

        }

    }







        
}
