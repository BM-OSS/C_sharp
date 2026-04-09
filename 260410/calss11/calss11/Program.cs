using System;

namespace calss10
{
    class Program
    {
        static void Main(string[] rags)
        {
            Console.WriteLine("位运算符");
            //位运算符主要用数值类型进行计算的
            //将数值转换为2进制 再进行位运算

            #region 知识点一 按位与 &
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 有0则0
            int a = 1;  //001
            int b = 5;  //101
            int c = a & b;  // 001 & 101 = 001
            Console.WriteLine(c);

            a = 3;  //  011
            b = 19; //10011
            c = a & b;// 00011 & 10011 = 00011
            Console.WriteLine(c);
            //多个值进行位运算 没有括号时 从左到右依次计算
            a = 1; //00001
            b = 5; //00101
            c = 19;//10011
            int d = a & b & c;// 00001 & 00101 & 10011 = 00001 
            Console.WriteLine(d);

            #endregion

            #region 知识点二 按位或 |
            //规则 连续两个数值进行位计算 将数值转换为2进制
            //对位运算 有1则1
            a = 1;     //001
            b = 3;     //011
            c = a | b;// 001 | 011 = 011
            Console.WriteLine(c);
            a = 5;  //  101
            b = 10; // 1010
            c = 20; //10100
            d = a | b | c;// 101 | 1010 | 10100 = 11111 
            Console.WriteLine(d);




            #endregion

            #region 知识点三 异或 ^
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 相同位0 不同位1
            a = 1;     //001
            b = 5;     //101
            c = a ^ b;// 001 ^ 101 = 100
            Console.WriteLine(c);
            a = 10;//1010
            b = 11;//1011
            c = 4; // 100
            d = a ^ b ^ c;// 1010 ^ 1011 ^ 100 = 101
            Console.WriteLine(d);
            #endregion

            #region 知识点四 位取反 ~
            //规则 写在数值前面 将数值转换位二进制
            //对位运算 0变1 1变0
            a = 5;
            c = ~a;
            Console.WriteLine(c);
            //注意~是将所有的二进制位取反 和 反码取反不一样
            //5的int类型是 0000 0000 0000 0000 0000 0000 0000 0101
            //按位取反后为 1111 1111 1111 1111 1111 1111 1111 1010
            //而这是补码源码就为 1000 0000 0000 0000 0000 0000 0000 0110
            #endregion

            #region 知识点五 左移<<和右移>>
            //规则 让一个数的二进制进行左移和右移
            //左移几位 右侧就补几个0
            int a2 = 5;
            a2 = a2 << 2;
            Console.WriteLine(a2);
            a2 = a2 >> 2;
            Console.WriteLine(a2);
            a2 = a2 >> 2;
            Console.WriteLine(a2);
            a2 = a2 << 2;
            Console.WriteLine(a2);
            #endregion

            #region 练习题一
            //35<<4和66>>1的结果为？
            //实际上左移几位就是原数值*2的几次方
            //右移几位就是原数值/2的几次方
            //35<<4=35*16=560
            Console.WriteLine("练习题一");
            a = 35;
            a = a << 4;
            Console.WriteLine(a);
            //66>>1=66/2=33
            b = 66;
            b = b >> 1;
            Console.WriteLine(b);
            #endregion

            #region 练习题二
            //99^33 和76|85的结果为？
            Console.WriteLine("练习题二");
            // 0110 0011
            //^0010 0001
            // 0100 0010=66
            a = 99 ^ 33;
            Console.WriteLine(a);
            // 0100 1100
            //|0101 0101
            // 0101 1101=93
            b = 76 | 85;
            Console.WriteLine(b);
            #endregion

            Console.WriteLine("三目运算符");
            #region 知识点一 基本语法
            //写法 bool类型（相关）？bool类型为真返回值：bool类型为假返回值
            //返回值必须有一个变量接受返回值
            #endregion

            #region 知识点二 具体使用
            string str = true ? "条件为真" : "条件为假";
            Console.WriteLine(str);
            a = 5 > 3 ? 1 :0;
            Console.WriteLine(a);
            #endregion

            #region 练习题一
            //比较两个数的大小，求出最大的
            a = 10;
            b = 15;
            str = a > b ? "较大的数是a" : "较大的数是b";
            Console.WriteLine(str);
            #endregion

            #region 练习题二
            //提示用户输入一个姓名，然后再控制台上输出姓名，只要不是帅哥 就显示美女
            Console.WriteLine("练习题二");
            string name=Console.ReadLine();
            string str2=name=="帅哥"?name:"美女";
            Console.WriteLine(str2);
            #endregion

            #region 练习题三
            //依次输入学生的姓名 C#语言的成绩 Unity的成绩
            //两门成绩都大于90分 才能毕业，请输出最后的结果
            Console.WriteLine("练习题三");           
            try
            {
                Console.WriteLine("请输入姓名");
                string yourName = Console.ReadLine();
                Console.WriteLine("请输入C#成绩");
                int cSharp = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入Unity成绩");
                int unity = int.Parse(Console.ReadLine());
                string str3 = cSharp >=90 && unity >= 90 ? "顺利毕业" : "成绩不达标";
                Console.WriteLine(str3);
            }
            catch
            {
                Console.WriteLine("请输入正确的数据");
            }
            #endregion

            #region 练习题四
            //要求用户输入一个年份 然后判断是不是闰年？
            Console.WriteLine("练习题四");
            try
            {
                Console.WriteLine("请输入一个年份，用来判断是不是闰年");
                int year = int.Parse(Console.ReadLine());
                string result = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "是闰年" : "不是闰年";
                Console.WriteLine(result);
            }
            catch 
            {
                Console.WriteLine("请输入正确的年份");
            }
            #endregion
        }
    }
}
