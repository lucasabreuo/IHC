using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidade;

namespace MeuCalhambeque
{
    public partial class FrmDespesa : Form
    {
        public FrmDespesa()
        {
            InitializeComponent();
        }

        private void tabCombustivel_Click(object sender, EventArgs e)
        {

        }

        #region Define o background ao entrar e sair dos campos
        private void txbDataCombustivel_Enter(object sender, EventArgs e)
        {
            txbDataCombustivel.BackColor = Color.White;
        }

        private void txbDataCombustivel_Leave(object sender, EventArgs e)
        {
            if (txbDataCombustivel.Text == "  /  /")
            {
                txbDataCombustivel.BackColor = Color.Salmon;
            }
        }

        private void txbValorTotCombustivel_Enter(object sender, EventArgs e)
        {
            txbValorTotCombustivel.BackColor = Color.White;
        }

        private void txbValorTotCombustivel_Leave(object sender, EventArgs e)
        {
            if (txbValorTotCombustivel.Text == "")
            {
                txbValorTotCombustivel.BackColor = Color.Salmon;
            }
        }

        private void txbQuantidadeCombustivel_Enter(object sender, EventArgs e)
        {
            txbQuantidadeCombustivel.BackColor = Color.White;
        }

        private void txbQuantidadeCombustivel_Leave(object sender, EventArgs e)
        {
            if (txbQuantidadeCombustivel.Text == "")
            {
                txbQuantidadeCombustivel.BackColor = Color.Salmon;
            }
        }

        private void txbValorUniCombustivel_Enter(object sender, EventArgs e)
        {
            txbValorUniCombustivel.BackColor = Color.White;
        }

        private void txbValorUniCombustivel_Leave(object sender, EventArgs e)
        {
            if (txbValorUniCombustivel.Text == "")
            {
                txbValorUniCombustivel.BackColor = Color.Salmon;
            }
        }
        #endregion

        private void label5_Enter(object sender, EventArgs e)
        {

        }

        private void txbValorTotCombustivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkCombustivel_Click(object sender, EventArgs e)
        {

        }

        #region Métodos Auxiliares        
        public void CapturaDadosCombustivel()
        {
            /*Combustivel comb = new Combustivel();
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
            veic.SalvarVeiculo();*/
        }
        #endregion
    }
}
