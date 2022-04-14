using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public Cliente(string nome, string cpf, string email)
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
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clintes( nome, cpf, email, datacad, ativo)" +
                "values('" + nome + "','" + cpf + "','" +
                Email + "',default,default)";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.CommandText = " selecione @@identity ";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
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
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cliente.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));

            }

            return cliente;

        } 
    }     
}
