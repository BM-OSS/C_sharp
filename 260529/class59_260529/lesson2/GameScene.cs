using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using 贪吃蛇.lensson1;
using 贪吃蛇.lesson4;
using 贪吃蛇.lesson5;
using 贪吃蛇.lesson6;

namespace 贪吃蛇.lesson2
{
    class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;

        //申明一个计数的变量，可以减缓蛇移动的速度
        int updateIndex = 0;

        public GameScene()
        {
            map = new Map();
            snake = new Snake(30,25);
            food = new Food(snake);
        }

        public void Update()
        {
            
            if (updateIndex % 12000 == 0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();

                //检测是否撞墙
                if (snake.CheckEnd(map))
                {
                    //如果if为真则执行结束逻辑
                    Game.ChangScene(E_SceneType.End);
                }
                snake.CheckEatFood(food);

                updateIndex = 0;
            }
            ++updateIndex;

            //在控制台中检测玩家输入 让程序不被卡住
            if (Console.KeyAvailable)
            {
                //检测输入输出不能用间隔帧来检测，应该实时检测
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                }
            }

            
        }
    }
}
