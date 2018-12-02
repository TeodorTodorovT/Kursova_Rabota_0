using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Convert 2081 to binary, octal and hexadecimal numbers.
            Console.WriteLine("All convertions are done as follows:\n1.Divide the decimal number by the desired target radix (2, 8, or 16).\n2.Append the remainder as the next most significant digit.\n3.Repeat until the decimal number has reached zero.");
            Console.WriteLine("\n2081 / 2  result  1040    remainder   1\n1040 / 2  result  520     remainder   0\n520 / 2   result  260     remainder   0\n260 / 2   result  130     remainder   0\n130 / 2   result  65      remainder   0\n65 / 2    result  32      remainder   1\n32 / 2    result  16      remainder   0\n16 / 2    result  8       remainder   0\n8 / 2     result  4       remainder   0\n4 / 2     result  2       remainder   0\n2 / 2     result  1       remainder   0\n1 / 2     result  0       remainder   1");
            Console.WriteLine("2081 in binary is 100000100001.");
            Console.WriteLine("\n2081 / 8   result  260 remainder   1\n260 / 8  result  32  remainder   4\n32 / 8   result  4   remainder   0\n                                 4");
            Console.WriteLine("2081 in octal is 4041");
            Console.WriteLine("\n2081 / 16  result  130 remainder   1\n130 / 16 result  8   remainder   2\n8 / 16   result  0   remainder   8");
            Console.WriteLine("2081 in hex is 821");
            Console.ReadLine();
            //All of this can also be done with code! Example:
            Console.WriteLine("All of this can also be done with code! Example:");
            Console.Write("Enter decimal number: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.",deci, deci.ToString("X"));
            Console.ReadLine();
        }
    }
}
