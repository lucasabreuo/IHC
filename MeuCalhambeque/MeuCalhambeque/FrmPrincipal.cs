using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuCalhambeque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Teclas de atalho para acessar os cadastros
            veiculosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            despesasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            gastoMensalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;            
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeiculo cadastrarVeiculo = new FrmVeiculo();
            cadastrarVeiculo.ShowDialog();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gastoMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            //Navega até a página de suporte 
            System.Diagnostics.Process.Start("https://pt.surveymonkey.com/r/JJVTQV5");
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair do sistema?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(0);
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    toolStripHelp_Click(sender, e);
                    break;
                case Keys.F4:
                    toolStripSair_Click(sender, e);
                    break;
            }
        }

        private void FrmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Do not implements code.                  
        }
    }
}
