using System;
using System.Runtime.CompilerServices;

namespace class16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环");

            #region 知识点一 基本语法
            //for (/*初始表达式*/;/*条件表达式*/;/*增量表达式*/ )
            //{
            //    //循环代码
            //}
            //和C语言里面的方式一样
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i的值为{0}",i);
            }
            #endregion

            #region 知识点二 支持嵌套
            //和C语言里面的嵌套是一样的
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.WriteLine(i+"_"+k);
                }
            }
            //还可以和其他语句相互嵌套使用
            #endregion
            #region 知识点三 特殊写法
            //for循环可以写死循环
            //for循环的三个填写位置都可以填空

            #endregion
            #region 知识点四 对比while循环
            //for循环一般用来准确得到一个范围中的所有数
            for (int i = 0; i < 10; i++)
            { 
            }
            int j = 0;
            while (j < 10)
            {
                j++;
            }
            //for循环更加的清晰简洁
            #endregion
            #region 练习题一
            //输出1到100之间的整数（包含本身）
            Console.WriteLine("练习题一");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region 练习题二
            //求1~100之间所有偶数的和
            Console.WriteLine("练习题二");
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }

            }
            Console.WriteLine(sum);
            #endregion
            #region 练习题三
            //找出100~999之间的水仙花数
            //153=1*1*1+5*5*5+3*3*3这个数就是水仙花数
            Console.WriteLine("练习题三");
            int bai = 0;
            int shi = 0;
            int ge = 0;
            for (int i = 100; i <= 999; i++)
            {
                bai = i / 100;
                shi = i % 100 / 10;
                ge = i % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    Console.WriteLine("该数{0}是水仙花数",i);
                }
            }
            #endregion
            #region 练习题四
            //在控制台上输出九九乘法表
            Console.WriteLine("练习题四");
            for (int i = 1; i <= 9; i++)
            {
                for (int m = 1; m <= i; m++)
                {
                    Console.Write("{0}X{1}={2}  ",m,i,m*i);
                }
                Console.WriteLine("\n");
            }
            #endregion
            #region 练习题五
            //在控制台上输出如下10*10的空心星型方阵
            //**********
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //**********
            for (int i = 0; i < 10; i++)
            {
                for (int m = 0; m < 10; m++)
                {

                    if (m == 0 || m == 9)
                    {
                        Console.Write("*");
                    }
                    else if ((i == 0 && m != 0 && m != 9) || (i == 9 && m != 9 && m != 0))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            
            }
            #endregion

            #region 练习题六
            //在控制台上输出如下10*10的三角型方阵
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********
            Console.WriteLine("练习题六");
            for (int i = 0; i < 10; i++)
            {
                for (int m = 0; m <= i; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题七
            //打印如下的10行三角形方阵
            //         *           1
            //        ***          2
            //       *****         3
            //      *******        4
            //     *********       5
            //    ***********      6
            //   *************     7
            //  ***************    8
            // *****************   9
            //******************* 10
            Console.WriteLine("练习题七");
            for (int i = 0; i < 10; i++)
            {
                for (int m = 0; m < 10 - i - 1; m++)
                {
                    Console.Write(" ");
                }
                for (int n = 2 * i + 1; n > 0; n--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
