//Q1
//namespace Assignment_1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(" write numbers from 1 - 10:");
//            int number = int.Parse(Console.ReadLine());
//            if (number < 1 || number > 10)
//            {
//                Console.WriteLine("wrong number");
//            }
//            if (number % 2 == 0)
//            {
//                Console.WriteLine($"{number} even number");
//            }
//            else
//            {
//                Console.WriteLine($"{number} odd number");
//            }


//        }
//    }
//}

//--------------------------------------------------------------------------------------
//Q2    

//using System.Threading.Channels;

//namespace Assigment1

//{
//    internal class Assignmentanswer
//    {

//        static void Main(string[] args)
//        {
//            int a = 0;
//            int b = 1;
//            Console.WriteLine($"{a}");
//            Console.WriteLine($"{b}");

//            for (int i = 0; i <= 15; i++)
//            {

//                i = a + b;
//                Console.WriteLine(i);
//                a = b;
//                b = i;

//            }
//        }

//    }
//}


//--------------------------------------------------------------------------------------
//Q3
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Math.Pow(2, i); 
//                Console.WriteLine($" {Math.Pow(2, i)}");

//            }




//        }
//    }
//}


//--------------------------------------------------------------------------------------

//Q4
//namespace Assigment1
//{
//    internal class Assignmentanswer 
//    {
//        static void Main(string[] args)
//        {

//            int[] numbers = { 12, 45, 6, 88, 31 };

//            int large = numbers[0];


//            foreach (int num in numbers)
//            {
//                if (num > large)
//                    large = num;
//            }


//            Console.WriteLine("largest array:  = " + large);



//        }

//    }
//}

//--------------------------------------------------------------------------------------
//Q5
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            int size = (5);

//            for (int i = 1; i <= 5; i++)
//            {
//                string space = new string(' ', size - i);
//                Console.WriteLine("*****");

//            }
//        }

//    }
//}
//---------------------------------------------------------------------------
//Q6
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Number:");
//            int num= int.Parse(Console.ReadLine());

//            if (num <= 1 )
//            {

//            }


//            }



//        }

//    }
//اكميليها 


//--------------------------------------------------------------------------------------
//Q7    

//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Number:"); 
//            int number = int.Parse(Console.ReadLine());  

//            int sum=1;  

//            for (int i = 0; i <= number; i++) 
//            { 
//                if(number > i) 
//                { 
//                int d = number % 10; 

//                    sum = sum + d;

//                    number = number / 10;


//                }
//            }
//            Console.WriteLine(sum);
//        }

//    }
//}

//------------------------------------------------------------------------------

//Q8
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            string word = "Apple";
//            Console.WriteLine(word);

//            word.Length.ToString();

//            for (int i = word.Length - 1; i >= 0; i--)
//            {
//                Console.Write(word[i]);
//            }


//        }
//    }
//}

//---------------------------------------------------------------------------
//Q9
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter word:");
//            string word = Console.ReadLine();

//            for (int i = 0; i < word.Length; i++)
//            {
//                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' ||
//                    word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
//                {
//                    Console.WriteLine($"{word[i]} is vowel");
//                }
//                else
//                {
//                    Console.WriteLine($"{word[i]} is consonant");
//                }
//            }

//        }
//    }
//}


//------------------------------------------------------------------------------
//Q10
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;

//            for (int i = 1; i <= 100; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    sum = sum + i;

//                }
//            }

//            Console.WriteLine($"The sum of all even numbers from 1 to 100 is : {sum}");



//        }
//    }
//}

//------------------------------------------------------------------------------
//Q11
//namespace Assigment1
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {

//            int number = int.Parse(Console.ReadLine());
//            int fact = 1;

//            for (int i = 1; i <= number; i++)
//            {
//                fact = fact * i;
//            }

//            Console.WriteLine(fact);


//        }
//    }
//}



//--------------------------------------------------------------------------------------
//Q12
//using System.Collections;
//using System.Collections.Immutable;

//namespace AssQ10
//{
//    internal class Assignmentanswer
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 2, 4,8,3,1,5,9 };

//            Array.Sort(numbers);

//            foreach (int num in numbers)

//            {

//                Console.WriteLine(" " + num);
//            }


           
//        }


//    }
//}




