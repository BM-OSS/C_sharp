using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lensson1;

namespace 贪吃蛇.lesson2
{
    internal class BeginScene : BeginOrEndBaseScene
    {
        public BeginScene() 
        {
            strTitle = "贪吃蛇";
            strPrompt = "(按J或j键确定)";
            strOne = "开始游戏";
        }

        public override void EnterJDoSomting()
        {
            //按J建后处理的逻辑
            if (nowSelIndex == 0)
            {
                Game.ChangScene(E_SceneType.Game);
            }
            else 
            {
                Environment.Exit(0);
            }
        }
    }
}
