namespace Banco
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasnfênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.adminstradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasnfênciaToolStripMenuItem,
            this.saqueToolStripMenuItem,
            this.depósitoToolStripMenuItem,
            this.empréstimoToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // trasnfênciaToolStripMenuItem
            // 
            this.trasnfênciaToolStripMenuItem.Name = "trasnfênciaToolStripMenuItem";
            this.trasnfênciaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.trasnfênciaToolStripMenuItem.Text = "Transferência";
            this.trasnfênciaToolStripMenuItem.Click += new System.EventHandler(this.trasnfênciaToolStripMenuItem_Click);
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saqueToolStripMenuItem.Text = "Saque";
            this.saqueToolStripMenuItem.Click += new System.EventHandler(this.saqueToolStripMenuItem_Click);
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            this.depósitoToolStripMenuItem.Click += new System.EventHandler(this.depósitoToolStripMenuItem_Click);
            // 
            // empréstimoToolStripMenuItem
            // 
            this.empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            this.empréstimoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.empréstimoToolStripMenuItem.Text = "Empréstimo";
            this.empréstimoToolStripMenuItem.Click += new System.EventHandler(this.empréstimoToolStripMenuItem_Click);
            // 
            // adminstradorToolStripMenuItem
            // 
            this.adminstradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.adminstradorToolStripMenuItem.Name = "adminstradorToolStripMenuItem";
            this.adminstradorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.adminstradorToolStripMenuItem.Text = "Adminstrador";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(623, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "v.1.0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.gruprX.com.br";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.ícones_para_o_sistema_bancário_112097565__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Rex Bank";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasnfênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminstradorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

