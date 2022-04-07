using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNu
{
      public class Nivel
    {

   

    
        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        private bool ativo;

        // criando propiedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } }
        public string Sigla { get { return sigla; } }
         
        //metodos construtores
        
        public Nivel (string nome,string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;

        }
        
        
      
        public Nivel(  int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
          
        }

        // metodos da classe
        public void InserirNovo()
        {
            // inserir o novo nivel
        }
        /// <summary>
        /// Altera a sigla do niel indicado. apenas adiministradores
        /// </summary>
        /// <param name="id">indentificação do nivel</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor par teste logico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla)
        {
            return true;
        }
      }   

}
