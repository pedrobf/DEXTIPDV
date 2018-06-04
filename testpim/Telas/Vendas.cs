using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Dao;

namespace testpim.Telas
{
    public class Vendas
    {
        public int Id_Venda { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public DateTime Data { get; set; }
        public int Qtd { get; set; }
        public String Tamanho { get; set; }
        public Estoque Estoque { get; set; }
        public int Codigo { get; set; }
        public int Finalizada { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdVenda { get; set; }
        public MySqlCommand Deletar { get; set; }

        public Vendas()
        {
            Produto = new Produto();
            Con = new ConnectionFactory().Connectar();
            Cliente = new Cliente();
        }

        public String BuscarCliente(TextBox nome)//Metódo que retorna o id do cliente de acordo com o TextBox passado como parâmetro
        {
            Con.Open();
            string buscar_cliente = "SELECT id_client FROM cliente WHERE nome = '" + nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_cliente, Con);
            string id = cmd.ExecuteScalar().ToString();
            Con.Close();
            return id;
        }

        public DataTable VerificarCadatsroCliente(TextBox nome)//Metódo que retorna um DateTable contendo os dados do cliente de acordo com o TextBox passado como parâmetro para verificar seu Cadastro no Sistema 
        {
            Con.Open();
            string buscar_cliente = "SELECT id_client FROM cliente WHERE nome = '" + nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_cliente, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public DataTable BuscarProduto(TextBox nome)//Metódo que retorna um DateTable contendo os dados do produto de acordo com o TextBox passado como parâmetro
        {
            Con.Open();
            string buscar_produto = "SELECT p.id_produto,p.nome,p.descricao,p.tipo,p.genero,p.preco_venda,es.qtd,es.tamanho FROM produto p INNER JOIN estoque es on es.id_produto=p.id_produto  WHERE p.nome= '" + nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_produto, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public DataTable BuscarEstoque(TextBox tamanho, TextBox id)//Metódo que retorna a quantidade de produtos no estoque de acordo com o tamanho e id do produto passados como parâmetro
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_qtd = "SELECT qtd from estoque WHERE tamanho='" + tamanho.Text + "' AND id_produto='" + id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_qtd, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool IncluirProduto(Vendas vendas)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser incluido no carrinho de compras  sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string inserir = "INSERT INTO venda (id_cliente,codigo,nome_cliente,id_produto,nome_produto,genero_produto,tipo_produto,data_venda,qtd,valor,finalizada) VALUES(@id_cliente,@codigo,@nome_cliente,@id_produto,@nome_produto,@genero_produto,@tipo_produto,@data_venda,@qtd,@valor,@finalizada);";
                AdVenda = new MySqlCommand(inserir, Con);
                Con.Open();
                AdVenda.Parameters.Add(new MySqlParameter("id_cliente", vendas.Cliente.Id));
                AdVenda.Parameters.Add(new MySqlParameter("codigo", vendas.Codigo));
                AdVenda.Parameters.Add(new MySqlParameter("nome_cliente", vendas.Cliente.Nome));
                AdVenda.Parameters.Add(new MySqlParameter("id_produto", vendas.Produto.IdProduto));
                AdVenda.Parameters.Add(new MySqlParameter("nome_produto", vendas.Produto.Nome));
                AdVenda.Parameters.Add(new MySqlParameter("genero_produto", vendas.Produto.Genero));
                AdVenda.Parameters.Add(new MySqlParameter("tipo_produto", vendas.Produto.Tipo));
                AdVenda.Parameters.Add(new MySqlParameter("data_venda", vendas.Data));
                AdVenda.Parameters.Add(new MySqlParameter("qtd", vendas.Qtd));
                AdVenda.Parameters.Add(new MySqlParameter("valor", vendas.Produto.PrecoVenda));
                AdVenda.Parameters.Add(new MySqlParameter("finalizada", vendas.Finalizada));
                AdVenda.Prepare();
                AdVenda.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }

            catch (Exception erro) {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

        public DataTable ListarVendas(TextBox nome)//Metódo que retorna um DateTable contendo os dados das Vendas
        {
            string listar = "SELECT id_venda,id_cliente,codigo,nome_cliente,id_produto,nome_produto,genero_produto,tipo_produto,data_venda,qtd,valor FROM venda WHERE nome_cliente='"+nome.Text+"' and finalizada =0";
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public int getId(Vendas vendas)//Metódo que retorna o id da venda de acordo com a venda passada como parâmetro
        {
            Con.Open();
            string pegarid = "SELECT id_venda FROM venda WHERE nome_produto='" + vendas.Produto.Nome + "'";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
            Id_Venda = int.Parse(cmd.ExecuteScalar().ToString());
            Con.Close();
            return Id_Venda;
        }

        public bool DeletarDados(Vendas venda)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde removido do carrinho de compras  sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string deletar = "DELETE FROM venda WHERE id_venda=@id_venda";
                Deletar = new MySqlCommand(deletar, Con);
                Con.Open();
                Deletar.Parameters.Add(new MySqlParameter("id_venda", venda.Id_Venda));
                Deletar.Prepare();
                Deletar.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }

            catch (Exception erro)
            {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

         public void DarBaixaEstoque( int quantidade, int idProduto)//Metódo que atualiza a quantidade do estoque de acordo com a quantidade e id do produto vendido
        { 
            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Con;
                Con.Open();
                cmd.CommandText = "UPDATE estoque SET qtd= qtd - @quantidade where id_produto=@idProduto  ";
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Con.Close();
             
            }
         
            catch (Exception erro)  {
               
                throw erro;
            }
        }

        public string ValorVenda(int codigo,DateTime data,int finalizada)//Metódo que retorna o Valor Total das vendas de acordo com a data,codigo do cliente, das vendas finalizadas
        {
            Con.Open();
            string pegarid = "Select SUM(qtd*valor) FROM venda WHERE codigo=@codigo AND data_venda=@data AND finalizada=@finalizada";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Parameters.AddWithValue("@codigo",codigo);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@finalizada", finalizada);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            string total =cmd.ExecuteScalar().ToString();
            Con.Close();
            return total;
        }

        public DataTable RelatorioClientePeriodo(DateTime data_inicial,DateTime data_final,string nome_cliente)//Metódo que retorna um DateTable contendo os  dados das vendas efetuadas de acordo as datas e nome do cliente passados como parâmetros
        {
            string relatorio = "SELECT  id_venda,id_cliente,nome_cliente,id_produto,nome_produto,genero_produto,tipo_produto,data_venda,qtd,valor FROM venda WHERE data_venda BETWEEN @data_inicial AND @data_final AND nome_cliente=@cliente  AND finalizada=1";
            AdVenda = new MySqlCommand(relatorio, Con);
            AdVenda.Parameters.AddWithValue("@data_inicial", data_inicial);
            AdVenda.Parameters.AddWithValue("@data_final", data_final);
            AdVenda.Parameters.AddWithValue("@cliente", nome_cliente);
            MySqlDataAdapter adp = new MySqlDataAdapter(AdVenda);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public DataTable RelatorioPeriodo(DateTime data_inicial, DateTime data_final)//Metódo que retorna um DateTable contendo os  dados das vendas efetuadas de acordo as datas passadas como parâmetros
        {
            string relatorio = "SELECT  id_venda,id_cliente,nome_cliente,id_produto,nome_produto,genero_produto,tipo_produto,data_venda,qtd,valor FROM venda WHERE data_venda BETWEEN @data_inicial AND @data_final AND finalizada=1";
            AdVenda = new MySqlCommand(relatorio, Con);
            AdVenda.Parameters.AddWithValue("@data_inicial", data_inicial);
            AdVenda.Parameters.AddWithValue("@data_final", data_final);
            MySqlDataAdapter adp = new MySqlDataAdapter(AdVenda);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;

        }

        public void AtualizarVenda(int id_venda)//Atualiza a venda para finalziada colocando o valor de finalizada para 1
        {
            Con.Open();
            string atualizar = "UPDATE venda SET finalizada=1 WHERE id_venda=@id_venda";
            AdVenda = new MySqlCommand(atualizar, Con);
            AdVenda.Parameters.AddWithValue("id_venda", id_venda);
            AdVenda.Prepare();
            AdVenda.ExecuteNonQuery();
            Con.Close();
        }

        public string ValorVendaRelatorio(string nome_cliente, DateTime data_inicial,DateTime data_final )//Metódo que retorna o Valor Total das Vendas de acordo com as datas e nome de cliente passados como parâmetro
        {
            Con.Open();
            string pegarid = "SELECT SUM(qtd*valor) FROM venda WHERE nome_cliente=@nome AND data_venda BETWEEN @data_inicial AND @data_final AND finalizada=1";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Parameters.AddWithValue("@nome",nome_cliente);
            cmd.Parameters.AddWithValue("@data_inicial", data_inicial);
            cmd.Parameters.AddWithValue("@data_final", data_final);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            string total = cmd.ExecuteScalar().ToString();
            Con.Close();
            return total;
        }

        public string ValorVendaRelatorioPeriodo(DateTime data_inicial, DateTime data_final)//Metódo que retorna o Valor Total das Vendas de acordo com as datas passadas como parâmetro
        {
            Con.Open();
            string pegarid = "SELECT SUM(qtd*valor) FROM venda WHERE   data_venda BETWEEN @data_inicial AND  @data_final AND finalizada=1";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Parameters.AddWithValue("@data_inicial", data_inicial);
            cmd.Parameters.AddWithValue("@data_final", data_final);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            string total = cmd.ExecuteScalar().ToString();
            Con.Close();
            return total;
        }


    }
}
