using Microsoft.VisualBasic;

namespace topic_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jonathan
            int number = 29;
            double price = 2.99;
            string yeah = "I am learning a bit about computer sience!";
            string name;
            int grad;
            Console.Title = "My programe is better then Raines";
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("this is room #" + number);
            Console.WriteLine("the price is " + price.ToString("c"));
            Console.WriteLine(yeah);
            Console.WriteLine();
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            name = "jonathan gaboury";
            grad = 2027;
            Console.WriteLine("my name is " + name + " and ill graduate in " + grad);
            

        }
    }
}
