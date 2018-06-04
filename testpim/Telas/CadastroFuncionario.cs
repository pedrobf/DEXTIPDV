
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Dao;
using System.Drawing.Imaging;


namespace testpim
{
    public partial class CadastroFuncionario : Form
    {
        Formulario form;
        Funcionario funcionario;

        public CadastroFuncionario()
        {
            form = new Formulario();
            InitializeComponent();
            Listar();

        }

        public void Listar()//Lista os dados dos Funcionários
        {
            funcionario = new Funcionario();
            dataGridView1.DataSource = funcionario.ListarFuncionarios();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void RetiraMascaras(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        public void LimpaTextBoxs(TextBox textbox)
        {
            textbox.Clear();
        }
        public void LimpaMaskedTextBoxs(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Checa se a label atualizarLbl é igual a 1 e atualiza os dados do Funcionário e se não ela insere um novo Funcionário no banco de dados
            Validacao val = new Validacao();
            int continuarcpf, continuaremail;
            if (atualizarLbl.Text == 1.ToString())
            {
                if (val.ValidarEmail(emailTbs.Text))
                {

                    continuaremail = 1;
                } else {
                    MessageBox.Show("Email Inválido!!!");
                    continuaremail = 0;
                }
               
                if (val.ValidarCpf(cpfMtbx.Text))
                {

                    continuarcpf = 1;
                } else {
                    MessageBox.Show("CPF Inválido!!!");
                    continuarcpf = 0;
                }
               
                if ((continuarcpf > 0) && (continuaremail > 0))
                {
                    Funcionario funcionario = new Funcionario();
                    form.IncluirMascaras(datanascimentoMtbx);
                    form.RetiraMascaras(cpfMtbx);
                    form.RetiraMascaras(cepMtbx);
                    form.RetiraMascaras(celularMtbx);
                    form.RetiraMascaras(telresidencialMtbx);
                    funcionario.Id = int.Parse(idTbx.Text);
                    funcionario.Nome = nomeTbx.Text;
                    funcionario.CPF = cpfMtbx.Text;
                    funcionario.RG = rgMtbx.Text;
                    funcionario.TituloEleitor = tituloeleitorTbx.Text;
                    funcionario.Email = emailTbs.Text;
                    funcionario.TelCelular = celularMtbx.Text;
                    funcionario.TelResidencial = telresidencialMtbx.Text;
                    funcionario.DataNascimento = DateTime.Parse(datanascimentoMtbx.Text);
                    funcionario.Sexo = sexoCbo.Text;
                    funcionario.EstadoCivil = estadocivilCbo.Text;
                    funcionario.Funcao = funcaoTbx.Text;
                    funcionario.DataAdmissao = DateTime.Parse(dataadmissaoTbx.Text);
                    funcionario.CTPS = ctpsTbx.Text;
                    funcionario.Logradouro.Endereco = enderecoTbx.Text;
                    funcionario.Logradouro.Numero = numeroTbx.Text;
                    funcionario.Logradouro.Complemento = complementoTbx.Text;
                    funcionario.Logradouro.Bairro = bairroTbx.Text;
                    funcionario.Logradouro.CEP = cepMtbx.Text;
                    funcionario.Logradouro.Cidade.UF = ufTbx.Text;
                    funcionario.Logradouro.Cidade.Nome = cidadeTbx.Text;
                    funcionario.Salario = Convert.ToDecimal(salarioTbx.Text);
                    form.RetiraMascaras(datademissaoMtbx);

                    if (datademissaoMtbx.Text != "")
                    {
                        form.IncluirMascaras(datademissaoMtbx);
                        funcionario.DataDemissao = DateTime.Parse(datademissaoMtbx.Text);
                        funcionario.DataDemissao.ToString("yyyy-MM-dd");
                    }
                    funcionario.Comissao = Convert.ToDecimal(comissaoTbx.Text);
                    funcionario.Obs = obsTbx.Text;
                    if (funcionario.AtualizarFuncionario(funcionario, 1))
                    {
                        MessageBox.Show("Dados Alterados com SUCESSO!!");
                        Listar();
                    } else{
                        MessageBox.Show("Erros ao Alterar os DADOS!!");
                    }
                      
                }  else { 
                        MessageBox.Show("Entre Novamente com os dados Inválidos");
                        if (continuaremail < 1)
                        {
                            form.LimpaTextBoxs(emailTbs);
                        }

                        if (continuarcpf < 1)
                        {
                            form.LimpaMaskedTextBoxs(cpfMtbx);
                        }
                }
                atualizarLbl.Text = 0.ToString();
                atualizarLbl.Visible = false;
            }  else { 
                
                    form.RetiraMascaras(cpfMtbx);
                    form.RetiraMascaras(telresidencialMtbx);
                    form.RetiraMascaras(celularMtbx);
                    form.RetiraMascaras(dataadmissaoTbx);
                    form.RetiraMascaras(datanascimentoMtbx);
                    form.RetiraMascaras(cepMtbx);

                    if ((nomeTbx.Text == "") || (rgMtbx.Text == "") || (tituloeleitorTbx.Text == "")
                    || (emailTbs.Text == "") || (celularMtbx.Text == "") || (telresidencialMtbx.Text == "") || (datanascimentoMtbx.Text == "") || (funcaoTbx.Text == "") || (ctpsTbx.Text == "")
                    || (enderecoTbx.Text == "") || (numeroTbx.Text == "") || (bairroTbx.Text == "") || (cidadeTbx.Text == "") || (salarioTbx.Text == "") || (cpfMtbx.Text == "") || (celularMtbx.Text == "") || (telresidencialMtbx.Text == "") || (datanascimentoMtbx.Text == "") || (dataadmissaoTbx.Text == ""))
                    {
                        MessageBox.Show("Campos obrigatórios vazios, preencha todos os campos que contém * !!!");
                }  else { 
              
                        form.IncluirMascaras(dataadmissaoTbx);
                        form.IncluirMascaras(datanascimentoMtbx);
                        form.IncluirMascaras(celularMtbx);
                        form.IncluirMascaras(telresidencialMtbx);
                        form.IncluirMascaras(cepMtbx);
                        form.IncluirMascaras(cpfMtbx);
                        if (val.ValidarEmail(emailTbs.Text))
                        {

                            continuaremail = 1;
                        } else {
                            MessageBox.Show("Email Inválido!!!");
                            continuaremail = 0;
                        }
                       
                        if (val.ValidarCpf(cpfMtbx.Text))
                        {

                            continuarcpf = 1;
                        } else {
                            MessageBox.Show("CPF Inválido!!!");
                            continuarcpf = 0;
                        }
                       
                        if ((continuarcpf > 0) && (continuaremail > 0))
                        {
                            Funcionario funcionario = new Funcionario();
                            form.RetiraMascaras(cpfMtbx);
                            form.RetiraMascaras(cepMtbx);
                            form.RetiraMascaras(celularMtbx);
                            form.RetiraMascaras(telresidencialMtbx);
                            funcionario.Nome = nomeTbx.Text;
                            funcionario.CPF = cpfMtbx.Text;
                            funcionario.RG = rgMtbx.Text;
                            funcionario.TituloEleitor = tituloeleitorTbx.Text;
                            funcionario.Email = emailTbs.Text;
                            funcionario.TelCelular = celularMtbx.Text;
                            funcionario.TelResidencial = telresidencialMtbx.Text;
                            funcionario.DataNascimento = DateTime.Parse(datanascimentoMtbx.Text);
                            funcionario.Sexo = sexoCbo.Text;
                            funcionario.EstadoCivil = estadocivilCbo.Text;
                            funcionario.Funcao = funcaoTbx.Text;
                            funcionario.DataAdmissao = DateTime.Parse(dataadmissaoTbx.Text);
                            funcionario.CTPS = ctpsTbx.Text;
                            funcionario.Logradouro.Endereco = enderecoTbx.Text;
                            funcionario.Logradouro.Numero = numeroTbx.Text;
                            funcionario.Logradouro.Complemento = complementoTbx.Text;
                            funcionario.Logradouro.Bairro = bairroTbx.Text;
                            funcionario.Logradouro.CEP = cepMtbx.Text;
                            funcionario.Logradouro.Cidade.UF = ufTbx.Text;
                            funcionario.Logradouro.Cidade.Nome = cidadeTbx.Text;
                            funcionario.Salario = Convert.ToDecimal(salarioTbx.Text);
                            form.RetiraMascaras(datademissaoMtbx);
                            if ((datademissaoMtbx.Text == "" || obsTbx.Text == "" || comissaoTbx.Text == "") || (datademissaoMtbx.Text == "" && obsTbx.Text == "" && comissaoTbx.Text == ""))
                            {

                                funcionario.Obs = "sem observação";
                                funcionario.Comissao = 0;
                                if (funcionario.Adicionar(funcionario, 0))
                                {
                                    MessageBox.Show("Dados salvos com SUCESSO!!!!");
                                    form.RetiraMascaras(datanascimentoMtbx);
                                    if (funcionario.CadastrarUsuario(emailTbs, datanascimentoMtbx))
                                    {
                                        MessageBox.Show("Usuário Cadastrado com Sucesso\nLogin para Acesso\nUser_name:" + emailTbs.Text + " e Senha: " + datanascimentoMtbx.Text + "!!!");
                                    } else{
                                        MessageBox.Show("Erro ao Cadastrar usuario !!");
                                    }
                                } else {
                                    MessageBox.Show("Erro ao salvar os DADOS!!!");
                                }

                                Listar();
                                idTbx.Text = funcionario.getId(funcionario).ToString();
                             } else {
                                form.IncluirMascaras(datademissaoMtbx);
                                funcionario.DataDemissao = DateTime.Parse(datademissaoMtbx.Text);
                                funcionario.DataDemissao.ToString("yyyy-MM-dd");
                                funcionario.Comissao = Convert.ToDecimal(comissaoTbx.Text);
                                funcionario.Obs = obsTbx.Text;

                                if (funcionario.Adicionar(funcionario, 1))
                                {
                                    MessageBox.Show("Dados salvos com SUCESSO!!!!");
                                }else{
                                    MessageBox.Show("Erro ao salvar os DADOS!!!");
                                }

                                Listar();
                                idTbx.Text = funcionario.getId(funcionario).ToString();
                            }
                        } else { 
                            MessageBox.Show("Entre Novamente com os dados Inválidos");
                            if (continuaremail < 1)
                            {
                                form.LimpaTextBoxs(emailTbs);
                            }

                            if (continuarcpf < 1)
                            {
                                form.LimpaMaskedTextBoxs(cpfMtbx);
                            }
                        }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public DataTable BuscarFuncionario()//Metódo que retorna um DateTable contendo os dados do funcionário de acordo com o campo do CPF
        {
            RetiraMascaras(cpfMtbx);
            MySqlConnection Con = new ConnectionFactory().Connectar();
            string listar = "SELECT id_func,nome,cpf,rg,email,tituloeleitor,telresidencial,telcelular,datanascimento,sexo,estadocivil,funcao,dataadmissao,datademissao,ctps,salario,comissao,uf,cidade,endereco,numero,complemento,bairro,cep,obs FROM funcionario   WHERE cpf='" + cpfMtbx.Text + "'";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public int getIdTextbox()//Metódo que retorna o id do TextBox
        {
            return int.Parse(idTbx.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {//Limpa os dados de todos os campos para serem inseridos novos valores
            form.LimpaTextBoxs(nomeTbx);
            form.LimpaTextBoxs(tituloeleitorTbx);
            form.LimpaTextBoxs(emailTbs);
            form.LimpaTextBoxs(funcaoTbx);
            form.LimpaTextBoxs(comissaoTbx);
            form.LimpaTextBoxs(salarioTbx);
            form.LimpaMaskedTextBoxs(datanascimentoMtbx);
            form.LimpaTextBoxs(ctpsTbx);
            form.LimpaTextBoxs(enderecoTbx);
            form.LimpaTextBoxs(numeroTbx);
            form.LimpaTextBoxs(complementoTbx);
            form.LimpaTextBoxs(bairroTbx);
            form.LimpaTextBoxs(cidadeTbx);
            form.LimpaTextBoxs(obsTbx);
            form.LimpaTextBoxs(idTbx);
            form.LimpaTextBoxs(rgMtbx);
            form.LimpaMaskedTextBoxs(dataadmissaoTbx);
            form.LimpaMaskedTextBoxs(datademissaoMtbx);
            form.LimpaMaskedTextBoxs(telresidencialMtbx);
            form.LimpaMaskedTextBoxs(celularMtbx);
            form.LimpaMaskedTextBoxs(cpfMtbx);
            form.LimpaMaskedTextBoxs(cepMtbx);
            Listar();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Recupera os dados do funcionario nos campos e no Grid de acordo o valor do campo do CPF
            form.RetiraMascaras(cpfMtbx);

            if (cpfMtbx.Text != "")
            {
                DataTable tb = BuscarFuncionario();
                if (tb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = BuscarFuncionario();
                    idTbx.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    nomeTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    cpfMtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    rgMtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    emailTbs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    tituloeleitorTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    telresidencialMtbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    celularMtbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    datanascimentoMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    sexoCbo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    estadocivilCbo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    funcaoTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    dataadmissaoTbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    datademissaoMtbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    ctpsTbx.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    salarioTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                    comissaoTbx.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    ufTbx.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    cidadeTbx.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                    enderecoTbx.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                    numeroTbx.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                    complementoTbx.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                    bairroTbx.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                    cepMtbx.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                    obsTbx.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                } else {
                    MessageBox.Show("CPF Não Encontrado!!!");
                }

            }else {
                MessageBox.Show("Por favor!!,Entre com seu CPF para efetuarmos a busca");
            }
             
        }

        public bool LocalizarCep()//Busca os dados do Cep na base do correio se tiver internet
        {
            int verifica;
            try
            {
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

        private void buscacepBtn_Click(object sender, EventArgs e)
        {
            if (LocalizarCep())
            {
            } else {
                MessageBox.Show("Sem Conexão com a INTERNET para o SERVIÇO!!");
            }
        }

        private int getIdTextBox()//Metódo que retorna o id do TextBox de acordo com o campo CPF
        {
            int Id;
            MySqlConnection Con = new ConnectionFactory().Connectar();
            string pegarid = "SELECT id_func FROM funcionario WHERE cpf='" + cpfMtbx.Text + "'";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
            Id = int.Parse(cmd.ExecuteScalar().ToString());
            Con.Close();
            return Id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//Recupera os dados do funcionário nos campos e no GridView para eles serem alterados
            atualizarLbl.Text = 1.ToString();
            atualizarLbl.Visible = false;
            string id;

            idTbx.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nomeTbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cpfMtbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rgMtbx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            emailTbs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tituloeleitorTbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            telresidencialMtbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            celularMtbx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            datanascimentoMtbx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sexoCbo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            estadocivilCbo.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            funcaoTbx.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            dataadmissaoTbx.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            datademissaoMtbx.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            ctpsTbx.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            salarioTbx.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            comissaoTbx.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            ufTbx.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            cidadeTbx.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            enderecoTbx.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            numeroTbx.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            complementoTbx.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            bairroTbx.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            cepMtbx.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            obsTbx.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
