﻿using System;
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
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(0, 197, 162);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblendereco_Click(object sender, EventArgs e)
        {

        }

        private void lblsexo_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormCadastrarCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 197, 162);
            this.StartPosition = FormStartPosition.CenterScreen;
            //button1.Visible = false;
            
        }

        private void lblestadocivil_Click(object sender, EventArgs e)
        {

        }

        private void lbltelefone_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            ConectaSQL conectaSQL = new ConectaSQL();
            Cliente cliente = new Cliente();

            cliente.contrutorCliente();
            cliente.setNome(txtnome.Text);
            cliente.setEmail(txtemail.Text);
            cliente.setTelefone(msktelefone.Text);
            cliente.setCpf(mskcpf.Text);
            cliente.Inserir();

            Close();
        }
        public void NomeGB(string nome)
        {
            groupBox1.Text = nome;
            BTNConfirmar.Visible = false;
            button1.Visible = true;
        }

        public void BotaoConfirmar(int user)
        {
            if (user == 1) { BTNConfirmar.Visible = false; button1.Visible = true; }
            else { button1.Visible = false; BTNConfirmar.Visible = true; }
        }
     
    }
}
