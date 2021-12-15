using System;

namespace recurs
{
    class Program
    {
        static void Foo(int a, int b)
        {
            Console.Write(a + " ");
          
            if (a >= b)
                return;
            a++;
            Foo(a,b);
        }
        
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            Foo(a: x, b: y);   
        }
    }
}
