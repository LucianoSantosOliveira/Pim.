namespace WindowsFormsApp1
{
    partial class FRMBackup
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
            this.LBLUltimo = new System.Windows.Forms.Label();
            this.LblUltimoBack = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbbackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecione uma operação para backup:";
            // 
            // rdbdemaistransacoes
            // 
            this.rdbdemaistransacoes.AutoSize = true;
            this.rdbdemaistransacoes.Location = new System.Drawing.Point(7, 205);
            this.rdbdemaistransacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbdemaistransacoes.Name = "rdbdemaistransacoes";
            this.rdbdemaistransacoes.Size = new System.Drawing.Size(171, 24);
            this.rdbdemaistransacoes.TabIndex = 8;
            this.rdbdemaistransacoes.TabStop = true;
            this.rdbdemaistransacoes.Text = "Demais transações";
            this.rdbdemaistransacoes.UseVisualStyleBackColor = true;
            // 
            // rdbcriptomoedas
            // 
            this.rdbcriptomoedas.AutoSize = true;
            this.rdbcriptomoedas.Location = new System.Drawing.Point(7, 150);
            this.rdbcriptomoedas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbcriptomoedas.Name = "rdbcriptomoedas";
            this.rdbcriptomoedas.Size = new System.Drawing.Size(133, 24);
            this.rdbcriptomoedas.TabIndex = 7;
            this.rdbcriptomoedas.TabStop = true;
            this.rdbcriptomoedas.Text = "Criptomoedas";
            this.rdbcriptomoedas.UseVisualStyleBackColor = true;
            // 
            // rdbsmart
            // 
            this.rdbsmart.AutoSize = true;
            this.rdbsmart.Location = new System.Drawing.Point(7, 96);
            this.rdbsmart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbsmart.Name = "rdbsmart";
            this.rdbsmart.Size = new System.Drawing.Size(139, 24);
            this.rdbsmart.TabIndex = 6;
            this.rdbsmart.TabStop = true;
            this.rdbsmart.Text = "Smart contract";
            this.rdbsmart.UseVisualStyleBackColor = true;
            // 
            // gbbackup
            // 
            this.gbbackup.Controls.Add(this.checkBox1);
            this.gbbackup.Controls.Add(this.LblUltimoBack);
            this.gbbackup.Controls.Add(this.LBLUltimo);
            this.gbbackup.Controls.Add(this.btnprosseguir);
            this.gbbackup.Controls.Add(this.label2);
            this.gbbackup.Controls.Add(this.rdbsmart);
            this.gbbackup.Controls.Add(this.rdbdemaistransacoes);
            this.gbbackup.Controls.Add(this.rdbcriptomoedas);
            this.gbbackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbbackup.Location = new System.Drawing.Point(0, 0);
            this.gbbackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbbackup.Name = "gbbackup";
            this.gbbackup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbbackup.Size = new System.Drawing.Size(656, 406);
            this.gbbackup.TabIndex = 10;
            this.gbbackup.TabStop = false;
            this.gbbackup.Text = "Backup Blockchain";
            this.gbbackup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnprosseguir
            // 
            this.btnprosseguir.Location = new System.Drawing.Point(348, 261);
            this.btnprosseguir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprosseguir.Name = "btnprosseguir";
            this.btnprosseguir.Size = new System.Drawing.Size(112, 35);
            this.btnprosseguir.TabIndex = 10;
            this.btnprosseguir.Text = "Prosseguir";
            this.btnprosseguir.UseVisualStyleBackColor = true;
            // 
            // LBLUltimo
            // 
            this.LBLUltimo.AutoSize = true;
            this.LBLUltimo.Location = new System.Drawing.Point(411, 44);
            this.LBLUltimo.Name = "LBLUltimo";
            this.LBLUltimo.Size = new System.Drawing.Size(120, 20);
            this.LBLUltimo.TabIndex = 11;
            this.LBLUltimo.Text = "Ultimo Backup :";
            // 
            // LblUltimoBack
            // 
            this.LblUltimoBack.AutoSize = true;
            this.LblUltimoBack.Location = new System.Drawing.Point(537, 44);
            this.LblUltimoBack.Name = "LblUltimoBack";
            this.LblUltimoBack.Size = new System.Drawing.Size(111, 20);
            this.LblUltimoBack.TabIndex = 12;
            this.LblUltimoBack.Text = "LblUltimoBack";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(415, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "BackUp automatico?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FRMBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 406);
            this.Controls.Add(this.gbbackup);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMBackup";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LblUltimoBack;
        private System.Windows.Forms.Label LBLUltimo;
    }
}