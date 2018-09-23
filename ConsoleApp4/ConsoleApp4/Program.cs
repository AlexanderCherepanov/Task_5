using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");   //decimal separator "."
            Console.Write("Enter the value of the side of the square: ");
            float side = (float.Parse)(Console.ReadLine());
            if (side > 0)
            {
                float Perimeter = side * 4;
                Console.WriteLine($"Perimeter of the square = {Perimeter}");
                float Surface = side * side;
                Console.WriteLine($"Surface of the square = {Surface}");
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
            Console.ReadKey();
        }
    }
}
