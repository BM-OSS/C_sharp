//引用命名空间
using System;
using System.Runtime.InteropServices;

//命名空间
namespace class2
{
    //类
    class Program
    {
        //主函数，程序入口点
        static void Main(string[]args)
        {
            Console.WriteLine("变量");

            //知识点一折叠代码
            //主要作用是让编程时逻辑更加清晰
            //由#region和#endregion组成
            //具体作用是可以将中间包裹的代码折叠起来
            //它的本质是编辑器提供给我们的预处理指令
            //它只会在编辑时有用发布了代码或执行
            //代码它就会自动删除
            #region 知识点二 如何申明变量
            //变量：可以变化的容器，变量就是用来存储各种不同类型数值
            //一个容器，不同的变量类型可以存储不同类型的值

            //变量申明的固定写法
            //变量类型 变量名 = 变量值；
            int i = 1;
            //变量类型：一共14种；
            //变量名 我们自定义 按照一定的规则
            //初始值一定要和变量类型是统一的
            //=和；是固定不变的



            //变量类型
            //1.有符号的整形变量
            //能存储一定范围正负数包括0的变量类型
            //sbyte:-128~127
            sbyte sb = 127;
            Console.WriteLine(sb);
            
            //short:-32768~32767
            short sh = 32767;
            Console.WriteLine(sh);
            
            //int:-21亿多~21亿多
            int i2= 2100000000;
            Console.WriteLine(i2);

            //long:-9百万兆~9百万兆之间
            long l= 9000000000000000000;
            Console.WriteLine(l);


            //2.无符号的整形变量
            //只能存储0和正数的变量类型

            //byte:0~255
            byte b = 255;
            Console.WriteLine(b);

            //ushort:0~65535
            ushort us = 65535;
            Console.WriteLine(us);

            //uint:0~42亿多
            uint ui = 4200000000;
            Console.WriteLine(ui);

            //ulong:0~18百万兆之间
            ulong ul = 18000000000000000000;
            Console.WriteLine(ul);


            //3.浮点数（小数）
            //float:存放7/8位有效数字（根据编译器不同有效位数不一样）
            //超出的位数会四舍五入
            //有效位数是指从左到右第一个非零数字开始计算的
            //之所以后面要加f是因为编辑器默认为double类型的小数
            float f = 1.23456789f;
            Console.WriteLine(f);

            //double:存放15~17位有效数字（和float类型类似）
            double d = 1.23456789123456789;
            Console.WriteLine(d);

            //decimal:存放27~29位有效数字（和float类型类似）
            decimal de = 1.23456789123456789123456789123456789m;
            Console.WriteLine(de);




            //4.特殊类型
            //bool:表示真（true）假（false）的数据类型
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            //char:表示单个字符的类型
            char c = 'A';
            Console.WriteLine(c);

            //string:字符串类型，用来存储多个字符没有上限
            string str ="fhdgasljl附件二领事馆321532";
            Console.WriteLine(str);
            #endregion

            #region 知识点三 为什么有那么多不同的变量类型
            //不同的变量 存储的范围和类型不一样 
            //本质是占用的内存空间不一样
            //选择不同的数据类型装不同的数据

            //姓名
            string myName = "北穆";

            //年龄
            byte myAge = 18;

            //身高
            float myHeight = 175.3f;

            //体重
            float myWeight = 62.5f;

            //性别(true代表男，false代表女)
            bool sex = true;

            //数字用int 小数用float
            //字符串用string 真假用bool
            #endregion

            #region 知识点四 多个相同类型变量 同时申明
            //多个同类型变量同时申明
            //固定写法
            //变量类型 变量名1=变量，变量名2=变量...;
            int i3 = 1, i4 = 2;
            Console.WriteLine(i4);
            string str1 = "123", str2 = "456";
            Console.WriteLine(str1 + str2);
            #endregion

            #region 知识点五 变量初始化相关
            //变量申明时可以不设置初始值
            //但不建议这样的书写方式
            int i5;
            i5 = 10;
            Console.WriteLine(i5);
            #endregion

            #region 练习题一
            //下面代码的输出结果是？
            //double num=36.6;
            //Console.WriteLine("num");

            //答：num
            double num = 36.6;
            Console.WriteLine("num");
            #endregion

            #region 练习题二
            //申明float类型时为什么要在数字后面加f？


            //答：应为编辑器默认小数为double类型
            //不加f会认为是double类型的小数
            #endregion

            #region 练习题三
            //请定义一系列变量来储存你的
            //姓名，年龄，身高，体重
            //性别，住址等信息，并且打印出来

            //答
            string name = "北穆";
            Console.WriteLine(name);
            byte age = 18;
            Console.WriteLine(age);
            float height = 175.3f;
            Console.WriteLine(height);
            float weight = 62.5f;
            Console.WriteLine(weight);
            string address = "地球中国";
            Console.WriteLine(address);
            #endregion

            #region 练习题四
            //小明的数学考试成绩是80
            //语文考试成绩是90
            //英语考试成绩是85
            //请用变量描述打印出来
            byte math = 80;
            byte chinese = 90;
            byte english = 85;
            Console.WriteLine("小明的数学成绩是："+math);
            Console.WriteLine("小明的语文成绩是："+chinese);
            Console.WriteLine("小明的英语成绩是："+english);
            #endregion

        }
    }
}
