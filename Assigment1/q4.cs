namespace Assigmentq4

{
    internal class q4
    {
        static void Main(string[] args)
        {
            
                
                int[] numbers = { 12,45,6,88,31};

              
                int large = numbers[0];

               
                foreach (int num in numbers)
                {
                    if (num > large)
                        large = num;
                }

            
            Console.WriteLine("largest array:  = " + large);

                
            
        }
    
    }
}
