namespace testpim
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlFndMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admLbl = new System.Windows.Forms.Label();
            this.usuáriolbl = new System.Windows.Forms.Label();
            this.pnlBarraLateralMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.btnAtualizarEstoque = new System.Windows.Forms.Button();
            this.btnListarProduto = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnCadastroDeFornecedor = new System.Windows.Forms.Button();
            this.btnCadastoFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlFndMenu.SuspendLayout();
            this.pnlBarraLateralMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // pnlFndMenu
            // 
            this.pnlFndMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFndMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFndMenu.BackgroundImage")));
            this.pnlFndMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlFndMenu.Controls.Add(this.panel1);
            this.pnlFndMenu.Controls.Add(this.admLbl);
            this.pnlFndMenu.Controls.Add(this.usuáriolbl);
            this.pnlFndMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFndMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlFndMenu.Name = "pnlFndMenu";
            this.pnlFndMenu.Size = new System.Drawing.Size(1232, 689);
            this.pnlFndMenu.TabIndex = 3;
            this.pnlFndMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFndMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 16);
            this.panel1.TabIndex = 13;
            // 
            // admLbl
            // 
            this.admLbl.AutoSize = true;
            this.admLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admLbl.ForeColor = System.Drawing.Color.Black;
            this.admLbl.Location = new System.Drawing.Point(512, 74);
            this.admLbl.Name = "admLbl";
            this.admLbl.Size = new System.Drawing.Size(0, 24);
            this.admLbl.TabIndex = 12;
            // 
            // usuáriolbl
            // 
            this.usuáriolbl.AutoSize = true;
            this.usuáriolbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriolbl.ForeColor = System.Drawing.Color.Black;
            this.usuáriolbl.Location = new System.Drawing.Point(512, 32);
            this.usuáriolbl.Name = "usuáriolbl";
            this.usuáriolbl.Size = new System.Drawing.Size(87, 25);
            this.usuáriolbl.TabIndex = 11;
            this.usuáriolbl.Text = "Usuário";
            // 
            // pnlBarraLateralMenu
            // 
            this.pnlBarraLateralMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pnlBarraLateralMenu.Controls.Add(this.button10);
            this.pnlBarraLateralMenu.Controls.Add(this.button9);
            this.pnlBarraLateralMenu.Controls.Add(this.button8);
            this.pnlBarraLateralMenu.Controls.Add(this.btnRealizarVenda);
            this.pnlBarraLateralMenu.Controls.Add(this.btnAtualizarEstoque);
            this.pnlBarraLateralMenu.Controls.Add(this.btnListarProduto);
            this.pnlBarraLateralMenu.Controls.Add(this.btnCadastroProduto);
            this.pnlBarraLateralMenu.Controls.Add(this.btnCadastroDeFornecedor);
            this.pnlBarraLateralMenu.Controls.Add(this.btnCadastoFuncionario);
            this.pnlBarraLateralMenu.Controls.Add(this.btnCadastroCliente);
            this.pnlBarraLateralMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateralMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraLateralMenu.Name = "pnlBarraLateralMenu";
            this.pnlBarraLateralMenu.Size = new System.Drawing.Size(468, 689);
            this.pnlBarraLateralMenu.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(19, 626);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(420, 56);
            this.button10.TabIndex = 9;
            this.button10.Text = "Sobre";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(19, 560);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(420, 60);
            this.button9.TabIndex = 8;
            this.button9.Text = "Ajuda";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(19, 491);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(420, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "Relatório de Vendas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnRealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarVenda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRealizarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarVenda.Image")));
            this.btnRealizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarVenda.Location = new System.Drawing.Point(19, 422);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(420, 60);
            this.btnRealizarVenda.TabIndex = 6;
            this.btnRealizarVenda.Text = "Realizar Vendas";
            this.btnRealizarVenda.UseVisualStyleBackColor = false;
            this.btnRealizarVenda.Click += new System.EventHandler(this.clickRealizarVenda);
            // 
            // btnAtualizarEstoque
            // 
            this.btnAtualizarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnAtualizarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarEstoque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarEstoque.Image")));
            this.btnAtualizarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarEstoque.Location = new System.Drawing.Point(19, 354);
            this.btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            this.btnAtualizarEstoque.Size = new System.Drawing.Size(420, 60);
            this.btnAtualizarEstoque.TabIndex = 5;
            this.btnAtualizarEstoque.Text = "Atualizar Estoque";
            this.btnAtualizarEstoque.UseVisualStyleBackColor = false;
            this.btnAtualizarEstoque.Click += new System.EventHandler(this.clickBtnAtualizarEstoque);
            // 
            // btnListarProduto
            // 
            this.btnListarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnListarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProduto.ForeColor = System.Drawing.Color.White;
            this.btnListarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnListarProduto.Image")));
            this.btnListarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarProduto.Location = new System.Drawing.Point(19, 285);
            this.btnListarProduto.Name = "btnListarProduto";
            this.btnListarProduto.Size = new System.Drawing.Size(420, 60);
            this.btnListarProduto.TabIndex = 4;
            this.btnListarProduto.Text = "Listar Produtos";
            this.btnListarProduto.UseVisualStyleBackColor = false;
            this.btnListarProduto.Click += new System.EventHandler(this.clickBtnListarProduto);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastroProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProduto.Image")));
            this.btnCadastroProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProduto.Location = new System.Drawing.Point(19, 216);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(420, 60);
            this.btnCadastroProduto.TabIndex = 3;
            this.btnCadastroProduto.Text = "Cadastro de Produtos";
            this.btnCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCadastroProduto.Click += new System.EventHandler(this.clickBtnCadastroProduto);
            // 
            // btnCadastroDeFornecedor
            // 
            this.btnCadastroDeFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnCadastroDeFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroDeFornecedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroDeFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastroDeFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroDeFornecedor.Image")));
            this.btnCadastroDeFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroDeFornecedor.Location = new System.Drawing.Point(19, 147);
            this.btnCadastroDeFornecedor.Name = "btnCadastroDeFornecedor";
            this.btnCadastroDeFornecedor.Size = new System.Drawing.Size(420, 60);
            this.btnCadastroDeFornecedor.TabIndex = 2;
            this.btnCadastroDeFornecedor.Text = "Cadastro de Fornecedores";
            this.btnCadastroDeFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastroDeFornecedor.Click += new System.EventHandler(this.btnClickarCadastroFornecedor);
            // 
            // btnCadastoFuncionario
            // 
            this.btnCadastoFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnCadastoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastoFuncionario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastoFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastoFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastoFuncionario.Image")));
            this.btnCadastoFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastoFuncionario.Location = new System.Drawing.Point(19, 77);
            this.btnCadastoFuncionario.Name = "btnCadastoFuncionario";
            this.btnCadastoFuncionario.Size = new System.Drawing.Size(420, 60);
            this.btnCadastoFuncionario.TabIndex = 1;
            this.btnCadastoFuncionario.Text = "Cadastro de Funcionários";
            this.btnCadastoFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastoFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(19, 6);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(420, 60);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnClickCadastroCliente);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1232, 711);
            this.Controls.Add(this.pnlBarraLateralMenu);
            this.Controls.Add(this.pnlFndMenu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Menu";
            this.Text = "Dexti PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlFndMenu.ResumeLayout(false);
            this.pnlFndMenu.PerformLayout();
            this.pnlBarraLateralMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlFndMenu;
        private System.Windows.Forms.Panel pnlBarraLateralMenu;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastoFuncionario;
        private System.Windows.Forms.Button btnCadastroDeFornecedor;
        private System.Windows.Forms.Button btnAtualizarEstoque;
        private System.Windows.Forms.Button btnListarProduto;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label usuáriolbl;
        private System.Windows.Forms.Label admLbl;
        private System.Windows.Forms.Panel panel1;
    }
}

