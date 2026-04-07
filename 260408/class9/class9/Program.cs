using System;


namespace class9
{
    class Program
    {
        static void Main(string[] rags)
        {
            Console.WriteLine("条件运算符");

            #region 知识点一 条件运算符
            //用于比较两个变量或两个常量
            //> < == != >= <=
            //总之与C语言里面的条件运算符写法和用法
            //几乎一样
            int a = 5;
            int b = 10;
            bool c = a > b;
            Console.WriteLine(c);
            //条件运算符的运算结果是一个bool类型的值
            //结果为真时返回true 结果为假时返回为flase


            #endregion

            #region 知识点二 各种写法
            //变量和变量之间的比较
            a = 5;
            b = 10;
            bool result = a < b;
            Console.WriteLine("a<b:" + result);
            //变量和数值之间的比较
            result = a > 5;
            Console.WriteLine("a>5:" + result);
            result = a < 10;
            Console.WriteLine("a<10:" + result);
            //数值和数值之间的比较
            result = 5 > 3;
            Console.WriteLine("5>3:" + result);
            result = 5 == 3;
            Console.WriteLine("5==3:" + result);
            result = 5 != 3;
            Console.WriteLine("5!=3:" + result);
            //计算结果比较
            //条件运算符的优先级低于算数运算符
            result = a + 3 > a - 2 + 3;
            Console.WriteLine("a+3>a-2+3:" + result);

            #endregion

            #region 知识点三 不能进行范围比较
            a = 5;
            //判断是否在两个值之间
            //1<a<6 这种写法会报错
            //判断是否在两个数之间的范围里
            //需要用到逻辑运算符 如下
            result =a < 6 && a > 1;
            Console.WriteLine("a<6&&a>1:" + result);
            #endregion

            #region 知识点四 不同类型之间的比较
            //不同数值类型之间可以随意进行条件运算符比较
            int i = 5;
            float f = 1.2f;
            double d = 12.5;
            short s = 2;
            byte by = 20;
            uint ui = 222;
            result = d > by;
            Console.WriteLine("d>by:" + result);
            result = a < s;
            Console.WriteLine("a<s:" + result);
            result = d > ui;
            Console.WriteLine("d>ui:" + result);
            result = ui > s;
            Console.WriteLine("ui>s:" + result);
            //特殊类型 char string bool
            //只能用同类型进行==和!=比较；

            string str = "123";
            char e = 'A';
            bool bo = false;

            result = str == "123";
            Console.WriteLine("str==123:" + result);
            result = e == 'A';
            Console.WriteLine("e==A:" + result);
            //char类型不仅可以和自己类型进行==和!=比较
            //还可以和数值类型进行比较
            //还可以和字符类型进行大小比较
            result = e > 'B';
            Console.WriteLine("e>B:" + result);
            result = e >= 65;
            Console.WriteLine("e>=65:" + result);
            result =bo== true;
            Console.WriteLine("bo==true:" + result);
            #endregion

            #region 练习题一
            //请口答下列表达式的结果
            //我的年龄（18）>你的年龄（22）
            //兔子的速度（3m/s）<乌龟的速度（0.3m/s）
            //狗的重量（50kg）<兔子的重量（5kg）
            //我身上的Money(10元)==你身上的Money(10元)
            Console.WriteLine("练习题一");
            //false
            //false
            //false
            //true
            #endregion

            #region 练习题二
            //求以下代码的打印结果是什么
            bool b1 = true;
            Console.WriteLine("练习题二");
            Console.WriteLine(b1!=true);//false
            Console.WriteLine(10==10);//true
            Console.WriteLine(10 > 20);//false
            Console.WriteLine(10 <=20);//true
            Console.WriteLine(10 <=10);//true
            #endregion

            #region 练习题三
            Console.WriteLine("练习题三");
            bool gameOver, startGame;
            int a1 = 10,b2=15;
            gameOver = a1 > (b2- 5);
            startGame = gameOver == (b2 > (a1 + 5));
            Console.WriteLine("startGame="+startGame);
            //请问打印的结果是什么？
            //true
            #endregion
        }
    }
}
