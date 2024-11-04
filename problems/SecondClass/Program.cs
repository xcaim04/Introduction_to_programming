using System;

namespace CP
{
    class CPSecond
    {
        public static bool CheckDate(int day, int month, int year)
        {
            if (year < 0) return false;
            if (day < 0) return false;

            if (!(month >= 1 && month <= 12))
            {
                return false;
            }

            // Biciesto
            if (month == 2)
            {
                if (day > 28)
                {
                    bool biciesto = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                    if (!biciesto && day > 28) return false;
                    else if (day > 29) return false;
                }
            }

            if (month <= 7 && (month % 2 != 0) || month >= 8 && (month % 2 == 0))
            {
                if (day <= 0 || day > 31) return false;
            }
            else
            {
                if (day <= 0 || day > 30) return false;
            }

            return true;
        }

        public static bool divNumbers(int a, int b)
        {
            return a % b == 0;
        }

        public static void Carnet()
        {
            string ci = Console.ReadLine();
            int pos = ci.Length - 2;
            int n = Convert.ToInt32(ci[pos]);
            if (n % 2 == 0)
                System.Console.WriteLine("Masculino");
            else
                System.Console.WriteLine("Femenino");
        }



        public static void Main(string[] args)
        {
            // Ejercicio 1: Ver si una fecha en formatao D/M/YYYY es valida
            System.Console.WriteLine(CheckDate(4, 2, 2005) == true ? "Es valida" : "Es invalida");

            //Ejercicio 2: Ver si un numero a es divisible por b
            System.Console.WriteLine(divNumbers(4, 2) ? $"{4} es divisible por {2}" : "No es divisible");

            //Ejercicio 3: Ver apartir del numero de carnet de identidad si es femenino o masculino
            Carnet();
        }
    }
}