using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey
{
    class Line
    {
        public List<Point> pList = new List<Point>();

        public Line(int x, int y, int lenght, Direction d, char s) 
        {
            Point p = new Point(x, y, s);
            
            pList.Add(p);
            switch (d)
                {
                    case Direction.RIGHT:            
                                      
                    case Direction.LEFT:
                    case Direction.UP:
                    case Direction.DOWN:
                    default: break;                    
                }
        }
    }
}
