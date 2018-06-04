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
    public class Fornecedor
    {
        public String NomeContato { get; set; }
        public String CNPJ { get; set; }
        public String IE { get; set; }
        public String RazaoSocial { get; set; }
        public String Email { get; set; }
        public String WebSite { get; set; }
        public String NomeFantasia { get; set; }
        public String TelEmpresa { get; set; }
        public String TelCelular { get; set; }
        public String TelFax { get; set; }
        public String Obs { get; set; }
        public int IdFornecedor { get; set; }
        public String Situacao { get; set; }
        public Logradouro Logradouro { get; set; }
        public MySqlConnection Con { get; set; }
        public MySqlCommand AdFuncionario { get; set; }
        public Formulario Form { get; set; }
        public MySqlCommand AdFornecedor { get; private set; }

        public Fornecedor()
        {
            Form = new Formulario();
            Con = new ConnectionFactory().Connectar();
            Logradouro = new Logradouro();
        }

        public bool Adicionar(Fornecedor fornecedor)//Metódo que retorna um,ou seja,verdadeiro se o fornecedor pôde ser adicionado sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try  {

                string inserir = "INSERT INTO fornecedor(nome_contato,razao_social,nome_fantasia,cnpj,ie,website,email,telempresa,telcelular,telfax,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs) VALUES(@nome_contato,@razao_social,@nome_fantasia,@cnpj,@ie,@website,@email,@telempresa,@telcelular,@telfax,@uf,@cidade,@endereco,@numero,@complemento,@bairro,@cep,@situacao,@obs);";
                AdFornecedor = new MySqlCommand(inserir, Con);
                Con.Open();
                AdFornecedor.Parameters.Add(new MySqlParameter("nome_contato", fornecedor.NomeContato));
                AdFornecedor.Parameters.Add(new MySqlParameter("razao_social", fornecedor.RazaoSocial));
                AdFornecedor.Parameters.Add(new MySqlParameter("nome_fantasia", fornecedor.NomeFantasia));
                AdFornecedor.Parameters.Add(new MySqlParameter("cnpj", fornecedor.CNPJ));
                AdFornecedor.Parameters.Add(new MySqlParameter("ie", fornecedor.IE));
                AdFornecedor.Parameters.Add(new MySqlParameter("email", fornecedor.Email));
                AdFornecedor.Parameters.Add(new MySqlParameter("website", fornecedor.WebSite));
                AdFornecedor.Parameters.Add(new MySqlParameter("telempresa", fornecedor.TelEmpresa));
                AdFornecedor.Parameters.Add(new MySqlParameter("telcelular", fornecedor.TelCelular));
                AdFornecedor.Parameters.Add(new MySqlParameter("telfax", fornecedor.TelFax));
                AdFornecedor.Parameters.Add(new MySqlParameter("uf", fornecedor.Logradouro.Cidade.UF));
                AdFornecedor.Parameters.Add(new MySqlParameter("cidade", fornecedor.Logradouro.Cidade.Nome));
                AdFornecedor.Parameters.Add(new MySqlParameter("endereco", fornecedor.Logradouro.Endereco));
                AdFornecedor.Parameters.Add(new MySqlParameter("numero", fornecedor.Logradouro.Numero));
                AdFornecedor.Parameters.Add(new MySqlParameter("complemento", fornecedor.Logradouro.Complemento));
                AdFornecedor.Parameters.Add(new MySqlParameter("bairro", fornecedor.Logradouro.Bairro));
                AdFornecedor.Parameters.Add(new MySqlParameter("cep", fornecedor.Logradouro.CEP));
                AdFornecedor.Parameters.Add(new MySqlParameter("situacao", fornecedor.Situacao));
                AdFornecedor.Parameters.Add(new MySqlParameter("obs", fornecedor.Obs));
                AdFornecedor.Prepare();
                AdFornecedor.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }

            catch (Exception erro) {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

        public DataTable ListarFornecedor()//Metódo que retorna uma DateTable contendo os dados dos Fornecedores
        {
            string listar = "SELECT id_fornec,nome_contato,razao_social,nome_fantasia,cnpj,ie,website,email,telempresa,telcelular,telfax,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs FROM fornecedor";
            Con.Open();
            MySqlCommand cmd = new MySqlCommand(listar, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public int getId(Fornecedor fornecedor)//Metódo que retorna o id do fornecedor de acordo com o fornecedor passado como parâmetro
        {
            Con.Open();
            string pegarid = "SELECT id_fornec from fornecedor WHERE nome_fantasia='" + fornecedor.NomeFantasia + "'";
            MySqlCommand cmd = new MySqlCommand(pegarid, Con);
            cmd.Prepare();
            IdFornecedor = int.Parse(cmd.ExecuteScalar().ToString());
            Con.Close();
            return IdFornecedor;

        }

        public DataTable BuscarFornecedor(TextBox nome_fantasia)//Metódo que retorna um DateTable contendo os dados do Fornecedor de acordo com o TextBox passado como parâmetro
        {
            MySqlConnection Con = new ConnectionFactory().Connectar();
            Con.Open();
            string buscar_fornecedor = "SELECT id_fornec,nome_contato,razao_social,nome_fantasia,cnpj,ie,website,email,telempresa,telcelular,telfax,uf,cidade,endereco,numero,complemento,bairro,cep,situacao,obs from fornecedor WHERE nome_fantasia = '" + nome_fantasia.Text + "'";
            MySqlCommand cmd = new MySqlCommand(buscar_fornecedor, Con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            Con.Close();
            return tb;
        }

        public bool AtualizarFornecedor(Fornecedor fornecedor)//Metódo que retorna um,ou seja,verdadeiro se o fornecedor pôde ser atualizado  sem erro e se não ele retorna 0,ou seja,falso
        {
            int verifica;
            try {
                string editar = "UPDATE fornecedor SET nome_contato=@nome_contato, razao_social=@razao_social, nome_fantasia=@nome_fantasia, cnpj=@cnpj, ie=@ie, website=@website, email=@email, telempresa=@telempresa, telcelular=@telcelular, telfax=@telfax, uf=@uf, cidade=@cidade, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cep=@cep, situacao=@situacao, obs=@obs WHERE id_fornec=@id_fornec;";
                AdFornecedor = new MySqlCommand(editar, Con);
                Con.Open();
                AdFornecedor.Parameters.Add(new MySqlParameter("id_fornec", fornecedor.IdFornecedor));
                AdFornecedor.Parameters.Add(new MySqlParameter("nome_contato", fornecedor.NomeContato));
                AdFornecedor.Parameters.Add(new MySqlParameter("razao_social", fornecedor.RazaoSocial));
                AdFornecedor.Parameters.Add(new MySqlParameter("nome_fantasia", fornecedor.NomeFantasia));
                AdFornecedor.Parameters.Add(new MySqlParameter("cnpj", fornecedor.CNPJ));
                AdFornecedor.Parameters.Add(new MySqlParameter("ie", fornecedor.IE));
                AdFornecedor.Parameters.Add(new MySqlParameter("email", fornecedor.Email));
                AdFornecedor.Parameters.Add(new MySqlParameter("website", fornecedor.WebSite));
                AdFornecedor.Parameters.Add(new MySqlParameter("telempresa", fornecedor.TelEmpresa));
                AdFornecedor.Parameters.Add(new MySqlParameter("telcelular", fornecedor.TelCelular));
                AdFornecedor.Parameters.Add(new MySqlParameter("telfax", fornecedor.TelFax));
                AdFornecedor.Parameters.Add(new MySqlParameter("uf", fornecedor.Logradouro.Cidade.UF));
                AdFornecedor.Parameters.Add(new MySqlParameter("cidade", fornecedor.Logradouro.Cidade.Nome));
                AdFornecedor.Parameters.Add(new MySqlParameter("endereco", fornecedor.Logradouro.Endereco));
                AdFornecedor.Parameters.Add(new MySqlParameter("numero", fornecedor.Logradouro.Numero));
                AdFornecedor.Parameters.Add(new MySqlParameter("complemento", fornecedor.Logradouro.Complemento));
                AdFornecedor.Parameters.Add(new MySqlParameter("bairro", fornecedor.Logradouro.Bairro));
                AdFornecedor.Parameters.Add(new MySqlParameter("cep", fornecedor.Logradouro.CEP));
                AdFornecedor.Parameters.Add(new MySqlParameter("situacao", fornecedor.Situacao));
                AdFornecedor.Parameters.Add(new MySqlParameter("obs", fornecedor.Obs));
                AdFornecedor.Prepare();
                AdFornecedor.ExecuteNonQuery();
                Con.Close();
                verifica = 1;
            }
           
            catch (Exception erro) {
                verifica = 0;
                throw erro;
            }
            return verifica > 0;
        }

    }
}
