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
    public partial class CadastroProduto : Form
    {
        Formulario form;
        Produto produto;

        public CadastroProduto()
        {
            form = new Formulario();
            InitializeComponent();
            Listar();
        }

        public void Listar()//Listar os dados dos Produtos
        {
            produto = new Produto();
            dataGridView1.DataSource = produto.ListarProduto();

        }

        private void btnBuscarFornec(object sender, EventArgs e)
        {//Busca os dados do fornecedor
            if (nomeFantTbx.Text != "")
            {
                DataTable tb = produto.BuscarFornecedor(nomeFantTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = produto.BuscarFornecedor(nomeFantTbx);
                    idfornecTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    nomeFantTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                } else {
                    MessageBox.Show("Fornecedor Não Encontrado");
                }
            }
        }

        private void btnSalvarProduto(object sender, EventArgs e)
        {//Checa se a label atualizarLbl é igual a 1 e atualiza os dados do Produto e se não ela insere um novo Produto no banco de dados
            if (atualizarLbl.Text == 1.ToString())
            {
                Produto produto = new Produto();
                produto.IdProduto = int.Parse(idprodutoTbx.Text);
                produto.Nome = nomeTbx.Text;
                produto.Descricao = descricaoTbx.Text;
                produto.Marca = marcaTbx.Text;
                produto.Tipo = tipoCbx.Text;
                produto.SubTipo = subTipoCbx.Text;
                produto.Genero = GeneroCbx.Text;
                produto.FaixaEtaria = faixaEtariaCbx.Text;
                produto.PrecoCusto = Convert.ToDecimal(precoCustoTbx.Text);
                produto.PrecoVenda = Convert.ToDecimal(precoVendaTbx.Text);
                produto.QtdMin = Convert.ToInt32(qtdMinTbx.Text);
                produto.QtdMax = Convert.ToInt32(qtdMaxTbx.Text);
                produto.DataCriacao = Convert.ToDateTime(dataCriacaoMtbx.Text);
                produto.Obs = obsTbx.Text;
                produto.Fornecedor.IdFornecedor = int.Parse(idfornecTbx.Text);
              
                if (produto.AtualizarProduto(produto))
                {
                    MessageBox.Show("Dados alterados com SUCESSO!!");
                    Listar();
                    idprodutoTbx.Text = produto.getId(produto).ToString();
                } else {
                    MessageBox.Show("Erro ao alterar os DADOS!!");
                }

            } else { 

                MessageBox.Show("Salvando..");

                if (precoCustoTbx.Text ==""||(nomeTbx.Text == "") || (descricaoTbx.Text == "") || (marcaTbx.Text == "") || (tipoCbx.Text == "") || (subTipoCbx.Text == "") || (GeneroCbx.Text == "") || (faixaEtariaCbx.Text == "")  || (precoVendaTbx.Text == "") ||  (nomeFantTbx.Text == "") || (dataCriacaoMtbx.Text == ""))
                {
                    MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");
                } else { 
               
                        if ( (qtdMinTbx.Text == "") || (qtdMaxTbx.Text == ""))
                        {
                            qtdMinTbx.Text = 0.ToString();
                            qtdMaxTbx.Text = 100.ToString();

                        }

                        Produto produto = new Produto();
                        produto.Nome = nomeTbx.Text;
                        produto.Descricao = descricaoTbx.Text;
                        produto.Marca = marcaTbx.Text;
                        produto.Tipo = tipoCbx.Text;
                        produto.SubTipo = subTipoCbx.Text;
                        produto.Genero = GeneroCbx.Text;
                        produto.FaixaEtaria = faixaEtariaCbx.Text;
                        produto.PrecoVenda = Convert.ToDecimal(precoVendaTbx.Text);
                        produto.PrecoCusto = Convert.ToDecimal(precoCustoTbx.Text);
                        produto.QtdMin = Convert.ToInt32(qtdMinTbx.Text);
                        produto.QtdMax = Convert.ToInt32(qtdMaxTbx.Text);
                        produto.DataCriacao = Convert.ToDateTime(dataCriacaoMtbx.Text);
                        produto.Obs = obsTbx.Text;
                        produto.Fornecedor.IdFornecedor = int.Parse(idfornecTbx.Text);

                        if (produto.Adicionar(produto))
                        {
                            MessageBox.Show("Dados salvos com SUCESSO!!");
                            Listar();
                            idprodutoTbx.Text = produto.getId(produto).ToString();
                        }else {

                            MessageBox.Show("Erro ao salvar os DADOS!!");
                        }                                       
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Limpa os dados de todos os campos para serem inseridos novos valores
            form.LimpaMaskedTextBoxs(dataCriacaoMtbx);
            form.LimpaTextBoxs(nomeFantTbx);
            form.LimpaTextBoxs(idfornecTbx);
            form.LimpaTextBoxs(descricaoTbx);
            form.LimpaTextBoxs(nomeTbx);
            form.LimpaTextBoxs(marcaTbx);
            form.LimpaTextBoxs(obsTbx);
            form.LimpaTextBoxs(precoVendaTbx);
            form.LimpaTextBoxs(precoCustoTbx);
            form.LimpaTextBoxs(nomeFantTbx);
            form.LimpaTextBoxs(idprodutoTbx);
            form.LimpaTextBoxs(qtdMaxTbx);
            form.LimpaTextBoxs(qtdMinTbx);
        }

         public String getNome_Fantasia(TextBox id) { //Retorna o nome fantasia do fornecedor de acordo com o valor do campo id
            
                MySqlConnection Con = new ConnectionFactory().Connectar();
                Con.Open();
                string buscar_fornecedor = "SELECT nome_fantasia FROM fornecedor WHERE id_fornec = '" + id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
                string nome = cmd.ExecuteScalar().ToString();
                 return nome;
          }
        
        private void button4_Click(object sender, EventArgs e) {
            //Recupera os dados do produto nos campos e no Grid de acordo o valor do campo do nome de produto ou nome fantasia de fornecedor**
            MessageBox.Show(" Busca por Nome de Produto!");
            if (nomeTbx.Text != "")
            {
                DataTable tb = produto.BuscarProduto(nomeTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tb;
                    idprodutoTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    nomeTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    descricaoTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    marcaTbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    tipoCbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    subTipoCbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    GeneroCbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    faixaEtariaCbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    precoVendaTbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    precoCustoTbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    qtdMinTbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    qtdMaxTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    dataCriacaoMtbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    obsTbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    idfornecTbx.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    nomeFantTbx.Text = getNome_Fantasia(idfornecTbx);
                } else {

                    MessageBox.Show("Produto Não Encontrado!");
                }         
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//Recupera os dados do produto nos campos e no GridView para eles serem alterados
            atualizarLbl.Text = 1.ToString();
            atualizarLbl.Visible = false;
            idprodutoTbx.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nomeTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            descricaoTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            marcaTbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tipoCbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            subTipoCbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            GeneroCbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            faixaEtariaCbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            precoVendaTbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            precoCustoTbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            qtdMinTbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            qtdMaxTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            dataCriacaoMtbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            obsTbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            idfornecTbx.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            nomeFantTbx.Text = getNome_Fantasia(idfornecTbx);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void precoVendaTbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
