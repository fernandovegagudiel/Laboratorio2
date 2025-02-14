###laboratori-2
## ¿Para qué crees que se usan los operadores lógicos en programación?
**R/** Los operadores lógicos se utilizan para realizar operaciones complejas, como la verificación de contraseñas o la evaluación de si una persona es mayor o menor de edad, entre otras.

### ¿Por qué es importante declarar correctamente el tipo de dato de una variable?
**R/** Es importante declarar correctamente el tipo de dato de una variable para realizar operaciones válidas, evitar errores de tipo y asegurar el buen funcionamiento y la eficiencia del programa al ejecutarlo.

---

### Enunciado 1: Clasificación de edad

**¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?**  
**R/** La estructura que utilicé fue `if-else`, porque trabajé con rangos y esto permite verificar múltiples condiciones relacionadas con la edad.

```csharp
int edad;
Console.WriteLine("Ingrese su Edad: ");
edad = int.Parse(Console.ReadLine());

if (edad <= 11)
    Console.WriteLine("Tu Edad pertenece a un Niño");
else if (edad >= 12 && edad <= 17)
    Console.WriteLine("Tu Edad pertenece a un Adolescente");
else if (edad >= 18 && edad <= 59)
    Console.WriteLine("Tu Edad pertenece a un Adulto");
else if (edad >= 60)
    Console.WriteLine("Tu Edad pertenece a un Adulto Mayor");

```

### Enunciado 2: Día de la semana

**¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?**  
**R/** En este caso, la estructura que utilicé fue `switch`. La razón principal es que estamos trabajando con una sola variable (`num`) que representa un valor específico entre 1 y 7, y el `switch` es más adecuado para manejar este tipo de situaciones.

```csharp
Console.WriteLine("Ingrese un número (1-7):");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Seleccionaste el día Lunes.");
        break;
    case 2:
        Console.WriteLine("Seleccionaste el día Martes.");
        break;
    case 3:
        Console.WriteLine("Seleccionaste el día Miércoles.");
        break;
    case 4:
        Console.WriteLine("Seleccionaste el día Jueves.");
        break;
    case 5:
        Console.WriteLine("Seleccionaste el día Viernes.");
        break;
    case 6:
        Console.WriteLine("Seleccionaste el día Sábado.");
        break;
    case 7:
        Console.WriteLine("Seleccionaste el día Domingo.");
        break;
    default:
        Console.WriteLine("Día inválido.");
        break;
}

```

### Enunciado 3: Verificación de acceso

**¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?**  
**R/** La estructura que utilicé fue `if-else`, ya que es la más adecuada para este tipo de verificación de condiciones que involucran múltiples valores o comparaciones, como la verificación de usuario y contraseña.

```csharp
string usuari = "fernando";
string contra = "4541";

Console.WriteLine("Ingrese el Usuario:");
string inUsuario = Console.ReadLine();

Console.WriteLine("Ingrese la Contraseña:");
string incontra = Console.ReadLine();  

if (usuari == inUsuario)
{
    if (contra == incontra)
    {
        Console.WriteLine("Los datos ingresados son correctos.");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta.");
    }
}
else
{
    Console.WriteLine("Usuario no registrado.");
}
```
 
