var path = @"C:\github projects\Curso Trabalhando com Arquivos e Streams em C#\Directory_and_DirectoryInfo\globo";

LerDiretorios(path);

Console.WriteLine("Digite [enter] para finalizar");
Console.ReadLine();

static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
        }
    }


}
