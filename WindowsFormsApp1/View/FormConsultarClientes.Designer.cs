namespace WindowsFormsApp1
{
    partial class frmconsultarclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsultarclientes));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblnasc = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.maskednasc = new System.Windows.Forms.MaskedTextBox();
            this.maskedcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.lblconsultor = new System.Windows.Forms.Label();
            this.txtconsultor = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dtgclientes = new System.Windows.Forms.DataGridView();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.BTNcadastrarCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GBcliente = new System.Windows.Forms.GroupBox();
            this.PBlogo = new System.Windows.Forms.PictureBox();
            this.BTNAlterar = new System.Windows.Forms.Button();
            this.BTNsair = new System.Windows.Forms.Button();
            this.BTNPesquisar1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).BeginInit();
            this.GBcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(129, 130);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Location = new System.Drawing.Point(408, 88);
            this.lblnasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(92, 20);
            this.lblnasc.TabIndex = 1;
            this.lblnasc.Text = "Data Nasc.:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(408, 128);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(44, 20);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(192, 130);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(208, 26);
            this.txtnome.TabIndex = 3;
            // 
            // maskednasc
            // 
            this.maskednasc.Location = new System.Drawing.Point(508, 97);
            this.maskednasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskednasc.Mask = "00/00/0000";
            this.maskednasc.Name = "maskednasc";
            this.maskednasc.Size = new System.Drawing.Size(88, 26);
            this.maskednasc.TabIndex = 4;
            this.maskednasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskedcpf
            // 
            this.maskedcpf.Location = new System.Drawing.Point(460, 131);
            this.maskedcpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedcpf.Mask = "000.000.000-00";
            this.maskedcpf.Name = "maskedcpf";
            this.maskedcpf.Size = new System.Drawing.Size(133, 26);
            this.maskedcpf.TabIndex = 5;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(306, 88);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 20);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(52, 39);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(46, 26);
            this.TxtID.TabIndex = 7;
            // 
            // lblconsultor
            // 
            this.lblconsultor.AutoSize = true;
            this.lblconsultor.Location = new System.Drawing.Point(14, 88);
            this.lblconsultor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconsultor.Name = "lblconsultor";
            this.lblconsultor.Size = new System.Drawing.Size(170, 20);
            this.lblconsultor.TabIndex = 9;
            this.lblconsultor.Text = "Consultor responsável:";
            // 
            // txtconsultor
            // 
            this.txtconsultor.Location = new System.Drawing.Point(192, 88);
            this.txtconsultor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtconsultor.Name = "txtconsultor";
            this.txtconsultor.Size = new System.Drawing.Size(208, 26);
            this.txtconsultor.TabIndex = 10;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(955, 244);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 35);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(1075, 244);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(112, 35);
            this.btnpesquisar.TabIndex = 12;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dtgclientes
            // 
            this.dtgclientes.AllowUserToOrderColumns = true;
            this.dtgclientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgclientes.Location = new System.Drawing.Point(13, 289);
            this.dtgclientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgclientes.Name = "dtgclientes";
            this.dtgclientes.RowHeadersWidth = 62;
            this.dtgclientes.Size = new System.Drawing.Size(1174, 391);
            this.dtgclientes.TabIndex = 13;
            this.dtgclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgclientes_CellContentClick);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(835, 244);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(112, 35);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // BTNcadastrarCli
            // 
            this.BTNcadastrarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNcadastrarCli.BackgroundImage")));
            this.BTNcadastrarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNcadastrarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcadastrarCli.Location = new System.Drawing.Point(615, 177);
            this.BTNcadastrarCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNcadastrarCli.Name = "BTNcadastrarCli";
            this.BTNcadastrarCli.Size = new System.Drawing.Size(64, 64);
            this.BTNcadastrarCli.TabIndex = 16;
            this.BTNcadastrarCli.UseVisualStyleBackColor = true;
            this.BTNcadastrarCli.Click += new System.EventHandler(this.BTNcadastrarCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // GBcliente
            // 
            this.GBcliente.Controls.Add(this.button2);
            this.GBcliente.Controls.Add(this.label1);
            this.GBcliente.Controls.Add(this.BTNcadastrarCli);
            this.GBcliente.Controls.Add(this.TxtID);
            this.GBcliente.Controls.Add(this.lblconsultor);
            this.GBcliente.Controls.Add(this.lblnome);
            this.GBcliente.Controls.Add(this.lblnasc);
            this.GBcliente.Controls.Add(this.BTNPesquisar1);
            this.GBcliente.Controls.Add(this.txtnome);
            this.GBcliente.Controls.Add(this.maskedcpf);
            this.GBcliente.Controls.Add(this.txtconsultor);
            this.GBcliente.Controls.Add(this.lblcpf);
            this.GBcliente.Controls.Add(this.maskednasc);
            this.GBcliente.Controls.Add(this.lblid);
            this.GBcliente.Location = new System.Drawing.Point(13, 12);
            this.GBcliente.Name = "GBcliente";
            this.GBcliente.Size = new System.Drawing.Size(695, 267);
            this.GBcliente.TabIndex = 17;
            this.GBcliente.TabStop = false;
            this.GBcliente.Text = "Dados do cliente";
            this.GBcliente.Enter += new System.EventHandler(this.GBcliente_Enter);
            // 
            // PBlogo
            // 
            this.PBlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBlogo.BackgroundImage")));
            this.PBlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBlogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBlogo.InitialImage")));
            this.PBlogo.Location = new System.Drawing.Point(717, 26);
            this.PBlogo.Name = "PBlogo";
            this.PBlogo.Size = new System.Drawing.Size(471, 212);
            this.PBlogo.TabIndex = 18;
            this.PBlogo.TabStop = false;
            // 
            // BTNAlterar
            // 
            this.BTNAlterar.Location = new System.Drawing.Point(716, 244);
            this.BTNAlterar.Name = "BTNAlterar";
            this.BTNAlterar.Size = new System.Drawing.Size(112, 35);
            this.BTNAlterar.TabIndex = 19;
            this.BTNAlterar.Text = "Alterar";
            this.BTNAlterar.UseVisualStyleBackColor = true;
            this.BTNAlterar.Click += new System.EventHandler(this.BTNAlterar_Click);
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
            this.BTNsair.Location = new System.Drawing.Point(1134, 33);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(43, 38);
            this.BTNsair.TabIndex = 20;
            this.BTNsair.UseVisualStyleBackColor = false;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // BTNPesquisar1
            // 
            this.BTNPesquisar1.BackColor = System.Drawing.Color.Transparent;
            this.BTNPesquisar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar1.BackgroundImage")));
            this.BTNPesquisar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPesquisar1.Location = new System.Drawing.Point(508, 177);
            this.BTNPesquisar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNPesquisar1.Name = "BTNPesquisar1";
            this.BTNPesquisar1.Size = new System.Drawing.Size(64, 64);
            this.BTNPesquisar1.TabIndex = 12;
            this.BTNPesquisar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPesquisar1.UseVisualStyleBackColor = false;
            this.BTNPesquisar1.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmconsultarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.BTNAlterar);
            this.Controls.Add(this.PBlogo);
            this.Controls.Add(this.GBcliente);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.dtgclientes);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnlimpar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmconsultarclientes";
            this.Text = "Consultar clientes";
            this.Load += new System.EventHandler(this.frmconsultarclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).EndInit();
            this.GBcliente.ResumeLayout(false);
            this.GBcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox maskednasc;
        private System.Windows.Forms.MaskedTextBox maskedcpf;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label lblconsultor;
        private System.Windows.Forms.TextBox txtconsultor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView dtgclientes;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button BTNcadastrarCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBcliente;
        private System.Windows.Forms.PictureBox PBlogo;
        private System.Windows.Forms.Button BTNAlterar;
        private System.Windows.Forms.Button BTNsair;
        private System.Windows.Forms.Button BTNPesquisar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}