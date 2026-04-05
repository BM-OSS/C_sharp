using System;

namespace Class5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显示转换");

            //显示转换——>手动处理 强制转换
            #region 知识点一 括号强转
            //作用 一般情况下 将高精度的类型强制转换为低精度
            //语法：变量类型 变量名=（变量类型）变量；
            //注意 精度问题 范围问题

            //相同大类的整形
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;

            //括号强转可能会出现范围问题
            //造成变量值异常
            s = (short)i;
            Console.WriteLine(s);
            //如上所示i的40000转变成s的-25536
            i = (int)l;
            Console.WriteLine(i);


            //无符号整形
            byte b = 1;
            uint u = 1;
            b = (byte)u;
            //与有符号类型类似的方法

            //浮点数之间
            float f = 1.1f;
            double d = 1.23456789123456789d;
            f = (float)d;
            Console.WriteLine(f);

            //无符号和有符号
            uint ui2 = 1;
            int i2 = -1;
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            //在强转时 一定要注意范围 不然的到的结果可能有异常

            i2 = (int)ui2;
            Console.WriteLine(i2);

            //浮点型和整形
            i2 = (int)1.64f;
            Console.WriteLine(i2);
            //浮点数据转成整形时 会直接抛弃小数点后面的小数

            //char和数值类型
            i2 = 'A';
            Console.WriteLine(i2);
            char c = (char)i2;
            Console.WriteLine(c);

            //bool和string
            bool bo = true;
            //int i3 = (bool)bo;

            string str = "123";
            //i3 = (int)str;

            //bool和string类型是不支持括号类型的强转的



            #endregion

            #region 知识点二 parse法
            //作用 把字符串类型转换为对应的类型
            //语法 变量类型.parse（"字符串"）
            //注意 字符串必须能够转换成对应的类型 否者报错

            //有符号
            string str1 = "123456";
            int i4 = int.Parse(str1);
            Console.WriteLine(i4);
            //我们填写字符串 必须是能够转换成对应
            //的类型的字符串 如果不符合会报错

            short s4 = short.Parse("456");
            Console.WriteLine(s4);
            //范围必须是变量存储范围以内的值


            //无符号
            //与有符号的类似


            //浮点数
            float f3 = float.Parse("1.2345");
            Console.WriteLine(f3);

            //特殊类型
            bool b5 = bool.Parse("true");
            Console.WriteLine(b5);

            char c2 = char.Parse("A");
            Console.WriteLine(c2);

            #endregion

            #region 知识点二 Convert法
            //作用 更准确的将各个类型之间进行相互转换
            //语法 Convert.To目标类型（变量或者常量）
            //注意 填写的变量或者常量必须正确 否者会出错

            //转字符串 如果是把字符串转对应的类型
            //字符串一定要合法合规
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);
            //精度比括号强转好一点 会四舍五入
            a = Convert.ToInt32(1.656789f);
            Console.WriteLine(a);
            //把bool类型转换为数值类型true对应1 bool对应0
            a = Convert.ToInt32(true);
            Console.WriteLine(a);
            a=Convert.ToInt32(false);
            Console.WriteLine(a);

            //把字符类型转换int类型
            a = Convert.ToInt32('A');
            Console.WriteLine(a);

            //每一个类型都存在对应的 Convert转换方法
            sbyte sb5 = Convert.ToSByte("1");
            Console.WriteLine(sb5);
            short s5 = Convert.ToInt16("1");
            Console.WriteLine(s5);
            int i5 = Convert.ToInt32("1");
            Console.WriteLine(i5);
            long l5=Convert.ToInt64("1");
            Console.WriteLine(l5);

            byte b6 = Convert.ToByte("1");
            Console.WriteLine(b6);
            ushort s6 = Convert.ToUInt16("1");
            Console.WriteLine(s6);
            uint i6 = Convert.ToUInt32("1");
            Console.WriteLine(i6);
            ulong l6 = Convert.ToUInt64("1");
            Console.WriteLine(l6);

            float f6 = Convert.ToSingle("13.2");
            Console.WriteLine(f6);
            double d6 = Convert.ToDouble("13,2");
            Console.WriteLine(d6);
            decimal de6 = Convert.ToDecimal("13.2");
            Console.WriteLine(de6);

            bool bo5 = Convert.ToBoolean("true");
            Console.WriteLine(bo5);
            char c5 = Convert.ToChar("A");
            Console.WriteLine(c5);

            string st6 = Convert.ToString(1234567);
            Console.WriteLine(st6);


            #endregion

            #region 知识点四 其他类型转string
            //作用 拼接打印
            //语法 变量.ToString（）；
            string str6 = 1.ToString();
            Console.WriteLine(str6);
            str6 = true.ToString();
            Console.WriteLine(str6);
            
            
            //当我们进行字符串拼接的时候
            //就会自动调用Tostring();转换成string;
            Console.WriteLine("2135" + 1 + true);






            #endregion

            #region 练习题一
            //显示类型转换有几种方式？
            //他们分别是什么，请举例说明？

            //括号强制转换、parse法
            //Convert法、ToString法
            int i7 = (int)s4;

            int i8 = int.Parse("1234");

            int i9 = Convert.ToInt32("24314");

            string str7 = 1.ToString();

            #endregion

            #region 练习题二
            //请将24069转成字符，并打印

            char c3 = (char)24069;
            Console.WriteLine(c3);

            char c4 = Convert.ToChar(24069);
            Console.WriteLine(c4);

            #endregion

            #region 练习题三
            //提示用户输入姓名 语文 数学
            //英语成绩，并将输入的三门成绩用整形变量储存
            Console.WriteLine("请输入你的姓名");
            string str4 = Console.ReadLine();
            
            
            Console.WriteLine("请输入你的语文成绩：");
            str4 = Console.ReadLine();
            int chinese = int.Parse(str4);
            Console.WriteLine(str4);

            Console.WriteLine("请输入你的数学成绩：");
            str4 = Console.ReadLine();
            int math = int.Parse(str4);
            Console.WriteLine(str4);

            Console.WriteLine("请输入你的英语成绩：");
            str4 = Console.ReadLine();
            int english = int.Parse(str4);
            Console.WriteLine(str4);
            #endregion
        }
    }
}
