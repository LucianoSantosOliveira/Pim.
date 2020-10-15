using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class frmconsultarclientes : Form
    {
        public frmconsultarclientes()
        {
            InitializeComponent();
            TxtID.Text = "0";
        }


        private void mnbackup_Click(object sender, EventArgs e)
        {

        }

        private void frmconsultarclientes_Load(object sender, EventArgs e)
        {
            //Transparencia dos botoes
            BTNPesquisar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNPesquisar1.FlatAppearance.BorderSize = 0;
            BTNPesquisar1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNPesquisar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNPesquisar1.BackColor = Color.Transparent;

            BTNcadastrarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNcadastrarCli.FlatAppearance.BorderSize = 0;
            BTNcadastrarCli.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNcadastrarCli.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNcadastrarCli.BackColor = Color.Transparent;

            // Cor de fundo do form
            this.BackColor = Color.FromArgb(0, 197, 162);

            dtgclientes.AllowUserToAddRows = false;
            dtgclientes.AllowUserToDeleteRows = false;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ConectaSQL conectaSQL = new ConectaSQL();

            cliente.setNome(txtnome.Text);
            cliente.setConsultor(txtconsultor.Text);
            if (string.IsNullOrEmpty(TxtID.Text)) { TxtID.Text = "0"; } else { cliente.setID(Convert.ToInt32(TxtID.Text)); }          
            cliente.setCpf(maskedcpf.Text);
            conectaSQL.ConsultarClientes(cliente , false);

            dtgclientes.DataSource = conectaSQL.getDataTable;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = ""; maskednasc.Text = "" ;  maskedcpf.Text = "";

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ConectaSQL conectaSQL = new ConectaSQL();
            cliente.setID(Convert.ToInt32(TxtID.Text));
            cliente.setNome(txtnome.Text);
            conectaSQL.DeletarCliente(cliente);
            dtgclientes.DataSource = conectaSQL.getDataTable;
        }

        private void dtgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome.Text = dtgclientes.CurrentRow.Cells[1].Value.ToString();
            TxtID.Text = dtgclientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTNcadastrarCli_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
            formCadastrarCliente.StartPosition = FormStartPosition.CenterScreen;
            formCadastrarCliente.Show();
        }

        private void BTNAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ConectaSQL conectaSQL = new ConectaSQL();

        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        //BtnSelecionaTodos
        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ConectaSQL conectaSQL = new ConectaSQL();
            conectaSQL.ConsultarClientes(null, true);
            dtgclientes.DataSource = conectaSQL.getDataTable;
        }
    }
}
