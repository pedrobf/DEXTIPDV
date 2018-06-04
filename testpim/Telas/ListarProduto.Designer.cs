namespace testpim
{
    partial class ListarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_fornec = new System.Windows.Forms.Label();
            this.nomefornecedorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomefantTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datacriacaoMtbx = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.faixaetariaCbx = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.marcaTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generoCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtipoCbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.produtoTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.id_fornec);
            this.panel1.Controls.Add(this.nomefornecedorLbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 757);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // id_fornec
            // 
            this.id_fornec.AutoSize = true;
            this.id_fornec.Location = new System.Drawing.Point(703, 281);
            this.id_fornec.Name = "id_fornec";
            this.id_fornec.Size = new System.Drawing.Size(0, 13);
            this.id_fornec.TabIndex = 61;
            // 
            // nomefornecedorLbl
            // 
            this.nomefornecedorLbl.AutoSize = true;
            this.nomefornecedorLbl.Location = new System.Drawing.Point(471, 298);
            this.nomefornecedorLbl.Name = "nomefornecedorLbl";
            this.nomefornecedorLbl.Size = new System.Drawing.Size(0, 13);
            this.nomefornecedorLbl.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 463);
            this.dataGridView1.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 665);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 40);
            this.button4.TabIndex = 58;
            this.button4.Text = "&Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.nomefantTbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.datacriacaoMtbx);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.faixaetariaCbx);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.marcaTbx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.generoCbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.subtipoCbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tipoCbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.produtoTbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Produto:";
            // 
            // nomefantTbx
            // 
            this.nomefantTbx.Location = new System.Drawing.Point(51, 153);
            this.nomefantTbx.Multiline = true;
            this.nomefantTbx.Name = "nomefantTbx";
            this.nomefantTbx.Size = new System.Drawing.Size(577, 25);
            this.nomefantTbx.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nome Fantasia do Fornecedor:";
            // 
            // datacriacaoMtbx
            // 
            this.datacriacaoMtbx.Location = new System.Drawing.Point(935, 47);
            this.datacriacaoMtbx.Mask = "99/99/9999";
            this.datacriacaoMtbx.Name = "datacriacaoMtbx";
            this.datacriacaoMtbx.Size = new System.Drawing.Size(117, 23);
            this.datacriacaoMtbx.TabIndex = 2;
            this.datacriacaoMtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datacriacaoMtbx.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(932, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Data de criação:";
            // 
            // faixaetariaCbx
            // 
            this.faixaetariaCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Adulto",
            "Infantil"});
            this.faixaetariaCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.faixaetariaCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faixaetariaCbx.FormattingEnabled = true;
            this.faixaetariaCbx.Items.AddRange(new object[] {
            "Adulto",
            "Infantil"});
            this.faixaetariaCbx.Location = new System.Drawing.Point(953, 93);
            this.faixaetariaCbx.Name = "faixaetariaCbx";
            this.faixaetariaCbx.Size = new System.Drawing.Size(99, 25);
            this.faixaetariaCbx.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(950, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Faixa Etária:";
            // 
            // marcaTbx
            // 
            this.marcaTbx.Location = new System.Drawing.Point(448, 41);
            this.marcaTbx.Multiline = true;
            this.marcaTbx.Name = "marcaTbx";
            this.marcaTbx.Size = new System.Drawing.Size(330, 25);
            this.marcaTbx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Marca:";
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
            this.generoCbx.Location = new System.Drawing.Point(622, 93);
            this.generoCbx.Name = "generoCbx";
            this.generoCbx.Size = new System.Drawing.Size(245, 25);
            this.generoCbx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gênero:";
            // 
            // subtipoCbx
            // 
            this.subtipoCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Camisa de Clube",
            "Camisa de Seleção"});
            this.subtipoCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.subtipoCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtipoCbx.FormattingEnabled = true;
            this.subtipoCbx.Items.AddRange(new object[] {
            "Camisa de Clube",
            "Camisa de Seleção"});
            this.subtipoCbx.Location = new System.Drawing.Point(317, 93);
            this.subtipoCbx.Name = "subtipoCbx";
            this.subtipoCbx.Size = new System.Drawing.Size(245, 25);
            this.subtipoCbx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub Tipo:";
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
            this.tipoCbx.Location = new System.Drawing.Point(51, 93);
            this.tipoCbx.Name = "tipoCbx";
            this.tipoCbx.Size = new System.Drawing.Size(201, 25);
            this.tipoCbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // produtoTbx
            // 
            this.produtoTbx.Location = new System.Drawing.Point(51, 41);
            this.produtoTbx.Multiline = true;
            this.produtoTbx.Name = "produtoTbx";
            this.produtoTbx.Size = new System.Drawing.Size(330, 25);
            this.produtoTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // ListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 713);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Produtos";
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
        private System.Windows.Forms.ComboBox faixaetariaCbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox marcaTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox generoCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox subtipoCbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox produtoTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox datacriacaoMtbx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nomefantTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nomefornecedorLbl;
        private System.Windows.Forms.Label id_fornec;
    }
}