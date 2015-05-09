using System;

    class BiggerNumber
    {
        static int GetMax(int a, int b)
        {
            int larger = int.MaxValue;

            if (a>b)
            {
                larger = a;
            }
            else
            {
                larger = b;
            }

            return larger;

        }

        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }
    }

