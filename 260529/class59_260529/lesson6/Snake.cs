using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using 贪吃蛇.lesson3;
using 贪吃蛇.lesson4;
using 贪吃蛇.lesson5;

namespace 贪吃蛇.lesson6
{
    /// <summary>
    /// 移动枚举
    /// </summary>
    enum E_MoveDir
    {
        /// <summary>
        /// 上
        /// </summary>
        Up,
        /// <summary>
        /// 下
        /// </summary>
        Down,
        /// <summary>
        /// 左
        /// </summary>
        Left, 
        /// <summary>
        /// 右
        /// </summary>
        Right,
    }

    class Snake : IDraw
    {

        SnakeBody[] bodys;
        //申明一个成员变量来记录蛇的长度
        int nowNum;
        //当前移动的方向
        E_MoveDir dir;


        public Snake(int x, int y)
        {
            //粗暴的 申明200个空间，默认为200个为极值
            bodys = new SnakeBody[200];

            bodys[0] = new SnakeBody(E_SnakeBody_Type.Head, x, y);
            nowNum = 1;

            dir = E_MoveDir.Right;
        }

        public void Draw()
        {
            //画一节一节的身子
            for (int i = 0; i < nowNum; i++)
            {
                bodys[i].Draw();
            }

        }
        /// <summary>
        /// 蛇的移动
        /// </summary>
        public void Move()
        {
            //移动前
            //擦除最后一个位置的蛇身体
            SnakeBody lastBody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastBody.pos.x,lastBody.pos.y);
            Console.Write(" ");

            //蛇移动后，把前一个数组元素的坐标传给后一个数组元素的坐标
            for (int i = nowNum-1; i > 0; i--)
            {
                bodys[i].pos = bodys[i-1].pos;

            }


            //再移动
            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;
                default:
                    break;
            }
            
        }
        /// <summary>
        /// 蛇的转向方法
        /// </summary>
        /// <param name="dir">键盘输入的转向方法</param>
        public void ChangeDir(E_MoveDir dir)
        {
            //只有头部的时候，可以直接左转右 右转左 上转下，下转上


            //有身体时，这种情况就不能直接转了

            //当传进来的方向和原来的方向都相同的话就不用转向
            if (dir == this.dir||
                nowNum>1&&
                (this.dir == E_MoveDir.Left&&dir == E_MoveDir.Right||
                 this.dir == E_MoveDir.Right&&dir == E_MoveDir.Left||
                 this.dir == E_MoveDir.Down && dir == E_MoveDir.Up||
                 this.dir == E_MoveDir.Up && dir == E_MoveDir.Down
                 )
               )
            {
                return;
            }
            //只要没有return 就记录外面传入的方向 之后就会按照这个方向去移动
            this.dir = dir;

        }
        /// <summary>
        /// 蛇碰墙壁和碰身体的方法
        /// </summary>
        /// <param name="map">传入地图的参数得到墙的坐标参数</param>
        /// <returns></returns>
        public bool CheckEnd(Map map)
        {
            //判断是否和墙体相碰撞
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }
            for (int i = 1; i < nowNum; i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    return true;
                }
            }

            return false;

        }
        /// <summary>
        /// 检查蛇的位置是否和生成食物的位置相同方法
        /// </summary>
        /// <param name="p">生成食物的位置</param>
        /// <returns></returns>
        public bool CheckSamePos(Position p)
        {
            for (int i = 0; i < nowNum; i++)
            {
                if (bodys[i].pos == p)
                {
                    return true;
                }
                
            }
            return false;
        }
        //吃食物的方法
        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                //当蛇头的位置和食物的位置重合了，就重新生成新的食物
                food.RandomPos(this);

                //长身体的方法调用
                AddBody();

            }
        }
        //长身体的方法
        public void AddBody()
        {
            //先长出身体，在加长度
            SnakeBody frontBody = bodys[nowNum - 1];

            bodys[nowNum] = new SnakeBody(E_SnakeBody_Type.Body, frontBody.pos.x, frontBody.pos.y);


            ++nowNum;


        }
    }
}
