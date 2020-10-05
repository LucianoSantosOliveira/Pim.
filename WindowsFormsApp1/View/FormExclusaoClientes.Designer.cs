namespace WindowsFormsApp1
{
    partial class Formexclusao
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
            this.lblid = new System.Windows.Forms.Label();
            this.gbselecione = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dtgexcluir = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedcpf = new System.Windows.Forms.MaskedTextBox();
            this.maskednasc = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnasc = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.gbselecione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgexcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(21, 46);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID:";
            this.lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbselecione
            // 
            this.gbselecione.Controls.Add(this.btncancelar);
            this.gbselecione.Controls.Add(this.btnexcluir);
            this.gbselecione.Controls.Add(this.dtgexcluir);
            this.gbselecione.Controls.Add(this.textBox1);
            this.gbselecione.Controls.Add(this.maskedcpf);
            this.gbselecione.Controls.Add(this.maskednasc);
            this.gbselecione.Controls.Add(this.txtnome);
            this.gbselecione.Controls.Add(this.lblcpf);
            this.gbselecione.Controls.Add(this.lblnasc);
            this.gbselecione.Controls.Add(this.lblnome);
            this.gbselecione.Controls.Add(this.lblid);
            this.gbselecione.Location = new System.Drawing.Point(115, 44);
            this.gbselecione.Name = "gbselecione";
            this.gbselecione.Size = new System.Drawing.Size(562, 354);
            this.gbselecione.TabIndex = 1;
            this.gbselecione.TabStop = false;
            this.gbselecione.Text = "Selecione o cliente";
            this.gbselecione.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(458, 311);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(377, 311);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // dtgexcluir
            // 
            this.dtgexcluir.AllowUserToOrderColumns = true;
            this.dtgexcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgexcluir.Location = new System.Drawing.Point(17, 137);
            this.dtgexcluir.Name = "dtgexcluir";
            this.dtgexcluir.Size = new System.Drawing.Size(524, 150);
            this.dtgexcluir.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedcpf
            // 
            this.maskedcpf.Location = new System.Drawing.Point(451, 62);
            this.maskedcpf.Mask = "000.000.000-00";
            this.maskedcpf.Name = "maskedcpf";
            this.maskedcpf.Size = new System.Drawing.Size(90, 20);
            this.maskedcpf.TabIndex = 11;
            this.maskedcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedcpf_MaskInputRejected);
            // 
            // maskednasc
            // 
            this.maskednasc.Location = new System.Drawing.Point(359, 62);
            this.maskednasc.Mask = "00/00/0000";
            this.maskednasc.Name = "maskednasc";
            this.maskednasc.Size = new System.Drawing.Size(72, 20);
            this.maskednasc.TabIndex = 10;
            this.maskednasc.ValidatingType = typeof(System.DateTime);
            this.maskednasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskednasc_MaskInputRejected);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(134, 62);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(206, 20);
            this.txtnome.TabIndex = 9;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(448, 46);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 8;
            this.lblcpf.Text = "CPF:";
            this.lblcpf.Click += new System.EventHandler(this.lblcpf_Click);
            // 
            // lblnasc
            // 
            this.lblnasc.AutoSize = true;
            this.lblnasc.Location = new System.Drawing.Point(357, 46);
            this.lblnasc.Name = "lblnasc";
            this.lblnasc.Size = new System.Drawing.Size(64, 13);
            this.lblnasc.TabIndex = 7;
            this.lblnasc.Text = "Data Nasc.:";
            this.lblnasc.Click += new System.EventHandler(this.lblnasc_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(131, 46);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 6;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // Formexclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbselecione);
            this.Name = "Formexclusao";
            this.Text = "Exclusão de clientes";
            this.Load += new System.EventHandler(this.Formexclusao_Load);
            this.gbselecione.ResumeLayout(false);
            this.gbselecione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgexcluir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.GroupBox gbselecione;
        private System.Windows.Forms.MaskedTextBox maskedcpf;
        private System.Windows.Forms.MaskedTextBox maskednasc;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnasc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgexcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexcluir;
    }
}