namespace WindowsFormsApp1
{
    partial class FormCadastrarCliente
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.rdbfeminino = new System.Windows.Forms.RadioButton();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.cmbestadocivil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.DPCliente = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(74, 223);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Nome:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(74, 304);
            this.lblcpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(44, 20);
            this.lblcpf.TabIndex = 11;
            this.lblcpf.Text = "CPF:";
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(74, 380);
            this.lblnascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(156, 20);
            this.lblnascimento.TabIndex = 12;
            this.lblnascimento.Text = "Data de nascimento:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(76, 163);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(57, 20);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "E-mail:";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(76, 82);
            this.lblendereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(82, 20);
            this.lblendereco.TabIndex = 14;
            this.lblendereco.Text = "Endereço:";
            this.lblendereco.Click += new System.EventHandler(this.lblendereco_Click);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(413, 163);
            this.lbltelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(62, 20);
            this.lbltelefone.TabIndex = 15;
            this.lbltelefone.Text = "Celular:";
            this.lbltelefone.Click += new System.EventHandler(this.lbltelefone_Click);
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(76, 530);
            this.lblsexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(49, 20);
            this.lblsexo.TabIndex = 16;
            this.lblsexo.Text = "Sexo:";
            this.lblsexo.Click += new System.EventHandler(this.lblsexo_Click);
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Location = new System.Drawing.Point(76, 447);
            this.lblestadocivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(92, 20);
            this.lblestadocivil.TabIndex = 17;
            this.lblestadocivil.Text = "Estado civil:";
            this.lblestadocivil.Click += new System.EventHandler(this.lblestadocivil_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(79, 247);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(314, 26);
            this.txtnome.TabIndex = 18;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(79, 330);
            this.mskcpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskcpf.Mask = "000.000.000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(232, 26);
            this.mskcpf.TabIndex = 19;
            this.mskcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(81, 106);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(232, 26);
            this.txtendereco.TabIndex = 20;
            this.txtendereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdbfeminino
            // 
            this.rdbfeminino.AutoSize = true;
            this.rdbfeminino.Location = new System.Drawing.Point(79, 555);
            this.rdbfeminino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbfeminino.Name = "rdbfeminino";
            this.rdbfeminino.Size = new System.Drawing.Size(99, 24);
            this.rdbfeminino.TabIndex = 21;
            this.rdbfeminino.TabStop = true;
            this.rdbfeminino.Text = "Feminino";
            this.rdbfeminino.UseVisualStyleBackColor = true;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Location = new System.Drawing.Point(205, 555);
            this.rdbmasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(105, 24);
            this.rdbmasculino.TabIndex = 22;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(81, 189);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 26);
            this.txtemail.TabIndex = 24;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mskcelular
            // 
            this.mskcelular.Location = new System.Drawing.Point(418, 188);
            this.mskcelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskcelular.Mask = "(99) 00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(148, 26);
            this.mskcelular.TabIndex = 25;
            this.mskcelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // cmbestadocivil
            // 
            this.cmbestadocivil.FormattingEnabled = true;
            this.cmbestadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "União estável",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)",
            ""});
            this.cmbestadocivil.Location = new System.Drawing.Point(80, 472);
            this.cmbestadocivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbestadocivil.Name = "cmbestadocivil";
            this.cmbestadocivil.Size = new System.Drawing.Size(180, 28);
            this.cmbestadocivil.TabIndex = 26;
            this.cmbestadocivil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "CEP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(331, 106);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(148, 26);
            this.txtcidade.TabIndex = 31;
            this.txtcidade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(496, 106);
            this.txtuf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(56, 26);
            this.txtuf.TabIndex = 32;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(577, 106);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(148, 26);
            this.txtcep.TabIndex = 33;
            // 
            // msktelefone
            // 
            this.msktelefone.Location = new System.Drawing.Point(250, 189);
            this.msktelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msktelefone.Mask = "(99) 0000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(148, 26);
            this.msktelefone.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefone";
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Location = new System.Drawing.Point(496, 428);
            this.BTNConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(185, 133);
            this.BTNConfirmar.TabIndex = 36;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.UseVisualStyleBackColor = true;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // DPCliente
            // 
            this.DPCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DPCliente.Location = new System.Drawing.Point(78, 405);
            this.DPCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPCliente.Name = "DPCliente";
            this.DPCliente.Size = new System.Drawing.Size(344, 26);
            this.DPCliente.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNConfirmar);
            this.groupBox1.Controls.Add(this.DPCliente);
            this.groupBox1.Controls.Add(this.lblendereco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbestadocivil);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.rdbmasculino);
            this.groupBox1.Controls.Add(this.msktelefone);
            this.groupBox1.Controls.Add(this.rdbfeminino);
            this.groupBox1.Controls.Add(this.lbltelefone);
            this.groupBox1.Controls.Add(this.mskcpf);
            this.groupBox1.Controls.Add(this.txtcep);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(this.lblestadocivil);
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.lblsexo);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblnascimento);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.mskcelular);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 635);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cliente";
            // 
            // FormCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 635);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadastrarCliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.FormCadastrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.RadioButton rdbfeminino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.ComboBox cmbestadocivil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.DateTimePicker DPCliente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}