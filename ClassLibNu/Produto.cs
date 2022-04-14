using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibNu
{
    internal class Produto
    {
        // atributos

        private int id;
        private string descrição;
        private string unidade;
        public string codbar;
        public double valor;
        public double desconto;

        // propiedades 
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descrição; } set { descrição = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string CodBar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }

        //construtores

        public Produto(int id, string descricao, string unidade, string codBar, double valor, double desconto)
        {

            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        // metodos de classe

        public void Inserir()
        {


            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_id", Id);
            cmd.Parameters.AddWithValue("_descrição", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("codbar",CodBar);
            cmd.Parameters.AddWithValue("valor", Valor);
            cmd.CommandText = " selecione @@identity ";

            cmd.Connection.Close();


        }
        public bool Alterar(Produto produto)
        {
            return false;
        }

        public static Produto ConsultarPorId(string codbar)
        {
            Produto produto = new Produto();
            return produto;
        }
        public static List<Produto> Listar()
        {

            List<Produto> produto = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

               Produto.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));

            }

            return produto;

        }

       
    }
}
