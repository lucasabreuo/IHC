﻿namespace MeuCalhambeque
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
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.veiculosToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.gastoMensalToolStripMenuItem});
            this.toolStripCadastros.Image = global::MeuCalhambeque.Properties.Resources.favicon__2_;
            this.toolStripCadastros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCadastros.Name = "toolStripCadastros";
            this.toolStripCadastros.Size = new System.Drawing.Size(125, 29);
            this.toolStripCadastros.Text = "&Cadastros";
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.volante1;
            this.veiculosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.veiculosToolStripMenuItem.Text = "Veículos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.despesas__1_;
            this.despesasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.despesasToolStripMenuItem_Click);
            // 
            // gastoMensalToolStripMenuItem
            // 
            this.gastoMensalToolStripMenuItem.Image = global::MeuCalhambeque.Properties.Resources.gastoMensal;
            this.gastoMensalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gastoMensalToolStripMenuItem.Name = "gastoMensalToolStripMenuItem";
            this.gastoMensalToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.gastoMensalToolStripMenuItem.Text = "Gasto Mensal";
            this.gastoMensalToolStripMenuItem.Click += new System.EventHandler(this.gastoMensalToolStripMenuItem_Click);
            // 
            // toolStripRelatorios
            // 
            this.toolStripRelatorios.Image = global::MeuCalhambeque.Properties.Resources.Relatorio;
            this.toolStripRelatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRelatorios.Name = "toolStripRelatorios";
            this.toolStripRelatorios.ShowDropDownArrow = false;
            this.toolStripRelatorios.Size = new System.Drawing.Size(110, 29);
            this.toolStripRelatorios.Text = "Relatórios";
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Image = global::MeuCalhambeque.Properties.Resources.help;
            this.toolStripHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.ShowDropDownArrow = false;
            this.toolStripHelp.Size = new System.Drawing.Size(69, 29);
            this.toolStripHelp.Text = "Help";
            this.toolStripHelp.ToolTipText = "Help (F1)";
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // toolStripSobre
            // 
            this.toolStripSobre.Image = global::MeuCalhambeque.Properties.Resources.icone_informacao;
            this.toolStripSobre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSobre.Name = "toolStripSobre";
            this.toolStripSobre.ShowDropDownArrow = false;
            this.toolStripSobre.Size = new System.Drawing.Size(79, 29);
            this.toolStripSobre.Text = "Sobre";
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::MeuCalhambeque.Properties.Resources.system_close_16;
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.ShowDropDownArrow = false;
            this.toolStripSair.Size = new System.Drawing.Size(61, 29);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.ToolTipText = "Sair (F4)";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 315);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Calhambeque - Sistema de Controle de Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPrincipal_KeyPress);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripCadastros;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRelatorios;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastoMensalToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripHelp;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSobre;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSair;
    }
}

