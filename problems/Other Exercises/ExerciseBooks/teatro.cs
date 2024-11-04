using System;
using System.Linq;

namespace Teatro
{
	public class Program 
	{
		
		static int charCounter (char[] charList, char character)
		{
			int counter = 0;

			foreach (char i in charList) 
			{
				if (i == character) ++counter;
			}

			return counter;
		}

		static void Main (string[] args)
		{
			int testCase = Convert.ToInt32(Console.ReadLine());
			string rowChair = Console.ReadLine();
			char[] typeChairs = rowChair.ToCharArray();

			int lengthString = rowChair.Length;
			int counterL = charCounter(typeChairs, 'L');

			int ans = (lengthString - counterL) + counterL / 2;
			ans = counterL > 0 ? ans + 1 : ans;

			Console.WriteLine(ans);

		}
	}
}