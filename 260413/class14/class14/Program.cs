using System;

namespace class14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while语句");

            #region 知识点一 作用
            //让顺序执行的代码
            //可以不停的循环执行某一行代码快的内容
            //条件分支语句是让代码产生分支
            //循环语句是让代码可以被重复执行

            #endregion


            #region 知识点二 相关语法
            while (false)//括号里面填写bool相关
            {
                Console.WriteLine("ssr");
            }//循环条件与C语言里面的条件有些不一样
            //C#里面括号里面的内容必须是
            //能转换成bool类型里面的两个值类型的相关类容
            #endregion

            #region 知识点三 嵌套使用
            //不仅可以嵌套if，switch还可以嵌套while
            int a = 0;
            int b = 0;
            while (a++ < 3)
            {
                b = 0;
                while (b++ < 3)
                {
                    
                    Console.WriteLine("还有机会，继续努力");
                }
            }
            while (a < 3)
            {
                ++a;
                if (b < 3)
                {
                    ++b;
                }
            }
            int a2 = 0;
            while (a2 < 10)
            {
                ++a2;
                int b2 = 0;
                //每次循环后的b2
                //就和上一次的b2不一样了
                Console.WriteLine(b2);
                while (b2 < 10)
                {
                    ++b2;
                    Console.WriteLine(b2);
                }
            }
            #endregion

            #region 知识点四 流程控制关键词
            //作用：控制循环逻辑的关键词
            //break:跳出循环（和循环里面的if没有关系只和本层while有关系）
            //continue:结束本次循环，进行下一次循环（和循环里面的if没有关系只和本层while有关系）
            //打印0到20的奇数
            int index = 0;
            while(index<20)
            {

                index++;
                if (index % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(index);
                

            }




            #endregion

            #region 练习题一
            //在控制台上输出1到100
            Console.WriteLine("练习题一");
            int i = 0;
            while (i < 100)
            {
                i++;
                Console.WriteLine(i);
            }
            #endregion

            #region 练习题二
            //在控制台上输出1到100之间所有整数的和
            i = 0;
            int sum = 0;
            Console.WriteLine("练习题二");
            while (i < 100)
            {
                i++;
                sum += i;
            }
            Console.WriteLine(sum);

            #endregion

            #region 练习题三
            //用while和continue实现计算
            //1到100之间能被7整除之外的所有整数之和
            i = 0;
            sum = 0;
            Console.WriteLine("练习题三");
            while (i < 100)
            {
                i++;
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);

            #endregion

            #region 练习题四
            //提示用户输入一个数，判断该数是否为素数并打印
            Console.WriteLine("练习题四");
            try
            {
                Console.WriteLine("请输入一个整数");
                int num2 = int.Parse(Console.ReadLine());
                index = 2;
                while (index <= num2 / 2)
                {
                    if (num2 % index == 0)
                    {
                        Console.WriteLine("不是素数");
                        break;
                    }
                    else if (index == num2 / 2)
                    {
                        Console.WriteLine("是素数");
                        break;
                    }
                    index++;

                }
            }
            catch
            {
                Console.WriteLine("请输入正确的内容");
            }
            #endregion

            #region 练习题五
            //要求输入用户名和密码（admin/8888），用户名或密码错误
            //提示“用户名或密码错误”，直到输入正确为止
            Console.WriteLine("练习题五");
            while (true)
            {
                Console.WriteLine("请输入用户名和密码");
                string userName = Console.ReadLine();
                string passWord = Console.ReadLine();
                if (userName == "admin" && passWord == "8888")
                {
                    Console.WriteLine("登录成功");
                    break;
                }
                else
                {
                    Console.WriteLine("用户名或密码错误");
                }
            }
            #endregion

            #region 练习题六
            //输入班级人数 然后依次输入学员成绩（需提示当前是第几个学员）
            //计算班级的平均成绩和总成绩
            Console.WriteLine("练习题六");
            try
            {
                Console.WriteLine("请输入班级的人数");
                int num1 = int.Parse(Console.ReadLine());
                sum = 0;
                index = 1;
                while (index <= num1)
                {
                    Console.WriteLine("请输入第{0}个学员的成绩", index);
                    int cj = int.Parse(Console.ReadLine());
                    sum += cj;
                    index++;

                }
                float avg = sum * 1.0f / num1;
                Console.WriteLine("班级总分为{0}，班级平均分为{1}", sum, avg);
            }
            catch
            {
                Console.WriteLine("请输入整数");
            }
            #endregion

            #region 练习题七
            //定义一个整形变量sum，然后分别把1~100
            //之间的数字依次累加到sum中
            //当sum的值大于500的时候，中断操作，
            //并在控制台上输出累加到第几个数字
            //就可以使sum大于500
            Console.WriteLine("练习题七");
            sum = 0;
            index = 0;
            while (index < 100)
            {
                index++;
                sum += index;
                if (sum > 500)
                {
                    break;
                }
            }
            Console.WriteLine("当累加到{0}时值大于500,其值为{1}", index, sum);
            #endregion

            #region 练习题八
            //假设看唐老狮视频的同学由100人，每月增长20%
            //请问按此速度增长，
            //经历多少个月看唐老狮视频的人能达到1000人？
            int persons = 100;
            int months = 0;
            Console.WriteLine("练习题八");
            while (persons <= 1000)
            {
                persons += (int)(persons * 0.2f);
                months++;
            }
            Console.WriteLine("经过{0}个月，看唐老狮的视频人数可以达到1000人", months);
            #endregion

            #region 练习题九
            //求数列 1,1,2,3,5,8,13...的第20位数字是多少？
            //斐波那偰数列 从第三个数开始
            //每一个数的值等于前两个数之和
            Console.WriteLine("练习题九");
            int n1 = 1;
            int n2 = 1;
            index = 0;
            int result = 0;
            while (index < 20)
            {
                index++;
                if (index == 1)
                {
                    result = n1;
                }
                else if (index == 2)
                {
                    result = n2;
                }
                else
                {
                    result = n1 + n2;
                    n1 = n2;
                    n2 = result;
                }
            }
            Console.WriteLine("第20个数等于{0}", result);
            #endregion

            #region 练习题十
            //找出100以内的所有素数并打印出来
            Console.WriteLine("练习题十");            
            int num = 2;
            while (num < 100)
            {
                int m = 2;
                while (m < num)
                {
                    if (num % m == 0)
                    {
                        break;
                    }
                    m++;
                }
                if (m == num)
                {
                    Console.WriteLine(num);
                }
                num++;
            }

            #endregion


        }
    }
}
