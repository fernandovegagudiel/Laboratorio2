using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
class Progra
{
    static void Main()
    {
        int Num1;
        int Num2;
        float deci1, deci2;
        Int16 de1, de2;
        byte by1, by2;

        Console.WriteLine("Ingrese el primer numero :");
        Num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero :");
        Num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("La Suma es: " + (Num1 + Num2));
        Console.WriteLine("La Resta es: " + (Num1 - Num2));
        Console.WriteLine("La Multiplicacion es: " + (Num1 * Num2));
        Console.WriteLine("La Divicion es :" + (Num1 / (double)Num2));

        Console.WriteLine("\n=========================================================================\n");


        // ingreso de datos float 
        Console.WriteLine("Ingrese el Primer Numero decimal  : ");
        deci1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Segundo Numero decimal :");
        deci2 = float.Parse(Console.ReadLine());

        Console.WriteLine("La suma de los Numeros es: " + (deci1 + deci2));
        Console.WriteLine("Las Resta de los Numeros es: " + (deci1 - deci2));
        Console.WriteLine("La Multiplicacion de los Numeros es: " + (deci1 * deci2));
        Console.WriteLine("la Divicion de los Numeros es: " + (deci1 /deci2));

        Console.WriteLine("\n===========================================================================\n");

        //ingreso de datos int16 
        Console.WriteLine("Ingrese el Primer Numero");
        de1 = Int16.Parse(Console.ReadLine());
        Console.WriteLine("ingres el SEgundo Numero");
        de2 = Int16.Parse(Console.ReadLine());

        Console.WriteLine("La Suma de los Numeros es: " + (de1 + de2));
        Console.WriteLine("La Resta de los Numeros es: " + (de1 + de2));
        Console.WriteLine("La Multiplicacion de los Numeros es:" + (de1 * de2));
        Console.WriteLine("La Division de los Numeros es:" + (de1 / de2));

        Console.WriteLine("\n================================================================================\n");

            //ingreso de datos en bytes 
        Console.WriteLine("Ingrese el Primer Numero");
        by1 = byte.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Segundo Numero");
        by2 = byte.Parse(Console.ReadLine());

        Console.WriteLine("la Suma de los Numeros es: " + (by1 + by2));
        Console.WriteLine("La Resta de los Numeros es: " + (by1 - by2));
        Console.WriteLine("La multiplicacion de los Numero es: " + (by1 * by2));
        Console.WriteLine("La Division de los Numeros es: " + (by1 /by2));

    }

}