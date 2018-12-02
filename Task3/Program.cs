using System;

namespace Task3
{
    class Program
    {   //Да се състави програма, която по зададен номер на месец отпечатва името на сезона, като декември, януари, февруари са зима, март, април, май - пролет и т.н.
        static void Main(string[] args)
        {
            Console.Write("Enter the number of a month: ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("January is in the winter"); break;
                case 2: Console.WriteLine("February is in the winter"); break;
                case 3: Console.WriteLine("March is in the spring"); break;
                case 4: Console.WriteLine("April is in the spring"); break;
                case 5: Console.WriteLine("May is in the spring"); break;
                case 6: Console.WriteLine("June is in the summer "); break;
                case 7: Console.WriteLine("July is in the summer"); break;
                case 8: Console.WriteLine("August is in the summer"); break;
                case 9: Console.WriteLine("September is in the fall"); break;
                case 10: Console.WriteLine("October is in the fall"); break;
                case 11: Console.WriteLine("November is in the fall"); break;
                case 12: Console.WriteLine("December is in the winter"); break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
