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

namespace testpim.Telas
{
    public partial class RealizarVenda : Form
    {
        Vendas vendas;
        Formulario form;
        public RealizarVenda()
        {

            InitializeComponent();
            form = new Formulario();
            dataMtbx.Text = DateTime.Now.ToShortDateString();
            vendas = new Vendas();

        }

        public void Listar()
        {
            dataGridView1.DataSource = vendas.ListarVendas(clienteTbx);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Adiciona um Cliente a venda
            if (clienteTbx.Text != "")
            {
                DataTable tb = vendas.VerificarCadatsroCliente(clienteTbx);
                if (tb.Rows.Count > 0)
                {
                    id_clienteTbx.Text = vendas.BuscarCliente(clienteTbx);
                } else {
                    MessageBox.Show("Cliente não Cadastrado!!por favor efetue seu CADASTRO!!!");
                } 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Realiza a busca de produto no estoque
            if (produtoTbx.Text != "")
            {
                DataTable tb = vendas.BuscarProduto(produtoTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tb;
                    id_produtoTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    produtoTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    descricaoTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    tipoCbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    generoCbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    precoTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                } else {

                    MessageBox.Show("Produto Não Encontrado!");
                }   
            }
        }

        private void incluir_produtoBtn_Click(object sender, EventArgs e)
        {
            //Adiciona um produto ao Carrinho de Compras
            if (precoTbx.Text != "" && qtdTbx.Text != "")
            {
                valorTbx.Text = Convert.ToString(Convert.ToDecimal((precoTbx.Text)) * Convert.ToDecimal((qtdTbx.Text)));
            }
            dataGridView1.DataSource = vendas.BuscarEstoque(tamanhoTbx, id_produtoTbx);
            dataGridView1.Refresh();
            DataTable tb = vendas.BuscarEstoque(tamanhoTbx, id_produtoTbx);
            if (tb.Rows.Count > 0)
            {
                if (qtdTbx.Text != "")
                {

                    int qtd_estoque = 0;
                    int qtd = int.Parse(qtdTbx.Text);
                    qtd_estoque = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    if (qtd > qtd_estoque)
                    {
                        MessageBox.Show("Quantidade maior do que   no estoque temos  a quantidade de  " + qtd_estoque.ToString() + "  produtos!!");
                        LimparProduto();

                    }

                    if (id_produtoTbx.Text == "")
                    {
                        MessageBox.Show("Escolha outra produto por favor!!");
                    }else { 
                        Vendas venda = new Vendas();
                        venda.Cliente.Nome = clienteTbx.Text;
                        venda.Cliente.Id = int.Parse(id_clienteTbx.Text);
                        venda.Produto.Nome = produtoTbx.Text;
                        venda.Produto.IdProduto = int.Parse(id_produtoTbx.Text);
                        venda.Produto.Genero = generoCbx.Text;
                        venda.Produto.Tipo = tipoCbx.Text;
                        venda.Tamanho = tamanhoTbx.Text;
                        venda.Qtd = int.Parse(qtdTbx.Text);
                        venda.Finalizada = 0;
                        venda.Produto.PrecoVenda = Convert.ToDecimal(precoTbx.Text);
                        venda.Data = DateTime.Parse(dataMtbx.Text);
                        venda.Codigo = int.Parse(id_clienteTbx.Text);
                        codigoLbl.Text = id_clienteTbx.Text;
                        codigoLbl.Visible = false;

                        if (venda.IncluirProduto(venda))
                        {
                            MessageBox.Show("Dados salvos com SUCESSO!!");
                            Listar();
                            id_venda.Text = venda.getId(venda).ToString();
                        }else {

                            MessageBox.Show("Erro ao salvar os DADOS!!");
                        }  
                    }
                } else {
                    MessageBox.Show("Entre com a quantidade do produto!!!");
                }
               
            } else {
                MessageBox.Show("Tamanho Inexistente,Entre com outro Tamanho");
            }
           
        }

        public void LimparProduto()
        {//Limpa os dados do produto
            form.LimpaTextBoxs(produtoTbx);
            form.LimpaTextBoxs(descricaoTbx);
            form.LimpaTextBoxs(id_produtoTbx);
            form.LimpaTextBoxs(tamanhoTbx);
            form.LimpaTextBoxs(valorTbx);
            form.LimpaTextBoxs(precoTbx);
            form.LimpaTextBoxs(qtdTbx);
        }

        public void LimparCliente()
        {//Limpa os dados do cliente
            form.LimpaTextBoxs(clienteTbx);
            form.LimpaTextBoxs(id_clienteTbx);
        }

        private void RealizarVenda_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exclui um produto do Carrinho de Compras
            vendas.Id_Venda = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (vendas.DeletarDados(vendas))
            {
                MessageBox.Show("Dados deletados com SUCESSO!!!!");
                Listar();

            } else  {
                MessageBox.Show("Erro ao deletar os DADOS");

                Listar();
            }
        }

