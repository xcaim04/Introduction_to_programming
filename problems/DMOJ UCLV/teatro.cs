using System;

namespace Teatro
{
	public class Program 
	{
		static string sortChair (string rowChair)
		{
			string ans = "*";
			foreach (string i in rowChair) 
			{
				if (i == 'L') continue;
				ans += '*';
				ans += i;
			}
			ans += "*";
			return ans;
		}

		static void Main (string[] args)
		{
			int testCase = Convert.ToInt32(Console.ReadLine());
			string rowChair = Console.ReadLine();
			string rowChairSorted = sortChair(rowChair);

			Console.WriteLine(rowChairSorted);

		}
	}
}