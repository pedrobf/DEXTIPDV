using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testpim.Dao;

namespace testpim
{
   public  class Estoque
    {
        public String NF { get; set; }
        public int Id_estoque { get; set; }
        public Decimal ValorNF { get; set; }
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }
        public int Qtd { get; set; }
        public String Tamanho { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdProduto { get; set; }
        public MySqlCommand Deletar { get; set; }

        public Estoque()
        {
            Produto = new Produto();
            Con = new ConnectionFactory().Connectar();
        }

        public bool AdicionarProduto(Estoque estoque)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser adicionado sem erro no estoque e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                    string inserir = "INSERT INTO estoque(nf,valor_nf,tamanho,qtd,id_produto,data_estoque) VALUES(@nf,@valor_nf,@tamanho,@qtd,@id_produto,@data_estoque);";
                    AdProduto = new MySqlCommand(inserir, Con);
                    Con.Open();
                    AdProduto.Parameters.Add(new MySqlParameter("nf", estoque.NF));
                    AdProduto.Parameters.Add(new MySqlParameter("valor_nf", estoque.ValorNF));
                    AdProduto.Parameters.Add(new MySqlParameter("tamanho", estoque.Tamanho));
                    AdProduto.Parameters.Add(new MySqlParameter("qtd", estoque.Qtd));
                    AdProduto.Parameters.Add(new MySqlParameter("id_produto",estoque.Produto.IdProduto));
                    AdProduto.Parameters.Add(new MySqlParameter("data_estoque", estoque.Data));
                    AdProduto.Prepare();
                    AdProduto.ExecuteNonQuery();
                    Con.Close();
                    verifica = 1;
             }

            catch (Exception erro)   {
                    verifica = 0;
                    throw erro;
             }
             
            return verifica > 0;  
        }

        public DataTable ListarEstoque()//Metódo que retorna um DataTable contendo os dados do Estoque
        {
            string listar = "SELECT id_estoque,nf,valor_nf,qtd,tamanho,id_produto,data_estoque FROM estoque";
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool DeletarDados(Estoque estoque)////Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser deletado do Estoque sem erro e se não ele retorna 0,ou seja,falso
        { int verifica;
            try {
                string deletar = "DELETE FROM estoque WHERE id_estoque=@id_estoque";
                Deletar = new MySqlCommand(deletar, Con);
                Con.Open();
               Deletar.Parameters.Add(new MySqlParameter("id_estoque", estoque.Id_estoque));
                Deletar.Prepare();
                Deletar.ExecuteNonQuery();
                Con.Close();
                verifica = 1;

            }

            catch(Exception erro) {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

        public bool Atualizarestoque(Estoque estoque)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser atualizado  no Estoque sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try  {
                string editar_estoque = "UPDATE estoque SET nf=@nf,valor_nf=@valor_nf,tamanho=@tamanho,qtd=@qtd,id_produto=@id_produto,data_estoque=@data_estoque WHERE id_estoque=@id_estoque";
                AdProduto = new MySqlCommand(editar_estoque, Con);
                Con.Open();
                AdProduto.Parameters.Add(new MySqlParameter("nf", estoque.NF));
                AdProduto.Parameters.Add(new MySqlParameter("valor_nf", estoque.ValorNF));
                AdProduto.Parameters.Add(new MySqlParameter("tamanho", estoque.Tamanho));
                AdProduto.Parameters.Add(new MySqlParameter("qtd", estoque.Qtd));
                AdProduto.Parameters.Add(new MySqlParameter("id_produto", estoque.Produto.IdProduto));
                AdProduto.Parameters.Add(new MySqlParameter("data_estoque", estoque.Data));
                AdProduto.Parameters.Add(new MySqlParameter("id_estoque", estoque.Id_estoque));
                AdProduto.Prepare();
                AdProduto.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }

            catch (Exception erro) {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }
    }
}
