namespace class27
{
    internal class Program
    {
        #region 知识点一 基本概念
        //概念
        //在同一语句块中（class或则struct）中
        //函数在（方法）名相同
        //参数的数量不同
        //或则
        //参数的数量相同但是类型或则顺序不同

        //作用：
        //1.命名一组功能相似的函数，减少函数名的数量避免空间的污染
        //2.提升程序的可读性
        #endregion


        #region 知识点二 实列
        //注意：
        //1.重载和返回值类型无关 只和参数类型 个数 顺序有关
        //2.调用时，程序会根据传入的参数类型和数量判断调用哪一个函数
        static int CalcSum(int a, int b)
        {
            return a + b;
        }


        //参数不同
        static int CalcSum(int a, int b, int c)
        {
            return a + b + c;
        }

        //参数数量相同 类型不同
        static float CalcSum(float a, float b)
        {
            return a + b;
        }

        //数量相同 顺序不同
        static float CalcSum(int a, float b, int c)
        {
            return a + b + c;
        }
        static float CalcSum(int a, int b, float c)
        {
            return a + b + c;
        }
        //ref和out
        //ref和out可以理解成他们是一种变量类型
        //可以用在重载中但是不能同时修饰变量类型和数量都一样的
        static float CalcSum(ref float f, int a)
        {
            return f + a;
        }

        //static float CalcSum(out float f, int a)
        //{
        //  return f + a;出现报错警告
        //}
        static float CalcSum(int a, int b, params int[] arr)
        {
            return 1;
        }
        //注意变长参数可以用来函数重载，但是默认参数是不可以函数重载的


        #endregion

        //总结
        //概念：同一个语句块中 函数名项同 参数名或类型不同
        //我们可以称为函数重载


        //练习题一函数
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static float GetMax(float a, float b)
        {
            return a > b ? a : b;
        }
        static double GetMax(double a, double b)
        {
            return a > b ? a : b;
        }
        //练习题二函数
        static int GetMax(params int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入参数");
                return -1;
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static float GetMax(params float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入参数");
                return -1;
            }
            float max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static double GetMax(params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入参数");
                return -1;
            }
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");

            
            Console.WriteLine(CalcSum(4, 7));
            Console.WriteLine(CalcSum(4, 7, 9));
            Console.WriteLine(CalcSum(4.6f, 7.9f));
            Console.WriteLine(CalcSum(4, 7, 7.9f));
            Console.WriteLine(CalcSum(4, 7.8f, 9));

            #region 练习题一
            //请重载一个函数
            //让其可以比较两个int或则两个float或则两个double的大小
            //并返回较大的那个值
            Console.WriteLine(GetMax(5,7));
            Console.WriteLine(GetMax(9.9f, 4.7f));
            Console.WriteLine(GetMax(5.7, 2.2));

            #endregion

            #region 练习题二
            //请重载一个函数
            //让其可以比较n个int或者float或者n个double的大小
            //并返回最大的那个值（用params可变参数来表示）
            Console.WriteLine("练习题二");
            Console.WriteLine(GetMax(1,2,3,4,5,6,7,345,35,7,43,6));
            Console.WriteLine(GetMax(1.6f, 2.4f, 3335.5765f, 4.7f, 5, 6, 7, 345, 35, 7, 43, 6));
            Console.WriteLine(GetMax(1.7654, 2, 3687.47, 4, 5.346, 6, 7.364, 345, 35, 7, 43.463, 6.567));
            #endregion
        }
    }
}
