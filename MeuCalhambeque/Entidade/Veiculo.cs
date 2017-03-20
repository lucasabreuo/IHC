using System;
using System.Collections.Generic;
using ArquivoDeTexto;

namespace Entidade
{
    public class Veiculo : CaminhoDoArquivo
    {
        private string _placa;
        private string _UF;
        private string _certificadoPropriedade;
        private string _marca;
        private string _modelo;
        private int _renavam;
        private float _tara;
        private int _anoFabricacao;
        private int _anoModelo;
        private long _antt;
        private float _capacidadeKg;
        private float _capacidadeM3;
        private string _tipoPropVeiculo;
        private string _tipoVeiculo;
        private string _tipoRodado;
        private string _tipoCarroceria;
        private string _nomePropVeiculo;
        private string _diretorioArquivo { get { return CaminhoArquivo(); } }

        List<Veiculo> _listaVeiculo = new List<Veiculo>();
        Arquivo _arquivo;

        #region Modificadores de Acesso
        public List<Veiculo> ListaVeiculo
        {
            get { return _listaVeiculo; }
        }

        public string Placa
        {
            get
            {
                return _placa;
            }

            set
            {
                _placa = value;
            }
        }

        public string UF
        {
            get
            {
                return _UF;
            }

            set
            {
                _UF = value;
            }
        }

        public string CertificadoPropriedade
        {
            get
            {
                return _certificadoPropriedade;
            }

            set
            {
                _certificadoPropriedade = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public int Renavam
        {
            get
            {
                return _renavam;
            }

            set
            {
                _renavam = value;
            }
        }

        public float Tara
        {
            get
            {
                return _tara;
            }

            set
            {
                _tara = value;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return _anoFabricacao;
            }

            set
            {
                _anoFabricacao = value;
            }
        }

        public int AnoModelo
        {
            get
            {
                return _anoModelo;
            }

            set
            {
                _anoModelo = value;
            }
        }

        public long Antt
        {
            get
            {
                return _antt;
            }

            set
            {
                _antt = value;
            }
        }

        public float CapacidadeKg
        {
            get
            {
                return _capacidadeKg;
            }

            set
            {
                _capacidadeKg = value;
            }
        }

        public float CapacidadeM3
        {
            get
            {
                return _capacidadeM3;
            }

            set
            {
                _capacidadeM3 = value;
            }
        }

        public string TipoPropVeiculo
        {
            get
            {
                return _tipoPropVeiculo;
            }

            set
            {
                _tipoPropVeiculo = value;
            }
        }

        public string TipoVeiculo
        {
            get
            {
                return _tipoVeiculo;
            }

            set
            {
                _tipoVeiculo = value;
            }
        }

        public string TipoRodado
        {
            get
            {
                return _tipoRodado;
            }

            set
            {
                _tipoRodado = value;
            }
        }

        public string TipoCarroceria
        {
            get
            {
                return _tipoCarroceria;
            }

            set
            {
                _tipoCarroceria = value;
            }
        }

        public string NomePropVeiculo
        {
            get
            {
                return _nomePropVeiculo;
            }

            set
            {
                _nomePropVeiculo = value;
            }
        }
        #endregion

        public Veiculo()
        {
            _arquivo = new Arquivo(_diretorioArquivo);
        }

        public Veiculo(bool loadLista)
        {
            _arquivo = new Arquivo(_diretorioArquivo);

            if (loadLista)
                LerVeiculo();
        }

        #region Métodos de CRUD
        public void SalvarVeiculo()
        {
            foreach (var aux in _listaVeiculo)
            {
                _arquivo.SalvarDados(aux.Placa, aux.UF, aux.CertificadoPropriedade, aux.Marca, aux.Modelo, aux.Renavam,
                    aux.Tara, aux.AnoFabricacao, aux.AnoModelo, aux.Antt, aux.CapacidadeKg, aux.CapacidadeM3, aux.TipoPropVeiculo,
                    aux.TipoVeiculo, aux.TipoRodado, aux.TipoCarroceria, aux.NomePropVeiculo);
            }
        }

        public List<Veiculo> LerVeiculo()
        {
            foreach (object[] item in _arquivo.Ler())
            {
                Veiculo veiculo = IniciarVeiculo(item);
                _listaVeiculo.Add(veiculo);
            }
            return _listaVeiculo;
        }

        public Veiculo IniciarVeiculo(object[] dados)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo.Placa = dados[0].ToString();
                veiculo.UF = dados[1].ToString();
                veiculo.CertificadoPropriedade = dados[2].ToString();
                veiculo.Marca = dados[3].ToString();
                veiculo.Modelo = dados[4].ToString();
                veiculo.Renavam = int.Parse(dados[5].ToString());
                veiculo.Tara = float.Parse(dados[6].ToString());
                veiculo.AnoFabricacao = int.Parse(dados[7].ToString());
                veiculo.AnoModelo = int.Parse(dados[8].ToString());
                veiculo.Antt = long.Parse(dados[9].ToString());
                veiculo.CapacidadeKg = float.Parse(dados[10].ToString());
                veiculo.CapacidadeM3 = float.Parse(dados[11].ToString());
                veiculo.TipoPropVeiculo = dados[12].ToString();
                veiculo.TipoVeiculo = dados[13].ToString();
                veiculo.TipoRodado = dados[14].ToString();
                veiculo.TipoCarroceria = dados[15].ToString();
                veiculo.NomePropVeiculo = dados[16].ToString();

                return veiculo;
            }
            catch (FormatException)
            {
                throw new Exception("ERRO: Formato Incorreto - Contate o administrador do sistema!");

            }
            catch (OverflowException)
            {
                throw new Exception("ERRO: Valores preenchidos maiores que os suportados - Contate o administrador do sistema!");

            }
            catch (NullReferenceException)
            {
                throw new Exception("ERRO: Objetos estão com valores nulos - Contate o administrador do sistema!");

            }
            catch (Exception)
            {
                throw new Exception("ERRO: - Contate o administrador do sistema!");
            }
        }

        public string ExcluirVeiculo(string placa)
        {
            string mensagem = "";

            try
            {
                for (int i = _listaVeiculo.Count - 1; i >= 0; i--)
                {
                    if (placa == _listaVeiculo[i].Placa)
                        _listaVeiculo.Remove(_listaVeiculo[i]);
                }

                _arquivo.Excluir();
                SalvarVeiculo();
                mensagem = "Veículo excluído com sucesso!";
            }
            catch (Exception)
            {
                mensagem = "Não é possível excluir o Veículo. Contate o administrador do sistema!";
            }

            return mensagem;
        }
        #endregion
    }
}
