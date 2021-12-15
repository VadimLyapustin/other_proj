using System;

namespace lessons___massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row a columns of massive : ");
            string[] s = Console.ReadLine().Split();
            int r = int.Parse(s[0]);
            int c = int.Parse(s[1]);
            Random rand = new();
            int[,] MyArray = new int[r, c];
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {
                    MyArray[i, j] = rand.Next(1, 20);
                    Console.Write(MyArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = MyArray[0, 0];
            for (int i = 0; i < r; i++)
            {

                for (int j = 1; j < c; j++)
                {
                    
                    if(MyArray[i,j] > max)
                    {
                        max = MyArray[i, j];
                    }

                }
            }
            Console.Write(max);
        }
    }
}
