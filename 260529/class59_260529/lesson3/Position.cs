using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇.lesson3
{
    struct Position
    {
        public int x; 
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //贪吃蛇中 肯定是存在位置比较
        //各个游戏对像 都会比较位置是否相互重合

        public static bool operator ==(Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x != p2.x || p1.y != p2.y)
            {
                return true;
            }
            return false;
        }

    }
}
