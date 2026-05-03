using System;

namespace Class39_260509
{

    #region 知识点一 静态成员的基本概念
    //静态关键字  static
    //用static修饰 成员变量，方法，属性等
    //称为静态成员


    //静态成员的特点是：直接用类名+点 出来使用

    #endregion

    #region 知识点二 早已出现的静态成员
    //例如
    //Console.WriteLine();
    //就是已经封装好的静态函数

    #endregion
    #region 知识点三 自定义静态成员
    class Test
    {

        public const float G=9.8f; 


        //静态成员变量
        public static float PI = 3.1415926f;
        //普通成员变量
        public int testInt = 100;

        //静态成员方法
        public static float CalcCircle(float r)
        {
            #region 知识点六 静态函数中不能使用非静态成员
            //成员变量只能对象实例化后 才能点出来使用 不能无中生有
            //不能直接使用 非静态成员 否则会报错
            //必须先new一个实例化对象才会出现的

            #endregion

            //πr²
            return PI *r*r;
        }
        //普通成员方法
        public void TestFun()
        {
            Console.WriteLine("123");
            #region 知识点七 非静态函数可以使用静态函数
            Console.WriteLine(PI); 
            Console.WriteLine(CalcCircle(2));
	        #endregion



        }

    }


    #endregion


    #region 知识点五 为什么静态成员变量可以直接点出来使用而不需要先new一个出来在使用
    //重点
    //程序中是不能无中生有的
    //我们要使用的对象，变量，函数，都是要在内存中分配存储空间的
    //之所以要实例化对象，目的就是分配内存空间，在程序中产生一个抽象的对象
    //
    //静态成员的特点
    //程序开始运行时 就会分配存储空间 所以我们可以直接使用
    //静态成员和程序同生共死
    //只要使用了它，直到程序结束时内存空间才会被释放
    //所以一个静态成员就会有自己唯一的一个“内存小房间”
    //这让静态成员就有了唯一性
    //在任何地方使用都是用的小房间里面的内容，改变了它也是改变小房间里面的内容


    #endregion

    #region 知识点八 静态成员变量对我们的作用
    //静态变量：
    //1.常用的且唯一变量的声明
    //2.方便别人获取的对象声明
    //静态方法：
    //常用唯一的方法声明 比如 相同规则的数学计算相关函数

    //静态变量的缺点：
    //占用了大部分内存，其他变量的内存就很少
    //加剧了GC的过程，会产生程序卡顿或者程序崩溃
    #endregion

    #region 知识点九 常量和静态变量
    //const(常量)可以理解为特殊的static(静态)
    //相同点
    //他们都可以通过类名点出来使用
    //不同点：
    //1.const必须初始化 不能修改 static可以修改
    //2.const只能修饰变量 static可以修饰很多
    //3.const一定是写在访问修饰符后面的，static没有这个要求
    #endregion

    #region 练习题一
    //请说出const和static的区别
    //相同点：
    //他们都可以用点出来的方式使用
    //不同点
    //1.用const是常量不能改变且要赋初值，用static是静态变量可以改变
    //2.const是只能修饰变量，static可以修饰很多
    //3.访问修饰符要写在const前面，static随意

    #endregion

    #region 练习题二
    //请用静态成员相关知识实现
    //一个类对象，在整个应用程序的生命周期中，有且仅有一个该对象的存在
    //不能在外部实例化，直接通过该类类名就能够得到唯一的对象
    class Test1
    {
        public static Test1 t = new Test1();

        public int testInt = 10;
        public static Test1 T
        {
            get 
            {
                return t;
            }
        }

        private Test1()
        { 
            
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员");

            Console.WriteLine(Test.G);
            #region 知识点四 静态成员的使用
            Console.WriteLine(Test.PI);
            Console.WriteLine(Test.CalcCircle(2));
            #endregion

            Console.WriteLine(Test1.T.testInt); ;
            
        }
    }
    //总结
    //概念：用static修饰的成员变量，成员方法，成员属性等，就成为静态成员
    //特点：直接用类名点出来使用（全局性）
    //生命周期：和程序同生共死
    //程序运行后就会一直存在内存中，直到程序结束后才会释放，因此静态成员具有唯一性
    //注意：
    //1.静态函数中不能直接使用非静态成员变量
    //2.非静态函数中可以直接使用静态成员变量

    //常量和静态变量
    //常量算作特殊的静态变量
    //相同点和不同点在上面提过（知识点九）

}