using System;
using System.Collections.Generic;
using System.Text;

namespace 贪吃蛇.lesson3
{
    abstract class GameObject : IDraw
    {

        //游戏对象位置
        public Position pos;


        //继承接口后 把接口中的行为 编写成抽象行为
        //提供给子类实现 因为是抽象行为 所以子类中是必须去实现
        public abstract void Draw();

    }
}
