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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 197, 162);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnemitir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mskinicial.Text +" "+ mskfinal.Text);

            Transacao transacao = new Transacao();
            transacao.SelecionaTransacao(0,"Corsair");
            dataGridView1.DataSource = transacao.GetDataTable();
            //transacao.SelecionaPorData(mskinicial.Text);
        }
    }
}
