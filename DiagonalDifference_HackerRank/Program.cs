using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> array = new List<List<int>>();
            List<int> r1 = new List<int>();
            r1.Add(11);
            r1.Add(2);
            r1.Add(4);
            array.Add(r1);
            List<int> r2 = new List<int>(); 
            r2.Add(4);
            r2.Add(5);
            r2.Add(6);
            array.Add(r2);
            List<int> r3 = new List<int>();
            r3.Add(10);
            r3.Add(8);
            r3.Add(-12);
            array.Add(r3);
            int x = diagonalDifference(array);
            Console.WriteLine(x);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int countx = 0;
            for (int i = 0; i < arr[0].Count; i++)
            {
                for (int j = i; j < arr[1].Count; j++)
                {
                    countx += arr[i][j];
                    break;
                }
            }
            int county = 0;
            for (int i = 0; i < arr[0].Count; i++)
            {
                for (int j = 0; j < arr[1].Count; j++)
                {
                    if ((i + j) == arr[0].Count - 1)
                    {
                        county += arr[i][j];
                    }
                }
            }
            int res = Math.Abs(countx - county);
            return res;
        }
    }
}
