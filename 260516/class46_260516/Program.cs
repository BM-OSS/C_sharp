using System;
using System.Security.Cryptography.X509Certificates;

namespace class46_260516
{
    #region 知识点一 继承中的构造函数的基本概念
    //特点
    //当申明一个子类对象时
    //先执行父类的构造函数
    //在执行子类的构造函数

    //注意：
    //1.父类的无参构造 很重要
    //2.子类可以通过base关键字 代表父类构造


    #endregion

    #region 知识点二 继承的无参构造函数的执行顺序
    //父类的父类的构造——>...父类构造——>...子类构造——>
    //会按照顺序依次执行
    class GameObject
    {
        public GameObject() 
        {
            Console.WriteLine("GameObject的构造函数");
        }
    }
    class Player : GameObject 
    {
        public Player()
        {
            Console.WriteLine("Player的构造函数");
        }
    }
    class MainPlayer : Player 
    {
        public MainPlayer()
        {
            Console.WriteLine("MainPlayer的构造函数");
        }
    }


    #endregion

    #region 知识点三 父类的无参构造函数重要
    //子类实例化是，默认自动调用的是父类的无参构造
    //所以如果父类无参构造函数被顶掉 会报错
    class Father
    {
        //public Father()
        //{
            
        //}

        public Father(int i)
        {
            Console.WriteLine("Father构造函数");
        }
    }
    class Son : Father
    {

        #region 知识点四 通过base调用指定的父类构造
        public Son(int i) : base(i)
        {
            Console.WriteLine("Son构造函数1");
        }
        public Son(int i, string str):this(i)
        {
            Console.WriteLine("Son构造函数2");
        }
        //只要父类的无参构造函数没有了，就是会报错
        //用base可以解决
        //用this可以间接解决这个问题
        #endregion
    }

    #endregion

    #region 练习题
    //有一个打工人基类 有工种，工作内容两个特征，一个工作方法
    //程序员，策划，美术分别继承打工人
    //请用继承中的构造函数这个知识点
    //实例化3个对象，分别是程序员，策划，美术
    class Worker
    {
        public string type;
        public string content;

        public Worker(string type,string content)
        { 
            this.type= type;
            this.content= content;
        }
        public void Work()
        {
            Console.WriteLine("{0}  {1}",type,content);
        }
    }
    class Programer : Worker 
    {
        public Programer():base("程序员","编程")
        {
            
        }
    }

    class Plan : Worker
    {
        public Plan() : base("策划", "设计游戏")
        {

        }
    }
    class Art : Worker
    {
        public Art() : base("美术", "绘图")
        {

        }
    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承中的构造函数");

            MainPlayer mp = new MainPlayer();

            Son s = new Son(1, "123");

            Programer p = new Programer();
            p.Work();
            Plan pl = new Plan();
            pl.Work();
            Art a = new Art();
            a.Work();
        }
    }

}
