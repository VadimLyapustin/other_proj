using System;

namespace methods
{
    class Program
    {
        static int str(int n, int num, int [] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 10);
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                
                if(num == arr[i])
                {
                    return i; 
                }
                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter lenght of massive : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter other number : ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int result = str(n, num, arr);
            Console.WriteLine("\n"+result);
        }
    }
}
