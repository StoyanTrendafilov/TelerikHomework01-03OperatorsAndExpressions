using System;


class Checking
    {
        static void Main(string[] args)
        {
            Console.Write("Please, insert you digit: ");
            int number = int.Parse(Console.ReadLine());
            bool check1 = (number % 7 == 0);
            bool check2 = (number % 5 == 0);
            bool passed = (check1 && check2);
            if (passed == true)
                Console.WriteLine("The number, you have entered, can be divided to 7 and 5 without reminder"); 
            else
                Console.WriteLine("The number, you have entered, can not be devided to 7 and 5 without reminder");
        }
    }

    