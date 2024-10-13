/*Clase Practica de Programacion*/
/*Facultad de matematica y computacion*/
// Universidad de la Habana
// Carlos Javier Blanco Moreira

/* 1. Reciba como entrada una cadena de caracteres (string). Luego muestre en la terminal ese
mismo string pero con terminación ”medio limón”. */

Console.WriteLine(" Ingrese una cadena de caracteres : ");
string inputString = Console.ReadLine();
Console.WriteLine(inputString + " medio limón ");

// 2. Reciba un número entero y muestre en la consola su doble.
Console.WriteLine("Ingrese un numero entero");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"El doble del numero es {number * 2}");

// 3. Reciba dos números enteros de la consola y determine cuál de los dos es mayor sin utilizar
//    Math.Max y Math.Min.
System.Console.Write("Ingrese el primer numero: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Ingrese el segundo numero: ");
int b = int.Parse(Console.ReadLine());

int max = (a + b + Math.Abs(a - b)) / 2;
System.Console.WriteLine($"El mayor valor entre {a} y {b} es {max}");

