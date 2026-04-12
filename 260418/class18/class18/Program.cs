using System;
using System.Numerics;


namespace class18
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;

            //通过两个变量来存储 舞台的大小
            int w = 80;
            int h = 45; 

            //设置舞台（控制台）的大小
            Console.SetWindowSize(w,h);
            Console.SetBufferSize(w,h);
            #endregion
            //结束场景显示的 文字提醒内容根据游戏结局不同而改变
            string gameOverInfo = "";
            #region 多个场景切换
            
            int nowScenID = 1;
            while (true)
            {
                switch (nowScenID)
                {
                    case 1:
                        Console.Clear();
                        #region 开始场景逻辑
                        Console.SetCursorPosition(w / 2 - 6, 15);
                        Console.Write("唐老狮打怪兽");

                        //当前选项的编号
                        int nowSelIndex = 0;



                        //因为要输入，我们可以构造一个 开始界面自己的死循环
                        //专门用来处理 开始场景相关的逻辑
                        while (true)
                        {
                            //显示 内容
                            //先设置光标的的位置 再显示内容
                            bool isQuitWhile = false;

                            Console.SetCursorPosition(w / 2 - 4, 20);
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 23);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            //检测 输入
                            //检测玩家输入的案件内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;

                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;

                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        nowScenID = 2;
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile == true)
                            {
                                break;
                            }
                        }
                        #endregion
                        Console.Clear();
                        break;
                    case 2:
                        
                        #region 不变的红墙（游戏背景）
                        //设置颜色为红色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //画墙
                        //上方墙
                        for (int i = 2; i <= w-2; i+=2)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                        }
                        //中间墙
                        for (int i = 2; i <= w - 2; i += 2)
                        {
                            Console.SetCursorPosition(i, h-13);
                            Console.Write("■");
                        }
                        //下方墙
                        for (int i = 2; i <= w - 2; i += 2)
                        {
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                        }
                        //左边的墙
                        for (int i = 0; i <= h-1; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                        }
                        //右边的墙
                        for (int i = 0; i <= h - 1; i++)
                        {
                            Console.SetCursorPosition(w-2,i);
                            Console.Write("■");
                        }
                        #endregion
                        //游戏场景的死循环 专门用来 检测玩家输入相关的循环
                        #region boss属性相关
                        int bossX = 40;
                        int bossY = 16;
                        int bossAtkMin = 7;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion

                        #region 玩家相关属性
                        int playerX = 6;
                        int playerY = 8;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //玩家一定变量申明
                        char playerInput;
                        #endregion

                        #region 奖励领取相关属性
                        int preciousX = 40;
                        int preciousY = 20;
                        string preciousIcon = "★";
                        ConsoleColor preciousColor = ConsoleColor.Red;
                        
                        #endregion

                        #region 玩家战斗状态
                        //战斗状态
                        bool isFight = false;
                        //游戏结束状态 用来跳出外层循环
                        bool isOver = false;  
                        #endregion
                        while (true)
                        {
                            #region boss显示
                            //绘制boos图标
                            if (bossHp > 0)
                            {
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion

                            #region 奖励领取相关逻辑 
                            else 
                            {
                                Console.SetCursorPosition(preciousX, preciousY);
                                Console.ForegroundColor = preciousColor;
                                Console.Write(preciousIcon);
                            }
                            #endregion

                            //画出玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            
                            
                            //得到玩家输入信息
                            playerInput =Console.ReadKey(true).KeyChar;
                            //判断是否为战斗状态
                            //若是则采用战斗状态逻辑，
                            //若不是则采用移动状态逻辑
                            if (isFight)
                            {
                                //战斗状态逻辑
                                //用“j”键进行判断交互情况
                                if (playerInput == 'J' || playerInput == 'j')
                                {
                                    //在这里判断 玩家或者怪物是否死亡 如果死了
                                    //继续之后的流程
                                    if (playerHp <= 0)
                                    {
                                        //挑战失败
                                        //失败后直接显示游戏结束画面
                                        nowScenID = 3;
                                        gameOverInfo = "游戏失败";
                                        break;
                                    }
                                    else if (bossHp <= 0)
                                    {
                                        //击败boss
                                        //擦除boss
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write(" ");
                                        isFight = false;
                                    }
                                    else 
                                    {
                                        //按“j”进行战斗
                                        //用回合制进行战斗交互
                                        //玩家进攻信息逻辑(随机值判断)
                                        Random r = new Random();
                                        int playerAtk = r.Next(playerAtkMin, playerAtkMax);
                                        bossHp -= playerAtk;
                                        //怪兽随机瞬身移动信息（根据系统时间进行刷新）
                                        //打印信息
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //打印新的战斗交互信息时应该
                                        //先把原有位置的战斗交互信息擦除
                                        Console.SetCursorPosition(2, h - 11);
                                        Console.Write("                                                                            ");
                                        Console.SetCursorPosition(2, h - 11);
                                        Console.Write("你对boss造成了{0}点伤害，boss剩余血量为{1}", playerAtk, bossHp);

                                        //玩家回合结束，判断boss是否死亡
                                        if (bossHp > 0)
                                        {
                                            //boss未死亡进行boss攻击逻辑（随机值）
                                            int bossAtk = r.Next(bossAtkMin, bossAtkMax);
                                            playerHp -= bossAtk;
                                            Console.ForegroundColor = ConsoleColor.Red;

                                            //打印新的战斗交互信息时应该
                                            //先把原有位置的战斗交互信息擦除
                                            Console.SetCursorPosition(2, h - 10);
                                            Console.Write("                                                                            ");
                                            //判断boss是否击败玩家
                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 12);
                                                Console.Write("                                                                            ");
                                                Console.SetCursorPosition(2, h - 11);
                                                Console.Write("                                                                            ");
                                                Console.SetCursorPosition(2, h - 10);
                                                Console.Write("                                                                            ");
                                                Console.SetCursorPosition(w / 2 - 22, h - 10);
                                                Console.Write("很遗憾你失败了，请再得取唐老狮真传，重新挑战");

                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 10);
                                                Console.Write("boss对你造成了{0}点伤害，你剩余血量为{1}", bossAtk, playerHp);

                                            }
                                        }
                                        else
                                        {
                                            //boss死亡后信息交互
                                            //先擦之前的战斗信息交互
                                            //再打印游戏结束后的交互信息
                                            Console.SetCursorPosition(2, h - 12);
                                            Console.Write("                                                                            ");
                                            Console.SetCursorPosition(2, h - 11);
                                            Console.Write("                                                                            ");
                                            Console.SetCursorPosition(2, h - 10);
                                            Console.Write("                                                                            ");
                                            Console.SetCursorPosition(w / 2 - 15, h - 12);
                                            Console.Write("唐老狮战胜了怪兽,请领取奖励");
                                            Console.SetCursorPosition(w / 2 - 12, h - 11);
                                            Console.Write("领取奖励，请按“j”键");


                                        }
                                    } 
                                }
                            }
                            else 
                            {
                                #region 玩家移动相关      
                                //擦除原有信息
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write(" ");


                                //改位置
                                switch (playerInput)
                                {
                                    case 'W':
                                    case 'w':
                                        --playerY;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        //判断边界是否与boss重叠
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0)
                                        {
                                            ++playerY;
                                        }
                                        //判断是否与宝藏重合
                                        else if (playerX == preciousX && playerY == preciousY)
                                        {
                                            ++playerY;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        //判断边界是否与boss重叠
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0)
                                        {
                                            playerX += 2;
                                        }
                                        //判断是否与宝藏重合
                                        else if (playerY == preciousY && playerX == preciousX)
                                        {
                                            playerX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        ++playerY;
                                        if (playerY > h - 14)
                                        {
                                            playerY = h - 14;
                                        }
                                        //判断边界是否与boss重叠
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0)
                                        {
                                            --playerY;
                                        }
                                        //判断是否与宝藏重合
                                        else if (playerX == preciousX && playerY == preciousY )
                                        {
                                            --playerY;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        //判断边界是否与boss重叠
                                        else if (playerY == bossY && playerX == bossX && bossHp > 0)
                                        {
                                            playerX -= 2;
                                        }
                                        //判断是否与宝藏重合
                                        else if (playerY == preciousY && playerX == preciousX)
                                        {
                                            playerX -= 2;
                                        }
                                        break;
                                        break;
                                    case 'J':
                                    case 'j':
                                        //开始战斗模块
                                        //玩家不能移动
                                        //当判断角色在boss
                                        //旁边才能产生交互
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            //状态转换，由游走状态转换为战斗状态
                                            isFight = true;

                                            //战斗信息输出
                                            //用随机值生成
                                            Console.SetCursorPosition(2, h - 12);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("可以开始战斗了，按J键继续");
                                            //这里不能用WriteLine函数，
                                            //用这个函数会把外围环境（墙体破坏）
                                            Console.SetCursorPosition(2, h - 11);
                                            Console.Write("玩家当前血量为{0}", playerHp);
                                            Console.SetCursorPosition(2, h - 10);
                                            Console.Write("玩家当前血量为{0}", bossHp);

                                        }
                                        //判断是否走到宝藏旁边
                                        else if ((playerX == preciousX && playerY == preciousY - 1 ||
                                                  playerX == preciousX && playerY == preciousY + 1 ||
                                                  playerX == preciousX - 2 && playerY == preciousY ||
                                                  playerX == preciousX + 2 && playerY == preciousY) && bossHp <= 0)
                                        {
                                            //改变场景ID
                                            //跳出游戏循环逻辑
                                            nowScenID = 3;
                                            isOver= true;
                                            gameOverInfo = "闯关成功";
                                        }
                                        break;
                                }
                                #endregion
                            }
                            //游戏结束领取奖励后跳出游戏的外层循环后面结束
                            if (isOver)
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(w / 2 - 4, 10);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");
                        //可变内容显示，根据失败或者 成功显示不一样的内容
                        Console.SetCursorPosition(w / 2 - 4, 11);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(gameOverInfo);
                        int nowSelEnddex = 0;
                        while (true)
                        {
                            bool isQuitEndwhile = false;

                            Console.SetCursorPosition(w / 2 - 6, 14);
                            Console.ForegroundColor = nowSelEnddex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到游戏界面");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelEnddex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            int input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelEnddex;
                                    if (nowSelEnddex<0)
                                    {
                                        nowSelEnddex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelEnddex;
                                    if (nowSelEnddex > 1)
                                    {
                                        nowSelEnddex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelEnddex == 0)
                                    {
                                        nowScenID = 1;
                                        isQuitEndwhile = true;
                                    }
                                    else 
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            //为了从switch中跳出while循环
                            if(isQuitEndwhile)
                            {
                                break;
                            }
                        }

                        break;
                }
            }
            #endregion

        }
    }
}