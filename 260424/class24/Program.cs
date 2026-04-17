namespace class24
{
    class Program
    {

        #region 知识点一 基本概念
        //函数（方法）
        //本质是一块具有名称的代码块
        //可以使用函数（方法）的名称来执行该代码块
        //函数（方法）是封装代码进行重复使用的一种机制

        //函数（方法）的主要作用
        //1.封装代码
        //2.提升代码的复用率
        //3.抽象行为
        #endregion

        #region 知识点二 函数写在哪里
        //1.class语句块中
        //2.struct语句块中

        #endregion

        #region 知识点三 基本语法
        //static 返回类型 函数名（参数类型 参数名1，参数类型 参数2，...）
        //{
        //  函数的代码逻辑；
        //  return 返回值（如果有返回类型才返回）
        //}

        //1.关于static 不是必须的在没有学习类和结构体之前 都是必须写的

        //2-1关于返回类型 引出一个新的关键字 void（表示没有返回值）
        //2-2返回类型 可以写任意变量类型 14种变量类型+复杂数据类型（数组，枚举，结构体，类）

        //3.关于函数名 使用帕斯卡命名法命名 
        //4.参数不是必须的，可以有0~n个参数 参数的类型也是任意类型的 14种变量类型+复杂数据类型
        //多个参数的时候需要用逗号隔开
        //参数名 驼峰命名法

        //5.当返回类型不为void是 必须通过新的关键词return返回

        #endregion

        #region 知识点四 实际运用
        //1.无参无返回函数

        static void SayHello()
        {
            Console.WriteLine("你好世界");
            //返回值是void是 可以省略return
        }
        //2.有参无返回函数
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是：{0}", name);
        }
        //3.无参有返回值函数
        static string WhatYourName()
        {
            return "唐老狮";
        }
        //4.有参又返回值函数
        static int sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //5.有参有多返回值
        //传入两个数 然后计算出两个数的和 以及他们俩的平均数 的出结果返回出来
        static int[] Calc(int a,int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            int[] arr = { sum, avg };
            return arr;
        }
        #endregion

        #region 知识点五 关于return
        //即使函数没有返回值，我们也可以使用return
        //return可以直接不执行之后的代码，直接返回函数外部

        static void Speak(string str)
        {
            if (str == "混蛋")
            {
                return;
            }
            Console.WriteLine(str);
        }

        #endregion

        //习题一函数
        static int CheckMax(int a, int b)
        {
            return a > b ? a : b;
        }
        //习题二函数
        static float[] CalcCirc(float r)
        {
            float[] f = new float[2];
            f[0] = 3.14f * r * r;
            f[1] = 3.14f * r * 2;
            return f;
        }
        //习题三函数
        static void Calc(int[] arr)
        {
            int sum = 0;
            int avg = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            avg=sum/arr.Length;
            Console.WriteLine("数组的最大值为{0}，最小值为{1}，总数为{2},平均数为{3}", max, min, sum, avg);

        }
        //练习题四函数
        static bool IsPrime(int num)
        {
            bool result = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                }
            }

            return result;
        }
        //练习题五
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("函数——基础");
            SayHello();
            SayYourName("唐老狮");
            string str = WhatYourName();
            Console.WriteLine(str);
            int c = sum(1 , 2);
            Console.WriteLine(c);
            int[] arr = Calc(1 , 2);
            Console.WriteLine(arr[0]+" " + arr[1]);
            Speak("混蛋");

            #region 练习题一
            //写一个函数，比较两个数字的大小返回最大值
            Console.WriteLine(CheckMax(99, 7));
            #endregion

            #region 练习题二
            //写一个函数用于计算一个圆的面积和周长并打印
            float [] f = CalcCirc(3);

            Console.WriteLine("圆的面积是{0}，圆的周长是{1}", f[0], f[1]);
            #endregion

            #region 练习题三
            //写一个函数，求一个数组的总和，最大值，最小值，平均值
            //参数：传一个数组，返回值，可以用数组返回，把这些返回回去
            //也可以没有返回值，直接内部打印
            int[] array = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Calc(array);

            #endregion

            #region 练习题四
            //写一个函数判断你传入的参数是不是质数
            int num = int.Parse(Console.ReadLine());
            bool result= IsPrime(num);
            Console.WriteLine("{0}{1}质数",num,result?"是":"不是");

            #endregion

            #region 练习题五
            //写一个函数 判断是否为闰年
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}闰年", year, IsLeapYear(year) ? "是" : "不是");

            #endregion
        }
    }

}
