using System;


// Error in input :)
// try input:


//4 5          //n,m
//1 5 5 2 4     //Matrix
//2 1 4 14 3
//3 7 11 2 8
//4 8 12 16 4   //end of Matrix
//swap x1 y1 x2 y2  //command
 

class MatrixShuffling
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

    static int[,] Swap(int x1, int y1, int x2, int y2,int[,]matrix)
    {
        int temp1 = 0;
        int temp2 = 0;
        temp1 = matrix[x1, y1];
        temp2 = matrix[x2, y2];
        matrix[x1, y1] = temp2;
        matrix[x2, y2] = temp1;
        return matrix;
    }

    static void PrintMatrix(int n, int m, int[,] matrix)
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

    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);
        int[,] matrix = ReadMatrix(n, m);
        while (true)
        {
            string[] command = Console.ReadLine().Split();
            
            if (command[0] =="END" )
            {
                break;
            }

            if (command[0] == "swap" && command[1].StartsWith("x")
            && command[2].StartsWith("y") && command[3].StartsWith("x")
            && command[4].StartsWith("y"))
            {
                string temp = command[1]+command[2]+command[3]+command[4];
                char[] coordinates =temp.ToCharArray() ;
                int x1 = (int)(coordinates[1] - 48);
                int y1 = (int)(coordinates[3] - 48);
                int x2 = (int)(coordinates[5] - 48);
                int y2 = (int)(coordinates[7] - 48);


                int[,] modMatrix = Swap(x1, y1, x2, y2, matrix);
                PrintMatrix(n, m, modMatrix);
 
               // Console.WriteLine("{0} {1} {2} {3}",x1,y1,x2,y2 );
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        

    }
}

