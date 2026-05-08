using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lensson1;
using 贪吃蛇.lesson3;

namespace 贪吃蛇.lesson4
{
    /// <summary>
    /// 蛇的身体类型枚举
    /// </summary>
    enum E_SnakeBody_Type
    {
        Head,
        Body,
    }
    class SnakeBody : GameObject
    {
        private E_SnakeBody_Type type;
        public SnakeBody(E_SnakeBody_Type type,int x,int y)
        {
            this.type = type;
            this.pos = new Position(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == E_SnakeBody_Type.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == E_SnakeBody_Type.Head ? "●" : "◎");

        }
    }
}
