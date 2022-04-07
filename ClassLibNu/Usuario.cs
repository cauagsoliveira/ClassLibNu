using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Usuario(int id, string nome, string email, string password, bool ativo) {  
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.ativo = ativo;
        }


        // métodos de classe
        public int inserir()
        {
            // chamadas de banco e gravo registro
            return id;
           
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            // realiza validação e devolve verdadeiro ou falso
            return false;

        }
       
        

    }
}
