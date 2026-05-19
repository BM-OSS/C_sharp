using System;

namespace class70_260609
{
    #region 知识点一 委托是什么

    //委托是 函数(方法)的容器
    //可以理解为表示函数(方法)的变量类型
    //用来 存储、传递函数(方法)
    //委托的本质是一个类, 用来定义函数(方法)的类型 (返回值和参数的类型)
    //不同的 函数(方法)必须对应和各自"格式"一致的委托

    #endregion

    #region 知识点二 基本语法
    //关键字 : delegate
    //语法: 访问修饰符 delegate 返回值 委托名(参数列表);

    //写在哪里?
    //可以申明在namespace和class语句块中
    //更多的写在namespace中

    //简单记忆委托语法 就是 函数申明语法前面加一个delegate关键字
    #endregion



    #region 知识点三 定义自定义委托
    //访问修饰默认不写 为public 在别的命名空间中也能使用
    //private 其它命名空间就不能用了
    //一般使用public


    //申明了一个可以用来存储无参无返回值函数的容器

    //这里只是定义了规则，并没有使用
    //委托规则的申明，是不能重名的
    delegate void MyFun();

    delegate int MyFun2(int a);
    //可以自己申明泛型委托
    delegate T Fun<T, K>(T t, K k);
    //默认为public修饰
    #endregion


    #region 知识点四 使用定义好的委托
    //委托变量是函数的容器

    //委托常用在:
    //1.作为类的成员
    class Test
    {
        public MyFun fun;
        public MyFun2 fun2;

        public void TestFun(MyFun fun,MyFun2 fun2)
        {
            //先处理一些别的逻辑，当这些逻辑处理完了
            //在执行传入的函数
            int i = 1;
            i *= 2;
            i += 2;
            //this.fun = fun;
            //this.fun2 = fun2;
            
        }

        public void AddFun(MyFun fun, MyFun2 fun2)
        {
            this.fun += fun;
            this.fun2 += fun2;
        }
        public void RemoveFun(MyFun fun, MyFun2 fun2)
        {
            //从容器里面移除的意思
            this.fun -= fun;
            this.fun2 -= fun2;
        }


    }
    //2.作为函数的参数

    #endregion

    #region 知识点五 委托变量可以存储多个函数(多播委托)

    #region 增
    //public void AddFun(MyFun fun, MyFun2 fun2)
    //    {
    //        this.fun = fun;
    //        this.fun2 = fun2;
    //    }
    #endregion




    #region 删
    //public void RemoveFun(MyFun fun, MyFun2 fun2)
    //    {
    //        //从容器里面移除的意思
    //        this.fun -= fun;
    //        this.fun2 -= fun2;
    //    }
    #endregion


    #endregion

    



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("委托");
            //专门用来装载函数的容器
            MyFun f = new MyFun(Fun);
            Console.WriteLine(123456789);
            f.Invoke();

            MyFun f2 = Fun;
            Console.WriteLine(123456789);
            f2();
            Console.WriteLine("**********");
            MyFun2 f3 = Fun2;
            Console.WriteLine(f3.Invoke(1));
            Console.WriteLine(f3(1));

            MyFun2 f4 = new MyFun2(Fun2);
            Console.WriteLine(f4.Invoke(5));

            Test t = new Test();

            t.TestFun(Fun, Fun2);
            //如何用委托存储多个函数
            Console.WriteLine("**************");
            MyFun ff = Fun4;
            ff += Fun3;
            ff = ff + Fun3;
            ff -= Fun3;//从容器中移除这个函数
            ff -= Fun3;
            //ff -= Fun4;//这里容器中没有函数了，
            //调佣委托就会报错


            ff();//使用该委托后会出现调用两次这个函数

            if (ff != null)
            {
                ff();
            }



            t.AddFun(Fun, Fun2);
            t.fun();
            t.fun2(59);

            #region 知识点六 系统定义好的委托
            //选用系统自带的委托，需要选用命名空间using System
            //无参无返回值的委托
            Action action = Fun;
            action += Fun3;
            action += Fun4;

            //泛型委托
            Func<string> str = Fun5;
            Func<int> Int = Fun6;
            //可以传参数的泛型委托(最多可以有16个参数)
            Action<int, string> action1 = Fun7;

