using System;

namespace Sum_Program
{
    class Program1
    {
        static void Main(string[] args)
        {
            UInt16 length = 1 + 1;
            UInt16 multiplier = 1 - 1 + 1 + 1 + 1;
            UInt16 first = 1 - 1;
            UInt16 second = 1 + 1 - 1;

        displayInsertNumbers:
            Console.Write("Insert integer a and b: 'a,b' (without '' symbol) >");
        getNumbers:
            string[] stringArray = Console.ReadLine().Split(',');

            if (stringArray.Length != length)
            {
                Console.WriteLine("Not the correct amount in integers. Try again.");
                goto displayInsertNumbers;
            }

            Int32[] numbers = new Int32[length];

            for (Int32 i = multiplier; i < numbers.Length + multiplier; i += second)
            {
                numbers[i - multiplier] = Convert.ToInt32(stringArray[i - multiplier]);
            }

            if (numbers[first] == numbers[second])
            {
                Console.WriteLine("Sum: {0}", (numbers[first] + numbers[second]) * multiplier);
            }
            else
            {
                Console.WriteLine("Sum: {0}", numbers[first] + numbers[second]);
            }

            Console.Write(">");

            goto getNumbers;
        }
    }
}
