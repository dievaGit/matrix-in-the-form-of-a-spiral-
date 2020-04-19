using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            int n = 0, m = 0,  top= 0, num = 1;
            int beguin = 0, i = 0, j = 0;

            //Requesting the number of numbers 
            Console.Write(" Enter the matrix dimention: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            int[,] matrix = new int[n,n];
            top = n * n;

            //Building matrix
            while(num <= top)
            {
                for (j = beguin; j < n; j++)
                {
                    if(num <= top)
                    {
                        matrix[i, j] = num;
                        num++;
                    }
                    else
                    {
                        break;
                    }
                    
                }

                for (i = beguin + 1; i < n; i++)
                {
                    if (num <= top)
                    {
                       matrix[i, j - 1] = num;
                       num++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (j = n - 1; j > beguin; j--)
                {
                    if (num <= top)
                    {
                       matrix[i - 1,j - 1] = num;
                       num++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (i = n - 1; i > beguin + 1; i--)
                {
                    if (num <= top)
                    {
                       matrix[i - 1, j] = num;
                       num++;
                    }
                    else
                    {
                        break;
                    }
                }

                beguin++;
                n--;
            }

            //Showing matrix
            for (int a = 0; a < m; a++)
            {
                for (int b = 0; b < m; b++)
                {
                    Console.Write(" {0} ", matrix[a, b]); 
                }
                Console.Write("\n");
            }           
         
            Console.ReadKey();

        }
    }
}
