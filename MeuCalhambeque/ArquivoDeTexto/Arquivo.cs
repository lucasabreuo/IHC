using System;
using System.Collections.Generic;
using System.IO;

namespace ArquivoTexto
{
    public class Arquivo
    {
        public FileStream arq;
        private string _arquivo;
        private string separador = "|";

        public Arquivo(string caminhoArquivo)
        {
            _arquivo = caminhoArquivo;
            if (!File.Exists(_arquivo))
            {
                FileStream f = new FileStream(_arquivo, FileMode.OpenOrCreate);
                f.Close();
            }
        }

        public bool SalvarDados(params object[] dados)
        {
            return SalvarDados(dados, separador);
        }

        private bool SalvarDados(object[] dados, string separador)
        {
            try
            {
                if (!File.Exists(_arquivo))
                    File.Create(_arquivo);

                File.Open(_arquivo,FileMode.OpenOrCreate); ;
                using (StreamWriter escrever = new StreamWriter(_arquivo, true))
                {
                    string linha = string.Join(separador, dados);
                    escrever.WriteLine(linha);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<object[]> Ler()
        {
            List<object[]> list = new List<object[]>();
            using (StreamReader sr = new StreamReader(_arquivo))
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    object[] dados = linha.Split(separador[0]);
                    list.Add(dados);
                }
            }
            return list;
        }

        public void Excluir()
        {
            File.Delete(_arquivo);
        }
    }
}
