namespace testpim
{
    partial class Login
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
            this.loginPbx = new System.Windows.Forms.PictureBox();
            this.logaBtn = new System.Windows.Forms.Button();
            this.senhatxt = new System.Windows.Forms.TextBox();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.senhalbl = new System.Windows.Forms.Label();
            this.usuáriolbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPbx
            // 
            this.loginPbx.Image = global::testpim.Properties.Resources.icone_contato;
            this.loginPbx.Location = new System.Drawing.Point(328, 44);
            this.loginPbx.Name = "loginPbx";
            this.loginPbx.Size = new System.Drawing.Size(235, 215);
            this.loginPbx.TabIndex = 6;
            this.loginPbx.TabStop = false;
            // 
            // logaBtn
            // 
            this.logaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.logaBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logaBtn.ForeColor = System.Drawing.Color.White;
            this.logaBtn.Location = new System.Drawing.Point(328, 444);
            this.logaBtn.Name = "logaBtn";
            this.logaBtn.Size = new System.Drawing.Size(257, 58);
            this.logaBtn.TabIndex = 9;
            this.logaBtn.Text = "Logar";
            this.logaBtn.UseVisualStyleBackColor = false;
            this.logaBtn.Click += new System.EventHandler(this.logaBtn_Click);
            // 
            // senhatxt
            // 
            this.senhatxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatxt.Location = new System.Drawing.Point(285, 364);
            this.senhatxt.Name = "senhatxt";
            this.senhatxt.PasswordChar = '*';
            this.senhatxt.Size = new System.Drawing.Size(352, 27);
            this.senhatxt.TabIndex = 8;
            // 
            // usuariotxt
            // 
            this.usuariotxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotxt.Location = new System.Drawing.Point(285, 284);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(352, 27);
            this.usuariotxt.TabIndex = 7;
            // 
            // senhalbl
            // 
            this.senhalbl.AutoSize = true;
            this.senhalbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhalbl.ForeColor = System.Drawing.Color.White;
            this.senhalbl.Location = new System.Drawing.Point(183, 358);
            this.senhalbl.Name = "senhalbl";
            this.senhalbl.Size = new System.Drawing.Size(96, 33);
            this.senhalbl.TabIndex = 11;
            this.senhalbl.Text = "Senha";
            // 
            // usuáriolbl
            // 
            this.usuáriolbl.AutoSize = true;
            this.usuáriolbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriolbl.ForeColor = System.Drawing.Color.White;
            this.usuáriolbl.Location = new System.Drawing.Point(171, 278);
            this.usuáriolbl.Name = "usuáriolbl";
            this.usuáriolbl.Size = new System.Drawing.Size(108, 33);
            this.usuáriolbl.TabIndex = 10;
            this.usuáriolbl.Text = "Usuário";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(854, 525);
            this.Controls.Add(this.senhalbl);
            this.Controls.Add(this.usuáriolbl);
            this.Controls.Add(this.logaBtn);
            this.Controls.Add(this.senhatxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.loginPbx);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPbx;
        private System.Windows.Forms.Button logaBtn;
        private System.Windows.Forms.TextBox senhatxt;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.Label senhalbl;
        private System.Windows.Forms.Label usuáriolbl;
    }
}