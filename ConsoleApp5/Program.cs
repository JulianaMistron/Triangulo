double lado1, lado2, lado3;

Console.WriteLine("Digite o lado 1:");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o lado 2:");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o lado 3:");
lado3 = Convert.ToDouble(Console.ReadLine());

{
    if (lado1 == lado2 && lado2 == lado3)
        Console.WriteLine("Triângulo Equilátero");

    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        Console.WriteLine("Triângulo Isósceles");
    else
        Console.WriteLine("Triângulo Escaleno");
}