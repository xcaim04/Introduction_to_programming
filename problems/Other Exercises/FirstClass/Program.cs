/*Clase Practica de Programacion*/
/*Facultad de matematica y computacion*/
// Universidad de la Habana
// Carlos Javier Blanco Moreira

System.Console.WriteLine("Ejercicio 1:");

/* 1. Reciba como entrada una cadena de caracteres (string). Luego muestre en la terminal ese
mismo string pero con terminación ”medio limón”. */

Console.WriteLine("Ingrese una cadena de caracteres : ");
string inputString = Console.ReadLine();
Console.WriteLine(inputString + " medio limón ");

System.Console.WriteLine("\nEjercicio 2:");

// 2. Reciba un número entero y muestre en la consola su doble.
Console.WriteLine("Ingrese un numero entero");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"El doble del numero es {number * 2}");

System.Console.WriteLine("\nEjercicio 3:");

// 3. Reciba dos números enteros de la consola y determine cuál de los dos es mayor sin utilizar
//    Math.Max y Math.Min.
System.Console.Write("Ingrese el primer numero: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Ingrese el segundo numero: ");
int b = int.Parse(Console.ReadLine());
int max = (a + b + Math.Abs(a - b)) / 2;
System.Console.WriteLine($"El mayor valor entre {a} y {b} es {max}");

System.Console.WriteLine("\nEjercicio 4:");

/*
    4. Reciba tres números enteros. Muestre en la consola el de valor medio (Utilice Math.Max
    y Math.Min) y el promedio de estos.
*/

Console.WriteLine("Ingrese tres numeros enteros : ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int middle = Math.Max(Math.Min(num1, num2), Math.Min(Math.Max(num1, num2), num3));

double promedio = (num1 + num2 + num3) / 3;

System.Console.WriteLine($"El valor del medio entre {num1} {num2} {num3} es {middle}");
System.Console.WriteLine($"Su promedio es {promedio}");

System.Console.WriteLine("\nEjercicio 5:");

/*
    5. Reciba un string y un entero (x) menor que el total de caracteres del string.
    Muestre en consola el caracter que ocupa en la posicion (x) del string.
*/

System.Console.Write("Ingrese una cadena de texto: ");
string text = Console.ReadLine();

System.Console.Write("Ingrese un numero entero: ");
int pos = int.Parse(Console.ReadLine());

System.Console.WriteLine($"En la posicion {pos} de {text} se encuentra el caracter {text[pos]}");

System.Console.WriteLine("\nEjercicio 6:");

// 6. Intercambia el valor de dos variables a y b de las siguientes maneras

// 1. Usando una variable auxiliar
// 2. Sin usar una variable auxiliar

System.Console.WriteLine("Ingresa dos numeros");

int num_a = int.Parse(Console.ReadLine());
int num_b = int.Parse(Console.ReadLine());

int ac = num_a;
int bc = num_b;
// Usando una variable auxiliar
// Intercambio
int aux = ac;
ac = bc;
bc = aux;

System.Console.WriteLine("Usando la variable auxiliar");
System.Console.WriteLine($"a = {ac}\nb = {bc}");

// Sin variable auxiliar
num_a += num_b;
num_b = num_a - num_b;
num_a -= num_b;

System.Console.WriteLine("Sin usar variable auxiliar");
System.Console.WriteLine($"a = {num_a}\nb = {num_b}");

System.Console.WriteLine("\nEjercicio 7:");

/*
    7. Sean las circunferencias C1 y C2 de redio r. Lea de la consola el radio r (puede ser cualquier
        número real, no sólo entero) y calcule el área sombreada.
*/

System.Console.WriteLine("Ingrese el valor del radio: ");
double r = double.Parse(Console.ReadLine());
double A = 2 * Math.PI * r * r / 3;
double B = Math.Sqrt(3) * r * r / 2;
System.Console.WriteLine($"El area sombreada es de {A - B}");

// ... lo dejamos por aqui