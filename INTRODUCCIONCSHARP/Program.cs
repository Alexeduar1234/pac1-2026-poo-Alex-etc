
using INTRODUCCIONCSHARP.ejemplos;

Calculadora calculadora = new Calculadora();

Console.WriteLine("===sumar===");
Console.WriteLine("");

string operacion = "";
int n1 = 0;
int n2 = 0;

try
{
    Console.WriteLine("indique que operacion desea realizar, se permite (+, -, x, ÷)");
    operacion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo nombre");
    n2 = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error de formato en el texto ingresado");
}
int resultado = 0;

switch (operacion)
{
    case "+":
    resultado = calculadora.Sumar(n1,n2);
    break;
    case "-":
    resultado = calculadora.Restar(n1,n2);
    break;
    case "*":
    resultado = calculadora.Multiplicar(n1,n2);
    break;
    case "÷":
    resultado = calculadora.Dividir(n1,n2);
    break;
    default:
    throw new Exception("no ingreso una operacion valida");

}

Console.WriteLine("el resultado es:" + resultado);


// Persona persona1 = new Persona("Juan","perez","M", 19);

// Console.WriteLine("hola " + persona1.nombre + " " + persona1.apellidos + " usted tiene " + persona1.edad + " anos");


// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("hola dku");

//         Console.WriteLine("como te llamas?");
//         string nombre = Console.ReadLine();
//         Console.WriteLine("que edad tienes");
//         string edad = Console.ReadLine();
//         Console.WriteLine("\nhola" + nombre + "tienes"+ edad + "anos.");

//     }
// }