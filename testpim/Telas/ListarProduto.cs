using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Dao;

namespace testpim
{
    public partial class ListarProduto : Form
    {
       
        Produto prod;

        public ListarProduto()
        {
            InitializeComponent();
            prod = new Produto();
          
        }

        DataTable BuscarFornecedorPorId(Label id_fornec)//Retorna o nome fantasia do fornecedor de acordo com o valor passado para a label
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_fornecedor = "SELECT nome_fantasia  FROM fornecedor WHERE id_fornec = '" + id_fornec.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        DataTable BuscarProdutosFornecedorId(Label id)
        {//Metódo que retorna um DateTable contendo os dados do produto de acordo com valor passado para a label
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_fornecedor = " SELECT id_produto,nome,descricao,marca,tipo,sub_tipo,genero,faixa_etaria,preco_venda,preco_custo,qtd_min,qtd_max,data_criacao,obs,id_fornecedor FROM produto WHERE id_fornecedor='" + id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        DataTable BuscarProdutosFornecedorNome(TextBox nome)
        {//Metódo que retorna um DateTable contendo os dados do id do fornecedor de acordo com valor passado para o textbox
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_fornecedor = " SELECT id_fornec FROM fornecedor WHERE nome_fantasia='" + nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
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

        private void button4_Click(object sender, EventArgs e)
        {//Realiza a Busca dos Produtos de acordo com o nome do produto ou nome fantasia de fornecedor
            if (produtoTbx.Text != "")
            {
                DataTable tb = prod.BuscarProduto(produtoTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = prod.BuscarProduto(produtoTbx);
                    marcaTbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    tipoCbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    subtipoCbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    generoCbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    faixaetariaCbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    datacriacaoMtbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    nomefornecedorLbl.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    nomefornecedorLbl.Visible = false;
                    dataGridView1.DataSource = BuscarFornecedorPorId(nomefornecedorLbl);
                    nomefantTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                } else {
                    MessageBox.Show("Produto Não Encontrado!!!");
                } 
                 
            }

            if (nomefantTbx.Text != "")
            {
                DataTable tb = BuscarProdutosFornecedorNome(nomefantTbx);
                if(tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = BuscarProdutosFornecedorNome(nomefantTbx);
                    id_fornec.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    id_fornec.Visible = false;
                    dataGridView1.DataSource = BuscarProdutosFornecedorId(id_fornec);
                } else  {
                    MessageBox.Show("Fornecedor Não Encontrado!!!");
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
