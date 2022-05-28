using CsvHelper.Configuration.Attributes;
public class Livro
{

    //caso o arquivo não tenha cabeçalho podemos utilizar de mesmo modo os Attributes com Idexes
    [Name("titulo")]
    public string Titulo { get; set; }
    [Name("autor")]
    public string Autor { get; set; }
    [Name("preço")]
    [CultureInfo("pt-BR")]
    public decimal Preco { get; set; }
    [Name("lançamento")]
    [Format("dd/MM/yyyy")]
    public DateOnly Lancamento { get; set; }
}