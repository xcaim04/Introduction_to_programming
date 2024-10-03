using System;

namespace CP
{
    class HelloWorld
    {

        static void sayHello()
        {
            // Di Hola

            // Muestre en consola el siguiente string "Hello World"
            Console.WriteLine("Hello World");
            //Muestre en consola el valores maximo y el valor minimo admitidos por el tipo int
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            Console.WriteLine($"Minimo: {minInt}  Maximo: {maxInt}");
            // Muestre en consola un valor aproximado de PI
            Console.WriteLine(Math.PI);
        }

        static void getInputs()
        {
            // Recibiendo entradas

            // Pedir un string como entrada y ponerle la terminacion "medio limon"
            string input = Console.ReadLine();
            Console.WriteLine(input + " medio limón");

            // Reciba un numero entero y muestre por consola su nombre
            int numberToPow = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(numberToPow, 2));

            // Reciba tres enteros por consola e imprima el valor del medio usando MIN y MAX y el promedio de estos
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int answer = (a + b + c) / 3;

            int mid = Math.Min(Math.Min(Math.Max(a, b), Math.Max(b, c)), Math.Max(a, c));

            Console.WriteLine($"Valor central de {a} {b} {c} es: {mid}");
            Console.WriteLine($"Su promedio es {answer}");

            // Mostrar el caracter x de un string
            string value = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(value[x - 1]);
        }

        static double Circunferencia(double r)
        {
            // Programando... 
        }

        static void Main(string[] args)
        {
            //sayHello();
            //getInputs();
            Circunferencia(6);
        }
    }
}