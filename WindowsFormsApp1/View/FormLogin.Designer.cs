namespace WindowsFormsApp1
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.linksenha = new System.Windows.Forms.LinkLabel();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lblbemvindo = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BTNsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(87, 163);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(72, 19);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuário:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(92, 229);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(60, 19);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(96, 194);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(394, 26);
            this.txtusuario.TabIndex = 2;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(96, 255);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(394, 26);
            this.txtsenha.TabIndex = 3;
            // 
            // linksenha
            // 
            this.linksenha.AutoSize = true;
            this.linksenha.Location = new System.Drawing.Point(322, 298);
            this.linksenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linksenha.Name = "linksenha";
            this.linksenha.Size = new System.Drawing.Size(168, 20);
            this.linksenha.TabIndex = 4;
            this.linksenha.TabStop = true;
            this.linksenha.Text = "Esqueceu sua senha?";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnentrar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Location = new System.Drawing.Point(202, 408);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(164, 49);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lblbemvindo
            // 
            this.lblbemvindo.AutoSize = true;
            this.lblbemvindo.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbemvindo.Location = new System.Drawing.Point(171, 66);
            this.lblbemvindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbemvindo.Name = "lblbemvindo";
            this.lblbemvindo.Size = new System.Drawing.Size(252, 46);
            this.lblbemvindo.TabIndex = 6;
            this.lblbemvindo.Text = "Bem Vindo :)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(96, 297);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Continuar logado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BTNsair
            // 
            this.BTNsair.BackColor = System.Drawing.Color.Transparent;
            this.BTNsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNsair.BackgroundImage")));
            this.BTNsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNsair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNsair.FlatAppearance.BorderSize = 0;
            this.BTNsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNsair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNsair.Location = new System.Drawing.Point(537, 12);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(51, 53);
            this.BTNsair.TabIndex = 8;
            this.BTNsair.UseVisualStyleBackColor = false;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 491);
            this.ControlBox = false;
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblbemvindo);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.linksenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "$ BLOCK MONEY $";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.LinkLabel linksenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lblbemvindo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BTNsair;
    }
}

