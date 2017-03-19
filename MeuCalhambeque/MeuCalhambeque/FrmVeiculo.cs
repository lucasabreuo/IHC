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
    public partial class FrmVeiculo : Form
    {
        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            txbPlaca.Select(); //Coloca o cursor automaticamente no campo do cadastro
        }

        private void lblCapacidadeM3_Click(object sender, EventArgs e)
        {

        }

        private void txbRenavam_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txbRenavam_TextChanged(object sender, EventArgs e)
        {

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
    }
}
