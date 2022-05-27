using static System.Console;

WriteLine("Digite o nome do Arquivo:");
var nome = ReadLine();
nome = LimparArquivo(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite qualquer tecla para finalizar");
ReadLine();

static string LimparArquivo(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}
static void CriarArquivo(string path)
{

    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("dale");
        sw.WriteLine("dale");
        sw.WriteLine("dale");
        sw.WriteLine("dale");
        sw.Flush();
    }
    catch (System.Exception)
    {

        WriteLine("Nome inválido...");
    }
}
