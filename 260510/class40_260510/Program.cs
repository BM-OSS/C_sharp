using System;

namespace class40_060510
{
    #region 知识点一 静态类
    //概念
    //用static修饰的类

    //特点
    //只能包含静态成员
    //不能被实例化

    //作用
    //1.将常用的静态成员写在静态类中 方便使用
    //2.静态类不能被实例化 更能体现工具类的 唯一性
    //比如Console就是一个静态类
    static class TestStatic
    {
        public static int testIndex = 0;
        public static void TestFun()
        {
            
        }

        public static int TestIndex
        {
            get 
            {
                return testIndex;
            }
            set 
            {
                
            }
        }
    }
    #endregion

    #region 知识点二 静态构造函数
    //概念
    //在构造函数上加static修饰

    //特点
    //1.静态类和普通类都可以有
    //2.不能使用访问修饰符
    //3.不能有参数
    //4.只会自动调用一次

    //作用
    //在静态构造函数中初始化 静态变量

    //使用
    //1.静态类中的静态构造函数
    static class StaticClass
    {
        public static int testInt = 100;
        public static int testInt2 = 200;
        static StaticClass()
        {
            Console.WriteLine("静态构造函数");
            testInt = 200;
            testInt2 = 300;
        }
        


    }
    //2.普通类中的静态构造函数
    class Test
    {
        public static int testInt = 200;

        static Test()
        {
            Console.WriteLine("普通类中的静态构造函数");
        }
        public Test()
        {
            Console.WriteLine("普通类中的普通构造函数");
        }

    }
    #endregion

    #region 练习题一
    //写一个用于数学计算的静态类
    //该类学习中提供计算圆的面积，周长，矩形面积，矩形周长，取一个数的绝对值 等方法
    static class MathTool
    {
        public static float PI = 3.14f;

        public static float ClacCricularArea(float r)
        {
            return PI * r * r;
        }
        public static float ClacCricularLength(float r)
        {
            return PI * 2 * r;
        }
        public static float ClacRectArea(float w, float h)
        {
            return w * h;
        }
        public static float ClacRectLength(float w, float h)
        {
            return w * 2 + h * 2;
        }
        public static float GetABS(float value)
        {
            if (value < 0)
            {
                return -value;
            }
            return value;
        }
        

    }
    #endregion
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("静态类和静态构造函数");
            Console.WriteLine(StaticClass.testInt);
            Console.WriteLine(StaticClass.testInt2);
            Console.WriteLine(Test.testInt);
            Test t = new Test();
            Test t2 = new Test();

            Console.WriteLine(MathTool.GetABS(-7));
            Console.WriteLine(MathTool.ClacCricularArea(5.6f));

        }
    }
}