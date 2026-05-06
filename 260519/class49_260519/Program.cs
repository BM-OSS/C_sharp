using System;

namespace class49_260519
{
    #region 知识点一 多态的概念
    //多态按字面意思就是 多种状态
    //让继承同一父类的子类们 在执行相同的方法时有不同的表现（状态）
    //主要目的
    //同一父类的对象 执行相同行为（方法）有不同的表现
    //解决的问题
    //让同一个对象有唯一行为的特征




    #endregion

    #region 知识点二 解决的问题

    class Father
    {
        public void SpeakName()
        {
            Console.WriteLine("father的方法");
        }
    
    }
    class Son : Father 
    {
        public new void SpeakName()
        {
            Console.WriteLine("son的方法");
        }
    }

    #endregion
    #region 知识点三 多态的实现
    //之前已经学过的多态
    //编译时多态——函数重载，开始就写好的

    //现在学习的：
    //运行时多态（vob，抽象函数，接口）
    //v:virtual(虚函数)
    //o:override(重写)
    //b:base(父类)

    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
           this.name= name;
        }
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象进行攻击");
        }
    }

    class Player : GameObject 
    {
        public Player(string name):base (name)
        {
            
        }
        //override表示重写写这个Atk方法在子类，这是与父类不相同的
        public override void Atk()
        {
            Console.WriteLine("玩家攻击对象");
            base.Atk();
            //base作用，是把父类的方法延续到子类里面
        }
    }


    class Monster : GameObject
    {
        public Monster(string name): base (name) 
        {
            
        }
        public override void Atk()
        {
            // base.Atk();
            Console.WriteLine("怪物对象进行攻击");
        }
    }


    #endregion

    #region 练习题一
    //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫

    class Duck
    {
        public virtual void Speak()
        {
            Console.WriteLine("嘎嘎叫");
        }
    }

    class WoodDuck : Duck 
    {
        public override void Speak()
        {
           
            Console.WriteLine("吱吱叫");
        }
    }

    class RubberDuck:Duck
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("唧唧叫");
        }
    }
    #endregion


    #region 练习题二
    //所有员工9点打卡
    //但经理十一点打卡，程序员不打卡
    class Staff
    {
        public virtual void Speak()
        {
            Console.WriteLine("9点钟打卡");
        }
    }

    class Manager : Staff
    {
        public override void Speak()
        {

            Console.WriteLine("11点钟打卡");
        }
    }

    class  Programer: Staff
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("老子不打卡");
        }
    }

    #endregion

    #region 练习题三
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图像类
    //实例化矩形，正方形，圆形对像求面积和周长

    class Graph
    {
        public virtual float GetLength()
        {
            return 0;
        }
        public virtual float GetArea()
        {
            return 0;
        }
    }

    class Rect : Graph
    {
        public float w;
        public float h;
        public Rect(float w,float h)
        {
            this.w = w;
            this.h = h;
        }
        public override float GetLength()
        {
            return 2 * (w + h);
        }
        public override float GetArea()
        {
            return w * h;
        }
    }

    class  Square : Graph
    {
        public float l;
        public Square(float l)
        {
            this.l = l;
            
        }
        public override float GetLength()
        {
            return 4 * l;
        }
        public override float GetArea()
        {
            return l * l;
        }
    }

    class Circular : Graph
    {
        public float r;
        const float PI = 3.14f;
        public Circular(float r)
        {
            this.r = r;

        }
        public override float GetLength()
        {
            return PI * r * 2;
        }
        public override float GetArea()
        {
            return PI * r * r;
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vob");

            Father f = new Son();

            f.SpeakName ();
            (f as Son).SpeakName();

            GameObject go = new Player("唐老狮");
            go.Atk();
            (go as Player).Atk();

            GameObject go1 = new Monster("小李");
            go1.Atk();

            Console.WriteLine("练习题一");
            Duck d = new Duck();
            d.Speak();

            Duck wd = new WoodDuck();
            wd.Speak();

            Duck rd = new RubberDuck();
            rd.Speak();

            Console.WriteLine("练习题二");
            Staff s=new Staff();
            s.Speak();

            Staff m = new Manager();
            m.Speak();

            Staff p = new Programer();
            p.Speak();

            Console.WriteLine("练习题三");
            Rect r = new Rect(5,7);
            Console.WriteLine("矩形的周长是"+ r.GetLength());
            Console.WriteLine("矩形的面积是" + r.GetArea());
            

            Square s1 = new Square(5.5f);
            Console.WriteLine("正方形的周长是" + s1.GetLength());
            Console.WriteLine("正方形的面积是" + s1.GetArea());
            
            

            Circular c = new Circular(6.6f);
            Console.WriteLine("圆的周长是" + c.GetLength());
            Console.WriteLine("圆的面积是" + c.GetArea());
            
            

        }
    }
    //总结：
    //多态：让同一类型的对象，执行相同行为是有不同的表现
    //解决问题：让同一对象有唯一的行为特征
    //vob：
    //v:virtual 虚函数
    //o:override 重写
    //b:base 父类
    //v和o是结合着使用的
    //b是否使用根据实际需求，保留父类行为
    
}
