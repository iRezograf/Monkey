using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey
{
    class Point
    {
        public int x;
        public int y;
        public char s;
        public Point(Point p) 
        {
            x = p.x;
            y = p.y;
            s = p.s;
        }

        public Point(int x, int y, char s) 
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }

        public void Draw() 
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.s);
        }
    }
}
