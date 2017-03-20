using System;
using System.Collections.Generic;
using ArquivoDeTexto;

namespace Entidade
{
    public class Combustivel : CaminhoDoArquivo
    {
        public string _ID;
        public string _data;
        public string _tipo;
        public float _valorUnit;
        public float _quantidade;
        public float _valorTotal;
        private string _diretorioArquivo { get { return CaminhoArquivo(); } }

        List<Combustivel> _listaCombustivel = new List<Combustivel>();
        Arquivo _arquivo;
        
        #region Modificador de acesso
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public float ValorUnit
        {
            get { return _valorUnit; }
            set { _valorUnit = value; }
        }

        public float Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public float ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        #endregion

        public Combustivel()
        {
            _arquivo = new Arquivo(_diretorioArquivo);
        }

        public Combustivel(bool loadLista)
        {
            _arquivo = new Arquivo(_diretorioArquivo);

            if (loadLista)
                LerCombustivel();
        }

        #region Métodos de CRUD
        public void SalvarVeiculo()
        {
            foreach (var aux in _listaCombustivel)
            {
                _arquivo.SalvarDados(aux.ID, aux.Data, aux.Tipo, aux.ValorUnit, aux.Quantidade, aux.ValorTotal);
            }
        }

        public List<Combustivel> LerCombustivel()
        {
            foreach (object[] item in _arquivo.Ler())
            {
                Combustivel combustivel = IniciarCombustivel(item);
                _listaCombustivel.Add(combustivel);
            }
            return _listaCombustivel;
        }

        public Combustivel IniciarCombustivel(object[] dados)
        {
            try
            {
                Combustivel combustivel = new Combustivel();

                combustivel.ID = dados[0].ToString();
                combustivel.Data = dados[1].ToString();
                combustivel.Tipo = dados[2].ToString();
                combustivel.ValorUnit = float.Parse(dados[3].ToString());
                combustivel.Quantidade = float.Parse(dados[4].ToString());
                combustivel.ValorTotal = float.Parse(dados[5].ToString());

                return combustivel;
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

        public string ExcluirCombustivel(string id)
        {
            string mensagem = "";

            try
            {
                for (int i = _listaCombustivel.Count - 1; i >= 0; i--)
                {
                    if (id == _listaCombustivel[i].ID)
                        _listaCombustivel.Remove(_listaCombustivel[i]);
                }

                _arquivo.Excluir();
                SalvarVeiculo();
                mensagem = "Lançamento de combustível excluído com sucesso!";
            }
            catch (Exception)
            {
                mensagem = "Não é possível excluir o lançamento de combustível. \nContate o administrador do sistema!";
            }

            return mensagem;
        }
        #endregion
    }
}
