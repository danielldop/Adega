using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace AdegaStockFlow
{
    public static class Banco
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";//colocar senha pwd=ifsp; se for no pc do instituto

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(stringDeConexao);
        }
    }
}
