using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BuscaJob.Conexao
{
    class Conexao
    {
        private String connectionString;
        public String getConnecttionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CRUD_MYSQL.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
