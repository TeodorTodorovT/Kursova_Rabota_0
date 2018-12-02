using System;
using System.IO;
namespace Task5
{
    class Program
    {   //Да се състави програма, в която:
        //  а) се дефинира метод cor(x,y)=(.....) при х!=-у и cor(x,y)=0 в противен случай;
        //  б) се въвеждат 2 цели числа p и q в интервал [-30,30]
        //  в) се изчислява и отпечатва на екрана стойността на израза (.....)
        //  г) се извеждат на екрана тези стойности на редицата cor(p,10), cor(p,14),...,cor(p,50), които са четни цели числа.
        private static double Cor(int x, int y) { return (Math.Abs(x) + Math.Abs(y)) ; }
        static void Main(string[] args)
        {
            int p, q;
            do
            {
                Console.Write("[-30;30]p=");
                p = int.Parse(Console.ReadLine());
            } while (p<-30||p>30);
            do
            {
                Console.Write("[-30;30]q=");
                q = int.Parse(Console.ReadLine());
            } while (q<-30||q>30);
            Console.WriteLine("Solution: " + (Cor(p, 3 * q) - Cor(3 * p, q)) / Cor(p, q));
            for (p= -30; p <=30; p+=3)
            {
                double s = Cor(p,q);
                if (s - (int)s == 0 && (int)s % 2 == 0)
                    Console.WriteLine("cor(" + p + ',' + q + ")=" + s);
            }
            Console.ReadLine();
        }
    }
}
