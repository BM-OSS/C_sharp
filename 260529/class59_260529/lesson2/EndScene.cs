using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lensson1;

namespace 贪吃蛇.lesson2
{
    internal class EndScene : BeginOrEndBaseScene
    {
        public EndScene()
        {
            strTitle = "结束游戏";
            strPrompt = "(按J或j键确定)";
            strOne = "回到开始界面";
        }
        public override void EnterJDoSomting()
        {
            //按J建后处理的逻辑
            if (nowSelIndex == 0)
            {
                Game.ChangScene(E_SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
