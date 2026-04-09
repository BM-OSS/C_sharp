using System;

namespace class12
{
    class Program
    {
        static void Main(string[] rags)
        {
            Console.WriteLine("条件分支语句");
            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            //if语句是第一个 可以让我们的程序产生逻辑变化的语句

            #endregion

            #region 知识点二 if语句
            //作用 ，满足条件时 执行if{}里面的内容
            //与C语言里面类似
            if (true)
            {
                Console.WriteLine("满足条件");
            }
            //if嵌套使用（与C语言里面的相同）
            #endregion

            #region 知识点三 if...else
            //与C语言里面一样
            if (5>3)
            {
                //满足条件执行的代码
            }
            else 
            {
                //不满足条件时执行的代码
            }

            #endregion

            #region 知识点四 if...else if...else
            //产生多条分支，有个条件判断
            //与C语言里面的if...else if...else一样
            int a = 7;
            if (a > 6)
            {
                //执行语句
                Console.WriteLine("a大于6");
            }
            else if (a > 4)
            {
                //执行语句
                Console.WriteLine("a大于4");
            }
            else 
            {
                //执行语句
                Console.WriteLine("a不大于6，也不大于4");
            }
            //每个括号之间都可以继续嵌套添加代码
            //if...if...if的条件判断不如if...else if...else
            #endregion

            #region 练习题一
            //请用户输入今日看唐老狮视频多少分钟
            //如果大于60分钟
            //再控制台上输出“今天看视频花了xx分钟，看来你离成功又进了一步！”
            Console.WriteLine("练习题一");
            Console.WriteLine("今天看视频花了多少时间（分钟）");
            try
            {
                int sum = int.Parse(Console.ReadLine());
                if (sum > 60)
                {
                    Console.WriteLine("今天看视频花了{0}分钟，离成功又进了一步", sum);
                }
                else
                {
                    Console.WriteLine("还需要努力啊！");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的格式");
            }
            #endregion

            #region 练习题二
            //请输入你的语文，数学，英语，成绩
            //满足以下任一条件，则输出“非常棒，继续加油”
            //语文成绩大于70 并且 数学成绩大于80 并且英语成绩大于90
            //语文成绩大于90 并且 其他两门中有一门成绩大于70
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            Console.WriteLine("练习题二");
            try
            {
                Console.WriteLine("请输入语文成绩");
                int chinese = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入数学成绩");
                int math = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入英语成绩");
                int english = int.Parse(Console.ReadLine());
                if (chinese > 70 && math > 80 && english > 90)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else if (chinese == 100 || math == 100 || english == 100)
                {
                    Console.WriteLine("非常棒，继续加油");
                }
                else if (chinese > 90 && (math > 70 || english > 70))
                {
                    Console.WriteLine("非常棒，继续加油");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的值");
            }
            #endregion

            #region 练习题三
            //要求用户输入两个数a，b如果两个数可以
            //可以整除或者这两个数加起来大于100
            //则输出a的值，否则输出b的值
            Console.WriteLine("练习题三");
            try
            {
                Console.WriteLine("请输入一个数a");
                int a1 = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入另一个数b");
                int b1 = int.Parse(Console.ReadLine());
                if (a1 % b1 == 0 || b1 % a1 == 0 || a + b1 > 100)
                {
                    Console.WriteLine(a1);
                }
                else
                {
                    Console.WriteLine(b1);
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的值");
            }
            #endregion

            #region 练习题四
            //输入一个整数 如果这个数是偶数，
            //则打印“your input is even”
            //否则打印“your input is odd”
            Console.WriteLine("练习题四");
            try
            {
                Console.WriteLine("请输入1个整数");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("your input is even");
                }
                else
                {
                    Console.WriteLine("your input is odd");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的整数");
            }
            #endregion

            #region 练习题五
            //有3个整形变量，分别存储不同的值，
            //编写代码输出其中最大整数
            Console.WriteLine("练习题五");
            a = 7;
            int b = 67;
            int c = 64;
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            #endregion

            #region 练习题六
            //写一个程序接收用户输入的字符，如果输入的
            //字符是0~9数字中的一个
            //就显示“你输入了一个数字”
            //否则显示“这不是一个数字”
            Console.WriteLine("练习题六");
            Console.WriteLine("请输入一个字符");
            int result = Console.ReadKey().KeyChar;
            if (result >= '0' && result <= '9')
            {
                Console.WriteLine("\n你输入了一个数字");
            }
            else
            {
                Console.WriteLine("\n这不是一个数字");
            }
            #endregion

            #region 练习题七
            //提示用户输入用户名，然后再提示输入密码
            //如果用户名是“admin”
            //并且密码是“8888”，则提示登录成功
            //如果用户名不是“admin”则提示用户不存在
            //如果用户名是admin则提示密码错误
            Console.WriteLine("练习题七");
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            if (name == "admin" && passWord == "8888")
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                if (name != "admin")
                {
                    Console.WriteLine("用户不存在");
                }
                else
                {
                    Console.WriteLine("密码错误");
                }
            }
            #endregion

            #region 练习题八
            //提示用户输入年龄，如果大于18，则告知
            //用户可以查看，
            //如果小于13岁，则告知不允许查看，如果大于等于13并且小于18
            //则提示用户是否继续查看（yes/no）
            //如果用户输入yes则提示用户“请查看”，否则提示“退出”
            Console.WriteLine("练习题八");
            try
            {
                Console.WriteLine("请输入你的年龄");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("你可以查看");
                }
                else if (age >= 13 && age < 18)
                {
                    Console.WriteLine("是否继续查看(yes/no)");
                    string street = Console.ReadLine();
                    if (street == "yes")
                    {
                        Console.WriteLine("可以继续查看");
                    }
                    else
                    {
                        Console.WriteLine("不可以继续查看,即将退出");
                    }
                }
                else
                {
                    Console.WriteLine("退出");
                }
            }
            catch
            {
                Console.WriteLine("请输入整数年龄");
            }
            #endregion

            #region 练习题九
            //请说明以下代码的打印结果（不通过运行程序）
            Console.WriteLine("练习题九");
            //a = 5;
            //if (a > 3)
            //{
            //    int b = 0;
            //    ++b;
            //    b += a;
            //}
            //Console.WriteLine(b);
            //int b=0;是申明的局部变量，而不是全局变量
            //if后面的打印代码中的b是全局变量，
            //而if外面没有申明b，运行会报错
            #endregion
        }
    }
}

