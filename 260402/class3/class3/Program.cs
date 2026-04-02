using System;
using System.Security.Authentication;

namespace class3
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 知识点一 变量的存储空间（内存中）
            //1byte=8bit
            //1kb=1024byte
            //1mb=1024kb
            //1gb=1024mb
            //1tb=1024gb
            //通过sizeof方法可以获取变量类
            //型所占用的内存空间（单位：字节）

            //有符号
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte所占用的字节数为：" + sbyteSize);

            int shortSize = sizeof(short);
            Console.WriteLine("short所占用的字节数为：" + shortSize);

            int intSize = sizeof(int);
            Console.WriteLine("int所占用的字节数为：" + intSize);

            int longSize = sizeof(long);
            Console.WriteLine("long所占用的字节数为：" + longSize);

            Console.WriteLine("**************************");

            //无符号
            int byteSize = sizeof(byte);
            Console.WriteLine("byte所占用的字节数为：" + byteSize);

            int ushortSize = sizeof(ushort);
            Console.WriteLine("ushort所占用的字节数为：" + ushortSize);

            int uintSize = sizeof(uint);
            Console.WriteLine("uint所占用的字节数为：" + uintSize);

            int ulongSize = sizeof(ulong);
            Console.WriteLine("ulong所占用的字节数为：" + ulongSize);

            Console.WriteLine("**************************");
            //浮点数
            int floatSize = sizeof(float);
            Console.WriteLine("float所占字节数为：" + floatSize);

            int doubleSize = sizeof(double);
            Console.WriteLine("double所占字节数为：" + doubleSize);

            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal所占字节数为：" + decimalSize);

            Console.WriteLine("**************************");
            //特殊类型
            int charSize = sizeof(char);
            Console.WriteLine("char所占用的字节数为：" + charSize);

            int boolSize = sizeof(bool);
            Console.WriteLine("bool所占用的字节数为：" + boolSize);

            //sizeof是不能够得到string类型所占用的内存
            //大小的，因为string是字符串类型，它的长度是可变的

            #endregion


            #region 变量的本质
            //变量的本质是2进制——>计算机所有的数据
            //的本质都是二进制的0和1组合而成的
            //为什么是二进制？
            //因为数据传递只能通过电信号，
            //而电信号只有两种状态，刚好可以用0和1来表示
            //1bit（位）即使1个电信号的状态（不是0就是1）
            //为了方便数据表示
            //出现一个byte（字节）的单位，它是由8bit组成的储存单位
            //所以1个byte（字节）就是8bit（位）
            //这八个数据位是由0和1组成的

            #endregion

            #region 习题一
            //请默写出常用的14个变量类型，以及他们所占用的内存空间

            //答
            //有符号
            //sbyte 1字节
            //short 2字节
            //int 4字节
            //long 8字节

            //无符号
            //byte 1字节
            //ushort 2字节
            //uint 4字节
            //ulong 8字节

            //浮点数
            //float 4字节
            //double 8字节
            //decimal 16字节

            //特殊类型
            //bool 1字节
            //char 2字节
            //string 不固定字节数


            #endregion

            #region 习题二
            //请将一下二进制数转为10进制数
            //11000111
            //001101
            //01010101

            //答
            //11000111=199
            //001101=13
            //01010101=85
            #endregion

            #region 习题三
            //请将下面是进制数转换为二进制数
            //99
            //1024
            //78937

            //答
            //99=1100011
            //1024=10000000000
            //78937=1001101001111001
            #endregion


            Console.WriteLine("变量的命名规则");
            #region 知识点一：必须遵守的规则
            //不能重名
            //不能以数字开头
            //不能使用程序的关键字命名
            //不能有特殊符号（下划线除外）

            //建议的命名规则
            //变量名要有含义——>用英文（拼音）表示变量
            //不建议用汉字命名

            #endregion

            #region 知识点二：常用命名规则
            //驼峰命名法：变量第一个单词小写，之后的单词第一个字母大写
            string myName = "张三";
            Console.WriteLine(myName);

            //帕斯卡命名法：所有单词首字母都大写
            string MyName = "李四";
            Console.WriteLine(MyName);
            #endregion

            #region 练习题一
            //下面的变量命名哪些是错误的？
            //U3d        No.1        3day
            //$money  discount_1   ShangHai
            //Main       _ 2C       print

            //答
            //U3d  discount_1   Main  print
            #endregion

            #region 练习题二
            //按照驼峰命名法命名以下变量（使用英文）
            //我的年龄 我的性别 我的攻击力 我的防御力 
            //你的身高 你的体重

            byte myAge = 18;
            Console.WriteLine(myAge);
            bool myGender = true;//ture表示男，false表示女
            Console.WriteLine(myGender);
            ushort myAttack = 100;
            Console.WriteLine(myAttack);
            ushort myDefense = 80;
            Console.WriteLine(myDefense);
            float yourHeight = 175.3f;
            Console.WriteLine(yourHeight);
            float yourWeight = 63.2f;
            Console.WriteLine(yourWeight);

            #endregion
        }
    }
}