            //可以跟传n个参数，并且有返回值的 也有16个委托
            Func<int, string, string> action2 = Fun8;

            #endregion

            //练习题一
            Console.WriteLine("********");
            Mother m = new Mother();
            Father fff = new Father();
            Son s = new Son();


            m.beginEat += fff.Eat;
            m.beginEat += s.Eat;
            m.beginEat += m.Eat;
            m.DoCook();

            //练习题二
            Console.WriteLine("********");
            Monster monster = new Monster();
            Player p = new Player();
            Panel panel = new Panel();
            CJ cj = new CJ();

            monster.deadDoSomthing += p.MonsterDeadDoSomthing;
            monster.deadDoSomthing += panel.MonsterDeadDo;
            monster.deadDoSomthing += cj.MonsterDeadDo;

            monster.Dead();
            monster.Dead();
            Monster monster2 = new Monster();
            monster.deadDoSomthing += p.MonsterDeadDoSomthing;
            monster.deadDoSomthing += panel.MonsterDeadDo;
            monster.deadDoSomthing += cj.MonsterDeadDo;
            monster.Dead();
        }

        static void Fun3()
        {
            Console.WriteLine("张三做什么");
        }
        static void Fun4()
        {
            Console.WriteLine("李四做什么");
        }

        static string Fun8(int i,string str)
        {
            return "12345";
        }


        static string Fun5()
        {
            return "12345";
        }
        static int Fun6()
        {
            return 5;
        }
        static void Fun7(int i,string str)
        {
            
        }
        static void Fun()
        {
            Console.WriteLine("123456");
        }
        

        static int Fun2(int value )
        {
            Console.WriteLine(value);
            return value;
        }
    }

    #region 练习题一
    //一家三口, 妈妈做饭, 爸爸妈妈和孩子都要吃饭
    //用委托模拟做饭—>开饭—>吃饭的过程

    abstract class Person
    {
        public abstract void Eat();
    }

    class Mother : Person
    {

        public Action beginEat;

        public override void Eat()
        {
            Console.WriteLine("妈妈吃饭");
        }

        public void DoCook()
        {
            Console.WriteLine("妈妈开始做饭");
            Console.WriteLine("妈妈完成做饭");

            //完成后调用委托
            if (beginEat != null)
            {
                beginEat();
            }


        }



    }
    class Father : Person
    {
        public override void Eat()
        {
            Console.WriteLine("爸爸吃饭");
        }
    }

    class Son : Person
    {
        public override void Eat()
        {
            Console.WriteLine("儿子吃饭");
        }

    }

    #endregion

    #region 练习题二

    //怪物死亡后, 玩家要加10块钱, 界面要更新数据
    //成就要累加怪物击杀数, 请用委托来模拟实现这些功能
    //只用写核心逻辑表现这个过程, 不用写的太复杂

    class Monster
    {
        //当怪物死亡时，把自己作为参数传出去
        public Action<Monster> deadDoSomthing;
        //怪物的击杀的价值（多少钱） 
        public int money = 10;

        public void Dead()
        {
            Console.WriteLine("怪物死亡");
            if (deadDoSomthing != null)
            {
                deadDoSomthing(this);
            }
            //一般情况下 委托关联函数 有加就有减，（或者直接清空）
            deadDoSomthing = null;

        }
    }

    class Player
    {
        public int myMoney = 0;
        public void MonsterDeadDoSomthing(Monster m)
        {
            myMoney += m.money;
            Console.WriteLine("现在有{0}钱",myMoney);
        }
    }

    class Panel
    {
        private int nowShowMoney = 0;

        public void MonsterDeadDo(Monster m)
        {
            nowShowMoney += m.money;
            Console.WriteLine("当前面板显示{0}元钱",nowShowMoney);
        }
    }

    class CJ
    {
        private int nowKillMonsterNum = 0;

        public void MonsterDeadDo(Monster m)
        {
            nowKillMonsterNum += 1;
            Console.WriteLine("当前击杀了{0}怪物", nowKillMonsterNum);
        }
    }

    #endregion
}
