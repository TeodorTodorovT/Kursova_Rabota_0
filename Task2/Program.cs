using System;

namespace Task2
{
    class Program
    {   // Да се напишат като аритметични изрази на езика C# следните алгебитрични изрази
        //  г)(.......)
        static void Main(string[] args)
        {
            Console.Write("x="); int x = int.Parse(Console.ReadLine());
            Console.Write("y="); int y = int.Parse(Console.ReadLine());
            Console.Write("a="); int a = int.Parse(Console.ReadLine());
            Console.Write("b="); int b = int.Parse(Console.ReadLine());
            Console.Write("z="); int z = int.Parse(Console.ReadLine());
            int t = (y + 6 * a - 2 / 3 * (x + 6));
            int q = t * t * t * t * t * t; //Math.Pow not working properly
            int w = q - z / z + 7 * b;
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
