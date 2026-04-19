namespace class28
{
    internal class Program
    {
        #region 知识点一 基本概念
        //递归函数就是函数自己调用自己


        //一个真确的递归函数
        //1.必须有一个结束调用的条件
        //2.用于条件的判断的条件必须改变能够达到停止的目的

        //注意：如果没有中断递归的条件栈内存会爆炸

        #endregion


        #region 知识点二 实列
        //用递归函数打印出0~10
        static void Fun(int a)
        {
            Console.WriteLine(a);
            a += 1;
            if (a > 10)
            {
                return ;
            }
            Fun(a);
        }
        #endregion

        //练习题二函数
        static int Fun2(int num)
        {
            if(num==1)
            {
                return 1;
            }
            return num*Fun2(num-1);
        }

        //练习题三函数
        static int Fun3(int num)
        {
            //借用刚刚写过的函数
            if (num == 1)
            {
                return 1;
            }
            return Fun2(num)+Fun3(num-1);
        }
        //练习题四函数
        static void Fun4(float length, int day)
        {
            if (day == 10)
            {
                Console.WriteLine("第十天的长度是{0}",length);
                return ;
            }
            length /= 2;
            ++day;
            Fun4(length, day);
        }
        //练习题五函数
        static bool Fun5(int num)
        {
            Console.WriteLine(num);
            return num == 200 || Fun5(num + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");
            Fun(0);

            #region 练习题一
            //使用递归的方式打印0~10；
            //上面已完成，不重复
            #endregion
            #region 练习题二
            //传入一个值 递归求该值的阶乘 并返回
            Console.WriteLine("练习题二");
            Console.WriteLine(Fun2(6));

            #endregion

            #region 练习题三
            //用递归函数求1！+2！+3！+...+10!;
            Console.WriteLine("练习题三");
            Console.WriteLine(Fun3(10));

            #endregion

            #region 练习题四
            //一根竹竿有100m，每一天砍掉一半，求第十天它的长度是多少（从第0天开始）
            Fun4(100, 0);
            #endregion

            #region 练习题五
            //不允许使用循环语句 条件语句 在控制台中打印出1~200这200个书（提示：递归+短路）
            Console.WriteLine("练习题五");
            Fun5(1);
            #endregion
        }
    }
}
