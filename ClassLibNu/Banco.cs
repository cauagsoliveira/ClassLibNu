using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLibNu
{
     public static class Banco
     {
       public static string Strconexao { get; set; }
        
        public static MySqlCommand  Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strcon = @"";
            MySqlConnection cn = new MySqlCommand(strcon);
            cn.Opem();
            cnd.Connectio

        }
     }
}
