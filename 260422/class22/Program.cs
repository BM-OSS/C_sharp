namespace class22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");
            #region 知识点一 基本概念
            //交错数组是数组的数组 每个维度的数量可以不同
            //注意：二维数组的每行的列数相同，交错数组每行的数列可能不同

            #endregion
            #region 知识点二 数组的申明
            //变量类型[][] 交错数组名；
            int[][] array1;

            //变量类型[][] 交错数组名=new 变量类型[行][];
            int[][] array2 = new int[2][];

            //变量类型[][] 交错数组名=new 变量类型[行][]{一维数组1，一维数组2，...};
            int[][] array3 = new int[2][] { new int[] {1,2},
                                            new int[] {1 ,2,34,} 
                                          };

            //变量类型[][] 交错数组名=new 变量类型[][]{一维数组1，一维数组2，...};
            int[][] array4 = new int[][] { new int[] {1,2},
                                            new int[] {1 ,2,34,},
                                            new int[] {1 ,2,34,}
                                          };

            //变量类型[][] 交错数组名={一维数组1，一维数组2，...};
            int[][] array5 =  { new int[] {1,2},
                                new int[] {1 ,2,34,},
                                new int[]{ 4,46,76,7}
                              };
            #endregion

            #region 知识点三 数组的使用
            //1.数组的长度
            int[][] array6 = { new int[] {1,2,3,4 },
                               new int[] {1,2,3},
                               new int[]{3,4,6,7,9 } 
                             };
            //得到行长度
            Console.WriteLine(array6.GetLength(0));

            //得到列长度
            Console.WriteLine(array6[0].Length);


            //2.获取交错数组中的元素
            Console.WriteLine(array6[1][2]);

            //3.修改交错数组的元素
            array6[0][3] = 99;
            //4.遍历数组元素
            Console.WriteLine("******");
            for (int i = 0; i < array6.GetLength(0); i++)
            {
                for (int j = 0; j < array6[i].Length; j++)
                {
                    Console.Write(array6[i][j] + " ");
                }
                Console.WriteLine();
            }
            #endregion       
        }
    }
}
