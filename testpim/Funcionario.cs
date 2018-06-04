using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testpim.Dao;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace testpim
{
    public class Funcionario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String RG { get; set; }
        public String TituloEleitor { get; set; }
        public String Email { get; set; }
        public String TelResidencial { get; set; }
        public String TelCelular { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Sexo { get; set; }
        public String EstadoCivil { get; set; }
        public String Funcao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public String CTPS { get; set; }
        public Decimal Salario { get; set; }
        public Decimal Comissao { get; set; }
        public DateTime DataDemissao { get; set; }
        public String Obs { get; set; }
        public Logradouro Logradouro { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdFuncionario { get; set; }
        public Formulario Form { get; set; }

    public Funcionario()
        {
            Form = new Formulario();
            Con = new ConnectionFactory().Connectar();
            Logradouro = new Logradouro();
        }

    public bool Adicionar(Funcionario funcionario, int verifica) {//Metódo que retorna um,ou seja,verdadeiro se o funcionario pôde ser adicionado de acordo com o valor passado para o verifica,se verifica=1 ele salva o funcionário com seus dados obrigatórios e não obrigatórios,já  se verifica=0 ele salva o funcionário somente com os dados obrigatórios, sem erro e se não ele retorna 0,ou seja,falso
            try { 

            if (verifica > 0) { 
                

                    string inserir = "INSERT INTO funcionario(nome,cpf,rg,email,tituloeleitor,telresidencial,telcelular,datanascimento,sexo,estadocivil,funcao,dataadmissao,datademissao,ctps,salario,comissao,uf,cidade,endereco,numero,complemento,bairro,cep,obs) VALUES(@nome,@cpf,@rg,@email,@tituloeleitor,@telresidencial,@telcelular,@datanascimento,@sexo,@estadocivil,@funcao,@dataadmissao,@datademissao,@ctps,@salario,@comissao,@uf,@cidade,@endereco,@numero,@complemento,@bairro,@cep,@obs);";
                    AdFuncionario = new MySqlCommand(inserir, Con);
                    Con.Open();
                    AdFuncionario.Parameters.Add(new MySqlParameter("nome", funcionario.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cpf", funcionario.CPF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("rg", funcionario.RG));
                    AdFuncionario.Parameters.Add(new MySqlParameter("email", funcionario.Email));
                    AdFuncionario.Parameters.Add(new MySqlParameter("tituloeleitor", funcionario.TituloEleitor));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telresidencial", funcionario.TelResidencial));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telcelular", funcionario.TelCelular));
                    AdFuncionario.Parameters.Add(new MySqlParameter("datanascimento", funcionario.DataNascimento.ToString("yyyy-MM-dd")));
                    AdFuncionario.Parameters.Add(new MySqlParameter("sexo", funcionario.Sexo));
                    AdFuncionario.Parameters.Add(new MySqlParameter("estadocivil", funcionario.EstadoCivil));
                    AdFuncionario.Parameters.Add(new MySqlParameter("funcao", funcionario.Funcao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("dataadmissao", funcionario.DataAdmissao.ToString("yyyy-MM-dd")));
                    AdFuncionario.Parameters.Add(new MySqlParameter("datademissao", funcionario.DataDemissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("ctps", funcionario.CTPS));
                    AdFuncionario.Parameters.Add(new MySqlParameter("salario", funcionario.Salario));
                    AdFuncionario.Parameters.Add(new MySqlParameter("comissao", funcionario.Comissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("uf", funcionario.Logradouro.Cidade.UF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cidade", funcionario.Logradouro.Cidade.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("endereco", funcionario.Logradouro.Endereco));
                    AdFuncionario.Parameters.Add(new MySqlParameter("numero", funcionario.Logradouro.Numero));
                    AdFuncionario.Parameters.Add(new MySqlParameter("complemento", funcionario.Logradouro.Complemento));
                    AdFuncionario.Parameters.Add(new MySqlParameter("bairro", funcionario.Logradouro.Bairro));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cep", funcionario.Logradouro.CEP));
                    AdFuncionario.Parameters.Add(new MySqlParameter("obs", funcionario.Obs));
                    AdFuncionario.Prepare();
                    AdFuncionario.ExecuteNonQuery();
                    Con.Close();
            } else
                {
                    string inserir = "INSERT INTO funcionario(nome,cpf,rg,email,tituloeleitor,telresidencial,telcelular,datanascimento,sexo,estadocivil,funcao,dataadmissao,ctps,salario,comissao,uf,cidade,endereco,numero,complemento,bairro,cep,obs) VALUES(@nome,@cpf,@rg,@email,@tituloeleitor,@telresidencial,@telcelular,@datanascimento,@sexo,@estadocivil,@funcao,@dataadmissao,@ctps,@salario,@comissao,@uf,@cidade,@endereco,@numero,@complemento,@bairro,@cep,@obs);";
                    AdFuncionario = new MySqlCommand(inserir, Con);
                    Con.Open();
                    AdFuncionario.Parameters.Add(new MySqlParameter("nome", funcionario.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cpf", funcionario.CPF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("rg", funcionario.RG));
                    AdFuncionario.Parameters.Add(new MySqlParameter("email", funcionario.Email));
                    AdFuncionario.Parameters.Add(new MySqlParameter("tituloeleitor", funcionario.TituloEleitor));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telresidencial", funcionario.TelResidencial));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telcelular", funcionario.TelCelular));
                    AdFuncionario.Parameters.Add(new MySqlParameter("datanascimento", funcionario.DataNascimento.ToString("yyyy-MM-dd")));
                    AdFuncionario.Parameters.Add(new MySqlParameter("sexo", funcionario.Sexo));
                    AdFuncionario.Parameters.Add(new MySqlParameter("estadocivil", funcionario.EstadoCivil));
                    AdFuncionario.Parameters.Add(new MySqlParameter("funcao", funcionario.Funcao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("dataadmissao", funcionario.DataAdmissao.ToString("yyyy-MM-dd")));
                    AdFuncionario.Parameters.Add(new MySqlParameter("ctps", funcionario.CTPS));
                    AdFuncionario.Parameters.Add(new MySqlParameter("salario", funcionario.Salario));
                    AdFuncionario.Parameters.Add(new MySqlParameter("comissao", funcionario.Comissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("uf", funcionario.Logradouro.Cidade.UF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cidade", funcionario.Logradouro.Cidade.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("endereco", funcionario.Logradouro.Endereco));
                    AdFuncionario.Parameters.Add(new MySqlParameter("numero", funcionario.Logradouro.Numero));
                    AdFuncionario.Parameters.Add(new MySqlParameter("complemento", funcionario.Logradouro.Complemento));
                    AdFuncionario.Parameters.Add(new MySqlParameter("bairro", funcionario.Logradouro.Bairro));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cep", funcionario.Logradouro.CEP));
                    AdFuncionario.Parameters.Add(new MySqlParameter("obs", funcionario.Obs));
                    AdFuncionario.Prepare();
                    AdFuncionario.ExecuteNonQuery();
                    Con.Close();
                }
                verifica = 1;
            }

            catch   {
                verifica = 0;
            }
            return verifica > 0;
        }

        public DataTable ListarFuncionarios()//Metódo que retorna um DateTable contendo os dados dos Funcionários
        {
            string listar = "SELECT id_func,nome,cpf,rg,email,tituloeleitor,telresidencial,telcelular,datanascimento,sexo,estadocivil,funcao,dataadmissao,datademissao,ctps,salario,comissao,uf,cidade,endereco,numero,complemento,bairro,cep,obs FROM funcionario";        
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public int getId(Funcionario funcionario)//Metódo que retorna o id do funcionário de acordo com o funcionário passado como parâmetro
        {
            string pegarid = "SELECT id_func from funcionario WHERE nome='" + funcionario.Nome + "'";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
           Id =int.Parse (cmd.ExecuteScalar().ToString());
            Con.Close();
            return Id;
        }

        public bool AtualizarFuncionario(Funcionario funcionario, int verifica) { //Metódo que retorna um,ou seja,verdadeiro se o funcionário pôde ser atualizado sem erro e se não ele retorna 0,ou seja,falso

            try  {
                if (verifica > 0)
                {
                    string inserir = "UPDATE funcionario SET nome=@nome, cpf=@cpf, rg=@rg, email=@email, tituloeleitor=@tituloeleitor,telresidencial=@telresidencial,telcelular=@telcelular,datanascimento=@datanascimento, sexo=@sexo, estadocivil=@estadocivil, funcao=@funcao, datademissao=@datademissao, ctps=@ctps, salario=@salario,comissao=@comissao,uf=@uf,cidade=@cidade,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cep=@cep,obs=@obs  WHERE id_func = @id_func";
                    AdFuncionario = new MySqlCommand(inserir, Con);
                    Con.Open();
                    AdFuncionario.Parameters.Add(new MySqlParameter("id_func", funcionario.Id));
                    AdFuncionario.Parameters.Add(new MySqlParameter("nome", funcionario.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cpf", funcionario.CPF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("rg", funcionario.RG));
                    AdFuncionario.Parameters.Add(new MySqlParameter("email", funcionario.Email));
                    AdFuncionario.Parameters.Add(new MySqlParameter("tituloeleitor", funcionario.TituloEleitor));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telresidencial", funcionario.TelResidencial));
                    AdFuncionario.Parameters.Add(new MySqlParameter("telcelular", funcionario.TelCelular));
                    AdFuncionario.Parameters.Add(new MySqlParameter("datanascimento", funcionario.DataNascimento.ToString("yyyy-MM-dd")));
                    AdFuncionario.Parameters.Add(new MySqlParameter("sexo", funcionario.Sexo));
                    AdFuncionario.Parameters.Add(new MySqlParameter("estadocivil", funcionario.EstadoCivil));
                    AdFuncionario.Parameters.Add(new MySqlParameter("funcao", funcionario.Funcao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("dataadmissao", funcionario.DataAdmissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("datademissao", funcionario.DataDemissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("ctps", funcionario.CTPS));
                    AdFuncionario.Parameters.Add(new MySqlParameter("salario", funcionario.Salario));
                    AdFuncionario.Parameters.Add(new MySqlParameter("comissao", funcionario.Comissao));
                    AdFuncionario.Parameters.Add(new MySqlParameter("uf", funcionario.Logradouro.Cidade.UF));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cidade", funcionario.Logradouro.Cidade.Nome));
                    AdFuncionario.Parameters.Add(new MySqlParameter("endereco", funcionario.Logradouro.Endereco));
                    AdFuncionario.Parameters.Add(new MySqlParameter("numero", funcionario.Logradouro.Numero));
                    AdFuncionario.Parameters.Add(new MySqlParameter("complemento", funcionario.Logradouro.Complemento));
                    AdFuncionario.Parameters.Add(new MySqlParameter("bairro", funcionario.Logradouro.Bairro));
                    AdFuncionario.Parameters.Add(new MySqlParameter("cep", funcionario.Logradouro.CEP));
                    AdFuncionario.Parameters.Add(new MySqlParameter("obs", funcionario.Obs));
                    AdFuncionario.Prepare();
                    AdFuncionario.ExecuteNonQuery();
                    Con.Close();
                }
                verifica = 1;
            }
          
            catch {
                verifica = 0;
            }
            return verifica > 0;
        }

        public DataTable BuscarFuncionario(MaskedTextBox cpf)//Metódo que retorna um DateTable contendo os dados do funcionário de acordo o MaskedTextBox passado como parâmetro
        {
            Form.RetiraMascaras(cpf);
            MySqlConnection Con = new ConnectionFactory().Connectar();
            string listar = "SELECT id_func,nome,cpf,rg,email,tituloeleitor,telresidencial,telcelular,datanascimento,sexo,estadocivil,funcao,dataadmissao,datademissao,ctps,salario,comissao,uf,cidade,endereco,numero,complemento,bairro,cep,obs FROM funcionario   WHERE cpf='" + cpf.Text + "'";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool CadastrarUsuario(TextBox email,MaskedTextBox datanascimento)//Metódo que retorna um,ou seja,verdadeiro se o cadastro para acesso a login do funcionário pôde ser cadastrado sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string cadastar = "INSERT INTO login(user_name,password) VALUES('" + email.Text+ "','" + datanascimento.Text + "')";
                Con.Open();
                MySqlCommand cmd = new MySqlCommand(cadastar, Con);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }
           
            catch(Exception erro)  {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }
    }
}