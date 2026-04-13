using System.Buffers;

namespace class20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");
            #region 知识点一 基本概念
            //数组是存储一组相同数据类型的集合
            //数组分为 一维，多维 交错数组
            //一般情况 一维数组 就简称 数组

            #endregion

            #region 知识点二 数组的申明
            //变量类型[] 数组名；//只是 申明了一个数组 但是没有开辟存储空间
            //变量类型 可以是学过的类型亦可以是没学过的
            int[] arr1;

            //变量类型[] 数组名 = new 变量类型[数组长度];
            int[] arr2 = new int[5];
            //这种方式 相当于开辟了5个内存空间，但房间里面默认为0

            //变量类型[] 数组名 = new 变量类型[数组长度]{内容1，内容2，...}
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };


            //变量类型[] 数组名 = new 变量类型[] {内容1，内容2，...} 
            int[] arr4 = new int[] { 1, 2, 3, 4, 5 };

            //变量类型[] 数组名 = {1,2,3,4,5};
            int[] arr5 = { 1, 2, 3, 4, 5 };


            bool[] arr6 = { true, false, true };

            #endregion

            #region 知识点三 数组的使用
            int[] array = { 1, 2, 3, 4, 5 };
            //1.数组的长度
            Console.WriteLine(array.Length);

            //2.获取数组中的元素
            Console.WriteLine(array[0]);
            Console.WriteLine(array[4]);
            //不能越界（左右边界都不能超过，0~Length-1）

            //3.修改数组中的元素
            array[0] = 99;
            Console.WriteLine(array[0]);

            //4.遍历数组
            //通过循环快速获得每一个元素的内容
            Console.WriteLine("****************");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //5.增加数组的元素
            //数组初始化以后 是不能够直接添加新元素
            int[] array2 = new int[6];
            Console.WriteLine("****************");
            //搬家办法
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array = array2;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //6.删除数组元素
            //数组初始化以后 是不能后直接删除元素的
            //删除仍然使用搬家原理
            Console.WriteLine("****************");
            int[] array3 = new int[5];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array[i];
            }
            array = array3;
            Console.WriteLine(array.Length);
            Console.WriteLine("****************");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            //7.查找数组元素
            //99 2 3 4 5
            //要查找 3这个元素在那个位置
            //只有通过遍历才能确定 数组中 是否存储了一个目标元素
            int a = 3;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (a == array[i])
                {
                    Console.WriteLine("和a相等的元素在{0}索引位置",i);
                    break;
                }
            }


            #endregion

            //总结
            //1.概念：同一变量类型的数据集合
            //2.一定要掌握知识的申明，遍历，增删查改
            //3.所有的变量类型都可以申明为 数组
            //4.它是用批量存储游戏中的同一类型对象的 容器
            //比如 所有的怪物 所有的玩家


            #region 练习题一
            //创建一个一维数组并赋值，让其与下标一样，长度为100
            int[] array4 = new int[100];
            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = i;
                Console.WriteLine(array4[i]);
            }
            #endregion

            #region 练习题二
            //创建另一个数组B，让数组A中的每一个元素
            //*2存入到数组B中
            Console.WriteLine("**************");
            int[] array5 = new int[100];
            for (int i = 0; i < array4.Length; i++)
            {
                array5[i] = array4[i] * 2;
                Console.WriteLine(array5[i]);
            }
            #endregion

            #region 练习题三
            //随机（0~100）生成1个长度为10的整数数组
            Console.WriteLine("******************");
            int[] array6 = new int[10];
            Random r = new Random();
            for (int i = 0; i < array6.Length; i++)
            {
                array6[i] = r.Next(1, 100);
                Console.WriteLine(array6[i]);
            }
            #endregion

            #region 练习题四
            //从一个整数数组中找出最大值，最小值，总和，平均值
            //（可以使用随机值1~100）
            Console.WriteLine("******************");
            Console.WriteLine("练习题四");
            int[] array7 = new int[10];
            
            for (int i = 0; i < array7.Length; i++)
            {
                array7[i]=r.Next(1, 100);
                Console.WriteLine(array7[i]);
            }
            int max = array7[0];
            int min = array7[0];
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < array7.Length; i++)
            {
                if (max <= array7[i])
                    max = array7[i];
                if (min >= array7[i])
                    min = array7[i];
                sum += array7[i];
            }
            avg = sum / array7.Length;
            Console.WriteLine("最小值是{0}，最大值是{1}，总和是{2}，平均数是{3}",min,max,sum,avg);
            #endregion

            #region 练习题五
            //交换数组的第一个和最后一个元素，
            //第二个后倒数第二个，
            //...依次类推实现数组的反转打印
            Console.WriteLine("练习题五");
            int[] array8 = new int[10];
            for (int i = 0; i < array8.Length; i++)
            {
                array8[i]=r.Next(1, 101);
                Console.WriteLine(array8[i]);
            }
            int temp;
            Console.WriteLine("*********");
            for (int i = 0; i < array8.Length/2; i++)
            {
                temp = array8[i];
                array8[i] = array8[array8.Length-1-i];
                array8[array8.Length - 1 - i] = temp;
                
            }
            for (int i = 0; i < array8.Length ; i++)
            {
                Console.WriteLine(array8[i]);
            }
            #endregion
            #region 练习题六
            Console.WriteLine("练习题六");
            //将一个整数数组的每一个元素进行如下的处理
            //如果元素是正数则将则个位置的元素增加1
            //如果这个元素是负数则将这个位置元素减1
            //如果元素是0，则不变
            int[] array9 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array9.Length; i++)
            {
                array9[i] = rand.Next(-10, 11);
                Console.WriteLine(array9[i]);
            }
            Console.WriteLine("***************");
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] > 0)
                {
                    array9[i] += 1;
                }
                else if (array9[i] < 0)
                {
                    array9[i] -= 1;
                }
                Console.WriteLine(array9[i]);
            }
            #endregion
            #region 练习题七
            //定义一个有10个元素的数组，是用for循环，输入10名同学的成绩
            //将成绩依次存入数组，然后分别求出最高分和最低分
            //并且求出10名同学的数学平均成绩
            Console.WriteLine("练习题七");
            //try
            //{
            //    int[] array10 = new int[10];
            //    for (int i = 0; i < array10.Length; i++)
            //    {
            //        array10[i] = int.Parse(Console.ReadLine());
            //        Console.WriteLine(array10[i]);
            //    }
            //    int maxScore = array10[0];
            //    int minScore = array10[0];
            //    int sumScore = 0;
            //    int avgScore = 0;
            //    for (int i = 0; i < array10.Length; i++)
            //    {
            //        if (array10[i] > maxScore)
            //        {
            //            maxScore = array10[i];
            //        }
            //        if (array10[i] < minScore)
            //        {
            //            minScore = array10[i];
            //        }
            //        sumScore += array10[i];
            //    }
            //    avgScore = sumScore / array10.Length;
            //    Console.WriteLine("最大成绩是{0}，最小成绩是{1}，平均成绩是{2}", maxScore, minScore, avgScore);

            //}
            //catch
            //{
            //    Console.WriteLine("输入有误，请重新输入");
            //}
            #endregion

            #region 练习题八
            //请申明一个string类型的数组（长度为25）（该数组存储首符号），
            //通过遍历数组的方式，取出其中的符号打印出以下效果
            //*#*#*
            //#*#*#
            //*#*#*
            //#*#*#
            //*#*#*
            string[] strs = new string[25];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i]=i%2==0?"*":"#";
            }
            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i]);
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

            #endregion
        }
    }
}
