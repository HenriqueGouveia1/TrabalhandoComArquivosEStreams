//using CsvHelper.Configuration.Attributes;
public class Livro
{

    //caso o arquivo não tenha cabeçalho podemos utilizar de mesmo modo os Attributes com Idexes
    // [Name("autor")] -> [Index(0)]
    public string Titulo { get; set; }
   
    public string Autor { get; set; }
    public decimal Preco { get; set; }
    public DateOnly Lancamento { get; set; }
}