        public String getTotal(Label codigo, MaskedTextBox data)
        {//Metódo que retorna o Total da venda de acordo com a data e o codigo do cliente
            MySqlConnection Con = new ConnectionFactory().Connectar();
            decimal total;
            Con.Open();
            string pegartotal = "SELECT sum(qtd*valor) FROM venda  WHERE  codigo='" + codigo.Text + "' and data_venda='" + data.Text + "'";
            MySqlCommand cmd = new MySqlCommand(pegartotal, Con);
            cmd.Prepare();
            total = Convert.ToDecimal((cmd.ExecuteScalar().ToString()));
            Con.Close();
            return total.ToString();

        }

        public void BaixaEstoque()
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {//Finalizando a Vendas de Produtos e exibindo Valor Total e preenchimento do valor recebido para calcular TROCO se houver necessidade e dar Baixa na quantidade de produtos do estoque
            if (valorLbl.Text == "Valor Recebido:")
            {
                vendaLbl.Text = 1.ToString();
                vendaLbl.Visible = false;
            }

            decimal valor_recebido;
            qtdLbl.Text = "Valor Total:";
            valorLbl.Text = "Valor Recebido:";
            valorTbx.Enabled = true;
            if (vendaLbl.Text == 1.ToString())
            {
                vendaLbl.Text = 0.ToString();
            } else {
                valorTbx.Clear();
            }

            vendas.Codigo = int.Parse(codigoLbl.Text);
            vendas.Data = DateTime.Parse(dataMtbx.Text);
            vendas.Finalizada = 0;
            qtdTbx.Text = vendas.ValorVenda(vendas.Codigo, vendas.Data, vendas.Finalizada);
            qtdTbx.Enabled = false;
            decimal total = decimal.Parse(qtdTbx.Text);
            if (valorLbl.Text == "Valor Recebido:")
            {
                if (valorTbx.Text != "")
                {
                    valor_recebido = decimal.Parse(valorTbx.Text);
                    if (valor_recebido >= total)
                    {
                        if (valor_recebido > total)
                        {
                            descricaoLbl.Text = "TROCO";
                            descricaoTbx.Text = (valor_recebido - total).ToString();
                            descricaoTbx.Enabled = false;


                        }

                        for (int x = 0; x < (dataGridView1.Rows.Count - 1); x++)
                        {

                            DataGridViewRow row = dataGridView1.Rows[x];

                            vendas.Qtd = Convert.ToInt32(row.Cells["qtd"].Value);

                            vendas.Produto.IdProduto = Convert.ToInt32(row.Cells["id_produto"].Value);
                            vendas.Id_Venda = Convert.ToInt32(row.Cells["id_venda"].Value);
                            vendas.DarBaixaEstoque(vendas.Qtd, vendas.Produto.IdProduto);
                            vendas.AtualizarVenda(vendas.Id_Venda);

                        }
                        MessageBox.Show("Venda finalizada com SUCESSO!!");
                        LimparCliente();
                        LimparProduto();

                    } else {
                        MessageBox.Show("Venda não pode ser concluida,pois o valor é menor do que o PREVISTO !!");
                    }
                    dataGridView1.DataSource = null;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

    

