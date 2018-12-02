using System;


namespace Task6
{
    class Program
    {   
        //Да се състави метод за проверка дали даден текст може да се интерпретира като реално число в определен интервал.

        static void Main(string[] args)
        {
            Console.Write("Please enter a whole number from -100,000 to 100,000: ");
            string num = Console.ReadLine();
            //Console.WriteLine(IsNumber(num));
            if (IsNumber(num))
            {
                Console.WriteLine("Good job!");
            }
            else {
                Console.WriteLine("You've messed up!");
            }
            Console.ReadLine();
        }

        public static bool IsNumber(string num)
        {

            if (String.IsNullOrEmpty(num))
                return false;

            int i;
            return int.TryParse(num, out i);

        }
}
    }

