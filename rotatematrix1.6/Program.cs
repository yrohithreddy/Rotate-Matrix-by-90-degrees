using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotatematrix1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int N = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[4,4];
            int[,] arra = getArray(a);
            for (int i= 0;i< 4;i++)
            {
                for (int j = 0; j < 4; j++)
                { 
                    Console.Write(arra[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
                
            }
            int[,] arraRotate = methodRotate(arra);

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arraRotate[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
            
        }
        static int[,] getArray(int[,] a)
        {
            bool flag = true;
            int N = a.GetLength(0);
            int i = 0;
            int j = 0;
            int k = 0;
            int value = 0;
            while(flag)
            {
                if ((i == N - 1) && (j == N))
                    flag = false;
                else
                {
                    if(j!=N)
                    {
                        value += 1;
                        a[i,j] = value;
                        j++;
                    }
                    else if (j==N)
                    {
                        k = k + 1;
                        i = k;
                        j = 0;
                    }
                }
            }
            return a;

        }

        static int[,] methodRotate(int[,] a)
        {
            int N = a.GetLength(0);
            int[,] b = new int[N, N];
            bool flag = true;
            
            int i = 0;
            int j = 0;
            int k = 0;
            while(flag)
            {
                if((i==N))
                {
                    flag = false;
                }
                else
                {
                    if(j!=N)
                    {
                        b[i, j] = a[j, (N - (i + 1))];
                        j++;
                    }
                    if(j==N)
                    {
                        k = k + 1;
                        i = k;
                        j = 0;
                    }
                }
            }

            return b;
        }
    }
}
