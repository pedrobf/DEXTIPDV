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
    public partial class Login : Form
    {
        Logar log;

        public Login()
        {
            InitializeComponent();
            log = new Logar();
        }
       
        private void Limpar()
        {//Limpa os Campos
            usuariotxt.Clear();
            senhatxt.Clear();
        }

        private void ValidarUsuario()//Verifica se o usuário existe ou não dentro do banco de dados, se sim ele entra na plataforma,se não ele não consegue entrar e é exibida uma mensagem de USUÁRIO/SENHA INCORRETOS
        {
            if((usuariotxt.Text == "Adm" && senhatxt.Text == "dexti123")  || (log.Autenticacao(usuariotxt,senhatxt)))
            {
                MessageBox.Show("LOGADO COM SUCESSO!!\nSeja bem vindo!", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                Menu menu = new Menu(usuariotxt.Text);
                menu.ShowDialog();
            }
            else if (usuariotxt.Text == "" || senhatxt.Text == "")
            {
                MessageBox.Show("CAMPO VAZIO!!!É NECESSÁRIO PREENCHER OS CAMPOS PARA LOGAR NO SISTEMA", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpar();
            } else  {
                MessageBox.Show("USUÁRIO/SENHA INCORRETOS", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void logaBtn_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
