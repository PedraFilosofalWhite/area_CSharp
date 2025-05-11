using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbeariaz
{

    public class Conexao
    {

        private static string stringConn = "Server=localhost;port=3306;database=barbearia;uid=root;pwd='Ph230905?';";

        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(stringConn);
            try
            {
                conn.Open();

            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }

        public static void Fecharconexao()
        {
            if (conn != null)
            {
                conn.Close();

            }

        }
    }

}
