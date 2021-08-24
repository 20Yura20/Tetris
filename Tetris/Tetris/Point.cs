using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        int x, y;
        char c;

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(c);
        }

        public Point(int x, int y, char c='@')
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
    }
}
