namespace WindowsFormsApp1
{
    partial class FormTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransacoes));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNsair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNPesquisar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 225);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Smart contract";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 278);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Criptomoedas";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione uma operação para consulta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome ";
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
            this.BTNsair.Location = new System.Drawing.Point(825, 12);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(51, 53);
            this.BTNsair.TabIndex = 9;
            this.BTNsair.UseVisualStyleBackColor = false;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(432, 334);
            this.dataGridView1.TabIndex = 10;
            // 
            // BTNPesquisar1
            // 
            this.BTNPesquisar1.BackColor = System.Drawing.Color.Transparent;
            this.BTNPesquisar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPesquisar1.BackgroundImage")));
            this.BTNPesquisar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPesquisar1.Location = new System.Drawing.Point(360, 238);
            this.BTNPesquisar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNPesquisar1.Name = "BTNPesquisar1";
            this.BTNPesquisar1.Size = new System.Drawing.Size(64, 64);
            this.BTNPesquisar1.TabIndex = 13;
            this.BTNPesquisar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPesquisar1.UseVisualStyleBackColor = false;
            this.BTNPesquisar1.Click += new System.EventHandler(this.BTNPesquisar1_Click);
            // 
            // FormTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 426);
            this.Controls.Add(this.BTNPesquisar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNsair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransacoes";
            this.Text = "Transações";
            this.Load += new System.EventHandler(this.FormTransacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNsair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNPesquisar1;
    }
}