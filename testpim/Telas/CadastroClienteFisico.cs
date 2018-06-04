using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using testpim.Dao;


namespace testpim
{
    
    public partial class CadastroClienteFisico : Form
    {
        Validacao val;
        Formulario form;
        Cliente cliente;
        public CadastroClienteFisico()
        {
            val = new Validacao();
            form = new Formulario();
            InitializeComponent();
            Listar();
        }

        public void Listar()//Lista os dados dos Clientes
        {
            cliente = new Cliente();
            dataGridView1.DataSource = cliente.ListarCliente();

        }
     
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Recupera os dados do cliente nos campos e no Grid de acordo o valor do campo do nome
            if (nomeTbx.Text != "")
            {
                DataTable tb = cliente.BuscarCliente(nomeTbx);
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = cliente.BuscarCliente(nomeTbx);
                    idclienteTbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    tipoclienteLbl.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    tipoclienteLbl.Visible = false;
                    if (tipoclienteLbl.Text == "PF"){
                        pfRdBtn.Checked = true;
                    } else{

                        pjRdBtn.Checked = true;

                    }
                     nomeTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    cpfMtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cnpjMtbx.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    rgTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    emailTbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    telresidMtbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    telcelMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    dataNascMtbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    sexoCbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    ufTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    cidadeTbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    enderecoTbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    numeroTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                    complementoTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                    bairroTbx.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    cepMtbx.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    situacaoCbx.Text= dataGridView1.CurrentRow.Cells[18].Value.ToString();
                    obsTbx.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Nome Não Encontrado!!!");
                }
            }
            else
            {
                MessageBox.Show("Por favor!!Entre com o Nome para efetuarmos a busca");
            }
        }

        private void CadastroClienteFisico_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_click(object sender, EventArgs e)
        {//Checa se a label atualizarLbl é igual a 1 e atualiza os dados do Cliente e se não ela insere um novo Cliente no banco de dados
            int cpf = 1;
            int email = 1;
            if (atualizaLbl.Text == 1.ToString())
            {
                if (emailTbx.Text != "")
                {
                    if (val.ValidarEmail(emailTbx.Text))
                    {

                    } else {
                        MessageBox.Show("Email Inválido!!!");
                        form.LimpaTextBoxs(emailTbx);
                    }
                }

                form.RetiraMascaras(cpfMtbx);
                if (cpfMtbx.Text != "")
                {
                    form.IncluirMascaras(cpfMtbx);
                    if (val.ValidarCpf(cpfMtbx.Text))
                    {

                    } else {
                        MessageBox.Show("CPF Inválido!!!");
                        form.LimpaMaskedTextBoxs(cpfMtbx);
                    }  
                }

                Cliente cliente = new Cliente();
                form.IncluirMascaras(dataNascMtbx);
                form.RetiraMascaras(cpfMtbx);
                form.RetiraMascaras(telresidMtbx);
                form.RetiraMascaras(telcelMtbx);
                form.RetiraMascaras(cepMtbx);
                form.RetiraMascaras(cnpjMtbx);
                cliente.Id = int.Parse(idclienteTbx.Text);
                cliente.TipoCliente = (pfRdBtn.Checked) ? "PF" : "PJ";
                cliente.Nome = nomeTbx.Text;
                cliente.CPF = cpfMtbx.Text;
                cliente.CNPJ = cnpjMtbx.Text;
                cliente.RG = rgTbx.Text;
                cliente.Email = emailTbx.Text;
                cliente.TelResidencial = telresidMtbx.Text;
                cliente.TelCelular = telcelMtbx.Text;
                cliente.DataNascimento = Convert.ToDateTime(dataNascMtbx.Text);
                cliente.Sexo = sexoCbx.Text;
                cliente.Logradouro.Cidade.UF = ufTbx.Text;
                cliente.Logradouro.Cidade.Nome = cidadeTbx.Text;
                cliente.Logradouro.Endereco = enderecoTbx.Text;
                cliente.Logradouro.Numero = numeroTbx.Text;
                cliente.Logradouro.Complemento = complementoTbx.Text;
                cliente.Logradouro.Bairro = bairroTbx.Text;
                cliente.Logradouro.CEP = cepMtbx.Text;
                cliente.Situacao = situacaoCbx.Text;
                cliente.Obs = obsTbx.Text;

                if (cliente.EditarCliente(cliente))
                {
                    MessageBox.Show("Dados alterados  com SUCESSO!!");
                    Listar();
                }else {

                    MessageBox.Show("Erro ao alterar dados DADOS!!!");
                }
                atualizaLbl.Text = 0.ToString();
                atualizaLbl.Visible = false;
                Listar();
            } else {

                form.RetiraMascaras(dataNascMtbx);
                if ((nomeTbx.Text == "") || (dataNascMtbx.Text == "") || (sexoCbx.Text == "") || (situacaoCbx.Text == ""))
                {
                    MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");
                } else {

                    if (emailTbx.Text != "")
                    {
                        if (val.ValidarEmail(emailTbx.Text))
                        {
                            
                        } else {
                            MessageBox.Show("Email Inválido!!!");
                            form.LimpaTextBoxs(emailTbx);
                            email = 0;
                        }   
                    }

                    form.RetiraMascaras(cpfMtbx);
                    if (cpfMtbx.Text != "")
                    {
                        if (val.ValidarCpf(cpfMtbx.Text))
                        {
                           
                        }else {
                            MessageBox.Show("CPF Inválido!!!");
                            form.LimpaMaskedTextBoxs(cpfMtbx);
                            cpf = 0;
                        }   
                    }

                    if ((cpf > 0) && (email > 0))
                    {
                        Cliente cliente = new Cliente();
                        form.IncluirMascaras(dataNascMtbx);
                        form.RetiraMascaras(telresidMtbx);
                        form.RetiraMascaras(telcelMtbx);
                        form.RetiraMascaras(cepMtbx);
                        form.RetiraMascaras(cnpjMtbx);
                        cliente.TipoCliente = (pfRdBtn.Checked) ? "PF" : "PJ";
                        cliente.Nome = nomeTbx.Text;
                        cliente.CPF = cpfMtbx.Text;
                        cliente.CNPJ = cnpjMtbx.Text;
                        cliente.RG = rgTbx.Text;
                        cliente.Email = emailTbx.Text;
                        cliente.TelResidencial = telresidMtbx.Text;
                        cliente.TelCelular = telcelMtbx.Text;
                        cliente.DataNascimento = Convert.ToDateTime(dataNascMtbx.Text);
                        cliente.Sexo = sexoCbx.Text;
                        cliente.Logradouro.Cidade.UF = ufTbx.Text;
                        cliente.Logradouro.Cidade.Nome = cidadeTbx.Text;
                        cliente.Logradouro.Endereco = enderecoTbx.Text;
                        cliente.Logradouro.Numero = numeroTbx.Text;
                        cliente.Logradouro.Complemento = complementoTbx.Text;
                        cliente.Logradouro.Bairro = bairroTbx.Text;
                        cliente.Logradouro.CEP = cepMtbx.Text;
                        cliente.Situacao = situacaoCbx.Text;
                        cliente.Obs = obsTbx.Text;

                        if (cliente.Adicionar(cliente))
                        {
                            MessageBox.Show("Dados salvo com SUCESSO!!");
                            Listar();
                            idclienteTbx.Text = cliente.getId(cliente).ToString();
                        } else  {

                            MessageBox.Show("Erro ao salvar os DADOS !!!");
                        } 
                    }
                }
            }

        }
        private void btnNovoclick(object sender, EventArgs e)
        {//Limpa os dados de todos os campos para serem inseridos novos valores
            form.LimpaTextBoxs(nomeTbx);
            form.LimpaMaskedTextBoxs(cnpjMtbx);
            form.LimpaTextBoxs(emailTbx);
            form.LimpaMaskedTextBoxs(dataNascMtbx);
            form.LimpaTextBoxs(enderecoTbx);
            form.LimpaTextBoxs(numeroTbx);
            form.LimpaTextBoxs(complementoTbx);
            form.LimpaTextBoxs(bairroTbx);
            form.LimpaTextBoxs(cidadeTbx);
            form.LimpaTextBoxs(obsTbx);
            form.LimpaTextBoxs(idclienteTbx);
            form.LimpaTextBoxs(rgTbx);
            form.LimpaMaskedTextBoxs(telresidMtbx);
            form.LimpaMaskedTextBoxs(telcelMtbx);
            form.LimpaMaskedTextBoxs(cpfMtbx);
            form.LimpaMaskedTextBoxs(cepMtbx);
            Listar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//Recupera os dados do cliente nos campos e no GridView para eles serem alterados
            atualizaLbl.Text = 1.ToString();
            atualizaLbl.Visible = false;
            idclienteTbx.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tipoclienteLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tipoclienteLbl.Visible = false;
            if (tipoclienteLbl.Text == "PF")
            {
                pfRdBtn.Checked = true;
            } else {

                pjRdBtn.Checked = true;

            }

            nomeTbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cpfMtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cnpjMtbx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            rgTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            emailTbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            telresidMtbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            telcelMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dataNascMtbx.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            sexoCbx.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
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

            catch 
            {
                verifica = 0;
                
            }
            return verifica > 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscacepBtn_Click(object sender, EventArgs e)
        {
            if (LocalizarCep())
            {
            } else {
                MessageBox.Show("Sem Conexão com a INTERNET para o SERVIÇO!!");
            } 
        }
    }
}
