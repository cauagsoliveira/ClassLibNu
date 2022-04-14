using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibNu
{
    // documentaçao de classes de projeto. - XMLdocs

    public class Usuario
    {
        // atributos
        private int id;
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;
        
        private bool ativo;

        // propiedades
        public int Id { get { return Id; } }
        public string Nome { get { return Nome; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } }
        public bool Ativo { get { return Ativo; } set { Ativo = value; } }

        // métodos construtores
        
        



        public Usuario()
        {

        }
        public Usuario(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
            ativo = true;

        }

        public Usuario(int id, string nome, string email, string password, DateTime dateTime, bool ativo) {  
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
        }


        // métodos de classe
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.CommandText = "insert usuario( id, nome, email, nivel, password, ativo)" +
                "values('" + nome + "','" + id + "','" +
                Email + "',default,default)";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email",Email);
            cmd.Parameters.AddWithValue("password", Password);
            cmd.Parameters.AddWithValue("ativo", Ativo);
            cmd.CommandText = " selecione @@identity ";
           
            cmd.Connection.Close();


        }
        public static bool EfetuarLogin(string email, string password)
        {
            // realiza validação e devolve verdadeiro ou falso
            return false;

        }
        public static List<Usuario> listar()
        {
            List<Usuario> usuario = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                usuario.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));

            }

            return Usuario.listar();
        }
        

    }
}
