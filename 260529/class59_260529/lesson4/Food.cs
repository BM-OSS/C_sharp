using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using 贪吃蛇.lensson1;
using 贪吃蛇.lesson3;
using 贪吃蛇.lesson6;
namespace 贪吃蛇.lesson4
{
    class Food : GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("¤");
        }
        //随机位置的行为和蛇的位置是有关系的
        public void RandomPos(Snake snake)
        {
            //随机位置
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            pos = new Position(x,y);
            //得到蛇
            //如果重合，就会进入if语句进行递归方法的调用
            if (snake.CheckSamePos(pos))
            {
                RandomPos(snake);               
            }

        }

    }


}
