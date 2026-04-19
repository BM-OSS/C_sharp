namespace class26
{
    internal class Program
    {
        #region 知识点一 函数语法复习
        //static void 函数名（参数类型 参数1,参数类型 参数2,...）
        //{
        //   return 返回值
        //}

        //1.静态关键词 可选 目前对于我们来说必须写
        //2.返回值，没有返回值填void 可以谈些任意类型的变量
        //3.函数名，帕斯卡命名法
        //4.参数可可以是0~n个 前面可以加 ref和out 
        //5.如果返回值不是void 那么必须要有return对应类型的内容 
        //return可以打断函数语句的逻辑，停止后面的逻辑
        #endregion
        #region 知识点二 边长参数关键字
        //变长关键字 params
        static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //params int[] 意味这可以传入n个int参数，
        //注意：
        //1.params关键字后面必为数组
        //2.数组的类型可以是任意的类型

        //3.函数参数可以有 别的参数和params关键字修饰的函数
        //4.函数参数中只能最多出现一个 params关键字
        //并且一定是在最后一组数组参数 前面可以有n个其它参数

        //static void Eat(string name, params string[] things, int a)
        //{                             //这个位置会报错，因为边长参数必须在最后

        //}

        #endregion

        #region 知识点三 参数默认值
        //有参数默认值的参数 一般称为可选参数
        //作用是 当调用函数时可以不传入参数，不传参数就会使用默认值作为参数的值

        static void Speak(string str = "我没什么话可说")
        {
            Console.WriteLine(str);
        }

        //注意：
        //1.支持多个参数默认值，每个参数都可以有默认值
        //2.如果要混用 可选参数 必须写在普通参数后面



        #endregion

        //练习题一函数
        static void ClacSum(params int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有参数");
            
                return ;
            }
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("得出的和是{0}，平均数是{1}",sum,avg);
        }
        //练习题二函数
        static void Calc(params int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有参数");
                return;
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum1 += arr[i];
                }
                else
                {
                    sum2 += arr[i];
                }
               
            }

            Console.WriteLine("奇数和为{0}，偶数和为{1}", sum1, sum2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("变长参数和参数默认值");

            Sum(1, 2, 3, 4, 5, 6, 7);

            Speak();
            Speak("123123");

            #region 练习题一
            //使用param参数 求多个数字的和以及平均数
            ClacSum();
            ClacSum(1,2,3,4,5,6,7,8,9,10);
            #endregion

            #region 练习题二
            //使用params参数求多个的数字的偶数和奇数和
            Calc();
            Calc(1,2,3,4,5,6,7,8,9,10);

            #endregion

        }
    }
}
