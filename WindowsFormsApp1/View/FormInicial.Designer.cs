namespace WindowsFormsApp1
{
    partial class FormInicial
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
            System.Windows.Forms.ToolStripMenuItem mnbackup;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.atualizarDadosSalvosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuprincipal = new System.Windows.Forms.MenuStrip();
            this.mninicio = new System.Windows.Forms.ToolStripMenuItem();
            this.mntransacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnclientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.BTNsair = new System.Windows.Forms.Button();
            this.LBnomeUsuario = new System.Windows.Forms.Label();
            this.PBuser = new System.Windows.Forms.PictureBox();
            mnbackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuprincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBuser)).BeginInit();
            this.SuspendLayout();
            // 
            // mnbackup
            // 
            mnbackup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarDadosSalvosToolStripMenuItem,
            this.restaurarDadosToolStripMenuItem});
            mnbackup.Name = "mnbackup";
            mnbackup.Size = new System.Drawing.Size(85, 29);
            mnbackup.Text = "Backup";
            mnbackup.Click += new System.EventHandler(this.mnbackup_Click);
            // 
            // atualizarDadosSalvosToolStripMenuItem
            // 
            this.atualizarDadosSalvosToolStripMenuItem.Name = "atualizarDadosSalvosToolStripMenuItem";
            this.atualizarDadosSalvosToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.atualizarDadosSalvosToolStripMenuItem.Text = "Atualizar dados salvos";
            // 
            // restaurarDadosToolStripMenuItem
            // 
            this.restaurarDadosToolStripMenuItem.Name = "restaurarDadosToolStripMenuItem";
            this.restaurarDadosToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.restaurarDadosToolStripMenuItem.Text = "Restaurar dados";
            // 
            // menuprincipal
            // 
            this.menuprincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuprincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mninicio,
            this.mntransacoes,
            this.mnclientes,
            mnbackup,
            this.mnrelatorio,
            this.cadastrarNovoUsuárioToolStripMenuItem});
            this.menuprincipal.Location = new System.Drawing.Point(0, 0);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Size = new System.Drawing.Size(1200, 33);
            this.menuprincipal.TabIndex = 0;
            this.menuprincipal.Text = "menuStrip1";
            // 
            // mninicio
            // 
            this.mninicio.Name = "mninicio";
            this.mninicio.Size = new System.Drawing.Size(70, 29);
            this.mninicio.Text = "Inicio";
            this.mninicio.Click += new System.EventHandler(this.mninicio_Click);
            // 
            // mntransacoes
            // 
            this.mntransacoes.Name = "mntransacoes";
            this.mntransacoes.Size = new System.Drawing.Size(113, 29);
            this.mntransacoes.Text = "Transações";
            this.mntransacoes.Click += new System.EventHandler(this.mntransacoes_Click);
            // 
            // mnclientes
            // 
            this.mnclientes.Name = "mnclientes";
            this.mnclientes.Size = new System.Drawing.Size(89, 29);
            this.mnclientes.Text = "Clientes";
            this.mnclientes.Click += new System.EventHandler(this.mnclientes_Click);
            // 
            // mnrelatorio
            // 
            this.mnrelatorio.Name = "mnrelatorio";
            this.mnrelatorio.Size = new System.Drawing.Size(98, 29);
            this.mnrelatorio.Text = "Relatório";
            this.mnrelatorio.Click += new System.EventHandler(this.mnrelatorio_Click);
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(212, 29);
            this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar novo usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.PBLogo);
            this.groupBox2.Controls.Add(this.BTNsair);
            this.groupBox2.Controls.Add(this.LBnomeUsuario);
            this.groupBox2.Controls.Add(this.PBuser);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 659);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // PBLogo
            // 
            this.PBLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.BackgroundImage")));
            this.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBLogo.Location = new System.Drawing.Point(340, 234);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(430, 198);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBLogo.TabIndex = 5;
            this.PBLogo.TabStop = false;
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
            this.BTNsair.Location = new System.Drawing.Point(1075, 23);
            this.BTNsair.Name = "BTNsair";
            this.BTNsair.Size = new System.Drawing.Size(43, 38);
            this.BTNsair.TabIndex = 4;
            this.BTNsair.UseVisualStyleBackColor = false;
            this.BTNsair.Click += new System.EventHandler(this.BTNsair_Click);
            // 
            // LBnomeUsuario
            // 
            this.LBnomeUsuario.AutoSize = true;
            this.LBnomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBnomeUsuario.Location = new System.Drawing.Point(1124, 92);
            this.LBnomeUsuario.Name = "LBnomeUsuario";
            this.LBnomeUsuario.Size = new System.Drawing.Size(57, 22);
            this.LBnomeUsuario.TabIndex = 3;
            this.LBnomeUsuario.Text = "Nome ";
            // 
            // PBuser
            // 
            this.PBuser.BackColor = System.Drawing.Color.Transparent;
            this.PBuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBuser.BackgroundImage")));
            this.PBuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBuser.Location = new System.Drawing.Point(1124, 25);
            this.PBuser.Name = "PBuser";
            this.PBuser.Size = new System.Drawing.Size(64, 64);
            this.PBuser.TabIndex = 2;
            this.PBuser.TabStop = false;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuprincipal);
            this.MainMenuStrip = this.menuprincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "$ BLOCK MONEY $";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuprincipal.ResumeLayout(false);
            this.menuprincipal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuprincipal;
        private System.Windows.Forms.ToolStripMenuItem mninicio;
        private System.Windows.Forms.ToolStripMenuItem mnclientes;
        private System.Windows.Forms.ToolStripMenuItem mntransacoes;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosSalvosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnrelatorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.Button BTNsair;
        private System.Windows.Forms.Label LBnomeUsuario;
        private System.Windows.Forms.PictureBox PBuser;
        private System.Windows.Forms.PictureBox PBLogo;
    }
}