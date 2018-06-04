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
    public partial class RelatorioVendas : Form
    {
        Formulario form;
        Vendas venda;
        public RelatorioVendas()
        {
            InitializeComponent();
            venda = new Vendas();
            form = new Formulario();
        }
       public void  LimparDados()
        {//Limpa os dados dos campos para a realização de uma nova pesquisa
            form.LimpaTextBoxs(clienteTbx);
            form.LimpaMaskedTextBoxs(data_finalMtbx);
            form.LimpaMaskedTextBoxs(data_inicialMtbx);  
        }

        private void button4_Click(object sender, EventArgs e)
        {//Realiza a busca dos dados da venda para exibir no Relatório
            form.RetiraMascaras(data_finalMtbx);
            form.RetiraMascaras(data_inicialMtbx);
            if ((data_inicialMtbx.Text == "") || (data_finalMtbx.Text == ""))
            {
                MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");
            }  else { 
                if ((clienteTbx.Text != "") && (data_inicialMtbx.Text!="")&&(data_finalMtbx.Text!=""))
                {
                    form.IncluirMascaras(data_finalMtbx);
                    form.IncluirMascaras(data_inicialMtbx);
                    DataTable tb = venda.RelatorioClientePeriodo(DateTime.Parse(data_inicialMtbx.Text), DateTime.Parse(data_finalMtbx.Text), clienteTbx.Text);
                    if (tb.Rows.Count > 0)
                    {
                        string nome = clienteTbx.Text;
                       DateTime data_inicial = DateTime.Parse(data_inicialMtbx.Text);
                        DateTime data_final = DateTime.Parse(data_finalMtbx.Text);
                        dataGridView1.DataSource = venda.RelatorioClientePeriodo(DateTime.Parse(data_inicialMtbx.Text), DateTime.Parse(data_finalMtbx.Text), clienteTbx.Text);
                        totalLbl.Text = "TOTAL:" + venda.ValorVendaRelatorio(nome, data_inicial, data_final);
                    }  else {
                        MessageBox.Show("Nenhuma Venda Encontrada  para este CLIENTE neste período!!");
                    }
                } else {

                    form.IncluirMascaras(data_finalMtbx);
                    form.IncluirMascaras(data_inicialMtbx);
                    DataTable tb = venda.RelatorioPeriodo(DateTime.Parse(data_inicialMtbx.Text), DateTime.Parse(data_finalMtbx.Text));
                    if (tb.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = tb;
                        DateTime data_inicial = DateTime.Parse(data_inicialMtbx.Text);
                        DateTime data_final = DateTime.Parse(data_finalMtbx.Text);
                        totalLbl.Text = "TOTAL:" + venda.ValorVendaRelatorioPeriodo( data_inicial, data_final);
                    } else{
                        MessageBox.Show("Nenhuma Venda Encontrada para este período!!");
                    }
                } 
               
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
