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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskinicial = new System.Windows.Forms.MaskedTextBox();
            this.mskfinal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbperiodos = new System.Windows.Forms.GroupBox();
            this.rdbsemanal = new System.Windows.Forms.RadioButton();
            this.rdbmensal = new System.Windows.Forms.RadioButton();
            this.rdbanual = new System.Windows.Forms.RadioButton();
            this.btnemitir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.gbdata.SuspendLayout();
            this.gbperiodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdata
            // 
            this.gbdata.Controls.Add(this.mskfinal);
            this.gbdata.Controls.Add(this.mskinicial);
            this.gbdata.Controls.Add(this.label2);
            this.gbdata.Controls.Add(this.label1);
            this.gbdata.Location = new System.Drawing.Point(23, 28);
            this.gbdata.Name = "gbdata";
            this.gbdata.Size = new System.Drawing.Size(211, 215);
            this.gbdata.TabIndex = 0;
            this.gbdata.TabStop = false;
            this.gbdata.Text = "Selecione uma opção";
            this.gbdata.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // mskinicial
            // 
            this.mskinicial.Location = new System.Drawing.Point(20, 71);
            this.mskinicial.Mask = "00/00/0000";
            this.mskinicial.Name = "mskinicial";
            this.mskinicial.Size = new System.Drawing.Size(100, 20);
            this.mskinicial.TabIndex = 4;
            this.mskinicial.ValidatingType = typeof(System.DateTime);
            // 
            // mskfinal
            // 
            this.mskfinal.Location = new System.Drawing.Point(20, 142);
            this.mskfinal.Mask = "00/00/0000";
            this.mskfinal.Name = "mskfinal";
            this.mskfinal.Size = new System.Drawing.Size(100, 20);
            this.mskfinal.TabIndex = 5;
            this.mskfinal.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ou";
            // 
            // gbperiodos
            // 
            this.gbperiodos.Controls.Add(this.rdbanual);
            this.gbperiodos.Controls.Add(this.rdbmensal);
            this.gbperiodos.Controls.Add(this.rdbsemanal);
            this.gbperiodos.Location = new System.Drawing.Point(352, 28);
            this.gbperiodos.Name = "gbperiodos";
            this.gbperiodos.Size = new System.Drawing.Size(211, 215);
            this.gbperiodos.TabIndex = 6;
            this.gbperiodos.TabStop = false;
            this.gbperiodos.Text = "Selecione uma opção";
            // 
            // rdbsemanal
            // 
            this.rdbsemanal.AutoSize = true;
            this.rdbsemanal.Location = new System.Drawing.Point(36, 46);
            this.rdbsemanal.Name = "rdbsemanal";
            this.rdbsemanal.Size = new System.Drawing.Size(66, 17);
            this.rdbsemanal.TabIndex = 0;
            this.rdbsemanal.TabStop = true;
            this.rdbsemanal.Text = "Semanal";
            this.rdbsemanal.UseVisualStyleBackColor = true;
            // 
            // rdbmensal
            // 
            this.rdbmensal.AutoSize = true;
            this.rdbmensal.Location = new System.Drawing.Point(36, 101);
            this.rdbmensal.Name = "rdbmensal";
            this.rdbmensal.Size = new System.Drawing.Size(59, 17);
            this.rdbmensal.TabIndex = 1;
            this.rdbmensal.TabStop = true;
            this.rdbmensal.Text = "Mensal";
            this.rdbmensal.UseVisualStyleBackColor = true;
            // 
            // rdbanual
            // 
            this.rdbanual.AutoSize = true;
            this.rdbanual.BackColor = System.Drawing.SystemColors.Control;
            this.rdbanual.Location = new System.Drawing.Point(36, 152);
            this.rdbanual.Name = "rdbanual";
            this.rdbanual.Size = new System.Drawing.Size(52, 17);
            this.rdbanual.TabIndex = 2;
            this.rdbanual.TabStop = true;
            this.rdbanual.Text = "Anual";
            this.rdbanual.UseVisualStyleBackColor = false;
            this.rdbanual.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnemitir
            // 
            this.btnemitir.Location = new System.Drawing.Point(415, 279);
            this.btnemitir.Name = "btnemitir";
            this.btnemitir.Size = new System.Drawing.Size(88, 23);
            this.btnemitir.TabIndex = 7;
            this.btnemitir.Text = "Emitir relatório";
            this.btnemitir.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(521, 279);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 312);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnemitir);
            this.Controls.Add(this.gbperiodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbdata);
            this.Name = "FormRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            this.gbdata.ResumeLayout(false);
            this.gbdata.PerformLayout();
            this.gbperiodos.ResumeLayout(false);
            this.gbperiodos.PerformLayout();
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
    }
}