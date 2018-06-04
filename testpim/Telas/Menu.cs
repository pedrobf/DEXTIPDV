using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Telas;

namespace testpim
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public Menu (String Valor)
        {
            InitializeComponent();
            admLbl.Text = Valor;
        }
        private void ClickPessoaFisica(object sender, EventArgs e)
        {
            new TelaCasdastroClienteF().Show();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new TelaCasdastroClienteF().Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroFuncionario().Show();
        }

        private void btnCadastroFuncionario(object sender, EventArgs e)
        {
            new CadastroFuncionario().Show();
        }

        private void btnClickCadastroCliente(object sender, EventArgs e)
        {
            new CadastroClienteFisico().Show();
        }

        private void btnClickarCadastroFornecedor(object sender, EventArgs e)
        {
            new CadastroFornecedor().Show();
        }

        private void clickBtnCadastroProduto(object sender, EventArgs e)
        {
            new CadastroProduto().Show();
        }

        private void clickBtnListarProduto(object sender, EventArgs e)
        {
            new ListarProduto().Show();
        }

        private void clickBtnAtualizarEstoque(object sender, EventArgs e)
        {
            new AtualizarEstoque().Show();
        }

        private void pnlFndMenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void clickRealizarVenda(object sender, EventArgs e)
        {
            new RealizarVenda().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new SobreDexti().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new RelatorioVendas().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Ajuda().Show();
        }
    }
}
