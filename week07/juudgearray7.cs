using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[][] a = new int[3][];
            a[0] = new int[4];
            a[1] = new int[3];
            a[2] = new int[2];
          
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the numbers: ");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            int k = 0;
            foreach (int[] x in a)
            {
                Console.Write($"a[{k}] = ");
                foreach (int y in x)
                {
                    Console.Write(y + "\t");
                }
                k++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
