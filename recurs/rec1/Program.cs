using System;

namespace rec1
{
    class Program
    {
        static int Sum(int[] Array, int i = 0)
        {
            if (i == Array.Length)
            {
                return 0;
            }
            int result = Sum(Array, i + 1);
            return  Array[i] + result;
          
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int diff = Math.Abs(x - y); 
            int [] NewArr = new int[diff + 1];
            for(int i = 0; i < NewArr.Length; i++)
            {
               
                
                NewArr[i] = diff;
                diff++;
            }
            int result = Sum(NewArr);
            Console.WriteLine(result);
        }
    }
}
