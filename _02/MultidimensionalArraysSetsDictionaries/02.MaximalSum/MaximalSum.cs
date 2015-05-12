using System;

class MaximalSum
{
    static int[,] ReadMatrix(int n, int m)
    {
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] inputNumber = Console.ReadLine().Split();

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(inputNumber[j]);
            }
        }
        return matrix;
    }

    static void MaxSum(int[,] matrixChk)
    {
       
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrixChk.GetLength(0) - 2; row++)
            for (int col = 0; col < matrixChk.GetLength(1) - 2; col++)
            {
                int sum = matrixChk[row, col] 
                    + matrixChk[row, col + 1]
                    + matrixChk[row,col+2]
                    + matrixChk[row + 1, col] 
                    + matrixChk[row + 1, col + 1]
                    + matrixChk[row + 1, col+2]
                    + matrixChk[row + 2, col]
                    + matrixChk[row + 2, col+1]   
                    + matrixChk[row + 2, col+2];
                if (sum > bestSum)
                    bestSum = sum;
                bestRow = row;
                bestCol = col;
            }
        Console.WriteLine("Sum = {0}",bestSum);
        //Console.WriteLine(bestRow);
        //Console.WriteLine(bestCol);
        Console.WriteLine("  {0} {1} {2}",

                             matrixChk[bestRow, bestCol-1],

                             matrixChk[bestRow, bestCol],
                             matrixChk[bestRow,bestCol + 1] );
        Console.WriteLine("  {0} {1} {2}",
                              matrixChk[bestRow + 1,bestCol-1],  
                              matrixChk[bestRow + 1, bestCol],
                              matrixChk[bestRow + 1, bestCol + 1]);
        Console.WriteLine("  {0} {1} {2}",
                             matrixChk[bestRow + 2, bestCol - 1],
                             matrixChk[bestRow + 2, bestCol],
                             matrixChk[bestRow + 2, bestCol + 1]);
                           

       
    }


    static void PrintMatrix(int n,int m , int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        string[] size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);
        int[,] matrix = ReadMatrix(n, m);
        MaxSum(matrix);
       

    }
}

