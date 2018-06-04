using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpim.Dao
{
    public class ConnectionFactory
    {
        private string Conexao = "server=localhost;user id=dexti;password=dexti;database=loja;SslMode=none";//String de Conexão
        public MySqlConnection Connectar()//Metódo que retorna a string de conexão com o banco de dados
        {
            return new MySqlConnection(Conexao);
        }
    }
}
