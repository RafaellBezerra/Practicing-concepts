namespace C_;


public class Calculos
{
    public void Operaçoes()
    {
        Console.Write("Digite um numero: ");
        var num1 = double.Parse(Console.ReadLine()!);
        Console.Write("Digite outro numero: ");
        var num2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");

        if (num2 == 0)
            Console.WriteLine("Divisão: <Não é possivel dividir por 0> \n");
        else Console.WriteLine($"Divisão: {num1 / num2}");

        Console.WriteLine($"Media: {(num1 + num2) / 2} \n");
    }
}

