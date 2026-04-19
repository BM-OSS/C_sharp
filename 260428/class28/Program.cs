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

            #region 练习题四
            //用递归函数求1！+2！+3！+...+10!;



            #endregion
        }
    }
}
