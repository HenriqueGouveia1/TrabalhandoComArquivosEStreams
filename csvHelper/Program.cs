using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

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
    Console.WriteLine($"nome:{registro.Nome}");
    Console.WriteLine($"email:{registro.Email}");
    Console.WriteLine($"telefone:{registro.Telefone}");
    Console.WriteLine("--------");
}
