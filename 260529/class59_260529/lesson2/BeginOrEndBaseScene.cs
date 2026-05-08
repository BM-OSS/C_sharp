using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lensson1;

namespace 贪吃蛇.lesson2
{
    abstract class BeginOrEndBaseScene : ISceneUpdate
    {
        protected string strTitle;
        protected string strOne;
        protected string strPrompt;
        protected int nowSelIndex=0;

        public abstract void EnterJDoSomting();

        public void Update()
        {
            //开始和结束场景的逻辑
            //选择当前的选项 然后 监听 键盘的输入值
            Console.ForegroundColor = ConsoleColor.White;


            //显示标题(和提示词)
            Console.SetCursorPosition(Game.w / 2-strTitle.Length,22);
            Console.Write(strTitle);
            Console.SetCursorPosition(Game.w / 2 - 7, 23);
            Console.Write(strPrompt);

            //显示下方的选项
            Console.SetCursorPosition(Game.w / 2 - strOne.Length,28);
            Console.ForegroundColor = nowSelIndex==0? ConsoleColor.Red: ConsoleColor.White;
            Console.Write(strOne);

            Console.SetCursorPosition(Game.w / 2 - 4, 30);
            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");
            //检测输入
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --nowSelIndex;
                    if (nowSelIndex < 0)
                    {
                        nowSelIndex = 0;
                    }
                    break;
                case ConsoleKey.S:
                    ++nowSelIndex;
                    if (nowSelIndex > 1)
                    {
                        nowSelIndex = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomting();
                    break;
            }
        }
    }
}
