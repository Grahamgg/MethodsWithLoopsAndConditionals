using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printrangez(1000, -1000);
            Threecount();
            equalCheck();
            evenCheck();
            positivecheck();
            voteCheck();
            tencheck();
            multitable();
        }

        public static void Printrangez(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void Threecount()
        {
            for (int i = 3; i <= 999; i += 3)
                Console.WriteLine(i);


        }


        public static void equalCheck()
        {
            Console.WriteLine("Write a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write another number");
            int num2 = int.Parse(Console.ReadLine());

            if 
                (num1 == num2)
                Console.WriteLine("These numbers are equal");

            else Console.WriteLine("These numbers aren't equal you idiot");
            


        }

        public static void evenCheck()
        {
            Console.WriteLine("Write a number");
            int oddz = int.Parse(Console.ReadLine());

            if (oddz % 2 == 0 )
                Console.WriteLine("This number is even hooray!");

            else Console.WriteLine("This number is odd and terrible!");
        }
        
        public static void positivecheck()
        {
            Console.WriteLine("Write another number you pleb");
            int pCheck = int.Parse(Console.ReadLine());

            if (pCheck > 0)
                Console.WriteLine("This number is positive.");

            else Console.WriteLine("This number is negative and lame");
        }

        public static void voteCheck()
        {
            Console.WriteLine("Write your age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You can vote hooray!");

            else Console.WriteLine("You cant vote lmao");
        }

        public static void tencheck()
        {
            Console.WriteLine("Write yet another number");
            int tCheck = int.Parse(Console.ReadLine());

            if (tCheck >= -10 && tCheck <= 10)
                Console.WriteLine("This number is between -10 & 10");

            else Console.WriteLine("This is a stupid number");

        }

        public static void multitable()
        {
            Console.WriteLine("Write another number lol");
            int mNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * mNum);
            }
            

        }


    }
}
