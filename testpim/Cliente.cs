using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testpim.Dao;

namespace testpim
{
    public class Cliente
    {
        public int Id { get; set; }
        public String TipoCliente { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String CNPJ { get; set; }
        public String RG { get; set; }
        public String Email { get; set; }
        public String TelResidencial { get; set; }
        public String TelCelular { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Sexo { get; set; }
        public String Obs { get; set; }
        public String Situacao { get; set; }
        public Logradouro Logradouro { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdCliente { get; set; }

        public Cliente()
        {
            Con = new ConnectionFactory().Connectar();
            Logradouro = new Logradouro();
        }

        public bool Adicionar(Cliente cliente) { //Metódo que retorna um,ou seja,verdadeiro se o cliente pôde ser adicionado sem erro e se não ele retorna 0,ou seja,falso
            int verifica;
            try {
                    string inserir = "INSERT INTO cliente(tipoCliente,nome,cpf,cnpj,rg,email,telresidencial,telcelular,datanascimento,sexo,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs) VALUES(@tipoCliente,@nome,@cpf,@cnpj,@rg,@email,@telresidencial,@telcelular,@datanascimento,@sexo,@uf,@cidade,@endereco,@numero,@complemento,@bairro,@cep,@situacao,@obs);";
                    AdCliente = new MySqlCommand(inserir, Con);
                    Con.Open();
                    AdCliente.Parameters.Add(new MySqlParameter("tipoCliente", cliente.TipoCliente));
                    AdCliente.Parameters.Add(new MySqlParameter("nome", cliente.Nome));
                    AdCliente.Parameters.Add(new MySqlParameter("cpf", cliente.CPF));
                    AdCliente.Parameters.Add(new MySqlParameter("cnpj", cliente.CNPJ));
                    AdCliente.Parameters.Add(new MySqlParameter("rg", cliente.RG));
                    AdCliente.Parameters.Add(new MySqlParameter("email", cliente.Email));
                    AdCliente.Parameters.Add(new MySqlParameter("telresidencial", cliente.TelResidencial));
                    AdCliente.Parameters.Add(new MySqlParameter("telcelular", cliente.TelCelular));
                    AdCliente.Parameters.Add(new MySqlParameter("datanascimento", cliente.DataNascimento.ToString("yyyy-MM-dd")));
                    AdCliente.Parameters.Add(new MySqlParameter("sexo", cliente.Sexo));
                    AdCliente.Parameters.Add(new MySqlParameter("uf", cliente.Logradouro.Cidade.UF));
                    AdCliente.Parameters.Add(new MySqlParameter("cidade", cliente.Logradouro.Cidade.Nome));
                    AdCliente.Parameters.Add(new MySqlParameter("endereco", cliente.Logradouro.Endereco));
                    AdCliente.Parameters.Add(new MySqlParameter("numero", cliente.Logradouro.Numero));
                    AdCliente.Parameters.Add(new MySqlParameter("complemento", cliente.Logradouro.Complemento));
                    AdCliente.Parameters.Add(new MySqlParameter("bairro", cliente.Logradouro.Bairro));
                    AdCliente.Parameters.Add(new MySqlParameter("cep", cliente.Logradouro.CEP));
                    AdCliente.Parameters.Add(new MySqlParameter("situacao", cliente.Situacao));
                    AdCliente.Parameters.Add(new MySqlParameter("obs", cliente.Obs));
                    AdCliente.Prepare();
                    AdCliente.ExecuteNonQuery();
                    Con.Close();
                    verifica = 1;
                } 

             catch (Exception erro)   {
                    verifica = 0;
                    throw erro;
                }
            return verifica > 0;  
        }

        public DataTable ListarCliente()//Metódo que retorna um DataTable contendo os dados dos Clientes
        {
            Con.Open();
            string listar = "SELECT id_client,tipoCliente,nome,cpf,cnpj,rg,email,telresidencial,telcelular,datanascimento,sexo,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs FROM cliente;";
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool EditarCliente(Cliente cliente) //Metódo que retorna um,ou seja,verdadeiro se o cliente pôde ser editado sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string editar = "UPDATE cliente SET nome=@nome,tipoCliente=@tipoCliente,cpf=@cpf,cnpj=@cnpj ,rg=@rg, email=@email,telresidencial=@telresidencial,telcelular=@telcelular,datanascimento=@datanascimento, sexo=@sexo,uf=@uf,cidade=@cidade,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cep=@cep,situacao=@situacao,obs=@obs  WHERE id_client = @id_client";
                AdCliente = new MySqlCommand(editar, Con);
                Con.Open();
                AdCliente.Parameters.Add(new MySqlParameter("id_client", cliente.Id));
                AdCliente.Parameters.Add(new MySqlParameter("tipoCliente", cliente.TipoCliente));
                AdCliente.Parameters.Add(new MySqlParameter("nome", cliente.Nome));
                AdCliente.Parameters.Add(new MySqlParameter("cpf", cliente.CPF));
                AdCliente.Parameters.Add(new MySqlParameter("cnpj", cliente.CNPJ));
                AdCliente.Parameters.Add(new MySqlParameter("rg", cliente.RG));
                AdCliente.Parameters.Add(new MySqlParameter("email", cliente.Email));
                AdCliente.Parameters.Add(new MySqlParameter("telresidencial", cliente.TelResidencial));
                AdCliente.Parameters.Add(new MySqlParameter("telcelular", cliente.TelCelular));
                AdCliente.Parameters.Add(new MySqlParameter("datanascimento", cliente.DataNascimento.ToString("yyyy-MM-dd")));
                AdCliente.Parameters.Add(new MySqlParameter("sexo", cliente.Sexo));
                AdCliente.Parameters.Add(new MySqlParameter("uf", cliente.Logradouro.Cidade.UF));
                AdCliente.Parameters.Add(new MySqlParameter("cidade", cliente.Logradouro.Cidade.Nome));
                AdCliente.Parameters.Add(new MySqlParameter("endereco", cliente.Logradouro.Endereco));
                AdCliente.Parameters.Add(new MySqlParameter("numero", cliente.Logradouro.Numero));
                AdCliente.Parameters.Add(new MySqlParameter("complemento", cliente.Logradouro.Complemento));
                AdCliente.Parameters.Add(new MySqlParameter("bairro", cliente.Logradouro.Bairro));
                AdCliente.Parameters.Add(new MySqlParameter("cep", cliente.Logradouro.CEP));
                AdCliente.Parameters.Add(new MySqlParameter("situacao", cliente.Situacao));
                AdCliente.Parameters.Add(new MySqlParameter("obs", cliente.Obs));
                AdCliente.Prepare();
                AdCliente.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }
           
            catch (Exception erro)
            {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

        public int getId(Cliente cliente)//Metódo que retorna o id do Cliente de acordo com o seu Nome
        {
            Con.Open();
            string pegarid = "SELECT id_client FROM cliente WHERE nome='" + cliente.Nome + "'";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
            Id = int.Parse(cmd.ExecuteScalar().ToString());
            Con.Close();
            return Id;
        }

        public DataTable BuscarCliente(TextBox nome)//Metódo que retorna um DataTable contendo os dados dos Cliente de acordo com o valor do TextBox passado como parâmetro
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_cliente = "Select id_client,tipoCliente,nome,cpf,cnpj,rg,email,telresidencial,telcelular,datanascimento,sexo,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs from cliente where nome = '"+ nome.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_cliente, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }
    }
}

        


