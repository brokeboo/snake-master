using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snak
{
    class snake : Figure
    {
        public snake(point tail, int lenght, int direction)
        {
            for(int i = 0; i < lenght; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }
    }
}
