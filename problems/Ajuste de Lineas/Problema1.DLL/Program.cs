using System.Collections.Generic;

namespace Problema1
{
    class Prueba
    {

        public static string[] AjusteDeLinea(string texto, int ancho)
        {
            string[] aux = texto.Split(' ');
            string[] ans = new string[aux.Length];

            string answer = "";
            int pos = 0;

            foreach (var i in aux)
            {
                if(i.Length + answer.Length <= ancho)
                    answer += i + ' ';
                else
                {
                    ans[pos] = answer;
                    answer = i + ' ';
                    pos++;
                }
            }
            if(answer != "" && answer != "\n" && pos < aux.Length)
                ans[pos++] = answer;

            return ans;
        }

        public static void Print(string[] ans)
        {
            foreach (var i in ans)
            {
                if(i != "" && i != "\n")
                    System.Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            string[] ans = AjusteDeLinea("Primera Prueba de Programacion Curso 2006 - 2007", 14);
            Print(ans);

            ans = AjusteDeLinea("Hola Mundo, Me llamo Carlos, y esto sera una linea de 4 espacios", 3);
            Print(ans);
        }
    }
}