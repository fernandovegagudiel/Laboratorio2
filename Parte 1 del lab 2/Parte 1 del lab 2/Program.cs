using System;
 
class Program
{
    static void Main()
    { 

int numeroE;
double numeroD;
string tex;
bool valBool;

Console.WriteLine("ingrese un número entero: ");
numeroE = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese un numero decimal");
numeroD = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese un texto");
tex = Console.ReadLine();
Console.WriteLine("ingresa un  true/false: ");
valBool = bool.Parse(Console.ReadLine());

        Console.WriteLine("------los datos ingresados son:-------" );

        Console.WriteLine("El numero entero ingresado es:  "  + numeroE);
        Console.WriteLine("El numero decimal ingresado es:  "  + numeroD);
        Console.WriteLine("El texto es :            " + tex);
        Console.WriteLine("El valor boleano :     " + valBool);

        
    }
}