using System;

namespace class32
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.控制台初始化
            int w = 80;
            int h = 45;
            ConsoleInit(w, h);
            #endregion

            #region 2.游戏场景切换相关内容
            E_SceneType nowSceneType = E_SceneType.Begin;
            while (true)
            {
                switch (nowSceneType)
                {
                    case E_SceneType.Begin:
                        //开始场景
                        Console.Clear();
                        BeginOrEndScene(w, h,ref nowSceneType);
                        break;
                    case E_SceneType.Game:
                        //游戏场景
                        Console.Clear();
                        Gamescene(w, h, ref nowSceneType);
                        break;
                    case E_SceneType.End:
                        //结束场景
                        Console.Clear();
                        BeginOrEndScene(w, h, ref nowSceneType);
                        break;
                    default:
                        break;
                }

            }
            #endregion
        }

        #region 1.控制台初始化
        static void ConsoleInit(int w, int h)
        {
            //基础设置
            //光标隐藏
            Console.CursorVisible = false;


            //控制台大小设置
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }
        #endregion

        #region 3.开始场景逻辑+8结束场景逻辑
        static void BeginOrEndScene(int w, int h,ref E_SceneType nowSceneType)
        {
            Console.SetCursorPosition(nowSceneType == E_SceneType.Begin ? w / 2 - 3:w / 2 - 4, 14);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nowSceneType==E_SceneType.Begin?"飞行棋":"结束游戏");
            int nowIndex = 0;

            //离开开始游戏界面的标志位
            bool IsLeave = false;

            while (true)
            {

                Console.SetCursorPosition(nowSceneType == E_SceneType.Begin ? w / 2 - 4:w / 2 - 5, 18);
                Console.ForegroundColor=nowIndex==0? ConsoleColor.Red: ConsoleColor.White;
                Console.Write(nowSceneType == E_SceneType.Begin ? "开始游戏":"回到主菜单");


                Console.SetCursorPosition(w / 2 - 4, 20);
                Console.ForegroundColor = nowIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");

                //按键检测逻辑，根据按下的按键进行判断
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        --nowIndex;
                        if (nowIndex < 0)
                        {
                            nowIndex = 0;
                        }
                        break;
                    case ConsoleKey.S:
                        ++nowIndex;
                        if (nowIndex > 1)
                        {
                            nowIndex = 1;
                        }
                        break;
                    case ConsoleKey.J:
                        if (nowIndex == 0)
                        {
                            //进入游戏
                            nowSceneType = nowSceneType == E_SceneType.Begin ? E_SceneType.Game:E_SceneType.Begin;
                            IsLeave = true;
                        }
                        else
                        {
                            //退出游戏
                            Environment.Exit(0);
                        }
                        break;

                }
                //判断是否离开开始游戏界面
                if (IsLeave)
                {
                    break;
                }


            }
        
        
        }
        #endregion

        #region 游戏场景逻辑
        static void Gamescene(int w,int h,ref E_SceneType nowSceneType)
        {
            //绘制不变的基本信息
            DrawWall(w,h);

            //绘制地图
            Map map = new Map(30, 12, 80);
            map.Draw();



            //绘制玩家
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayer(player, computer, map);

            //游戏是否结束的标志位
            bool isGameOver = false;

            //游戏场景循环
            while (true)
            {
                //之后的游戏逻辑



                //玩家扔骰子逻辑

                //检测输入
                Console.ReadKey(true);
                //扔骰子逻辑
                isGameOver = RandomMove(w, h, ref player, ref computer, map);
                //绘制地图
                map.Draw();
                //绘制玩家
                DrawPlayer(player, computer, map);
                //判断是否要结束游戏
                if (isGameOver)
                {
                    //卡住程序，让玩家按下任意键
                    Console.ReadKey(true);
                    //改变场景ID
                    nowSceneType = E_SceneType.End;
                    //跳出循环
                    break;
                }
                //玩家扔骰子逻辑

                //检测输入
                Console.ReadKey(true);
                //扔骰子逻辑
                isGameOver = RandomMove(w, h, ref computer, ref player, map);
                //绘制地图
                map.Draw();
                //绘制玩家
                DrawPlayer(computer, player, map);
                //判断是否要结束游戏
                if (isGameOver)
                {
                    //卡住程序，让玩家按下任意键
                    Console.ReadKey(true);
                    //改变场景ID
                    nowSceneType = E_SceneType.End;
                    //跳出循环
                    break;
                }
            }




        }



        #endregion

        #region 4.绘制不变的内容
        static void DrawWall(int w,int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //画墙
            //横着的墙
            for (int i = 0; i < w; i += 2)
            {
                //最上面的墙
                Console.SetCursorPosition(i, 0);
                Console.Write("■");

                //最下面的墙
                Console.SetCursorPosition(i, h-1);
                Console.Write("■");

                //中间的墙
                Console.SetCursorPosition(i,h-11);
                Console.Write("■");

                Console.SetCursorPosition(i,h-6);
                Console.Write("■");

            }
            //竖着的墙
            for (int i = 0; i < h; i++)
            {
                //最左边
                Console.SetCursorPosition(0, i);
                Console.Write("■");


                //最右边
                Console.SetCursorPosition(w-2, i);
                Console.Write("■");


            }
            //文字信息
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h-10);
            Console.Write("□:普通格子");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("||:暂停，一回合不动");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●:暂停，炸弹倒退5格");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("¤:时空隧道，随机倒退，暂停，换位置");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("★：玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("▲：电脑");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("◎：玩家和电脑重合");


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始扔骰子");



        }



        #endregion

        #region 7.绘制玩家
        static void DrawPlayer(Player player,Player computer,Map map)
        {
            //重合的时候
            if (player.nowIndex == computer.nowIndex)
            {
                Grid grid = map.grids[player.nowIndex];
                Console.SetCursorPosition(grid.pos.x, grid.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("◎");
            }

            //不重合的时候
            else 
            {
                player.Draw(map);
                computer.Draw(map);
            }


        }
        #endregion

        #region 8.扔骰子函数

        //擦除提示的函数
        static void ClearInfo(int h)
        {
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                             ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                             ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                             ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                                             ");
        }



        /// <summary>
        /// 扔骰子函数
        /// </summary>
        /// <param name="w">窗口的宽</param>
        /// <param name="h">窗口的高</param>
        /// <param name="p">扔骰子的对象</param>
        /// <param name="map">地图信息</param>
        /// <returns>默认返回false，代表没有结束</returns>
        static bool RandomMove(int w,int h,ref Player p, ref Player otherp, Map map)
        {
            //擦掉之前的内容
            ClearInfo(h);

            //根据扔骰子的对象类型 决定信息的颜色
            Console.ForegroundColor = p.type == E_PlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;
            
                
           


            //扔骰子之前判断玩家是否处于暂停状态
            //如果判断出对象为暂停状态，就在提前返回false，不进行扔骰子逻辑了(直接提前截断后面的代码)
            //这样在GameScene函数中就不会进行玩家位置的改变，直接进入另一个对象的扔骰子逻辑了
            if (p.isPause)
            {
                Console.SetCursorPosition(2, h - 5);
                Console.Write("处于暂停点，{0}需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                Console.SetCursorPosition(2, h - 4);
                Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                //停止暂停
                p.isPause = false;
                return false;
            }
            //扔骰子的目的 是改变或者电脑的位置，计算位置的变化

            Random r = new Random();
            int randomNum = r.Next(1, 7);
            p.nowIndex += randomNum;

            //打印扔出的骰子的点数
            Console.SetCursorPosition(2,h-5);
            Console.Write("{0}扔出的点数为{1}",p.type==E_PlayerType.Player?"你":"电脑",randomNum);

            //首先判断是否到达终点了
            
            if (p.nowIndex >= map.grids.Length - 1)
            {
                p.nowIndex = map.grids.Length - 1;
                Console.SetCursorPosition(2, h - 4);
                if (p.type==E_PlayerType.Player)
                {
                    
                    Console.Write("恭喜你到达了终点，游戏结束！");
                    
                }
                else
                {
                    
                    Console.Write("很遗憾，电脑到达了终点，游戏结束！");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("请按任意键退出游戏");
                return true;
            }
            else
            {
                //没有到达终点，就判断当前对象到了一个什么样的格子
                Grid grid = map.grids[p.nowIndex];
                switch(grid.type)
                {
                    case E_GridType.Normal:
                        //什么都不用处理
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了一个安全位置", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Boom:
                        //炸弹格子，倒退5格
                        p.nowIndex -= 5;
                        if (p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了炸弹，倒退5格", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Pause:
                        //暂停一回合
                        //添加一个标志位，表示暂停
                        p.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了暂停点，需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    case E_GridType.Tunnel:
                        //随机
                        //触发，倒退
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}遇到了时空隧道，", p.type == E_PlayerType.Player ? "你" : "电脑");
                        randomNum = r.Next(1, 91);
                        if (randomNum <= 30)
                        {
                            p.nowIndex -= 5;
                            if (p.nowIndex < 0)
                            {
                                p.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退5格");
                        }
                        //触发，暂停
                        else if (randomNum <= 60)
                        {
                            p.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停一回合");
                        }
                        else
                        {
                            int temp = p.nowIndex;
                            p.nowIndex = otherp.nowIndex;
                            otherp.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发位置互换");
                        }
                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("请按任意键，让{0}开始扔骰子", p.type == E_PlayerType.Player ? "电脑" : "你");
                        break;
                    default:
                        break;
                }
            }
            //默认没有结束
            return false;
        }


        #endregion

    }
    #region 2.游戏场景切换相关内容
    enum E_SceneType
    {
        /// <summary>
        /// 开始游戏
        /// </summary>
        Begin,
        /// <summary>
        /// 进行游戏
        /// </summary>
        Game,
        /// <summary>
        /// 结束游戏
        /// </summary>
        End,
    }
    #endregion

    #region 5.格子结构体和格子枚举
    /// <summary>
    /// 格子类型枚举
    /// </summary>
    enum E_GridType
    {
        /// <summary>
        /// 普通格子
        /// </summary>
        Normal,
        /// <summary>
        /// 炸弹格子
        /// </summary>
        Boom,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 时空隧道，随机倒退，暂停，换位置
        /// </summary>
        Tunnel,

    }

    /// <summary>
    /// 位置信息结构体，包含x,y位置
    /// </summary>
    struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct Grid
    {
        //格子的类型
        public E_GridType type;
        //格子的位置
        public Vector2 pos;

        //初始化结构体函数
        public Grid(int x, int y, E_GridType type)
        {
            pos.x = x;
            pos.y = y;
            this.type = type;

        }
        /// <summary>
        /// 构造一个格子选择的函数，根据不同的格子选择不同的分支
        /// </summary>
        public void Draw()
        {
            switch (type)
            {
                case E_GridType.Normal:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(pos.x, pos.y);
                    Console.Write("□");
                    break;
                case E_GridType.Boom:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(pos.x, pos.y);
                    Console.Write("●");
                    break;
                case E_GridType.Pause:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(pos.x, pos.y);
                    Console.Write("||");
                    break;
                case E_GridType.Tunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(pos.x, pos.y);
                    Console.Write("¤");
                    break;
                default:
                    break;
            }
        } 
    }



    #endregion

    #region 6.地图结构体
    /// <summary>
    ///地图结构体
    /// </summary>
    struct Map
    {
        //地图上格子的数组
        public Grid[] grids;
        
        //初始了各个格子的类型和位置
        public Map(int x,int y,int num)
        {
            grids = new Grid[num];

            //用于位置改变计数的变量
            //表示x变化的次数
            int indexX = 0;

            //表示y变化的次数
            int indexY = 0;

            //声明一个步长
            int stepNum = 2;


            Random r = new Random();
            int randomNum;
            for (int i = 0; i < num; i++)
            {
                //初始化格子 格子类型
                randomNum = r.Next(0, 101);

                //设置类型 普通格子
                //收尾两个格子都是普通格子
                //其余地方又85%是普通格子
                if (randomNum < 85 || i == 0 || i == num - 1)
                {
                    grids[i].type = E_GridType.Normal;


                }
                //有5%的几率是炸弹
                else if (randomNum >= 85 && randomNum < 90)
                {
                    grids[i].type = E_GridType.Boom;

                }
                //有5%的几率是暂停
                else if (randomNum >= 90 && randomNum < 95)
                {
                    grids[i].type = E_GridType.Pause;
                }
                //有5%的几率是时空隧道
                else
                {
                    grids[i].type = E_GridType.Tunnel;
                }
                //位置应该如何设置
                grids[i].pos = new Vector2(x, y);
                //每次循环都应该按一定的的规则变化

                //加十次
                if (indexX == 10)
                {
                    y += 1;
                    //加一次Y记一次数
                    ++indexY;
                    if (indexY == 2)
                    {
                        //y加了两次后，把x加的次数记0
                        indexX = 0;
                        indexY = 0;
                        //反向步长
                        stepNum = -stepNum;
                    }
                }
                else 
                {
                    x += stepNum;
                    //加一次x记一次数
                    ++indexX;
                }
            }

        }

        public void Draw()
        {
            for (int i = 0; i < grids.Length; i++)
            {
                grids[i].Draw();
            }
        }
    }
    #endregion

    #region 7.玩家类型枚举和玩家结构体
    /// <summary>
    /// 玩家类型枚举
    /// </summary>
    enum E_PlayerType
    {
        /// <summary>
        /// 玩家
        /// </summary>
        Player,
        /// <summary>
        ///电脑
        /// </summary>
        Computer,
    }
    struct Player
    {

        //玩家类型
        public E_PlayerType type;
        //当前所在地图哪一个索引的格子
        public int nowIndex;
        //是否暂停的标志位
        public bool isPause;

        public Player(int index, E_PlayerType type)
        {
            nowIndex = index;
            this.type = type;
            isPause = false;
        }

        public void Draw(Map mapInfo)
        {
            //必须要先得到地图，才能够 得到我在地图上的哪一个格子
            //从传入的地图中 得到 格子的信息
            Grid grid = mapInfo.grids[nowIndex];

            //设置位置
            Console.SetCursorPosition(grid.pos.x, grid.pos.y);


            //画 设置颜色 设置图标
            switch (type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case E_PlayerType.Computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;

            }

        }

    }



    #endregion


}
