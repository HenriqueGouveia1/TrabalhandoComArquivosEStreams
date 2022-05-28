var path = @"C:\github projects\Curso Trabalhando com Arquivos e Streams em C#\Directory_and_DirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("[Enter] Para Finalizar");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Objeto {e.Name} foi criado!");
}


void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"Objeto {e.Name} foi renomeado para {e.OldName}!");
}


void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Objeto {e.Name} foi deletado!");
}