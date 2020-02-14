using System;

namespace Sum_Program
{
    class Program
    {
        static void CleanCode(string[] args)
        {
            Console.WriteLine("Indtast tal a og b: 'a, b' (uden '' tegn) >");

            while (true)
            {
                try
                {
                    String[] input = Console.ReadLine().Split(',');
                    if (input.Length < 2)
                    {
                        Console.WriteLine("Try again.");
                    }

                    int a = 0;
                    int b = 0;
                    
                    try
                    {
                        a = Convert.ToInt32(input[0]);
                        b = Convert.ToInt32(input[1]);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("This program only accepts whole numbers");
                    }

                    if (a == b)
                    {
                        Console.WriteLine("Sum: {0}", ((a + b) * 3));
                    }
                    else
                    {
                        Console.WriteLine("Sum: {0}", (a + b));
                    }

                    Console.Write(">");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("lol you failed");
                }
            }
        }
    }
}
