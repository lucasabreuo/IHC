namespace MeuCalhambeque
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripCadastros = new System.Windows.Forms.ToolStripDropDownButton();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastoMensalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSobre = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastros,
            this.toolStripRelatorios,
            this.toolStripHelp,
            this.toolStripSobre,
            this.toolStripSair});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(885, 32);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripCadastros
            // 
            this.toolStripCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.gastoMensalToolStripMenuItem});
            this.toolStripCadastros.Image = global::MeuCalhambeque.Properties.Resources.favicon__2_;
            this.toolStripCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCadastros.Name = "toolStripCadastros";
            this.toolStripCadastros.Size = new System.Drawing.Size(133, 29);
            this.toolStripCadastros.Text = "Cadastros";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.volante;
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.despesas;
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.despesasToolStripMenuItem.Text = "Despesas";
            // 
            // gastoMensalToolStripMenuItem
            // 
            this.gastoMensalToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.gastoMensal;
            this.gastoMensalToolStripMenuItem.Name = "gastoMensalToolStripMenuItem";
            this.gastoMensalToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.gastoMensalToolStripMenuItem.Text = "Gasto Mensal";
            // 
            // toolStripRelatorios
            // 
            this.toolStripRelatorios.Image = global::MeuCalhambeque.Properties.Resources.Relatorio;
            this.toolStripRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRelatorios.Name = "toolStripRelatorios";
            this.toolStripRelatorios.ShowDropDownArrow = false;
            this.toolStripRelatorios.Size = new System.Drawing.Size(118, 29);
            this.toolStripRelatorios.Text = "Relatórios";
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Image = global::MeuCalhambeque.Properties.Resources.help;
            this.toolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.ShowDropDownArrow = false;
            this.toolStripHelp.Size = new System.Drawing.Size(77, 29);
            this.toolStripHelp.Text = "Help";
            // 
            // toolStripSobre
            // 
            this.toolStripSobre.Image = global::MeuCalhambeque.Properties.Resources.icone_informacao;
            this.toolStripSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSobre.Name = "toolStripSobre";
            this.toolStripSobre.ShowDropDownArrow = false;
            this.toolStripSobre.Size = new System.Drawing.Size(87, 29);
            this.toolStripSobre.Text = "Sobre";
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::MeuCalhambeque.Properties.Resources.system_close_16;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.ShowDropDownArrow = false;
            this.toolStripSair.Size = new System.Drawing.Size(69, 29);
            this.toolStripSair.Text = "Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 315);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Calhambeque - Sistema de Controle de Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripCadastros;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRelatorios;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastoMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripHelp;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSobre;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSair;
    }
}

