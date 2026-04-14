using System.Runtime.CompilerServices;

namespace class21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");

            #region 知识点一 基本概念
            //二维数组 是使用两个下标索引类确定元素数组
            //两个下标可以理解成 行标 列标
            //比如矩阵
            //可以用二维数组 int[2，3]表示
            //好比 两行 三列的数据集合
            #endregion

            #region 知识点二 二维数组的申明
            //变量类型[,] 变量名；
            int[,] arr;//申明后会在在后面进行初始化

            //变量类型[,] 变量名 = new 变量类型[行，列];
            int[,] arr2 = new int[3, 3];

            //变量类型[,] 变量名 = new 变量类型[行，列]{ {0行内容1，0行内容2...},{1行内容，...} ,...  }
            int[,] arr3 = new int[3, 3] { 
                                            { 1, 2, 3 }, 
                                            { 4, 5, 6 }, 
                                            { 7, 8, 9 } 
                                        };
            //变量类型[,] 变量名 = new 变量类型[ ，]{ {0行内容1，0行内容2...},{1行内容，...} ,...  }
            int[,] arr4 = new int[3, 3] {
                                            { 1, 2, 3 },
                                            { 4, 5, 6 },
                                            { 7, 8, 9 }
                                        };
            //变量类型[,] 变量名 = { {0行内容1，0行内容2...},{1行内容，...} ,...  }
            int[,] arr5 =  {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                           };
            #endregion

            #region 知识点三 二维数组的使用
            //1.二维数组的长度
            int[,] array6 = new int[2, 3] {
                                          {1,2,3 },
                                          {4,5,6 } };
            //得到行
            Console.WriteLine(array6.GetLength(0));
            //得到列
            Console.WriteLine(array6.GetLength(1));
            //2.获取二维数组中的元素
            //注意：索引是从0~长度-1（避免越界溢出）
            Console.WriteLine(array6[0, 1]);
            Console.WriteLine(array6[1, 2]);

            //3.修改二维数组中的元素
            array6[0, 0] = 99;
            Console.WriteLine(array6[0,0]);

            //4.遍历数组中的元素
            //把二维数组看作一个矩阵
            //用两层for循环进行遍历
            Console.WriteLine("*************");
            for (int i = 0; i < array6.GetLength(0); i++)
            {
                for (int j = 0; j < array6.GetLength(1); j++)
                {
                    Console.Write(array6[i, j]+" ");
                }
                Console.WriteLine();
            }
            //5.增加数组的元素
            //数组确定后就不能再增加或则减少数组的大小了；
            int[,] array7 = new int[3, 3];
            for (int i = 0; i < array6.GetLength(0); i++)
            {
                for (int j = 0; j < array6.GetLength(1); j++)
                {
                    array7[i, j] = array6[i, j];
                }
                
            }
            array6 = array7;
            array6[2, 0] = 7; 
            array6[2, 1] = 8;
            array6[2, 2] = 9;
            Console.WriteLine("*********");
            for (int i = 0; i < array6.GetLength(0); i++)
            {
                for (int j = 0; j < array6.GetLength(1); j++)
                {
                    Console.Write(array6[i, j] + " ");
                }
                Console.WriteLine();
            }

            //6.减少数组的元素
            //与方法与二维数组增加相同
            //格式和一维数组的减少元素相似

            //7.查找数组中的元素
            //格式和一维数组的查找元素相似

            #endregion

            #region 练习题一
            Console.WriteLine("练习题一");
            //将1~10000赋值给一个二维数组（100行100列）
            int[,] array8 = new int[100, 100];
            int index = 1;
            for (int i = 0; i < array8.GetLength(0); i++)
            {
                for (int j = 0; j < array8.GetLength(1); j++)
                {
                    array8[i, j] = index++;
                    Console.Write(array8[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题二
            //将一个二维数组[4，4]的右上部分置零（元素随机1~100）
            int[,] array9 = new int[4, 4];
            Random R= new Random();
            for (int i = 0; i < array9.GetLength(0); i++)
            {
                for (int j = 0; j < array9.GetLength(1); j++)
                {
                    array9[i, j] = R.Next(1, 101);
                    if (i <= 1 && j > 1)
                    {
                        array9[i,j] = 0;
                    }
                    Console.Write(array9[i, j] + " ");

                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题三
            Console.WriteLine("***********");
            //求二维数组[3,3]对角线元素的和（随机数1~10）
            int[,] array10 = new int[3, 3];
            int sum1 = 0;
            for (int i = 0; i < array10.GetLength(0); i++)
            {
                for (int j = 0; j < array10.GetLength(1); j++)
                {
                    array10[i, j] = R.Next(1, 11);
                    if (i == j || i + j == 2)
                    {
                        sum1 += array10[i, j];
                    }
                    Console.Write(array10[i, j] + " ");
                
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum1);
            #endregion

            #region 练习题四
            //求二维数组[5,5]中最大元素值及其行列号（元素随机1~500）
            Console.WriteLine("***************");
            int[,] array11 = new int[5, 5];
            int max = 0;
            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < array11.GetLength(0); i++)
            {
                for (int j = 0; j < array11.GetLength(1); j++)
                {
                    array11[i, j] = R.Next(1, 501);
                    if (max < array11[i, j])
                    {
                        max= array11[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                    Console.Write(array11[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("该数列的最大值为{0}，其行号为{1}，列号为{2}", max, maxI, maxJ);
            #endregion

            #region 练习题五
            //给一个M*N的二维数组，数组元素的值为0或则1
            //要求转换数组，将行有1的行和列全部置为1
            Console.WriteLine("*****************");
            int[,] array12 = new int[5, 5] { { 0, 0, 0, 0, 0 }, 
                                             { 0, 0, 0, 0, 0 },
                                             { 0, 1, 1, 1, 0 },
                                             { 0, 0, 1, 0, 0 },
                                             { 0, 0, 0, 0, 0 },};
            bool[] hang = new bool[5] ;
            bool[] lie = new bool[5];
            for (int i = 0; i < array12.GetLength(0); i++)
            {
                for (int j = 0; j < array12.GetLength(1); j++)
                {
                    //array12[i, j] = R.Next(0, 2);
                    Console.Write(array12[i, j]+" ");
                    if (array12[i, j] == 1)
                    {
                        hang[i] = true;
                        lie[j] = true;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************");
            for (int i = 0; i < array12.GetLength(0); i++)
            {
                for (int j = 0; j < array12.GetLength(1); j++)
                {
                    if (hang[i] == true || lie[j] == true)
                    {
                        array12[i,j] = 1;
                    }
                    Console.Write(array12[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
