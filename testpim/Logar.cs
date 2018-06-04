using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Dao;

namespace testpim
{
   public class Logar
    {
        public String User_name { get; set; }
        public String Password { get; set; }

        public bool Autenticacao(TextBox usuariotxt, TextBox senhatxt)//Metódo que retorna um,ou seja,verdadeiro se o o usuário consta na base de dados do Sistema sem erro e se não ele retorna 0,ou seja,falso
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string autenticar = "SELECT * FROM login where user_name='" + usuariotxt.Text + "'AND   password='" + senhatxt.Text + "'";

            MySqlCommand cmd = new MySqlCommand(autenticar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb.Rows.Count > 0;
        }
    }
}
