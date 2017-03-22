using System.IO;

namespace ArquivoDeTexto
{
    public interface ICaminhoDoArquivo
    {
        //private string Caminho = Directory.GetCurrentDirectory(); //diretorio corrente do aplicativo

        string CaminhoArquivo();
        
    }
}
