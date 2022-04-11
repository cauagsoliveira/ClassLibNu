using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibNu
{
    public  class ItemPedido
    {
        // atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;

        // propiedades
        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }


       
    }
}
