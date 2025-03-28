using System.Globalization;

Console.Write("Informe seu nome completo: ");
// criar a variavel nome e recebe o seu valor
string nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.Write("Quantos quartos tem na sua casa? ");
// converte o texto digitado para um numero int
int quartos = int.Parse( Console.ReadLine() );
Console.WriteLine();
Console.Write("Informe o preço da sua internet: ");
double precoInternet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("Informe seu último nome, idade e altura: ");
// Suarez 32 1.81
string linha = Console.ReadLine();
// vetor de texto - divisão quando encontrar um espaço
string[] vetor = linha.Split(' ');
string sobreNome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);


Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));
Console.WriteLine(sobreNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));