using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lesson3;

namespace 贪吃蛇.lesson4
{
    class Wall : GameObject
    {
        public Wall(int x, int y)
        {
            pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x,pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }
    }
}
