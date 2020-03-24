using System;

namespace Monkey
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello Monkey!");
            
            Point p = new Point(20,20,'*');
            p.Draw();
            Console.Read();
            Line line;
            line = new Line(p, 15, Direction.RIGHT);
            line.Draw();
            line = new Line(p, 15, Direction.UP);
            line.Draw();
        }

    }
}
