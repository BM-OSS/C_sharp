using System;


namespace class4
{
    class Program
    {
        static void Main(string[] rge)
        {
            Console.WriteLine("常量");
            #region 知识点一 常量的申明
            //关键字 const
            //固定写法：
            //const 变量类型 变量名 =初始值；
            //变量的申明
            int i = 5;
            //常量的申明
            const int i1 = 10;

            #endregion

            #region 知识点二 常量的特点
            //1.必须初始化
            //2.不能被修改

            //常量通常用来表示一些常用不变的变量
            //PI 3.1415926
            const double PI = 3.1415926;
            Console.WriteLine(PI);
            #endregion

            #region 习题一
            //常量有什么特点


            //1.常量必须初始化
            //2.常量不能被修改
            //3.常量的申明就是在申明变量的前面加上const

            #endregion

            #region 练习题二
            //请简述你觉得在游戏开发中常量会用来干什么

            //常量是用来申明一些在游戏中不会变化的变量的
            //PI 角度转弧度 弧度转角度 重力加速度
            //一些数学定理或者公里性质的变量 用来参与计算的变量
            //玩家的最大血量（没有改变血量的方法时）
            #endregion

            Console.WriteLine("转义字符");
            #region 知识点一 转义字符的使用
            //什么是转义字符
            //他是字符串的一部分，用来表示一些特殊含义的字符
            //比如：在字符串里出现单引号 引号 等等
            //string str ="asff"fsga";
            //如上在字符中含有"会报错，就需要用其他的方法
            #endregion

            #region 转义字符的固定写法
            //固定写 \字符
            // \和不同的字符组合表示不同的含义

            //常用的转义字符
            //单引号 \'
            string str = "hahah\'hahah";
            Console.WriteLine(str);

            //双引号 \"
            str = "hahhafeif\"gkgrg";
            Console.WriteLine(str);

            //换行 \n
            str = "fslehglg\ngjelgir";
            Console.WriteLine(str);

            //斜杠 \\
            str = "gjelgl\\glehglfi";
            Console.WriteLine(str);

            //不常用的转义字符
            //制表符（空一个tab键） \t
            str = "gjldsghjgl\tgjriig";
            Console.WriteLine(str);

            //光标退格 \b
            str = "1234\b1234";
            Console.WriteLine(str);

            //空字符  \0
            str = "1234\01234";
            Console.WriteLine(str);

            //警报音  \a
            str = "fesfig\aief";
            Console.WriteLine(str);

            #endregion

            #region 知识点二 取消转义字符
            //在申明字符串的前面加@
            //或者在Console.WriteLine((这里加@)"")；
            string str1 = @"12445\n\tfgdg";
            Console.WriteLine(str1);

            Console.WriteLine(@"gjle\ngf\tgigirf");


            #endregion

            #region 习题一
            //请写出至少5种转义字符


            //答
            // \n \t \b \\
            // \a \' \" \0
            #endregion

            #region 练习题二
            //请用至少两种方式在控制台中打印：
            //我是小明
            //我今年18
            //我的爱好是制作游戏
            //我要好好学习，天天向上



            //答
            Console.WriteLine("我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上");

            Console.WriteLine("*********************");

            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");


            #endregion

            Console.WriteLine("类型转换——隐式转换");
            //什么是隐式转换
            //类型转换就是不同变量之间的相互转换
            //隐式转换的及基本规则——>不同类型之间自动转换
            //大范围转小范围
            #region 知识点一 相同大类型之间的转换
            //有符号  long——>int——>short——>sbyte
            long l = 1;
            int i2 = 10;
            short s = 1;
            sbyte sb = 1;
            //隐式转换，用包含和被包含的关系进行转换
            l = i2;
            l = s;
            l=sb;

            i2 = s;
            i2 = sb;

            s = sb;

            //无符号 ulong——>uint——>ushort——>byte
            ulong ul = 1;
            uint ui = 1;
            ushort us = 1;
            byte b = 1;

            ul = ui;
            ul = us;
            ul = b;

            ui = us;
            ui = b;

            us = b;

            //浮点型 decimal(没有隐式转换)
            //double——>float
            decimal de = 1;
            double d = 1;
            float f = 1;
            //decimal 没有办法用隐式转换去存储double和float类型
            d = f;

            //特殊类型 bool char string
            //他们之间不存在隐式转换
            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间的转换
            //无符号
            byte sb2 = 1;
            ushort us2 = 1; 
            uint ui2 = 1;
            ulong ul2 = 1; 

            //有符号
            sbyte b2 = 1;
            short s2 = 1;
            int i3 = 10;
            long l3 = 1;

            //无符号装有符号
            //有符号的变量含有负数部分
            //无符号变量不能存储

            //有符号装无符号
            //可能可以存储但有前置条件
            //有符号的最大范围一定要比无符号的
            //最大范围要大,如下

            s2 = sb2;
            i3 = us2;
            l3 = ui2;
            #endregion

            #region 浮点数和整数（有符号，无符号）之间
            //浮点数装整数
            float f3 = 1f;
            double d3 = 1;
            decimal de3 = 1m;
            //浮点数是可以装任何整形的
            f3 = l3;
            f3 = i3;
            f3 = s2;
            f3 = sb2;

            f3 = ul2;
            f3 = ui2;
            f3 = us2;
            f3 = b2;
            //decimal不能隐式存储float和double
            //但是decimal可以隐式存储整型

            de3 = l3;
            de3 = i3;
            de3 = s2;
            //double——>float——>所有整形（有符号，无符号）
            //decimal——>所有整形（有符号，无符号）


            //整数装浮点数
            //整数不能饮食存储浮点数

            #endregion

            #region 特殊类型和其他类型的转换
            bool bo=true;
            char c = 'A';
            string str2 = "12345";

            //bool
            //bool不能和其他类型相互转换

            //char
            //char可以隐式转换为整形和浮点型
            i2 = c;
            f = c;
            ui = c;
            Console.WriteLine(i2);
            Console.WriteLine(f);
            Console.WriteLine(ui);
            //char类型是16为的无符号整数，取值范围是0到65535
            //它可以隐式转换为更大大数值类型


            //string
            //string类型无法和其他类型相互转换



            #endregion
            //高精度存储低精度
            //double——>float——>整数——>char
            //decimal——>整数——>char
            //string和bool不参与隐式转换的规则

            #endregion

            #region 练习一
            //什么情况下会出现数据类型的隐式转换，请举例说明

            //答
            //大范围存储小范围
            //double——>float——>整形——>char
            //decimal——>整形——>char
            //long——>int——>short——>sbyte
            //ulong——>uint——>ushort——>byte
            //bool和string不参加隐式转换
            #endregion

            #region 练习二
            //请将自己的名字的每个字符转换成数字并打印出来

            int bei = '北';
            int mu = '穆';
            Console.WriteLine(bei);
            Console.WriteLine(mu);
            Console.WriteLine("我的名字对应的编号是："+bei+mu);
            Console.WriteLine(bei + mu);


            #endregion
        }
    }
}