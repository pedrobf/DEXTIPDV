using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpim
{
    public partial class TelaCasdastroClienteF : Form
    {
        public TelaCasdastroClienteF()
        {
            InitializeComponent();
        }

        private void ClickNovoCliente(object sender, EventArgs e)
        {
            new CadastroClienteFisico().Show();
        }

        private void ClickEditarCadastro(object sender, EventArgs e)
        {
            new CadastroClienteFisico().Show();
        }
    }
}
