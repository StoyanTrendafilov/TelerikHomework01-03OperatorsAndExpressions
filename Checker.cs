using System;

class Checker
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert one number: ");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        { // Тук не е задължително поставянето на "{" , защото кодът след условието е само един ред. Все пак така е по-четимо. Това важи и за затварящата скоба, както и за частта след else
            Console.WriteLine("The number, you have enteres, is even");
        }
        else
        {
            Console.WriteLine("The number, you have enteres, is odd");
        }
    }
}

