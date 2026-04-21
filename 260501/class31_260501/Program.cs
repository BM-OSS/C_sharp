using System;
using System.Linq.Expressions;
using System.Reflection;

namespace class31
{
    class Paogram
    {
        #region 练习题一
        //定义一个数组长度为20，每个元素是随机数0~100
        //写出函数能够进行升序或者降序排序
        static int[] Sort(int[] arr, bool TrueOrFalse)
        {
            int temp;
            bool order;
            int index;
            for (int i = 0; i < arr.Length; i++)
            {
                index = 0;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    order = TrueOrFalse ? arr[index] < arr[j] : arr[index] > arr[j];
                    if (order)
                    {
                        index = j;
                    }
                }
                if (index != arr.Length - 1 - i)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
            }

            return arr;
        }



        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");

            #region 知识点一 选择排序基本原理
            //建立一个中间商
            //依次比较
            //找出极值（最大或者最小）
            //放入目标位置
            //比较n轮



            #endregion

            #region 知识点二 代码实现
            //实现升序的选择排序
            int[] array = new int[20];
            Random r = new Random();
            //排序前
            Console.WriteLine("排序前");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1,101);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            int temp;
            int index;
            
            for (int i = 0; i < array.Length; i++)
            {
                index = 0;
                
                for (int j = 1; j < array.Length-i; j++)
                {
                    if (array[j] > array[index])
                    {
                        index = j;
                    }
                }
                temp = array[array.Length - 1-i];
                array[array.Length - 1 - i] = array[index];
                array[index] = temp;
            }
            //排序后
            Console.WriteLine("排序后");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            #endregion

            #region 练习题一
            //定义一个数组长度为20，每个元素是随机数0~100
            //写出函数能够进行升序或者降序排序
            Console.WriteLine();
            Console.WriteLine("练习题一");
            int[] arr = new int[20];
            bool TrueOrFalse ;
            while (true)
            {
                try
                {
                    //排序前
                    Console.WriteLine("排序前");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = r.Next(1, 101);
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("请选择你需要的排序种类true代表升序false代表降序");
                    TrueOrFalse = bool.Parse(Console.ReadLine());
                    Sort(arr, TrueOrFalse);
                    //排序后
                    Console.WriteLine("排序后");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                catch
                {
                    Console.WriteLine("只能输入true或者false");

                }
            }

            #endregion

        }
    }
}
