using System.IO;

namespace ArquivoDeTexto
{
    public abstract class CaminhoDoArquivo
    {
        private string Caminho = Directory.GetCurrentDirectory(); //diretorio corrente do aplicativo

        protected string CaminhoArquivo()
        {
            return Path.Combine(Caminho, this.ToString() + ".txt");
        }
    }
}
