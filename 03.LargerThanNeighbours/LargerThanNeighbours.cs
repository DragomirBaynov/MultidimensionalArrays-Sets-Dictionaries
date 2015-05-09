using System;

class LargerThanNeighbours
{
    static bool IsLargerThanNeighbours(int[] input, int i)
    {
        bool result=true;
        if (i > 0 && i < input.Length-1)
        {
            if (input[i] > input[i - 1] && input[i] > input[i + 1])
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        else if(i==0)
        {
            if (input[i]>input[i+1])
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        else if(i == input.Length)
        {
            if (input[i]>input[i-1])
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        return result;
    }
    
    static void Main()
    {
        int[] number = {1, 3, 4, 5, 1, 0, 5};
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(number , i));
        }
    }
}

