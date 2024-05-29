using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public static class Banco
    {
        public static MySqlCommand Abrir() 
        {
            MySqlCommand cmd = new MySqlCommand();
            // dados da conexão
            string strconn = @"server=127.0.0.1;database=ComercialDB;user id=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            try // tratamento de excessão
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }
}
