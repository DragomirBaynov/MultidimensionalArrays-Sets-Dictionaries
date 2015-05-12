using System;

class FillTheMatrix
{
    static void PrintMatrix(int n ,int[,] matrix)
    {
        for (int i = 0; i < n; i++)
			{
			     for (int j = 0; j < n; j++)
			    {
			        Console.Write("{0,4}",matrix[i,j]);
			    }
                 Console.WriteLine();
			}
    }
    
    static int[,] FillMatrixA(int n)
    {
        int[,] matrix = new int[n, n];
        int index = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = +index;
                index++;
            }

        }

        return matrix;
    }

    static int[,] FillMatrixB(int n)
{
    int[,] matrix = new int[n, n];
        int index = 1;
        int changer = 1;
        

        for (int i = 0; i < n; i++)
        {
            if (changer%2 == 0 )
            {
                index = (index-1) + n;

                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = +index;                    
                    index--;
                }
                index = (index+1) + n;
                changer++;
            }
            else
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = +index;
                    index++;
                   
                }
                changer++;
            }
        }

        return matrix;


}

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string pattern = Console.ReadLine();

        if (pattern[0]=='A')
        {
            PrintMatrix(n, FillMatrixA(n));
            
        }
        if (pattern[0]=='B')
        {
            PrintMatrix(n, FillMatrixB(n));
           
        }
       
    }
}

