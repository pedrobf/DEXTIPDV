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
    public class Produto
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Marca { get; set; }
        public String Tipo { get; set; }
        public String SubTipo { get; set; }
        public String Genero { get; set; }
        public String FaixaEtaria { get; set; }
        public Decimal PrecoVenda { get; set; }
        public Decimal PrecoCusto { get; set; }
        public String Obs { get; set; }
        public int QtdMax { get; set; }
        public int QtdMin { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataCriacao { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdProduto { get; set; }
        public MySqlCommand Deletar { get; set; }

        public Produto()
        {
            Fornecedor = new Fornecedor();
            Con = new ConnectionFactory().Connectar();
        }

        public bool Adicionar(Produto produto)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser cadastrado sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {

                string inserir = "INSERT INTO produto(nome,descricao,marca,tipo,sub_tipo,genero,faixa_etaria,preco_venda,preco_custo,qtd_min,qtd_max,data_criacao,obs,id_fornecedor) VALUES(@nome,@descricao,@marca,@tipo,@sub_tipo,@genero,@faixa_etaria,@preco_venda,@preco_custo,@qtd_min,@qtd_max,@data_criacao,@obs,@id_fornecedor);";
                AdProduto = new MySqlCommand(inserir, Con);
                Con.Open();
                AdProduto.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                AdProduto.Parameters.Add(new MySqlParameter("descricao", produto.Descricao));
                AdProduto.Parameters.Add(new MySqlParameter("marca", produto.Marca));
                AdProduto.Parameters.Add(new MySqlParameter("tipo", produto.Tipo));
                AdProduto.Parameters.Add(new MySqlParameter("sub_tipo", produto.SubTipo));
                AdProduto.Parameters.Add(new MySqlParameter("genero", produto.Genero));
                AdProduto.Parameters.Add(new MySqlParameter("faixa_etaria", produto.FaixaEtaria));
                AdProduto.Parameters.Add(new MySqlParameter("preco_venda", produto.PrecoVenda));
                AdProduto.Parameters.Add(new MySqlParameter("preco_custo", produto.PrecoCusto));
                AdProduto.Parameters.Add(new MySqlParameter("qtd_min", produto.QtdMin));
                AdProduto.Parameters.Add(new MySqlParameter("qtd_max", produto.QtdMax));
                AdProduto.Parameters.Add(new MySqlParameter("data_criacao", produto.DataCriacao.ToString("yyyy-MM-dd")));
                AdProduto.Parameters.Add(new MySqlParameter("obs", produto.Obs));
                AdProduto.Parameters.Add(new MySqlParameter("id_fornecedor", produto.Fornecedor.IdFornecedor));
                AdProduto.Prepare();
                AdProduto.ExecuteNonQuery();
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

        public DataTable BuscarFornecedor(TextBox nome_fantasia)//Metódo que retorna um DateTable contendo os dados do produto de acordo com o TextBox passado como parâmetro
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_fornecedor = "SELECT id_fornec,nome_fantasia FROM fornecedor where nome_fantasia = '" + nome_fantasia.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

       
        public DataTable ListarProduto()//Metódo que retorna um DateTable contendo os dados dos Produtos
        {
            string listar = "SELECT id_produto,nome,descricao,marca,tipo,sub_tipo,genero,faixa_etaria,preco_venda,preco_custo,qtd_min,qtd_max,data_criacao,obs,id_fornecedor FROM produto";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public int getId(Produto produto)//Metódo que retorna o id do produto de acordo com o produto passado como parâmetro
        {
            Con.Open();
            string pegarid = "Select id_produto from produto where nome='" + produto.Nome + "'";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
            IdProduto = int.Parse(cmd.ExecuteScalar().ToString());
            Con.Close();
            return IdProduto;
        }

        public DataTable BuscarProduto(TextBox nome)//Metódo que retorna um DateTable contendo os dados do produto de acordo com o TextBox passado como parâmetro
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_produto = "SELECT id_produto,nome,descricao,marca,tipo,sub_tipo,genero,faixa_etaria,preco_venda,preco_custo,qtd_min,qtd_max,data_criacao,obs,id_fornecedor FROM produto  where nome= '" + nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_produto, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool AtualizarProduto(Produto produto)//Metódo que retorna um,ou seja,verdadeiro se o produto pôde ser atualizado  sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string editar_produto = "UPDATE produto SET nome=@nome,descricao=@descricao,marca=@marca,tipo=@tipo,sub_tipo=@sub_tipo,genero=@genero,faixa_etaria=@faixa_etaria,preco_venda=@preco_venda,preco_custo=@preco_custo,qtd_min=@qtd_min,qtd_max=@qtd_max,data_criacao=@data_criacao,obs=@obs,id_fornecedor=@id_fornecedor where id_produto=@id_produto";
                AdProduto = new MySqlCommand(editar_produto, Con);
                Con.Open();
                AdProduto.Parameters.Add(new MySqlParameter("id_produto", produto.IdProduto));
                AdProduto.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                AdProduto.Parameters.Add(new MySqlParameter("descricao", produto.Descricao));
                AdProduto.Parameters.Add(new MySqlParameter("marca", produto.Marca));
                AdProduto.Parameters.Add(new MySqlParameter("tipo", produto.Tipo));
                AdProduto.Parameters.Add(new MySqlParameter("sub_tipo", produto.SubTipo));
                AdProduto.Parameters.Add(new MySqlParameter("genero", produto.Genero));
                AdProduto.Parameters.Add(new MySqlParameter("faixa_etaria", produto.FaixaEtaria));
                AdProduto.Parameters.Add(new MySqlParameter("preco_venda", produto.PrecoVenda));
                AdProduto.Parameters.Add(new MySqlParameter("preco_custo", produto.PrecoCusto));
                AdProduto.Parameters.Add(new MySqlParameter("qtd_min", produto.QtdMin));
                AdProduto.Parameters.Add(new MySqlParameter("qtd_max", produto.QtdMax));
                AdProduto.Parameters.Add(new MySqlParameter("data_criacao", produto.DataCriacao.ToString("yyyy-MM-dd")));
                AdProduto.Parameters.Add(new MySqlParameter("obs", produto.Obs));
                AdProduto.Parameters.Add(new MySqlParameter("id_fornecedor", produto.Fornecedor.IdFornecedor));
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
