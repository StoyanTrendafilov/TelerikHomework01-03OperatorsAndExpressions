using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.Write("Insert your number :");
        UInt32 number = UInt32.Parse(Console.ReadLine());
        UInt32 mask1, mask2, bit1, bit2;
        int first = 3; int second = 24;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        UInt32 one = 1;
        for (int i = 0; i < 3; i++)
        {
            mask1 = Convert.ToUInt32(one << first + i);
            mask2 = Convert.ToUInt32(one << second + i);

            bit1 = (number & mask1) >> (first + i);
            bit2 = (number & mask2) >> (second + i);

            if (bit1 == 0)
                number = number & (~(one << second + i));                          
            else
                number = (one << (second + i)) | number;

            if (bit2 == 0)
                number = number & (~(one << first + i));                   
            else
                number = (one << (first + i)) | number;
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}

