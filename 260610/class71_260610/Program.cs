using System;
namespace class71_260611
{
    #region 知识点一 事件是什么
    //事件是基于委托的存在
    //事件是委托的安全包裹
    //让委托的使用更具有安全性
    //事件 是一种特殊的变量类型
    #endregion
    #region 知识点二 事件的使用
    //申明语法:
    //访问修饰符 event 委托类型 事件名;
    //事件的使用:
    //1.事件是作为 成员变量存在于类中
    //2.委托怎么用 事件就怎么用
    //事件相对于委托的区别:
    //1.不能在类外部 赋值
    //2.不能再类外部 调用
    //注意:
    //它只能作为成员存在于类和接口以及结构体中
    class Test
    {
        //申明一个委托 用于存储 函数的
        public Action myFun;
        //事件成员变量 用于存储 函数的
        public event Action myEvent;
        public Test()
        {
            myFun = TestFun;
            myFun += TestFun;
            myFun -= TestFun;
            myFun();
            myFun.Invoke();
            myFun = null;
            myEvent = TestFun;
            myEvent += TestFun;
            myEvent -= TestFun;
            myEvent();
            myEvent.Invoke();
            myEvent = null;
        }

        public void TestFun()
        {
            Console.WriteLine("123456");
        }
        //外部不能调用它，
        //只能通过在内部封装后再在外部去调用
        public void DoEvent()
        {
            if (myEvent != null)
            {
                myEvent();
            }
              
        }



    }


    #endregion



    #region 知识点三 为什么有事件
    //1.防止外部随意置空委托
    //2.防止外部随意调用委托
    //3.事件相当于对委托进行了一次封装 让其更加安全
    #endregion



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("事件");

            Test t = new Test();
            //委托在外面赋值
            t.myFun = null;
            t.myFun += TestFun;

            //事件时不能再外面赋值的

            //但是可以通过+=或者-=的方法实现
            //t.myEvent = null;
            t.myEvent += TestFun;
            t.myEvent -= TestFun;
            t.myEvent += TestFun;
            t.myEvent += TestFun;

            //事件不能再外部调用，但是委托可以
            //t.myEvent();
            t.myFun();
            
            //t.myEvent.Invoke();
            t.myFun.Invoke();
            //通过封装好的函数来间接调用
            t.DoEvent();

            Action a = TestFun;
            //事件 是不能作为临时变量在函数中使用的
            //event Action ae = TestFun;

            Heater h = new Heater();
            Alarm a1 = new Alarm();
            Display d = new Display();
            h.myEvent += a1.ShowInfo;
            h.myEvent += d.ShowInfo;
            //加热
            h.AddHot();

        }
        static void TestFun()
        {
            Console.WriteLine("调用");
        }
    }

    //总结
    //事件和委托的区别
    //事件和委托的使用基本是一模一样的
    //事件就是特殊的委托
    //主要区别:
    //1.事件不能再外部使用赋值=符号, 只能使用+ - 委托 哪里都能用
    //2.事件 不能再外部执行 委托哪里都能执行
    //3.事件 不能作为 函数中的临时变量的 委托可以


    #region 练习题
    //有一个热水器, 包含一个加热器, 一个报警器, 一个显示器
    //我们给热水器通上电, 当水温超过95度时
    //1.报警器会开始发出语音, 告诉你水的温度
    //2.显示器也会改变水温提示, 提示水已经烧开了


    class Heater
    {
        public event Action<int> myEvent;

        private int value = 0;

        public void AddHot()
        {
            int updateIndex = 50000000;
            while (true)
            {

                //隔一段时间加一点温度
                if (updateIndex <= 0)
                {
                    Console.WriteLine("加热到{0}度",value);
                    ++value;
                    //当温度超过95度 就触发 报警器和显示器显示信息
                    if (value > 100)
                    {
                        break;
                    }
                    
                    if (value >= 100)
                    {
                        if (myEvent != null)
                        {
                            myEvent(value);
                        }
                        myEvent = null;
                    }
                    updateIndex = 50000000;
                }
                --updateIndex;


            }
            

        } 
    }

    class Alarm
    {
        public void ShowInfo(int v)
        {
            Console.WriteLine("当前水温{0}度",v);
        }
    }

    class Display
    {
        public void ShowInfo(int v)
        {
            Console.WriteLine("水开了，当前水温{0}度",v);
        }
    }



    #endregion

}

