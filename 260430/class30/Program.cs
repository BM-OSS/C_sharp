using System;

namespace class30
{
    class Program
    {
        #region 练习题二
        //写一个函数，实现一个数组的排序，并返回结果，可以根据参数决定是升序还是降序
        static int[] Sort(int[] array, bool TrueOrFalse)
        {
            int temp;
            int isSort;
            bool order;
            for (int i = 0; i < array.Length; i++)
            {
                isSort = 0;
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    order = TrueOrFalse ? array[j] > array[j + 1] : array[j] < array[j + 1];
                    if (order)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSort = 1;   
                    }
                }
                if (isSort == 0)
                {
                    break;
                }
            }
            return array;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");

            #region 知识点一 排序的基本概念
            //把无序变成有序（升序或降序）
            #endregion

            #region 知识点二 冒泡排序的基本原理
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            //第i项与i+1项比较，直到第Length-1项为止
            #endregion

            #region 知识点三 代码呈现
            int[] arr = new int[] { 435, 65, 74, 74, 5, 7, 3, 6534, 6 };
            int temp;
            int result;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                result = 0;
                for (int j = 0; j < arr.Length - 1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        result = 1;
                    }
                }
                if (result == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }


            #endregion

            #region 练习题一
            //定义一个数组长度为20，每个元素值随机0~100
            //使用冒泡排序进行升序排序并打印
            //使用冒泡排序进行降序排序并打印
            Console.WriteLine();
            Console.WriteLine("练习题一");
            int[] arr2 = new int[20];
            Random R = new Random();
            //升序
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = R.Next(0,101);
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < arr2.Length; i++)
            {
                bool index = false;
                for (int j = 0; j < arr2.Length-1-i; j++)
                {
                    if (arr2[j] > arr2[j + 1])
                    {
                        int temp1 = arr2[j+1];
                        arr2[j + 1] = arr2[j];
                        arr2[j] = temp1;
                        index = true;
                    }
                }
                if (index == false)
                {
                    break;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            { 
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            //降序
            for (int i = 0; i < arr2.Length; i++)
            {
                bool index = false;
                for (int j = 0; j < arr2.Length - 1 - i; j++)
                {
                    if (arr2[j] < arr2[j + 1])
                    {
                        int temp1 = arr2[j + 1];
                        arr2[j + 1] = arr2[j];
                        arr2[j] = temp1;
                        index = true;
                    }
                }
                if (index == false)
                {
                    break;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }



            #endregion

            #region 练习题二
            //写一个函数，实现一个数组的排序，并返回结果，可以根据参数决定是升序还是降序
            int[] array = new int[20];
            bool TrueOrFalse;
            Console.WriteLine("练习题二");
            Console.WriteLine("排序前");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = R.Next(0,101);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("请选择升序或者降序true代表升序排列false代表降序排列");
            TrueOrFalse = bool.Parse(Console.ReadLine());
            Sort(array, TrueOrFalse);
            Console.WriteLine("排序后");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            #endregion



        }
    }
}
