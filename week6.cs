using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 4, 6, 8, 10, };
            int j = 0;
          
            foreach (int i in a)
            {
                j = i + 2;
            }
          
            foreach(int i in a)
            {
                Console.Write(i +"\t");
            }
            Console.ReadLine();
        }
    }
}