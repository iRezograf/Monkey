using System;
using System.Collections.Generic;
using System.Text;

namespace Monkey
{
    class Line : Figure
    {
        //public List<Point> pList = new List<Point>();

        public Line(Point p, int lenght, Direction d) 
        {
            //Head = p;
            pList = new List<Point>();
            //pList.Add(Head);
            for (int i = 1; i <= lenght; i++ ) 
            {
                switch (d)
                {
                    case Direction.RIGHT: pList.Add( Head = p.Move(i, Direction.RIGHT) ); break;
                    case Direction.LEFT : pList.Add( Head = p.Move(i, Direction.LEFT)  ); break;
                    case Direction.UP   : pList.Add( Head = p.Move(i, Direction.UP)    ); break;
                    case Direction.DOWN : pList.Add( Head = p.Move(i, Direction.DOWN)  ); break;
                    default: Head = p; break;
                }
                pList.Add( Head );  
                
            }            
        }

        public void Draw() 
        {
            foreach (Point p in pList) p.Draw();
        }
    }
}
