using System.Globalization;
using System.Runtime.InteropServices;
using System;
using System.Numerics;
using static Program;
using static csqaralama.Program;

namespace csqaralama;


partial class Program
{
    
    static void Main(string[] args)
    {
        int n = 0;

        int[,] M = new int[5,5];
        int sum = 0;
        for (int i = 0; i < 5; i++) {
            int rowSum = 0;
            for (int j = 0; j < 5; j++) {
                M[i, j] = Random.Shared.Next(1, 10);
                Console.Write(M[i, j]+"\t");
                rowSum += M[i, j];
               }

            Console.WriteLine();
            if (rowSum > sum)
            {
                sum = rowSum;
                n = i;
            }
        }
        Console.WriteLine();
        for(int i = 0;i < 5;i++) {
            Console.Write(M[n,i]+"\t");
        }
        Console.WriteLine(sum);



    }
}

