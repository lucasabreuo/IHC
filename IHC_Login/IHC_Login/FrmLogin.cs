using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHC_Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region Componentes
            //Define a disposição geral dos componentes da tela de login            
            txbUsuario.Select(); //Posiciona o cursor no textbox do usuário
            lblFacaOLogin.BackColor = Color.Transparent; //Define a cor do label como transparente
            lblUsuario.BackColor = Color.Transparent;
            lblSenha.BackColor = Color.Transparent;
            picBoxLogin2.BackColor = Color.Transparent;
            lblCopyright.BackColor = Color.Transparent;
            picBoxSuporte.BackColor = Color.Transparent;
            lblSuporte.BackColor = Color.Transparent;
            lblFacaOLogin.Location = new Point(35, 40); //Seta a posição da label em relação à pictureBox
            lblUsuario.Location = new Point(35, 80);            
            txbUsuario.Location = new Point(39, 100); //Seta a posição do textBox em relação à pictureBox
            lblSenha.Location = new Point(35, 130);
            txbSenha.Location = new Point(39, 150);
            btnEntrar.Location = new Point(35, 200); //Seta a posição do botão em relação à pictureBox
            btnCancelar.Location = new Point(75, 200);
            picBoxLogin2.Location = new Point(430, 30);
            btnCancelar.Left = btnEntrar.Right + 15;
            picBoxLogin1.Controls.Add(lblFacaOLogin); //Adiciona a label em cima da pictureBox
            picBoxLogin1.Controls.Add(lblUsuario);
            picBoxLogin1.Controls.Add(txbUsuario); //Adiciona o textBox em cima da pictureBox
            picBoxLogin1.Controls.Add(lblSenha);
            picBoxLogin1.Controls.Add(txbSenha);
            picBoxLogin1.Controls.Add(btnEntrar);
            picBoxLogin1.Controls.Add(btnCancelar);
            picBoxLogin1.Controls.Add(picBoxLogin2);
            picBoxLogin.Controls.Add(lblCopyright);
            picBoxLogin.Controls.Add(picBoxSuporte);
            picBoxLogin.Controls.Add(lblSuporte);
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lblSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Navega até a página de suporte 
            System.Diagnostics.Process.Start("https://pt.surveymonkey.com/r/JJVTQV5");
        }

        private void picBoxSuporte_Click(object sender, EventArgs e)
        {
            //Navega até a página de suporte 
            System.Diagnostics.Process.Start("https://pt.surveymonkey.com/r/JJVTQV5");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha a tela de login            
        }
    }
}
