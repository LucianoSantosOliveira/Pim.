using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1
{
    public partial class FormTransacoes : Form
    {
        public FormTransacoes()
        {
            InitializeComponent();
        }

        private void FormTransacoes_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 197, 162);
            this.StartPosition = FormStartPosition.CenterScreen;
            BTNsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNsair.FlatAppearance.BorderSize = 0;
            BTNsair.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.BackColor = Color.Transparent;

            BTNPesquisar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNPesquisar1.FlatAppearance.BorderSize = 0;
            BTNPesquisar1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNPesquisar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNPesquisar1.BackColor = Color.Transparent;
            CriptoMoedas criptoMoedas = new CriptoMoedas();
        }
        //468; 426 , 888; 426

        private void BTNsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNPesquisar1_Click(object sender, EventArgs e)
        {
            Transacao transacao = new Transacao();
            transacao.SelecionaTransacao(0,textBox2.Text);
            dataGridView1.DataSource =  transacao.GetDataTable();
        }
    }
}
