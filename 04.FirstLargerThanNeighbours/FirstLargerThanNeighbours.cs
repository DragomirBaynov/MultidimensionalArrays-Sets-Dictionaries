using System;
using System.Diagnostics;

class FirstLargerThanNeighbours
{
    static int IsLargerThanNeighbours(int[] input)
    {
        int index = 0;
        bool result = false;
        int n = 0;
        for (int i = 0; i < input.Length; i++)
        {


            if (i > 0 && i < input.Length - 1)
            {
                index = i;

                if (input[i] > input[i - 1] && input[i] > input[i + 1])
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            else if (i == 0)
            {
                if (input[i] > input[i + 1])
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            else if (i == input.Length)
            {
                if (input[i] > input[i - 1])
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                    
                }
            }
        }
        if (result)
        {
            n = index;
        }
        else
        {
            n = -1;
        }
        return n;
    }


    static void Main()
    {
        int[] secqunceOne = {1, 3, 4, 5, 1, 0, 5};
        int[] sequnceTwo = {1, 2, 3, 4, 5, 6, 6};
        int[] sequnceThree = {1, 1, 1};
        Console.WriteLine(IsLargerThanNeighbours(secqunceOne));
        Console.WriteLine(IsLargerThanNeighbours(sequnceTwo));
        Console.WriteLine(IsLargerThanNeighbours(sequnceThree));

    }
}

