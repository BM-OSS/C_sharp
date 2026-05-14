using System;
using System.Collections;
namespace class61_260513
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            #region 知识点一 栈的本质
            //Stack（栈）是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Stack是栈存储容器，栈是一种先进后出的数据结构
            //先存入的数据后获取，后存入的数据先获取
            //栈是先进后出
            #endregion

            #region 知识点二 申明
            Stack stack = new Stack();
            #endregion


            #region 知识点三 增取查改
            //压线
            //增
            stack.Push(1);
            stack.Push(1234);
            stack.Push(true);
            stack.Push(false);
            stack.Push(5468);
            //取
            //栈里面只有取的概念
            object v = stack.Pop();
            Console.WriteLine(v);

            v = stack.Pop();
            Console.WriteLine(v);

            //查
            //1.无法查看指定内容，
            //只能查看栈顶的内容

            v = stack.Peek();
            Console.WriteLine(v);

            //2.查看元素是否存在于栈中
            if (stack.Contains(1234))
            {
                Console.WriteLine("存在1234");
            }

            //改
            //栈无法改变指定的元素，
            //实在要改的话就只有清空
            stack.Clear();
            Console.WriteLine(stack);

            stack.Push(123);
            stack.Push(true);
            stack.Push(false);
            stack.Push(123456);
            Console.WriteLine(stack.Pop());
            #endregion

            #region 知识点四 遍历
            //1.长度
            //直接通过栈是没办法用for循环遍历的
            Console.WriteLine(stack.Count);

            //2.用foreach遍历
            //而且遍历出来的顺序，也是栈顶到栈底
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            //3.将栈转换为for循环数组
            //遍历出来的顺序是栈顶到栈底
            object[] array = stack.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(stack.Count);
            //4.循环弹栈
            while (stack.Count > 0)
            {
                object o = stack.Pop();
                Console.WriteLine(o);
            }


            #endregion

            #region  练习题
            //写一个函数，判断是否是二进制
            
            static void Calc(uint num)
            {
                Console.Write("{0}的二进制是:", num);
                Stack stack = new Stack();
                
                while (true)
                {
                    
                    stack.Push(num%2);
                    num /= 2;
                    if (num==1)
                    {
                        stack.Push(num);
                        break;
                    }
                    
                }
                
                while (stack.Count>0)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine();
            }
            Calc(10);
            Calc(6);
            Calc(8);
            Calc(5);

            #endregion

            #region 装箱拆箱



            #endregion


        }
    }
}