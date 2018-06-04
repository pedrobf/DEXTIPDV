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
    public partial class AtualizarEstoque : Form
    { Estoque estoque;
      Produto produto;
      Formulario form;

        public AtualizarEstoque()
        {
            form = new Formulario();
            InitializeComponent();
            ListarEstoque();
        }

        public void ListarEstoque() {//Lista os dados do Estoque
            estoque = new Estoque();
            dataGridView1.DataSource = estoque.ListarEstoque();
        }

        public void Listar()//Metódo que Lista os dados do Estoque
        {
            produto = new Produto();
            dataGridView1.DataSource = produto.ListarProduto();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//Realiza a busca dos dados do produto de acordo o TextBox do nome
        {
            Listar();

            MessageBox.Show(" Busca por Nome de Produto!");
            if (produtoTbx.Text != "")
            {
                DataTable tb = produto.BuscarProduto(produtoTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = produto.BuscarProduto(produtoTbx);
                    idprodutoTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    id_fornecedorLbl.Text= dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    id_fornecedorLbl.Visible = false;
                    ListarEstoque();
                }else{

                    MessageBox.Show("Produto não encontrado!!");

                }
                  
            }

            MessageBox.Show(" Busca por Id de Fornecedor!!");
            if (produtoTbx.Text != "")
            {
                DataTable tb = BuscarFornecedorPorId(id_fornecedorLbl);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = BuscarFornecedorPorId(id_fornecedorLbl);
                    nomefantTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Listar();
                    ListarEstoque();
                }  else  {
                     MessageBox.Show("Produto não associado a nenhum fornecedor!!!");

                }     
            }
        }

        DataTable BuscarFornecedorPorId(Label id_fornec)//Metódo que retorna um DateTable contendo o nome fantasia do fornecedor de acordo com a Label passada como parâmetro
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

        private void button2_Click(object sender, EventArgs e)
        {//Checa se a label atualizarLbl é igual a 1 e atualiza os dados do Estoque e se não ela insere um novo produto no Estoque
            if (atualizarLbl.Text == 1.ToString())
            {
                    Estoque estoque = new Estoque();
                    estoque.Id_estoque = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    estoque.NF = nfTbx.Text;
                    estoque.ValorNF = Convert.ToDecimal(nf_valorTbx.Text);
                    estoque.Qtd = int.Parse(qtdTbx.Text);
                    estoque.Tamanho = tamanhoTbx.Text;
                    estoque.Data = DateTime.Parse(dataTbx.Text);
                    estoque.Produto.IdProduto = int.Parse(idprodutoTbx.Text);
                    if (estoque.Atualizarestoque(estoque))
                    {
                        MessageBox.Show("Dados atualizados com SUCESSO!!");
                        atualizarLbl.Text = 0.ToString();
                        ListarEstoque();
                        Limpardados();
                    }  else  {
                        MessageBox.Show("Erro ao atualizar os DADOS !!");
                        Limpardados();
                    }
              
                }  else {
                        form.RetiraMascaras(dataTbx);                       
                        if (nfTbx.Text == "" || nf_valorTbx.Text == "" || qtdTbx.Text == "" || tamanhoTbx.Text == "" || idprodutoTbx.Text == "" || produtoTbx.Text == "" || dataTbx.Text == "")
                        {
                            MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");

                         }else {
                                 form.IncluirMascaras(dataTbx);
                                Estoque estoque = new Estoque();
                                estoque.NF = nfTbx.Text;
                                estoque.ValorNF = Convert.ToDecimal(nf_valorTbx.Text);
                                estoque.Qtd = int.Parse(qtdTbx.Text);
                                estoque.Tamanho = tamanhoTbx.Text;
                                estoque.Data = DateTime.Parse(dataTbx.Text);
                                estoque.Produto.IdProduto = int.Parse(idprodutoTbx.Text);

                                if (estoque.AdicionarProduto(estoque))
                                {
                                    MessageBox.Show("Dados salvos com SUCESSO!!!");
                                     ListarEstoque();
                                     Limpardados();
                                }else {
                                    MessageBox.Show("Erro ao salvar os DADOS!!");
                                    Limpardados();
                                }     
                         }

                }
        }

         private void button1_Click(object sender, EventArgs e) { 
              //Deleta os produtos do estoque
        
                    estoque.Id_estoque = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                   if (estoque.DeletarDados(estoque))
                    {
                        MessageBox.Show("Dados deletados com SUCESSO!!!!");
                        ListarEstoque();
                        Limpardados();
                    } else  {
                         MessageBox.Show("Erro ao deletar os DADOS");
                        Limpardados();

                    }     
                   
         }

        private void button3_Click(object sender, EventArgs e)
        {//Recupera os dados do estoque nos campos e no GridView para eles serem alterados
            atualizarLbl.Text = 1.ToString();
            atualizarLbl.Visible = false;
            nfTbx.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nf_valorTbx.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            qtdTbx.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tamanhoTbx.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            idprodutoTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dataTbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            MySqlConnection con = new ConnectionFactory().Connectar();
            string query = " SELECT fornecedor.nome_fantasia FROM produto INNER JOIN fornecedor  on produto.id_fornecedor =fornecedor.id_fornec";
            MySqlCommand buscar_fornecedor = new MySqlCommand(query, con);
            con.Open();
            nomefantTbx.Text = buscar_fornecedor.ExecuteScalar().ToString();
            con.Close();
            con.Open();
            string buscarproduto = " SELECT nome FROM produto WHERE id_produto='" + idprodutoTbx.Text + "'";
            MySqlCommand buscar_produto = new MySqlCommand(buscarproduto, con);
            produtoTbx.Text = buscar_produto.ExecuteScalar().ToString();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Limpardados()//Metódo que Limpa os dados dos TextBoxs e MaskedTextBoxs
        {
            form.LimpaTextBoxs(nf_valorTbx);
            form.LimpaMaskedTextBoxs(nfTbx);
            form.LimpaTextBoxs(produtoTbx);
            form.LimpaTextBoxs(idprodutoTbx);
            form.LimpaMaskedTextBoxs(dataTbx);
            form.LimpaTextBoxs(qtdTbx);
            form.LimpaTextBoxs(tamanhoTbx);
            form.LimpaTextBoxs(nomefantTbx);
        }

        private void AtualizarEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
