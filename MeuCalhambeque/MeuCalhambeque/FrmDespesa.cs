﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidade;
using System.IO;
using ArquivoDeTexto;

namespace MeuCalhambeque
{
    public partial class FrmDespesa : Form, ICaminhoDoArquivo
    {
        private string Caminho = Directory.GetCurrentDirectory(); //diretorio corrente do aplicativo
        private string _diretorioArquivo { get { return CaminhoArquivo(); } }
        private List<Veiculo> _listVeiculos = new List<Veiculo>();

        public FrmDespesa()
        {
            InitializeComponent();
        }

        #region Define o background ao entrar e sair dos campos
        private void txbDataCombustivel_Enter(object sender, EventArgs e)
        {
            dtDataAbastecimento.BackColor = Color.White;
        }

        private void txbDataCombustivel_Leave(object sender, EventArgs e)
        {
            if (dtDataAbastecimento.Text == "  /  /")
            {
                dtDataAbastecimento.BackColor = Color.Salmon;
            }
        }

        private void txbValorTotCombustivel_Enter(object sender, EventArgs e)
        {
            //Do not implements code            
        }

        private void txbValorTotCombustivel_Leave(object sender, EventArgs e)
        {
            //Do not implements code
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

        #region Eventos ao Clicar no Mouse
        private void btnOkCombustivel_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelarCombustivel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            cbxVeiculoComb.Select();
        }
        #endregion

        #region Métodos Auxiliares        
        public void CapturaDadosCombustivel()
        {
            //A ser implementado           
        }

        private void CalcularVlrTotal(object sender, EventArgs e)
        {
            if (txbValorUniCombustivel.Text != "" && txbQuantidadeCombustivel.Text != "")
                lblVlrTotalCombustivel.Text = (float.Parse(txbValorUniCombustivel.Text) * float.Parse(txbQuantidadeCombustivel.Text)).ToString();
            else
                lblVlrTotalCombustivel.Text = "0,00";
        }

        public string CaminhoArquivo()
        {
            return Path.Combine(Caminho, this.ToString() + ".txt");
        }

        private void LerArquivo()
        {
            string[] array = File.ReadAllLines(Caminho);

            for (int i = 0; i < array.Length; i++)
            {
                Veiculo veic = new Veiculo();

                string[] auxiliar = array[i].Split('|');

                veic.Modelo = auxiliar[4];
                veic.Placa = auxiliar[0];

                _listVeiculos.Add(veic);
            }
        }
        #endregion

        #region Código Automático
        private void lblVlrTotalCombustivel_TextChanged(object sender, EventArgs e)
        {
            //Do not implements code           
        }

        private void label5_Enter(object sender, EventArgs e)
        {
            //Do not implements code
        }

        private void txbValorTotCombustivel_TextChanged(object sender, EventArgs e)
        {
            //Do not implements code
        }

        private void tabCombustivel_Click(object sender, EventArgs e)
        {
            //Do not implements code
        }
        #endregion

        #region Eventos KeyPress
        private void txbValorUniCombustivel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbQuantidadeCombustivel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmDespesa_Load(object sender, EventArgs e)
        {
            LerArquivo();

            foreach (var item in _listVeiculos)
            {
                cbxVeiculoComb.Items.Add(item.Modelo);
            }
        }
    }
}
