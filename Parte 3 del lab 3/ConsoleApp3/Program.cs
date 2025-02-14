using System;

class Progra
{
    static void Main()
    {
        int valor1, valor2;

        Console.Write("Ingrese el primer valor: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        if (valor1 > valor2)
            Console.WriteLine("El primer valor es mayor que el segundo.");
        else if (valor1 < valor2)
            Console.WriteLine("El primer valor es menor que el segundo.");
        else
            Console.WriteLine("Ambos valores son iguales.");

        Console.WriteLine("\n=== Comparaciones con Operadores Lógicos ===");
        if (valor1 > 0 && valor2 > 0)
            Console.WriteLine("Ambos valores son positivos.");

        if (valor1 < 0 || valor2 < 0)
            Console.WriteLine("Al menos uno de los valores es negativo.");

        else
            Console.WriteLine("Ninguno de los Numeros es menor que 0");



    }

}

