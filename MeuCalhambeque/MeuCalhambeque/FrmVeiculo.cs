using System;
using System.Linq;
using System.Windows.Forms;
using Entidade;

namespace MeuCalhambeque
{
    public partial class FrmVeiculo : Form
    {
        #region Variáveis
        //Lista de Enumeração
        StatusCadastro sStatus;
        #endregion

        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {            
            sStatus = StatusCadastro.scBrowser;
            limpaControles(this);
            habilitaDesabilitaControles(false);
            //Habilita somente os controle necessário no load do formulário
            btnCancelar.Enabled = true;
        }

        #region Eventos ao Clicar no Mouse
        private void lblCapacidadeM3_Click(object sender, EventArgs e)
        {
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scInsert;
            limpaControles(this);
            habilitaDesabilitaControles(true);            
            txbPlaca.Select(); //Coloca o cursor automaticamente no campo do cadastro
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = StatusCadastro.scBrowser;
                habilitaDesabilitaControles(false);                
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaControles(this);
                btnCancelar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            txbPlaca.Select();            
        }

        private void toolStripLimpar_Click(object sender, EventArgs e)
        {
            limpaControles(this);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                CapturaDadosVeiculo();
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Objetos estão com valores nulos!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                if (txbPlaca.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: Placa do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cbxUF.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: UF do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txbModelo.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: Modelo do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Valores preenchidos maiores que os suportados!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }       
                   
        public bool Salvar()
        {
            try
            {
                CapturaDadosVeiculo();
                return true;
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Objetos estão com valores nulos!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch (FormatException)
            {
                if (txbPlaca.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: Placa do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (cbxUF.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: UF do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (txbModelo.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido: Modelo do Veículo!", "Veículos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;

            }
            catch (OverflowException)
            {
                MessageBox.Show("Valores preenchidos maiores que os suportados!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        #endregion

        #region Eventos TextChanged
        private void txbRenavam_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Eventos KeyPress
        private void txbRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txbTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txb = (TextBox)sender;

            //Validação para permitir somente números e vírgulas.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                    e.Handled = (txb.Text.Contains(','));
                else
                    e.Handled = true;
            }
        }

        private void txbAnoFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txbAnoModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txbAntt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txbCapacidadeKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txb = (TextBox)sender;

            //Validação para permitir somente números e vírgulas.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                    e.Handled = (txb.Text.Contains(','));
                else
                    e.Handled = true;
            }
        }

        private void txbCapacidadeM3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txb = (TextBox)sender;

            //Validação para permitir somente números e vírgulas.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                    e.Handled = (txb.Text.Contains(','));
                else
                    e.Handled = true;
            }
        }
        #endregion

        #region Métodos para Controlar o Comportamento do Forms
        /// <summary>
        /// Limpa os componentes após a inserção ou atualização de dados.
        /// </summary>
        protected void limpaControles(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox)
                    ctl.Text = "";

                if (ctl is RichTextBox)
                    ctl.Text = "";

                if (ctl is ComboBox)
                    ctl.Text = "";

                txbPlaca.Focus();

                if (ctl.HasChildren)
                    limpaControles(ctl);
            }
            cbxUF.SelectedIndex = -1;
            cbxTipoPropVeiculo.SelectedIndex = -1;
            cbxTipoVeiculo.SelectedIndex = -1;
            cbxTipoRodado.SelectedIndex = -1;
            cbxTipoCarroceria.SelectedIndex = -1;
        }

        /// <summary>
        /// Indica quando os controles da tela podem fica disponíveis para o usuário.
        /// </summary>
        /// <param name="value">Valor: true or false</param>
        private void habilitaDesabilitaControles(bool value)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ToolStrip)
                    continue;                              

                ctl.Enabled = value;
            }
            //Habilitado quando estivermos inserindo, somente navegando.
            toolStripIncluir.Enabled = (sStatus == StatusCadastro.scBrowser);
            //Habilitado quando estivermos inserindo.
            toolStripSalvar.Enabled = (sStatus == StatusCadastro.scInsert);
            toolStripExcluir.Enabled = (sStatus == StatusCadastro.scInsert);
            toolStripLimpar.Enabled = (sStatus == StatusCadastro.scInsert);
        }

        /// <summary>
        /// Lista de Enumerador.
        /// </summary>
        /// <remarks>
        /// scInsert = Quando estivermos salvando os dados.
        /// scBrowser = Quando estivermos navegando, inserindo dados. 
        /// </remarks>
        public enum StatusCadastro
        {
            scInsert, scBrowser
        }     
        #endregion

        #region Métodos Auxiliares        
        public void CapturaDadosVeiculo()
        {
            Veiculo veic = new Veiculo();
            veic.Placa = txbPlaca.Text;
            veic.UF = cbxUF.Text;
            veic.CertificadoPropriedade = txbCertificado.Text;
            veic.Marca = txbMarca.Text;
            veic.Modelo = txbModelo.Text;
            veic.Renavam = int.Parse(txbRenavam.Text);
            veic.Tara = float.Parse(txbTara.Text);
            veic.AnoFabricacao = int.Parse(txbAnoFabricacao.Text);
            veic.AnoModelo = int.Parse(txbAnoModelo.Text);
            veic.Antt = long.Parse(txbAntt.Text);
            veic.CapacidadeKg = float.Parse(txbCapacidadeKg.Text);
            veic.CapacidadeM3 = float.Parse(txbCapacidadeM3.Text);
            veic.TipoPropVeiculo = cbxTipoPropVeiculo.Text;
            veic.TipoVeiculo = cbxTipoVeiculo.Text;
            veic.TipoRodado = cbxTipoRodado.Text;
            veic.TipoCarroceria = cbxTipoRodado.Text;
            veic.NomePropVeiculo = txbProprietario.Text;

            veic.ListaVeiculo.Add(veic);
            veic.SalvarVeiculo();
        }
        #endregion

        #region Define o background ao entrar e sair dos campos
        private void txbPlaca_Enter(object sender, EventArgs e)
        {
            txbPlaca.BackColor = System.Drawing.Color.White;
        }

        private void txbPlaca_Leave(object sender, EventArgs e)
        {
            if(txbPlaca.Text == "")
                txbPlaca.BackColor = System.Drawing.Color.Salmon;
            else
                txbPlaca.BackColor = System.Drawing.Color.White;
        }

        private void cbxUF_Enter(object sender, EventArgs e)
        {
            cbxUF.BackColor = System.Drawing.Color.White;
        }

        private void cbxUF_Leave(object sender, EventArgs e)
        {
            if (cbxUF.Text == "")
                cbxUF.BackColor = System.Drawing.Color.Salmon;
            else
                cbxUF.BackColor = System.Drawing.Color.White;
        }

        private void txbModelo_Enter(object sender, EventArgs e)
        {
            txbModelo.BackColor = System.Drawing.Color.White;
        }

        private void txbModelo_Leave(object sender, EventArgs e)
        {
            if (txbModelo.Text == "")
                txbModelo.BackColor = System.Drawing.Color.Salmon;
            else
                txbModelo.BackColor = System.Drawing.Color.White;
        }
        #endregion

        private void FrmVeiculo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    toolStripIncluir_Click(sender, e);
                    break;
                case Keys.F2:
                    toolStripSalvar_Click(sender, e);
                    break;
                case Keys.F3:
                    toolStripLimpar_Click(sender, e);
                    break;                   
            }
        }
    }
}
