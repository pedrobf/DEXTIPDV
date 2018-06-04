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
using MySql.Data.MySqlClient;

namespace testpim
{
    public partial class CadastroFornecedor : Form
    {
        Validacao val;
        Formulario form;
        Fornecedor fornecedor;
        
        public CadastroFornecedor()
        {
            val = new Validacao();
            form = new Formulario();
            InitializeComponent();
            Listar();
            
        }

        public void Listar()//Lista os dados dos Fornecedores
        {
            fornecedor = new Fornecedor();
            dataGridView1.DataSource = fornecedor.ListarFornecedor();

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnClickSalvarFornecedor(object sender, EventArgs e)
        {//Checa se a label atualizarLbl é igual a 1 e atualiza os dados do Fornecedor e se não ela insere um novo Fornecedor no banco de dados
            int cnpj = 1;
            int email = 1;
            if (atualizaLbl.Text == 1.ToString())
            {
                    
                    if (val.ValidarEmail(emailTbx.Text))
                    {
                        
                    }else {
                        MessageBox.Show("Email Inválido!!!");
                        form.LimpaTextBoxs(emailTbx);
                    }
                   
                    form.RetiraMascaras(cnpjMtbx);
                    if (val.ValidaCnpj(cnpjMtbx.Text))
                    {
                        
                    }else {
                        MessageBox.Show("CNPJ Inválido!!!");
                        form.LimpaMaskedTextBoxs(cnpjMtbx);
                    }
                   
                    Fornecedor fornecedor = new Fornecedor();
                    form.RetiraMascaras(telempMtbx);
                    form.RetiraMascaras(telcelMtbx);
                    form.RetiraMascaras(telfaxMtbx);
                    form.RetiraMascaras(cepMtbx);
                    form.RetiraMascaras(cnpjMtbx);
                    fornecedor.IdFornecedor = int.Parse(idfornecTbx.Text);
                    fornecedor.NomeContato = nomeContTbx.Text;
                    fornecedor.RazaoSocial = razaoSocialTbx.Text;
                    fornecedor.NomeFantasia = nomeFantTbx.Text;
                    fornecedor.CNPJ = cnpjMtbx.Text;
                    fornecedor.IE = ieTbx.Text;
                    fornecedor.Email = emailTbx.Text;
                    fornecedor.WebSite = siteTbx.Text;
                    fornecedor.TelEmpresa = telempMtbx.Text;
                    fornecedor.TelCelular = telcelMtbx.Text;
                    fornecedor.TelFax = telfaxMtbx.Text;
                    fornecedor.Logradouro.Cidade.UF = ufTbx.Text;
                    fornecedor.Logradouro.Cidade.Nome = cidadeTbx.Text;
                    fornecedor.Logradouro.Endereco = enderecoTbx.Text;
                    fornecedor.Logradouro.Numero = numeroTbx.Text;
                    fornecedor.Logradouro.Complemento = complementoTbx.Text;
                    fornecedor.Logradouro.Bairro = bairroTbx.Text;
                    fornecedor.Logradouro.CEP = cepMtbx.Text;
                    fornecedor.Situacao = situacaoCbx.Text;
                    fornecedor.Obs = obsTbx.Text;

                    if (fornecedor.AtualizarFornecedor(fornecedor))
                    {
                        MessageBox.Show("Dados alterados com SUCESSO!!");
                        Listar();
                    } else {
                        MessageBox.Show("Erro ao alterar DADOS!!");
                    }

                    atualizaLbl.Text = 0.ToString();
                    atualizaLbl.Visible = false;
                    Listar();
                
            }  else { 

                if ((nomeContTbx.Text == "") || (nomeFantTbx.Text == "") || (razaoSocialTbx.Text == "") || (cnpjMtbx.Text == "") || (ieTbx.Text == "") || (emailTbx.Text == "") || (telempMtbx.Text == "") || (telcelMtbx.Text == "") || (enderecoTbx.Text == "") || (numeroTbx.Text == "") || (bairroTbx.Text == "") || (cidadeTbx.Text == "") || (cepMtbx.Text == "") || (ufTbx.Text == "") || (situacaoCbx.Text == ""))
                {
                    MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");
                } else { 
                    if (emailTbx.Text != "")
                    {
                        if (val.ValidarEmail(emailTbx.Text))
                        {
                            
                            email = 1;
                        } else {
                            MessageBox.Show("Email Inválido!!!");
                            form.LimpaTextBoxs(emailTbx);
                            email = 0;
                        }
                    }

                    form.RetiraMascaras(cnpjMtbx);
                    if (cnpjMtbx.Text != "")
                    {
                        if (val.ValidaCnpj(cnpjMtbx.Text))
                        {
                          
                            cnpj = 1;
                        } else {
                            MessageBox.Show("CNPJ Inválido!!!");
                            form.LimpaMaskedTextBoxs(cnpjMtbx);
                            cnpj = 0;
                        }  
                    }

                    if ((cnpj > 0) && (email > 0))
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        form.RetiraMascaras(telempMtbx);
                        form.RetiraMascaras(telcelMtbx);
                        form.RetiraMascaras(telfaxMtbx);
                        form.RetiraMascaras(cepMtbx);
                        form.RetiraMascaras(cnpjMtbx);
                        fornecedor.NomeContato = nomeContTbx.Text;
                        fornecedor.RazaoSocial = razaoSocialTbx.Text;
                        fornecedor.NomeFantasia = nomeFantTbx.Text;
                        fornecedor.CNPJ = cnpjMtbx.Text;
                        fornecedor.IE = ieTbx.Text;
                        fornecedor.Email = emailTbx.Text;
                        fornecedor.WebSite = siteTbx.Text;
                        fornecedor.TelEmpresa = telempMtbx.Text;
                        fornecedor.TelCelular = telcelMtbx.Text;
                        fornecedor.TelFax = telfaxMtbx.Text;
                        fornecedor.Logradouro.Cidade.UF = ufTbx.Text;
                        fornecedor.Logradouro.Cidade.Nome = cidadeTbx.Text;
                        fornecedor.Logradouro.Endereco = enderecoTbx.Text;
                        fornecedor.Logradouro.Numero = numeroTbx.Text;
                        fornecedor.Logradouro.Complemento = complementoTbx.Text;
                        fornecedor.Logradouro.Bairro = bairroTbx.Text;
                        fornecedor.Logradouro.CEP = cepMtbx.Text;
                        fornecedor.Situacao = situacaoCbx.Text;
                        fornecedor.Obs = obsTbx.Text;

                        if (fornecedor.Adicionar(fornecedor))
                        {
                            MessageBox.Show("Dados salvos com SUCESSO!!");
                            Listar();
                            idfornecTbx.Text = fornecedor.getId(fornecedor).ToString();
                        } else {

                            MessageBox.Show("Erro ao salvar DADOS!!!");
                        }
                    }
                }
            }
        }

