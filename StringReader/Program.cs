using System.Text;

var sb = new StringBuilder();

sb.AppendLine("aAAaAaaAaAaAAAaaa");
sb.AppendLine("BbBbBb");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;

do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.WriteLine(string.Join("", buffer));
} while (tamanho >= buffer.Length);

Console.WriteLine("[Enter] para finalizar");
Console.ReadKey();