using System;

class Prime
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert number, smaller or equal to 100: ");
        int number = int.Parse(Console.ReadLine());
        bool numberCheck = number <= 100; // защото условието е да е по-малко от 100. Иначе си работи без грешка и за числата над 100, ако се махне условието
        if (numberCheck) //                    поне до коклото съм го проверил  на ръка :) 
        {
            bool prime = ((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0))
                            || ((number == 2) || (number == 3) || (number == 5) || (number == 7));
            if (prime)
                Console.WriteLine("Your number is prime!");
            else
                Console.WriteLine("Your number is NOT prime !");
        }
        else
            Console.WriteLine("Your number is larger than 100, have a nice day:)");
    }
}

