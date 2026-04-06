using System;

namespace class8
{
    class Program
    {
        static void Main(string[] regs)
        {
            Console.WriteLine("字符串拼接");

            #region 知识点一 字符串拼接方式1
            //之前的算数运算符 只是用来数值类型变量进行数学运算的
            //而string不存在算数运算符不能计算 但是可以通过
            //+号来进行字符串的拼接
            string str = "123";
            str = str + "456";
            Console.WriteLine(str);

            //复合运算+=
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);

            str += 1 + 2 + 3 + 4;
            Console.WriteLine(str);

            //sting只能用+或者+=这两种方式进行拼接

            #endregion

            #region 知识点二 字符串拼接方式2
            //固定写法
            //string.Format("待拼接的内容"，内容1，内容2,...);
            //如下
            string str2 = "123";
            str2 = string.Format("我是{0}，我今年{1}，我想要{2}", "小李", 18, "好好学习");
            Console.WriteLine(str2);

            str2 = string.Format("fse{0},{1},gori{2}", 1, true, false);
            Console.WriteLine(str2);
            #endregion

            #region 知识点三控制台拼接
            Console.WriteLine("A{0}B{1}{2}",1,true,false);
            Console.Write("A{0}B{1}{2}", 1, true, false);
            //后面的内容比占位符多不会报错
            //但是后面的内容比占位符少会报错

            #endregion

            #region 练习题一
            //定义一个变量储存客户的姓名，
            //然后在屏幕上显示“你好，xxx”
            Console.WriteLine("\n练习题一");
            string str3 = "小李";
            Console.WriteLine("你好，" + str3);
            Console.WriteLine("你好，{0}",str3);
            str3 = string.Format("你好，{0}", str3);
            Console.WriteLine(str3);
            #endregion

            #region 练习题二
            //当我们去面试时，前台会要求我们填一张表
            //有姓名 年龄 邮箱 家庭住址 期望工资
            //将这些内容在控制台上输出
            Console.WriteLine("练习题二");
            string name = "小李";
            int age = 18;
            string email = "123456789@qq.com";
            string address = "地球深处";
            long money = 999999999;
            Console.WriteLine("姓名 {0}\n年龄 {1}\n邮箱 {2}\n家庭住址 {3}\n期望工资 {4}",name,age,email,address,money);


            #endregion

            #region 练习题三
            //请用户输入用户名 年龄 班级
            //最后一起用占位符形式打印出来
            Console.WriteLine("练习题三");
            Console.WriteLine("请输入你的用户名");
            string nameStr = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string ageStr = Console.ReadLine();
            Console.WriteLine("请输入你的班级");
            string classStr = Console.ReadLine();
            Console.WriteLine("用户名:{0}\n年龄:{1}\n班级:{2}",nameStr,ageStr,classStr);
            //Format法
            Console.WriteLine("请输入你的用户名");
            nameStr = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            ageStr = Console.ReadLine();
            Console.WriteLine("请输入你的班级");
            classStr = Console.ReadLine();
            string str4 =string.Format("用户名:{0}\n年龄:{1}\n班级:{2}", nameStr, ageStr, classStr);
            Console.WriteLine(str4);

            #endregion
        }
    }
}
