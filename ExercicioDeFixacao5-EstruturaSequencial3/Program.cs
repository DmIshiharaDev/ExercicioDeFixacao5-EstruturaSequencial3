using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- Calcule o salário do Colaborador ---");
        Console.WriteLine();

        Console.Write("Digite o código do funcionário: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de horas trabalhadas: ");
        float horas = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor da hora trabalhada: ");
        float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        double salario = horas * valorHora;

        Console.WriteLine("Código do Colaborador: " + codigo);
        Console.WriteLine("Saláro: R$" + salario, CultureInfo.InvariantCulture);
    }
}