        public bool LocalizarCep()//Busca os dados do Cep na base do correio se tiver internet
        {
            int verifica;
            try {
                using (var ws = new Ws.AtendeClienteClient())
                {
                    var resultado = ws.consultaCEP(cepMtbx.Text);
                    enderecoTbx.Text = resultado.end;
                    complementoTbx.Text = resultado.complemento;
                    cidadeTbx.Text = resultado.cidade;
                    bairroTbx.Text = resultado.bairro;
                    ufTbx.Text = resultado.uf;
                    numeroTbx.Text = resultado.complemento2;
                    verifica = 1;
                }
            }
           
            catch {
                verifica = 0;

            }
            return verifica > 0;

        }

        private void btnLocalizarCep(object sender, EventArgs e)
        {
            if (LocalizarCep())
            {
            } else {
                MessageBox.Show("Sem Conexão com a INTERNET para o SERVIÇO!!");
            }    
        }

        private void btnBuscarFornecedor(object sender, EventArgs e)
        {
            //Recupera os dados do fornecedor nos campos e no Grid de acordo o valor do campo do nome fantasia
            if (nomeFantTbx.Text != "")
            {
                DataTable tb = fornecedor.BuscarFornecedor(nomeFantTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = fornecedor.BuscarFornecedor(nomeFantTbx);
                    idfornecTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    nomeContTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    razaoSocialTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    nomeFantTbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cnpjMtbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ieTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    siteTbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    emailTbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    telempMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    telcelMtbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    telfaxMtbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    ufTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    cidadeTbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    enderecoTbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    numeroTbx.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    complementoTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                    bairroTbx.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    cepMtbx.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    situacaoCbx.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                    obsTbx.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                }else {
                    MessageBox.Show("Nome Fantasia Não Encontrado!");
                }   
            } else {
                MessageBox.Show("Por favor, entre com o Nome Fantasia para efetuarmos a busca.");
            } 
        }

        private void btnNovofornc(object sender, EventArgs e)
        {//Limpa os dados de todos os campos para serem inseridos novos valores
            form.LimpaTextBoxs(nomeContTbx);
            form.LimpaTextBoxs(nomeFantTbx);
            form.LimpaTextBoxs(razaoSocialTbx);
            form.LimpaMaskedTextBoxs(cnpjMtbx);
            form.LimpaTextBoxs(ieTbx);
            form.LimpaTextBoxs(emailTbx);
            form.LimpaTextBoxs(siteTbx);
            form.LimpaMaskedTextBoxs(telempMtbx);
            form.LimpaMaskedTextBoxs(telcelMtbx);
            form.LimpaMaskedTextBoxs(telfaxMtbx);
            form.LimpaMaskedTextBoxs(cepMtbx);
            form.LimpaTextBoxs(enderecoTbx);
            form.LimpaTextBoxs(numeroTbx);
            form.LimpaTextBoxs(bairroTbx);
            form.LimpaTextBoxs(complementoTbx);
            form.LimpaTextBoxs(cidadeTbx);
            form.LimpaTextBoxs(ufTbx);
            form.LimpaTextBoxs(idfornecTbx);
            Listar();
        }

        private void btnEditarFornecedor(object sender, EventArgs e)
        {//Recupera os dados do fornecedor nos campos e no GridView para eles serem alterados
            atualizaLbl.Text = 1.ToString();
            atualizaLbl.Visible = false;
            idfornecTbx.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nomeContTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            razaoSocialTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nomeFantTbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cnpjMtbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ieTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            siteTbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            emailTbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            telempMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            telcelMtbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            telfaxMtbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            ufTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cidadeTbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            enderecoTbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            numeroTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            complementoTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            bairroTbx.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            cepMtbx.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            situacaoCbx.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            obsTbx.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
