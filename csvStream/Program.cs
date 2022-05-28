var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios-exportacao.csv");

if (File.Exists(path))
{
    using var sr = new StreamReader(path);
    var cabecalho = sr.ReadLine()?.Split(',');

    while (true)
    {
        var registro = sr.ReadLine()?.Split(',');
        if (registro == null) break;

        if (cabecalho.Length != registro.Length)
        {
            Console.WriteLine("Arquivo Fora do Padrão");
            break;
        }

        for (int i = 0; i < registro.Length; i++)
        {
            Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
        }
        Console.WriteLine("--------------------------------");
    }
}
