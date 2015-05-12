using System;

class SequenceInMatrix
{

    static string[,] ReadMatrix(int n, int m)
    {
        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] inputNumber = Console.ReadLine().Split();

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = inputNumber[j];
            }
        }
        return matrix;
    }

    static void PrintMatrix(int n, int m, string[,] matrix)
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

    static string DiagonalChecker(string[,] matrix)
    {
        int index = 0;
        int counter = 0;
        string best = "";

        string result;
        int maxCounter = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
			{
                index = 0;
                counter = 1;               
			     for (int j = 0; j < matrix.GetLength(1); j++)
			    {
                     
                    if (index >= matrix.GetLength(0)-1 || index >= matrix.GetLength(1)-1)
                    {
                        break;
                    }
                    if (matrix[index,index] == matrix[index+1,index+1])
                    {
                        
                        counter++;
                    }
                    index++;
			    }
                 if (counter>maxCounter)
                 {
                     maxCounter = counter;
                     best = matrix[i,i];
                 }

			}
        
        result=""+counter+best;
        return result;
    }

    static string Checker(string[,]matrix)
    {
        string result = "";
        int counter = 1;
        int maxCounter = int.MinValue;
        string best = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            counter = 1; 
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,i] == matrix[i,j])
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                best = matrix[i, i];
                result = "" + counter + best;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string[] size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);
        string[,] matrix = ReadMatrix(n, m);
        
       string resultD =  DiagonalChecker(matrix);
       string check = Checker(matrix);
       if (resultD[0]>check[0])
       {
           for (int i = 0; i <(int)resultD[0]-48; i++)
           {
               Console.Write("{0}, ",resultD.Substring(1));
           }
       }
    }
}

