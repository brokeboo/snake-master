using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            horizontallLine upLine = new horizontallLine(0, 78, 0, '+');
            horizontallLine downLine = new horizontallLine(0, 78, 24, '+');
            verticalLine leftLine = new verticalLine(0, 24, 0, '+');
            verticalLine rightLine = new verticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //отрисовка точек
            point p = new point(4, 5, '*');
            snake snake = new snake(p, 4, direction.RIGHT)
            
        }
    }
} 
  