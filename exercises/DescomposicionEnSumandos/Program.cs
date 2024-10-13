namespace MOG
{
    class Descomposition
    {
        public static int count = 1;

        public static void AllSums(int number)
        {
            if (number == 0)
                count ++;
            else
            {
                for (int i=1;i<=(number+1)/2;i++)
                    AllSums(number-i);
            }
        }

        public static int Counter(int number)
        {
            AllSums(number);
            return count;
        }

        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Counter(number));
        }
    }
}