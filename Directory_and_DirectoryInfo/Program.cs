CriarDiretorio();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul","Brasil","brasil.txt");

MoverArquivo(origem, destino);

static void CopiarArquivo(string pathO, string pathD)
{
    if (!File.Exists(pathO))
    {
       Console.WriteLine("Arquido de origem não existe");
       return;
    }
    if (!File.Exists(pathD))
    {
        Console.WriteLine("Arquido de destino não existe");
        return;
    }
    File.Copy(pathO, pathD);
}

static void MoverArquivo(string pathO, string pathD)
{
    if (!File.Exists(pathO))
    {
       Console.WriteLine("Arquido de origem não existe");
       return;
    }
    if (!File.Exists(pathD))
    {
        Console.WriteLine("Arquido de destino não existe");
        return;
    }
    File.Move(pathO, pathD);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("dale");
    }
}

static void CriarDiretorio()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var dirGLobo = Directory.CreateDirectory(path);

        var dirAmericaNorte = dirGLobo.CreateSubdirectory("América do Norte");
        var dirAmericaSul = dirGLobo.CreateSubdirectory("América do Sul");
        var dirAmericaCentro = dirGLobo.CreateSubdirectory("América Central");

        dirAmericaCentro.CreateSubdirectory("Costa Rica");

        dirAmericaNorte.CreateSubdirectory("USA");

        dirAmericaSul.CreateSubdirectory("Brasil");
    }


}

