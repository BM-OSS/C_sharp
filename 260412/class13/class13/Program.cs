using System;

namespace class13
{
    class Program
    {
        static void Main(string[] rags)
        {
            Console.WriteLine("switch语句");
            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            #endregion

            #region 知识点二 基本语法

            int a = 3;
            switch (a)
            {

                case 1://case后面的值一定是为常量
                    //结果语句
                    break;
                case 2:
                    //结果语句
                    break;
                case 3:
                    //结果语句
                    break;
                default:
                    break;
            }
            float f = 1.4f;
            switch (f)
            {
                case 1.5f:
                    Console.WriteLine("f=1.5");
                    break;
                case 1:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("f什么条件都不满足，执行deault中的内容");
                    break;

            }
            #endregion

            #region 知识点三 default可以省略
            string str = "123";
            switch(str)
            {
                case "123":
                    Console.WriteLine("等于123");
                    break;
                case "234":
                    Console.WriteLine("等于234");
                    break;

            }

            #endregion

            #region 知识点四 可自定义常量
            char c = 'A';
            const char c2 = 'A';
            switch (c)
            {
                case c2:
                    Console.WriteLine("c等于A");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点五 贯穿
            //作用：满足某些条件时 做的事情时一样的 就可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("是个数字");
                    break;
                default:
                    break;
                    //在C#里面不写break也不
                    //也没有相应的其他操作时会发生贯穿作用
                    //在C#里面写完一个case和对应的操作代码后
                    //但不写break会报错

            }
            #endregion

            #region 练习题一
            //唐老师的工资是由基本工资+绩效决定的
            //绩效说明：
            //学生评价 很兴奋，则评级为A，绩效工资500
            //学生评价 很充实，则评级为B，不加绩效工资
            //学生评价 还好吧，则评级为C，绩效工资扣300
            //学生评价 难理解，则评级为D，绩效工资扣500
            //学生评价 枯燥乏味，则评级为E，绩效工资扣800

            //假设唐老师的绩效工资是4000
            //请用户输入唐老师的评级 并计算出唐老师的工资是多少？
            Console.WriteLine("练习题一");
            int money = 4000;
            Console.WriteLine("请输入唐老师的评级");
            string str1 = Console.ReadLine();
            switch (str1)
            {
                case "A":
                    money += 500;
                    break;
                case "B":
                    break;
                case "C":
                    money -= 300;
                    break;
                case "D":
                    money -= 500;
                    break;
                case "E":
                    money -= 800;
                    break;
                default:
                    Console.WriteLine("请给出相应对的评级");
                    break;
            }
            Console.WriteLine("唐老师的评价为{0}唐老师的工资是{1}", str1, money);


            #endregion

            #region 练习题二
            //小唐带了10元钱去买星巴克，三种型号先择：
            //1=（中杯 ￥5）
            //2=（大杯 ￥7）
            //3=（超大杯 ￥11）
            //请用户输入选择型号，如果钱够，
            //则购买成功，并计算出小王最后还剩多少钱？
            //如果钱不够则提示用户“钱不够，请换其他型号”
            int money2 = 10;
            Console.WriteLine("练习题二");
            Console.WriteLine("请输入你想要购买的型号(1是中杯，2是大杯，3是超大杯)");
            string str2 = Console.ReadLine();
            switch (str2)
            {
                case "1":
                    money2 -= 5;
                    Console.WriteLine("购买成功，你还剩{0}元", money2);
                    break;
                case "2":
                    money2 -= 7;
                    Console.WriteLine("购买成功，你还剩{0}元", money2);
                    break;
                case "3":
                    Console.WriteLine("请不够了，请换其他型号吧");
                    break;
                default:
                    Console.WriteLine("请输入正确的型号");
                    break;
            }
            #endregion

            #region 练习题三
            //输入学生的考试成绩，如果
            //   成绩>=90:A
            //80<=成绩<90:B
            //70<=成绩<80:C
            //60<=成绩<70:D
            //    成绩<60:E
            //使用siwtch语法完成成绩分级
            //并输出学生的考试等级
            Console.WriteLine("练习题三");
            try
            {
                Console.WriteLine("请输入学生成绩");
                int cj = int.Parse(Console.ReadLine());
                cj /= 10;
                switch (cj)
                {
                    case 10:
                        break;
                    case 9:
                        Console.WriteLine("你的成绩等级是A");
                        break;
                    case 8:
                        Console.WriteLine("你的成绩等级是B");
                        break;
                    case 7:
                        Console.WriteLine("你的成绩等级是C");
                        break;
                    case 6:
                        Console.WriteLine("你的成绩等级是D");
                        break;
                    default:
                        Console.WriteLine("你的成绩等级是E");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入正确的成绩");
            }
            #endregion

            #region 练习题四
            //在控制台输入一个(0~9)的数并显示为大写，
            //如输入2，显示为二
            Console.WriteLine("练习题四");
            try
            {
                Console.WriteLine("请输入0~9之间的数字");
                int s=int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (s)
                {
                    case 0:
                        Console.WriteLine("\n零");
                        break;
                    case 1:
                        Console.WriteLine("\n一");
                        break;
                    case 2:
                        Console.WriteLine("\n二");
                        break;
                    case 3:
                        Console.WriteLine("\n三");
                        break;
                    case 4:
                        Console.WriteLine("\n四");
                        break;
                    case 5:
                        Console.WriteLine("\n五");
                        break;
                    case 6:
                        Console.WriteLine("\n六");
                        break;
                    case 7:
                        Console.WriteLine("\n七");
                        break;
                    case 8:
                        Console.WriteLine("\n八");
                        break;
                    case 9:
                        Console.WriteLine("\n九");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\n请输入正确的数值");
            }
            #endregion
        }
    }
}