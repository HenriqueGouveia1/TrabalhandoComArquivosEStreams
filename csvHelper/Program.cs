using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

//LerCSVComDynamic();
//LerCsvComClasse();
LerCsvComOutroDelimiter();

Console.WriteLine("[Enter] para finalizar");
Console.ReadLine();

static void LerCsvComOutroDelimiter()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "Livros.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O aruivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Titulo}");
        Console.WriteLine($"Autor:{registro.Autor}");
        Console.WriteLine($"Preço:{registro.Preco}");
        Console.WriteLine($"Lançamento:{registro.Lancamento}");
        Console.WriteLine("--------");
    }
}

static void LerCsvComClasse()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "novos-usuarios.csv");
    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O aruivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"email:{registro.Email}");
        Console.WriteLine($"telefone:{registro.Telefone}");
        Console.WriteLine("--------");
    }
}

static void LerCSVComDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>(); //não tem intelisense, precisa ser o nome exato

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Produto}");
        Console.WriteLine($"marca:{registro.Marca}");
        Console.WriteLine($"preco:{registro.Preco}");
        Console.WriteLine("--------");
    }

}
