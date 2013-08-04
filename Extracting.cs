using System;

class Extracting
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please, insert the bit position,you are interested in, starting from zero(0): ");
        int position = int.Parse(Console.ReadLine());
        int bit = (((1 << position) & number) >> position);
        Console.WriteLine("The bit value of the position, you have asked for, is: " + bit);
    }
}

