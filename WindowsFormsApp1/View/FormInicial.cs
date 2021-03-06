﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormInicial : Form
    {
        

        private string ReadUser()
        {
            String User;

            User = File.ReadAllText(@"C:\Users\lucianoq\source\repos\PIMM\WindowsFormsApp1\User.txt");
            File.Delete(@"C:\Users\lucianoq\source\repos\PIMM\WindowsFormsApp1\User.txt");
            return User;
        }

        public FormInicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            LBnomeUsuario.BackColor = Color.White;
        }
        

        private void consultarClientesToolStripMenuItem_Click  (object sender, EventArgs e)
        {
            frmconsultarclientes FrmConsultarCliente = new frmconsultarclientes();
            FrmConsultarCliente.StartPosition = FormStartPosition.CenterScreen;
            FrmConsultarCliente.Show();
        }

        private void mncadastrarclientes_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente formCadastrarCliente = new FormCadastrarCliente();
            formCadastrarCliente.StartPosition = FormStartPosition.CenterScreen;
            formCadastrarCliente.Show();
        }

        private void mnclientes_Click(object sender, EventArgs e)
        {
            frmconsultarclientes FrmConsultarCliente = new frmconsultarclientes();
            FrmConsultarCliente.StartPosition = FormStartPosition.CenterScreen;
            FrmConsultarCliente.Show();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

            
            LBnomeUsuario.BackColor = Color.FromArgb(0, 197, 150);
            LBnomeUsuario.BorderStyle = BorderStyle.None;

            LBnomeUsuario.Text = ReadUser();

            BTNsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNsair.FlatAppearance.BorderSize = 0;
            BTNsair.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.BackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(0, 197, 162);
            menuprincipal.BackColor = Color.FromArgb(0, 197, 162);
            groupBox2.BackColor = Color.FromArgb(0, 197, 162);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mntransacoes_Click(object sender, EventArgs e)
        {
            FormTransacoes formTransacoes = new FormTransacoes();
            formTransacoes.StartPosition = FormStartPosition.CenterScreen;
            formTransacoes.Show();
        }

        private void mnbackup_Click(object sender, EventArgs e)
        {
            FRMBackup fRMBackup = new FRMBackup();
            fRMBackup.Show();
        }

        private void mnrelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio();
            formRelatorio.StartPosition = FormStartPosition.CenterScreen;
           
            formRelatorio.Show();

            //if (fechar == true) { formRelatorio.Close(); }
        }

        private void ControleAcesso(int nivel)
        {
            if (nivel == 0) { DesabilitaComp(); } else if (nivel == 1) { DesabilitaComp(); };
        }

        private void DesabilitaComp()
        {
            mntransacoes.Visible = false;
            mnrelatorio.Visible = false;
            mninicio.Visible = false;
            mnclientes.Visible = false;
        }

        private void mninicio_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente cadastrarUser = new FormCadastrarCliente();
            cadastrarUser.NomeGB("Cadastrar Usuário");
            cadastrarUser.BotaoConfirmar(1);
            cadastrarUser.Show();
        }

           
    }
}
