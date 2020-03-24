using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey
{
    class Point : Figure
    {
        public int x;
        public int y;
        public char s;
        
        /*
        public Point(Point p) 
        {
            x = p.x;
            y = p.y;
            s = p.s;
            
        }
        */

        public Point(int x, int y, char s) 
        {
            this.x = x;
            this.y = y;
            this.s = s;
            pList = new List<Point>();
            pList.Add(this);
            Head = this;
        }

        public Point Move(int shift, Direction d)
        {
            Point p = new Point(this.x, this.y, this.s);            
            switch (d) 
            {
                case Direction.RIGHT:   p.x += shift; break;
                case Direction.LEFT:    p.x -= shift; break;
                case Direction.UP:      p.y -= shift; break;
                case Direction.DOWN:    p.y += shift; break;
                default: break;                       
            }           
            return p;
        }
        public void Draw() 
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.s);
        }
    }
}
