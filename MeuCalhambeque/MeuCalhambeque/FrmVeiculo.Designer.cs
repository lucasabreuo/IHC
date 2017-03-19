namespace MeuCalhambeque
{
    partial class FrmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
            this.toolStripDropIncluir = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripLimpar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripCadastroVeiculo = new System.Windows.Forms.ToolStrip();
            this.tabPageIdentificacao = new System.Windows.Forms.TabPage();
            this.txbProprietario = new System.Windows.Forms.TextBox();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.cbxTipoCarroceria = new System.Windows.Forms.ComboBox();
            this.lblTipoCarroceria = new System.Windows.Forms.Label();
            this.cbxTipoRodado = new System.Windows.Forms.ComboBox();
            this.lblTipoRodado = new System.Windows.Forms.Label();
            this.cbxTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.cbxTipoPropVeiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoPropVeiculo = new System.Windows.Forms.Label();
            this.txbCapacidadeM3 = new System.Windows.Forms.TextBox();
            this.txbCapacidadeKg = new System.Windows.Forms.TextBox();
            this.lblCapacidadeM3 = new System.Windows.Forms.Label();
            this.lblCapacidadeKg = new System.Windows.Forms.Label();
            this.txbAntt = new System.Windows.Forms.TextBox();
            this.lblAntt = new System.Windows.Forms.Label();
            this.txbAnoModelo = new System.Windows.Forms.TextBox();
            this.txbAnoFabricacao = new System.Windows.Forms.TextBox();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.txbTara = new System.Windows.Forms.TextBox();
            this.txbRenavam = new System.Windows.Forms.TextBox();
            this.lblTara = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbCertificado = new System.Windows.Forms.TextBox();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tabControlIdentificacao = new System.Windows.Forms.TabControl();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStripCadastroVeiculo.SuspendLayout();
            this.tabPageIdentificacao.SuspendLayout();
            this.tabControlIdentificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropIncluir
            // 
            this.toolStripDropIncluir.Image = global::MeuCalhambeque.Properties.Resources.add;
            this.toolStripDropIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropIncluir.Name = "toolStripDropIncluir";
            this.toolStripDropIncluir.ShowDropDownArrow = false;
            this.toolStripDropIncluir.Size = new System.Drawing.Size(87, 29);
            this.toolStripDropIncluir.Text = "Incluir";
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Image = global::MeuCalhambeque.Properties.Resources.btnDelete;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.ShowDropDownArrow = false;
            this.toolStripExcluir.Size = new System.Drawing.Size(89, 29);
            this.toolStripExcluir.Text = "Excluir";
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.Image = global::MeuCalhambeque.Properties.Resources.btnSave;
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.ShowDropDownArrow = false;
            this.toolStripSalvar.Size = new System.Drawing.Size(87, 29);
            this.toolStripSalvar.Text = "Salvar";
            // 
            // toolStripLimpar
            // 
            this.toolStripLimpar.Image = global::MeuCalhambeque.Properties.Resources.clear;
            this.toolStripLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLimpar.Name = "toolStripLimpar";
            this.toolStripLimpar.ShowDropDownArrow = false;
            this.toolStripLimpar.Size = new System.Drawing.Size(94, 29);
            this.toolStripLimpar.Text = "Limpar";
            // 
            // toolStripCadastroVeiculo
            // 
            this.toolStripCadastroVeiculo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripCadastroVeiculo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropIncluir,
            this.toolStripExcluir,
            this.toolStripSalvar,
            this.toolStripLimpar});
            this.toolStripCadastroVeiculo.Location = new System.Drawing.Point(0, 0);
            this.toolStripCadastroVeiculo.Name = "toolStripCadastroVeiculo";
            this.toolStripCadastroVeiculo.Size = new System.Drawing.Size(802, 32);
            this.toolStripCadastroVeiculo.TabIndex = 0;
            this.toolStripCadastroVeiculo.Text = "toolStrip1";
            // 
            // tabPageIdentificacao
            // 
            this.tabPageIdentificacao.Controls.Add(this.txbProprietario);
            this.tabPageIdentificacao.Controls.Add(this.lblProprietario);
            this.tabPageIdentificacao.Controls.Add(this.cbxTipoCarroceria);
            this.tabPageIdentificacao.Controls.Add(this.lblTipoCarroceria);
            this.tabPageIdentificacao.Controls.Add(this.cbxTipoRodado);
            this.tabPageIdentificacao.Controls.Add(this.lblTipoRodado);
            this.tabPageIdentificacao.Controls.Add(this.cbxTipoVeiculo);
            this.tabPageIdentificacao.Controls.Add(this.lblTipoVeiculo);
            this.tabPageIdentificacao.Controls.Add(this.cbxTipoPropVeiculo);
            this.tabPageIdentificacao.Controls.Add(this.lblTipoPropVeiculo);
            this.tabPageIdentificacao.Controls.Add(this.txbCapacidadeM3);
            this.tabPageIdentificacao.Controls.Add(this.txbCapacidadeKg);
            this.tabPageIdentificacao.Controls.Add(this.lblCapacidadeM3);
            this.tabPageIdentificacao.Controls.Add(this.lblCapacidadeKg);
            this.tabPageIdentificacao.Controls.Add(this.txbAntt);
            this.tabPageIdentificacao.Controls.Add(this.lblAntt);
            this.tabPageIdentificacao.Controls.Add(this.txbAnoModelo);
            this.tabPageIdentificacao.Controls.Add(this.txbAnoFabricacao);
            this.tabPageIdentificacao.Controls.Add(this.lblAnoModelo);
            this.tabPageIdentificacao.Controls.Add(this.lblAnoFabricacao);
            this.tabPageIdentificacao.Controls.Add(this.txbTara);
            this.tabPageIdentificacao.Controls.Add(this.txbRenavam);
            this.tabPageIdentificacao.Controls.Add(this.lblTara);
            this.tabPageIdentificacao.Controls.Add(this.lblRenavam);
            this.tabPageIdentificacao.Controls.Add(this.txbModelo);
            this.tabPageIdentificacao.Controls.Add(this.lblModelo);
            this.tabPageIdentificacao.Controls.Add(this.txbMarca);
            this.tabPageIdentificacao.Controls.Add(this.lblMarca);
            this.tabPageIdentificacao.Controls.Add(this.txbCertificado);
            this.tabPageIdentificacao.Controls.Add(this.lblCertificado);
            this.tabPageIdentificacao.Controls.Add(this.cbxUF);
            this.tabPageIdentificacao.Controls.Add(this.lblUF);
            this.tabPageIdentificacao.Controls.Add(this.txbPlaca);
            this.tabPageIdentificacao.Controls.Add(this.lblPlaca);
            this.tabPageIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageIdentificacao.Location = new System.Drawing.Point(4, 29);
            this.tabPageIdentificacao.Name = "tabPageIdentificacao";
            this.tabPageIdentificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdentificacao.Size = new System.Drawing.Size(781, 450);
            this.tabPageIdentificacao.TabIndex = 0;
            this.tabPageIdentificacao.Text = "Identificação";
            this.tabPageIdentificacao.UseVisualStyleBackColor = true;
            // 
            // txbProprietario
            // 
            this.txbProprietario.Location = new System.Drawing.Point(20, 393);
            this.txbProprietario.Name = "txbProprietario";
            this.txbProprietario.Size = new System.Drawing.Size(420, 28);
            this.txbProprietario.TabIndex = 33;
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietario.Location = new System.Drawing.Point(16, 368);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(199, 22);
            this.lblProprietario.TabIndex = 32;
            this.lblProprietario.Text = "Nome do Prop. Veículo:";
            // 
            // cbxTipoCarroceria
            // 
            this.cbxTipoCarroceria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCarroceria.FormattingEnabled = true;
            this.cbxTipoCarroceria.Items.AddRange(new object[] {
            "Não Aplicável",
            "Aberta",
            "Fechada/Baú",
            "Granalera",
            "Porta Container",
            "Sider"});
            this.cbxTipoCarroceria.Location = new System.Drawing.Point(587, 319);
            this.cbxTipoCarroceria.Name = "cbxTipoCarroceria";
            this.cbxTipoCarroceria.Size = new System.Drawing.Size(162, 30);
            this.cbxTipoCarroceria.TabIndex = 31;
            // 
            // lblTipoCarroceria
            // 
            this.lblTipoCarroceria.AutoSize = true;
            this.lblTipoCarroceria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCarroceria.Location = new System.Drawing.Point(583, 294);
            this.lblTipoCarroceria.Name = "lblTipoCarroceria";
            this.lblTipoCarroceria.Size = new System.Drawing.Size(165, 22);
            this.lblTipoCarroceria.TabIndex = 30;
            this.lblTipoCarroceria.Text = "Tipo de Carroceria:";
            // 
            // cbxTipoRodado
            // 
            this.cbxTipoRodado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRodado.FormattingEnabled = true;
            this.cbxTipoRodado.Items.AddRange(new object[] {
            "Não Aplicável",
            "Truck",
            "Toco",
            "Cavalo Mecânico",
            "VAN",
            "Utilitário",
            "Outros"});
            this.cbxTipoRodado.Location = new System.Drawing.Point(392, 319);
            this.cbxTipoRodado.Name = "cbxTipoRodado";
            this.cbxTipoRodado.Size = new System.Drawing.Size(162, 30);
            this.cbxTipoRodado.TabIndex = 29;
            // 
            // lblTipoRodado
            // 
            this.lblTipoRodado.AutoSize = true;
            this.lblTipoRodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRodado.Location = new System.Drawing.Point(388, 294);
            this.lblTipoRodado.Name = "lblTipoRodado";
            this.lblTipoRodado.Size = new System.Drawing.Size(144, 22);
            this.lblTipoRodado.TabIndex = 28;
            this.lblTipoRodado.Text = "Tipo de Rodado:";
            // 
            // cbxTipoVeiculo
            // 
            this.cbxTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVeiculo.FormattingEnabled = true;
            this.cbxTipoVeiculo.Items.AddRange(new object[] {
            "Tração",
            "Reboque"});
            this.cbxTipoVeiculo.Location = new System.Drawing.Point(203, 320);
            this.cbxTipoVeiculo.Name = "cbxTipoVeiculo";
            this.cbxTipoVeiculo.Size = new System.Drawing.Size(162, 30);
            this.cbxTipoVeiculo.TabIndex = 27;
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVeiculo.Location = new System.Drawing.Point(199, 294);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(140, 22);
            this.lblTipoVeiculo.TabIndex = 26;
            this.lblTipoVeiculo.Text = "Tipo do Veículo:";
            // 
            // cbxTipoPropVeiculo
            // 
            this.cbxTipoPropVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPropVeiculo.FormattingEnabled = true;
            this.cbxTipoPropVeiculo.Items.AddRange(new object[] {
            "Próprio",
            "Terceiro"});
            this.cbxTipoPropVeiculo.Location = new System.Drawing.Point(20, 320);
            this.cbxTipoPropVeiculo.Name = "cbxTipoPropVeiculo";
            this.cbxTipoPropVeiculo.Size = new System.Drawing.Size(162, 30);
            this.cbxTipoPropVeiculo.TabIndex = 25;
            // 
            // lblTipoPropVeiculo
            // 
            this.lblTipoPropVeiculo.AutoSize = true;
            this.lblTipoPropVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPropVeiculo.Location = new System.Drawing.Point(16, 294);
            this.lblTipoPropVeiculo.Name = "lblTipoPropVeiculo";
            this.lblTipoPropVeiculo.Size = new System.Drawing.Size(163, 22);
            this.lblTipoPropVeiculo.TabIndex = 24;
            this.lblTipoPropVeiculo.Text = "Tipo Prop. Veículo:";
            // 
            // txbCapacidadeM3
            // 
            this.txbCapacidadeM3.Location = new System.Drawing.Point(618, 253);
            this.txbCapacidadeM3.Name = "txbCapacidadeM3";
            this.txbCapacidadeM3.Size = new System.Drawing.Size(125, 28);
            this.txbCapacidadeM3.TabIndex = 23;
            this.txbCapacidadeM3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCapacidadeM3_KeyPress);
            // 
            // txbCapacidadeKg
            // 
            this.txbCapacidadeKg.Location = new System.Drawing.Point(466, 253);
            this.txbCapacidadeKg.Name = "txbCapacidadeKg";
            this.txbCapacidadeKg.Size = new System.Drawing.Size(125, 28);
            this.txbCapacidadeKg.TabIndex = 22;
            this.txbCapacidadeKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCapacidadeKg_KeyPress);
            // 
            // lblCapacidadeM3
            // 
            this.lblCapacidadeM3.AutoSize = true;
            this.lblCapacidadeM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadeM3.Location = new System.Drawing.Point(614, 228);
            this.lblCapacidadeM3.Name = "lblCapacidadeM3";
            this.lblCapacidadeM3.Size = new System.Drawing.Size(140, 22);
            this.lblCapacidadeM3.TabIndex = 21;
            this.lblCapacidadeM3.Text = "Capacidade M3:";
            this.lblCapacidadeM3.Click += new System.EventHandler(this.lblCapacidadeM3_Click);
            // 
            // lblCapacidadeKg
            // 
            this.lblCapacidadeKg.AutoSize = true;
            this.lblCapacidadeKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadeKg.Location = new System.Drawing.Point(462, 228);
            this.lblCapacidadeKg.Name = "lblCapacidadeKg";
            this.lblCapacidadeKg.Size = new System.Drawing.Size(142, 22);
            this.lblCapacidadeKg.TabIndex = 20;
            this.lblCapacidadeKg.Text = "Capacidade KG:";
            // 
            // txbAntt
            // 
            this.txbAntt.Location = new System.Drawing.Point(288, 253);
            this.txbAntt.Name = "txbAntt";
            this.txbAntt.Size = new System.Drawing.Size(152, 28);
            this.txbAntt.TabIndex = 19;
            this.txbAntt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAntt_KeyPress);
            // 
            // lblAntt
            // 
            this.lblAntt.AutoSize = true;
            this.lblAntt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntt.Location = new System.Drawing.Point(283, 228);
            this.lblAntt.Name = "lblAntt";
            this.lblAntt.Size = new System.Drawing.Size(161, 22);
            this.lblAntt.TabIndex = 18;
            this.lblAntt.Text = "Registro na ANTT:";
            // 
            // txbAnoModelo
            // 
            this.txbAnoModelo.Location = new System.Drawing.Point(170, 253);
            this.txbAnoModelo.Name = "txbAnoModelo";
            this.txbAnoModelo.Size = new System.Drawing.Size(94, 28);
            this.txbAnoModelo.TabIndex = 17;
            this.txbAnoModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAnoModelo_KeyPress);
            // 
            // txbAnoFabricacao
            // 
            this.txbAnoFabricacao.Location = new System.Drawing.Point(20, 253);
            this.txbAnoFabricacao.Name = "txbAnoFabricacao";
            this.txbAnoFabricacao.Size = new System.Drawing.Size(126, 28);
            this.txbAnoFabricacao.TabIndex = 16;
            this.txbAnoFabricacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAnoFabricacao_KeyPress);
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoModelo.Location = new System.Drawing.Point(166, 228);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(110, 22);
            this.lblAnoModelo.TabIndex = 15;
            this.lblAnoModelo.Text = "Ano Modelo:";
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoFabricacao.Location = new System.Drawing.Point(16, 228);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(141, 22);
            this.lblAnoFabricacao.TabIndex = 14;
            this.lblAnoFabricacao.Text = "Ano Fabricação:";
            // 
            // txbTara
            // 
            this.txbTara.Location = new System.Drawing.Point(618, 188);
            this.txbTara.Name = "txbTara";
            this.txbTara.Size = new System.Drawing.Size(109, 28);
            this.txbTara.TabIndex = 13;
            this.txbTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTara_KeyPress);
            // 
            // txbRenavam
            // 
            this.txbRenavam.Location = new System.Drawing.Point(466, 188);
            this.txbRenavam.Name = "txbRenavam";
            this.txbRenavam.Size = new System.Drawing.Size(115, 28);
            this.txbRenavam.TabIndex = 12;
            this.txbRenavam.TextChanged += new System.EventHandler(this.txbRenavam_TextChanged);
            this.txbRenavam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRenavam_KeyPress);
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTara.Location = new System.Drawing.Point(614, 163);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(113, 22);
            this.lblTara.TabIndex = 11;
            this.lblTara.Text = "Tara em KG:";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenavam.Location = new System.Drawing.Point(462, 163);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(91, 22);
            this.lblRenavam.TabIndex = 10;
            this.lblRenavam.Text = "Renavam:";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(20, 188);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(420, 28);
            this.txbModelo.TabIndex = 9;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(16, 163);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(162, 22);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo do Veículo:";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(466, 119);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(261, 28);
            this.txbMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(462, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(153, 22);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca do Veículo:";
            // 
            // txbCertificado
            // 
            this.txbCertificado.Location = new System.Drawing.Point(20, 119);
            this.txbCertificado.Name = "txbCertificado";
            this.txbCertificado.Size = new System.Drawing.Size(420, 28);
            this.txbCertificado.TabIndex = 5;
            // 
            // lblCertificado
            // 
            this.lblCertificado.AutoSize = true;
            this.lblCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificado.Location = new System.Drawing.Point(16, 94);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(318, 22);
            this.lblCertificado.TabIndex = 4;
            this.lblCertificado.Text = "Certificado de Propriedade do Veículo:";
            // 
            // cbxUF
            // 
            this.cbxUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbxUF.Location = new System.Drawing.Point(252, 51);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(231, 30);
            this.cbxUF.TabIndex = 3;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(248, 26);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(142, 22);
            this.lblUF.TabIndex = 2;
            this.lblUF.Text = "UF do Veículo:";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(20, 52);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(162, 28);
            this.txbPlaca.TabIndex = 1;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(16, 26);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(166, 22);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa do Veículo:";
            // 
            // tabControlIdentificacao
            // 
            this.tabControlIdentificacao.Controls.Add(this.tabPageIdentificacao);
            this.tabControlIdentificacao.Location = new System.Drawing.Point(13, 49);
            this.tabControlIdentificacao.Name = "tabControlIdentificacao";
            this.tabControlIdentificacao.SelectedIndex = 0;
            this.tabControlIdentificacao.Size = new System.Drawing.Size(789, 483);
            this.tabControlIdentificacao.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(562, 541);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(686, 541);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(2);
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 584);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControlIdentificacao);
            this.Controls.Add(this.toolStripCadastroVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos";
            this.Load += new System.EventHandler(this.FrmVeiculo_Load);
            this.toolStripCadastroVeiculo.ResumeLayout(false);
            this.toolStripCadastroVeiculo.PerformLayout();
            this.tabPageIdentificacao.ResumeLayout(false);
            this.tabPageIdentificacao.PerformLayout();
            this.tabControlIdentificacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropIncluir;
        private System.Windows.Forms.ToolStripDropDownButton toolStripExcluir;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSalvar;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLimpar;
        private System.Windows.Forms.ToolStrip toolStripCadastroVeiculo;
        private System.Windows.Forms.TabPage tabPageIdentificacao;
        private System.Windows.Forms.TabControl tabControlIdentificacao;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbCertificado;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.TextBox txbTara;
        private System.Windows.Forms.TextBox txbRenavam;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbCapacidadeKg;
        private System.Windows.Forms.Label lblCapacidadeM3;
        private System.Windows.Forms.Label lblCapacidadeKg;
        private System.Windows.Forms.TextBox txbAntt;
        private System.Windows.Forms.Label lblAntt;
        private System.Windows.Forms.TextBox txbAnoModelo;
        private System.Windows.Forms.TextBox txbAnoFabricacao;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.TextBox txbCapacidadeM3;
        private System.Windows.Forms.ComboBox cbxTipoVeiculo;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.ComboBox cbxTipoPropVeiculo;
        private System.Windows.Forms.Label lblTipoPropVeiculo;
        private System.Windows.Forms.ComboBox cbxTipoCarroceria;
        private System.Windows.Forms.Label lblTipoCarroceria;
        private System.Windows.Forms.ComboBox cbxTipoRodado;
        private System.Windows.Forms.Label lblTipoRodado;
        private System.Windows.Forms.TextBox txbProprietario;
        private System.Windows.Forms.Label lblProprietario;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.Button btnCancelar;
    }
}