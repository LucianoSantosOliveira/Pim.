namespace WindowsFormsApp1
{
    partial class FormRelatorio
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
            this.gbdata = new System.Windows.Forms.GroupBox();
            this.mskfinal = new System.Windows.Forms.MaskedTextBox();
            this.mskinicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbperiodos = new System.Windows.Forms.GroupBox();
            this.rdbanual = new System.Windows.Forms.RadioButton();
            this.rdbmensal = new System.Windows.Forms.RadioButton();
            this.rdbsemanal = new System.Windows.Forms.RadioButton();
            this.btnemitir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbdata.SuspendLayout();
            this.gbperiodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbdata
            // 
            this.gbdata.Controls.Add(this.mskfinal);
            this.gbdata.Controls.Add(this.mskinicial);
            this.gbdata.Controls.Add(this.label2);
            this.gbdata.Controls.Add(this.label1);
            this.gbdata.Location = new System.Drawing.Point(34, 43);
            this.gbdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbdata.Name = "gbdata";
            this.gbdata.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbdata.Size = new System.Drawing.Size(316, 331);
            this.gbdata.TabIndex = 0;
            this.gbdata.TabStop = false;
            this.gbdata.Text = "Selecione uma opção";
            this.gbdata.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mskfinal
            // 
            this.mskfinal.Location = new System.Drawing.Point(30, 218);
            this.mskfinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskfinal.Mask = "00/00/0000";
            this.mskfinal.Name = "mskfinal";
            this.mskfinal.Size = new System.Drawing.Size(148, 26);
            this.mskfinal.TabIndex = 5;
            this.mskfinal.ValidatingType = typeof(System.DateTime);
            // 
            // mskinicial
            // 
            this.mskinicial.Location = new System.Drawing.Point(30, 109);
            this.mskinicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskinicial.Mask = "00/00/0000";
            this.mskinicial.Name = "mskinicial";
            this.mskinicial.Size = new System.Drawing.Size(148, 26);
            this.mskinicial.TabIndex = 4;
            this.mskinicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ou";
            // 
            // gbperiodos
            // 
            this.gbperiodos.Controls.Add(this.rdbanual);
            this.gbperiodos.Controls.Add(this.rdbmensal);
            this.gbperiodos.Controls.Add(this.rdbsemanal);
            this.gbperiodos.Location = new System.Drawing.Point(528, 43);
            this.gbperiodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbperiodos.Name = "gbperiodos";
            this.gbperiodos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbperiodos.Size = new System.Drawing.Size(316, 331);
            this.gbperiodos.TabIndex = 6;
            this.gbperiodos.TabStop = false;
            this.gbperiodos.Text = "Selecione uma opção";
            // 
            // rdbanual
            // 
            this.rdbanual.AutoSize = true;
            this.rdbanual.BackColor = System.Drawing.SystemColors.Control;
            this.rdbanual.Location = new System.Drawing.Point(54, 234);
            this.rdbanual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbanual.Name = "rdbanual";
            this.rdbanual.Size = new System.Drawing.Size(75, 24);
            this.rdbanual.TabIndex = 2;
            this.rdbanual.TabStop = true;
            this.rdbanual.Text = "Anual";
            this.rdbanual.UseVisualStyleBackColor = false;
            this.rdbanual.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbmensal
            // 
            this.rdbmensal.AutoSize = true;
            this.rdbmensal.Location = new System.Drawing.Point(54, 155);
            this.rdbmensal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbmensal.Name = "rdbmensal";
            this.rdbmensal.Size = new System.Drawing.Size(85, 24);
            this.rdbmensal.TabIndex = 1;
            this.rdbmensal.TabStop = true;
            this.rdbmensal.Text = "Mensal";
            this.rdbmensal.UseVisualStyleBackColor = true;
            // 
            // rdbsemanal
            // 
            this.rdbsemanal.AutoSize = true;
            this.rdbsemanal.Location = new System.Drawing.Point(54, 71);
            this.rdbsemanal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbsemanal.Name = "rdbsemanal";
            this.rdbsemanal.Size = new System.Drawing.Size(97, 24);
            this.rdbsemanal.TabIndex = 0;
            this.rdbsemanal.TabStop = true;
            this.rdbsemanal.Text = "Semanal";
            this.rdbsemanal.UseVisualStyleBackColor = true;
            // 
            // btnemitir
            // 
            this.btnemitir.Location = new System.Drawing.Point(625, 384);
            this.btnemitir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnemitir.Name = "btnemitir";
            this.btnemitir.Size = new System.Drawing.Size(132, 35);
            this.btnemitir.TabIndex = 7;
            this.btnemitir.Text = "Emitir relatório";
            this.btnemitir.UseVisualStyleBackColor = true;
            this.btnemitir.Click += new System.EventHandler(this.btnemitir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(765, 384);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(112, 35);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(888, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(564, 322);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnemitir);
            this.Controls.Add(this.gbperiodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbdata);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.gbdata.ResumeLayout(false);
            this.gbdata.PerformLayout();
            this.gbperiodos.ResumeLayout(false);
            this.gbperiodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskfinal;
        private System.Windows.Forms.MaskedTextBox mskinicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbperiodos;
        private System.Windows.Forms.RadioButton rdbanual;
        private System.Windows.Forms.RadioButton rdbmensal;
        private System.Windows.Forms.RadioButton rdbsemanal;
        private System.Windows.Forms.Button btnemitir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}