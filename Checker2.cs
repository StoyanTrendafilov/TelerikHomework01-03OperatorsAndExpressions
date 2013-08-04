using System;

class Checker
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your digit: ");
        int number = int.Parse(Console.ReadLine());
        if (((number % 1000) / 100) == 7)
            Console.WriteLine("The third digit of yout number IS 7 ! ");
        else
            Console.WriteLine("The third digit of your number is NOT 7 !");
    }
}

