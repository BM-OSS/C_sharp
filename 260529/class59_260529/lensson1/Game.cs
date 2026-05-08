using System;
using System.Collections.Generic;
using System.Text;
using 贪吃蛇.lesson2;
using System.Runtime.InteropServices;
namespace 贪吃蛇.lensson1
{
    /// <summary>
    /// 场景类型枚举
    /// </summary>
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End,
    }

    class Game
    {
        //定义两个变量w,h来表示宽，高
        public static int w;
        public static int h;

        //当前选中的场景
        public static ISceneUpdate nowScene;

        public Game()
        {
            Console.CursorVisible = false;
            int wInfo = Console.LargestWindowWidth;
            int hInfo = Console.LargestWindowHeight;
            if (wInfo % 2 != 0)
            {
                wInfo -= 1;
            }
            Console.SetWindowSize(wInfo, hInfo);
            Console.SetBufferSize(wInfo, hInfo);
            ChangScene(E_SceneType.Begin);


            //获取游戏窗口的宽高
            w= Console.WindowWidth;
            h= Console.WindowHeight;
            
        }
        //游戏开始的方法
        public void Start()
        {
            //游戏主循环 主要负责 游戏场景的逻辑更新
            while (true)
            {
                //判断当前游戏场景不为空 就更新
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }
        public static void ChangScene(E_SceneType type)
        {
            //切换场景之前先擦掉以前的场景
            Console.Clear();
            switch (type)
            {
                case E_SceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    nowScene = new GameScene();
                    break;
                case E_SceneType.End:
                    nowScene = new EndScene();
                    break;
            }
        }


    }
}
