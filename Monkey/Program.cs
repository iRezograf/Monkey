using System;

namespace Monkey
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello Monkey!");
            
            Point p = new Point(20,20,'!');
            p.Draw();
            Console.Read();
        }
    }
}
