namespace AssQ10
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of all even numbers from 1 to 100: " + sum);
        }
    }
}
