namespace testpim.Telas
{
    partial class RealizarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vendaLbl = new System.Windows.Forms.Label();
            this.verificaestoque = new System.Windows.Forms.Label();
            this.codigoLbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incluir_produtoBtn = new System.Windows.Forms.Button();
            this.valorTbx = new System.Windows.Forms.TextBox();
            this.valorLbl = new System.Windows.Forms.Label();
            this.precoTbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buscar_produtoBtn = new System.Windows.Forms.Button();
            this.id_produtoTbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qtdTbx = new System.Windows.Forms.TextBox();
            this.qtdLbl = new System.Windows.Forms.Label();
            this.tamanhoTbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.generoCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descricaoTbx = new System.Windows.Forms.TextBox();
            this.descricaoLbl = new System.Windows.Forms.Label();
            this.produtoTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id_venda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_clienteTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adclientebtn = new System.Windows.Forms.Button();
            this.clienteTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMtbx = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.vendaLbl);
            this.panel1.Controls.Add(this.verificaestoque);
            this.panel1.Controls.Add(this.codigoLbl);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 815);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vendaLbl
            // 
            this.vendaLbl.AutoSize = true;
            this.vendaLbl.Location = new System.Drawing.Point(636, 270);
            this.vendaLbl.Name = "vendaLbl";
            this.vendaLbl.Size = new System.Drawing.Size(0, 13);
            this.vendaLbl.TabIndex = 73;
            // 
            // verificaestoque
            // 
            this.verificaestoque.AutoSize = true;
            this.verificaestoque.Location = new System.Drawing.Point(681, 391);
            this.verificaestoque.Name = "verificaestoque";
            this.verificaestoque.Size = new System.Drawing.Size(0, 13);
            this.verificaestoque.TabIndex = 72;
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Location = new System.Drawing.Point(281, 310);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(0, 13);
            this.codigoLbl.TabIndex = 71;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(18, 640);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 64);
            this.button5.TabIndex = 57;
            this.button5.Text = "&Finalizar Venda";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(933, 650);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 45);
            this.button3.TabIndex = 56;
            this.button3.Text = "&Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 411);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.incluir_produtoBtn);
            this.groupBox1.Controls.Add(this.valorTbx);
            this.groupBox1.Controls.Add(this.valorLbl);
            this.groupBox1.Controls.Add(this.precoTbx);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buscar_produtoBtn);
            this.groupBox1.Controls.Add(this.id_produtoTbx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.qtdTbx);
            this.groupBox1.Controls.Add(this.qtdLbl);
            this.groupBox1.Controls.Add(this.tamanhoTbx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.generoCbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tipoCbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descricaoTbx);
            this.groupBox1.Controls.Add(this.descricaoLbl);
            this.groupBox1.Controls.Add(this.produtoTbx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.id_venda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.id_clienteTbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.adclientebtn);
            this.groupBox1.Controls.Add(this.clienteTbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataMtbx);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // incluir_produtoBtn
            // 
            this.incluir_produtoBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incluir_produtoBtn.Image = ((System.Drawing.Image)(resources.GetObject("incluir_produtoBtn.Image")));
            this.incluir_produtoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluir_produtoBtn.Location = new System.Drawing.Point(924, 137);
            this.incluir_produtoBtn.Name = "incluir_produtoBtn";
            this.incluir_produtoBtn.Size = new System.Drawing.Size(108, 44);
            this.incluir_produtoBtn.TabIndex = 70;
            this.incluir_produtoBtn.Text = "&Incluir";
            this.incluir_produtoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.incluir_produtoBtn.UseVisualStyleBackColor = true;
            this.incluir_produtoBtn.Click += new System.EventHandler(this.incluir_produtoBtn_Click);
            // 
            // valorTbx
            // 
            this.valorTbx.Enabled = false;
            this.valorTbx.Location = new System.Drawing.Point(778, 157);
            this.valorTbx.Name = "valorTbx";
            this.valorTbx.Size = new System.Drawing.Size(92, 23);
            this.valorTbx.TabIndex = 69;
            // 
            // valorLbl
            // 
            this.valorLbl.AutoSize = true;
            this.valorLbl.Location = new System.Drawing.Point(775, 136);
            this.valorLbl.Name = "valorLbl";
            this.valorLbl.Size = new System.Drawing.Size(46, 17);
            this.valorLbl.TabIndex = 68;
            this.valorLbl.Text = "Valor:";
            // 
            // precoTbx
            // 
            this.precoTbx.Enabled = false;
            this.precoTbx.Location = new System.Drawing.Point(497, 158);
            this.precoTbx.Name = "precoTbx";
            this.precoTbx.Size = new System.Drawing.Size(92, 23);
            this.precoTbx.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Preço:";
            // 
            // buscar_produtoBtn
            // 
            this.buscar_produtoBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_produtoBtn.Image = ((System.Drawing.Image)(resources.GetObject("buscar_produtoBtn.Image")));
            this.buscar_produtoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar_produtoBtn.Location = new System.Drawing.Point(531, 90);
            this.buscar_produtoBtn.Name = "buscar_produtoBtn";
            this.buscar_produtoBtn.Size = new System.Drawing.Size(102, 32);
            this.buscar_produtoBtn.TabIndex = 65;
            this.buscar_produtoBtn.TabStop = false;
            this.buscar_produtoBtn.Text = "&Buscar";
            this.buscar_produtoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar_produtoBtn.UseVisualStyleBackColor = true;
            this.buscar_produtoBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // id_produtoTbx
            // 
            this.id_produtoTbx.Enabled = false;
            this.id_produtoTbx.Location = new System.Drawing.Point(963, 97);
            this.id_produtoTbx.Name = "id_produtoTbx";
            this.id_produtoTbx.Size = new System.Drawing.Size(101, 23);
            this.id_produtoTbx.TabIndex = 64;
            this.id_produtoTbx.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(960, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "ID Produto:";
            // 
            // qtdTbx
            // 
            this.qtdTbx.Location = new System.Drawing.Point(608, 158);
            this.qtdTbx.Name = "qtdTbx";
            this.qtdTbx.Size = new System.Drawing.Size(155, 23);
            this.qtdTbx.TabIndex = 62;
            // 
            // qtdLbl
            // 
            this.qtdLbl.AutoSize = true;
            this.qtdLbl.Location = new System.Drawing.Point(605, 136);
            this.qtdLbl.Name = "qtdLbl";
            this.qtdLbl.Size = new System.Drawing.Size(91, 17);
            this.qtdLbl.TabIndex = 61;
            this.qtdLbl.Text = "Quantidade:";
            // 
            // tamanhoTbx
            // 
            this.tamanhoTbx.Location = new System.Drawing.Point(409, 158);
            this.tamanhoTbx.Name = "tamanhoTbx";
            this.tamanhoTbx.Size = new System.Drawing.Size(70, 23);
            this.tamanhoTbx.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Tamanho:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // generoCbx
            // 
            this.generoCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Unissex"});
            this.generoCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.generoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoCbx.FormattingEnabled = true;
            this.generoCbx.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Unissex"});
            this.generoCbx.Location = new System.Drawing.Point(9, 156);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(187, 25);
            this.generoCbx.TabIndex = 58;
            this.generoCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Gênero:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tipoCbx
            // 
            this.tipoCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Camisas de Futebol",
            "Camisas de Basquete"});
            this.tipoCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tipoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCbx.FormattingEnabled = true;
            this.tipoCbx.Items.AddRange(new object[] {
            "Camisas de Futebol",
            "Camisas de Basquete"});
            this.tipoCbx.Location = new System.Drawing.Point(202, 156);
            this.tipoCbx.Name = "tipoCbx";
            this.tipoCbx.Size = new System.Drawing.Size(201, 25);
            this.tipoCbx.TabIndex = 56;
            this.tipoCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tipo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // descricaoTbx
            // 
            this.descricaoTbx.Enabled = false;
            this.descricaoTbx.Location = new System.Drawing.Point(639, 95);
            this.descricaoTbx.Multiline = true;
            this.descricaoTbx.Name = "descricaoTbx";
            this.descricaoTbx.Size = new System.Drawing.Size(318, 25);
            this.descricaoTbx.TabIndex = 54;
            this.descricaoTbx.TabStop = false;
            this.descricaoTbx.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // descricaoLbl
            // 
            this.descricaoLbl.AutoSize = true;
            this.descricaoLbl.Location = new System.Drawing.Point(636, 76);
            this.descricaoLbl.Name = "descricaoLbl";
            this.descricaoLbl.Size = new System.Drawing.Size(76, 17);
            this.descricaoLbl.TabIndex = 53;
            this.descricaoLbl.Text = "Descrição:";
            this.descricaoLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // produtoTbx
            // 
            this.produtoTbx.Location = new System.Drawing.Point(9, 96);
            this.produtoTbx.Multiline = true;
            this.produtoTbx.Name = "produtoTbx";
            this.produtoTbx.Size = new System.Drawing.Size(516, 25);
            this.produtoTbx.TabIndex = 2;
            this.produtoTbx.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Nome Produto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // id_venda
            // 
            this.id_venda.Enabled = false;
            this.id_venda.Location = new System.Drawing.Point(963, 39);
            this.id_venda.Name = "id_venda";
            this.id_venda.Size = new System.Drawing.Size(101, 23);
            this.id_venda.TabIndex = 50;
            this.id_venda.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "ID Venda:";
            // 
            // id_clienteTbx
            // 
            this.id_clienteTbx.Enabled = false;
            this.id_clienteTbx.Location = new System.Drawing.Point(639, 39);
            this.id_clienteTbx.Name = "id_clienteTbx";
            this.id_clienteTbx.Size = new System.Drawing.Size(96, 23);
            this.id_clienteTbx.TabIndex = 48;
            this.id_clienteTbx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID Cliente:";
            // 
            // adclientebtn
            // 
            this.adclientebtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adclientebtn.Image = ((System.Drawing.Image)(resources.GetObject("adclientebtn.Image")));
            this.adclientebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adclientebtn.Location = new System.Drawing.Point(531, 30);
            this.adclientebtn.Name = "adclientebtn";
            this.adclientebtn.Size = new System.Drawing.Size(102, 32);
            this.adclientebtn.TabIndex = 46;
            this.adclientebtn.TabStop = false;
            this.adclientebtn.Text = "&Adicionar";
            this.adclientebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adclientebtn.UseVisualStyleBackColor = true;
            this.adclientebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clienteTbx
            // 
            this.clienteTbx.Location = new System.Drawing.Point(9, 40);
            this.clienteTbx.Name = "clienteTbx";
            this.clienteTbx.Size = new System.Drawing.Size(516, 23);
            this.clienteTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome Cliente:";
            // 
            // dataMtbx
            // 
            this.dataMtbx.Enabled = false;
            this.dataMtbx.Location = new System.Drawing.Point(788, 38);
            this.dataMtbx.Mask = "99/99/9999";
            this.dataMtbx.Name = "dataMtbx";
            this.dataMtbx.Size = new System.Drawing.Size(117, 23);
            this.dataMtbx.TabIndex = 1;
            this.dataMtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataMtbx.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(786, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Data:";
            // 
            // RealizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 713);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RealizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.Load += new System.EventHandler(this.RealizarVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clienteTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dataMtbx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox id_venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_clienteTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adclientebtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox generoCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descricaoTbx;
        private System.Windows.Forms.Label descricaoLbl;
        private System.Windows.Forms.TextBox produtoTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tamanhoTbx;
        private System.Windows.Forms.TextBox id_produtoTbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox qtdTbx;
        private System.Windows.Forms.Label qtdLbl;
        private System.Windows.Forms.Button buscar_produtoBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button incluir_produtoBtn;
        private System.Windows.Forms.TextBox valorTbx;
        private System.Windows.Forms.Label valorLbl;
        private System.Windows.Forms.TextBox precoTbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label codigoLbl;
        private System.Windows.Forms.Label verificaestoque;
        private System.Windows.Forms.Label vendaLbl;
    }
}