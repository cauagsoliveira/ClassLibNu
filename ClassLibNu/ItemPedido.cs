using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNu
{
    
    public class ItemPedido
    {
        //atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;

        //propiedades
        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
         
        
        // contrutores
        public ItemPedido()
        {
        }

        public ItemPedido(Produto produto, double valor, double quantidade, double desconto)
        {
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public void inserir() { }
        public void change(ItemPedido item)
        {

        }
     


       

    }
}
