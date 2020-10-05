namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdbdemaistransacoes = new System.Windows.Forms.RadioButton();
            this.rdbcriptomoedas = new System.Windows.Forms.RadioButton();
            this.rdbsmart = new System.Windows.Forms.RadioButton();
            this.gbbackup = new System.Windows.Forms.GroupBox();
            this.btnprosseguir = new System.Windows.Forms.Button();
            this.gbbackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecione uma operação para backup:";
            // 
            // rdbdemaistransacoes
            // 
            this.rdbdemaistransacoes.AutoSize = true;
            this.rdbdemaistransacoes.Location = new System.Drawing.Point(66, 138);
            this.rdbdemaistransacoes.Name = "rdbdemaistransacoes";
            this.rdbdemaistransacoes.Size = new System.Drawing.Size(115, 17);
            this.rdbdemaistransacoes.TabIndex = 8;
            this.rdbdemaistransacoes.TabStop = true;
            this.rdbdemaistransacoes.Text = "Demais transações";
            this.rdbdemaistransacoes.UseVisualStyleBackColor = true;
            // 
            // rdbcriptomoedas
            // 
            this.rdbcriptomoedas.AutoSize = true;
            this.rdbcriptomoedas.Location = new System.Drawing.Point(66, 102);
            this.rdbcriptomoedas.Name = "rdbcriptomoedas";
            this.rdbcriptomoedas.Size = new System.Drawing.Size(89, 17);
            this.rdbcriptomoedas.TabIndex = 7;
            this.rdbcriptomoedas.TabStop = true;
            this.rdbcriptomoedas.Text = "Criptomoedas";
            this.rdbcriptomoedas.UseVisualStyleBackColor = true;
            // 
            // rdbsmart
            // 
            this.rdbsmart.AutoSize = true;
            this.rdbsmart.Location = new System.Drawing.Point(66, 67);
            this.rdbsmart.Name = "rdbsmart";
            this.rdbsmart.Size = new System.Drawing.Size(94, 17);
            this.rdbsmart.TabIndex = 6;
            this.rdbsmart.TabStop = true;
            this.rdbsmart.Text = "Smart contract";
            this.rdbsmart.UseVisualStyleBackColor = true;
            // 
            // gbbackup
            // 
            this.gbbackup.Controls.Add(this.btnprosseguir);
            this.gbbackup.Controls.Add(this.label2);
            this.gbbackup.Controls.Add(this.rdbsmart);
            this.gbbackup.Controls.Add(this.rdbdemaistransacoes);
            this.gbbackup.Controls.Add(this.rdbcriptomoedas);
            this.gbbackup.Location = new System.Drawing.Point(22, 21);
            this.gbbackup.Name = "gbbackup";
            this.gbbackup.Size = new System.Drawing.Size(384, 207);
            this.gbbackup.TabIndex = 10;
            this.gbbackup.TabStop = false;
            this.gbbackup.Text = "Backup Blockchain";
            this.gbbackup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnprosseguir
            // 
            this.btnprosseguir.Location = new System.Drawing.Point(293, 174);
            this.btnprosseguir.Name = "btnprosseguir";
            this.btnprosseguir.Size = new System.Drawing.Size(75, 23);
            this.btnprosseguir.TabIndex = 10;
            this.btnprosseguir.Text = "Prosseguir";
            this.btnprosseguir.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 264);
            this.Controls.Add(this.gbbackup);
            this.Name = "Form2";
            this.Text = "Backup";
            this.gbbackup.ResumeLayout(false);
            this.gbbackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbdemaistransacoes;
        private System.Windows.Forms.RadioButton rdbcriptomoedas;
        private System.Windows.Forms.RadioButton rdbsmart;
        private System.Windows.Forms.GroupBox gbbackup;
        private System.Windows.Forms.Button btnprosseguir;
    }
}