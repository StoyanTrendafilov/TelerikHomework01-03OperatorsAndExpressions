using System;

class BitCheck
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your number : ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Please, insert bit position, you are interested in (start counting from zero) : ");
        int bit = int.Parse(Console.ReadLine());
        bool bitCheck = ( ((number & (1 << bit)) >> bit) == 1);
        Console.WriteLine("It is {0}, that the bit on the position, you were interested in, is \"1\".", bitCheck);
    }
}

