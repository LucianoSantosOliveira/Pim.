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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            //usuario.Login = txtusuario.Text;
            //usuario.Senha = txtsenha.Text;

            usuario.VerificaLogin(txtusuario.Text);
            usuario.VerificaSenha(txtsenha.Text);

            FormInicial formInicial = new FormInicial();
            if(checkBox1.Checked == true)
            {

            }else
            {
                txtsenha.Text = "";
                txtusuario.Text = "";
            }
            
            if(String.IsNullOrEmpty(usuario.Login) || String.IsNullOrEmpty(usuario.Senha)) { MessageBox.Show("Usuario ou senha errado"); }
            else { formInicial.Show(); MessageBox.Show(usuario.Login + " " + usuario.Senha); }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 197, 162);
            BTNsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNsair.FlatAppearance.BorderSize = 0;
            BTNsair.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 197, 150);
            BTNsair.BackColor = Color.Transparent;

        }

        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
