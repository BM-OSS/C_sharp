using System;

namespace class47_260517
{

    #region 知识点一万物之父
    //万物之父
    //关键字：object
    //概念：
    //object是所有类型的基类，它是一个类（引用类型）
    //作用：
    //1.可以利用里氏替换原则，用object容器装所有的对象
    //2.可以用来表示不确定的类型，作为函数参数类型
    #endregion
    class Father
    {
        
    }
    class Son : Father
    {
        public void Speak()
        {
            Console.WriteLine("123");
        }
    }


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("万物之父和装箱拆箱");

            #region 知识点二 万物之父的使用
            Father f = new Son();
            if (f is Son)
            {
                (f as Son).Speak();
            }

            //引用类型使用
            object o = new Son();
            //用 is as 来判断和转换
            if (o is Son)
            {
                (o as Son).Speak();
            }
            //值类型使用
            object o2 = 1;
            //用括号强转
            float f1 = (float)o2;
            //特殊的string类型
            object str = "123123";
            string str2 = str.ToString();
            //上面是括号强转的方法
            //下面是as强转的方法
            str2 = (str as string);

            object arr = new int[10];
            int[] ar = (int[])arr;

            #endregion


            #region 装箱和拆箱
            //发生条件
            //用object存值类型（装箱）
            //再把object转为值类型（拆箱）

            //装箱
            //把值类型用引用类型存储
            //栈内存会迁移到堆内存中

            //拆箱
            //把引用类型存储的值类型取出来
            //堆内存会迁移到栈内存中

            //好处：不确定类型时可以方便参数的存储和传递
            //坏处：存在内存迁移，增加性能消耗

            //装箱演示
            object v = 3;

            //拆箱演示
            int value = (int)v;



            #endregion
            //用object使用时最好的一个点就是在输入参数时输入任何类型都可以运行
            TestFun(ar, str, str2,324,15.455f,"fgsg");

            #region 练习题一
            //请口头描述什么事装箱拆箱

            //发生条件
            //用object存值类型（装箱）
            //再把object存的值类型转换为值对象时（拆箱）

            //装箱
            //把值类型装载引用类型存储
            //栈内存迁移到堆内存

            //拆箱
            //把引用存储的值类型取出来放到值对象中
            //堆内存迁移到栈内存

            //好处：不确定类型时使用object来存储任何类型，方便存储和传递
            //坏处：存在内存迁移 增加性能的消耗


            #endregion

            #region 练习题二
            //请用代码实现装箱拆箱
            //装箱
            int i = 10;
            object ob = i;
            //拆箱
            i = (int)ob;


            #endregion
        }
        //params 是边长参数的关键字，可以多输入一些参数，和object结合着使用
        static void TestFun(params object[] array)
        {
            
        }

    }
    //总结：
    //万物之父：object
    //基于里氏替换原则，可以用object容器装载一切类型的变量
    //是所有类型的基类


    //重点：
    //装箱拆箱
    //不是不用，是尽量少用


}