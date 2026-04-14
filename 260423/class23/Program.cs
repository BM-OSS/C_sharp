namespace class23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");
            #region 知识点一 变量类型的复习
            //无符号整形

            //有符号整形

            //浮点数

            //特殊类型

            //复杂数据类型
            //1.枚举类型
            //2.数组（一维，二维，多维）

            //以上类型分成值类型和引用类型
            //引用类型  string 数组 类
            //值类型  其它，结构体 
            #endregion

            #region 知识点二 值类型和引用类型的区别
            //1.使用上的区别
            //值类型
            int a = 0;
            //引用类型
            int[] arr = new int[] { 1, 2, 3, 4, };
            //申明一个b让其等于之前的a            
            int b=a;
            //申明一个arr2让其等于之前的arr
            int[] arr2 = arr;
            Console.WriteLine("改变前a={0},b={1}",a,b);
            Console.WriteLine("改变前arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            b = 20;
            arr2[0] = 5;
            Console.WriteLine("改变后a={0},b={1}", a, b);
            Console.WriteLine("改变后arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);

            //值类型 再相互赋值时 把内容拷贝给了对方 他变我不变
            //引用类型的相互赋值 是让两者指向同一个值 他变我也变
            //类似于C语言里面的指针相关的区别


            //为什么有以上的区别
            //值类型 和引用类型 存储在不同的内存区域
            //值类型存储在栈空间 ————系统分配内存 自动回收 小而快
            //引用类型 存储在堆内存上 ————手动申请分配和释放，大而慢
            #endregion
            Console.WriteLine("*************");
            arr2 = new int[] { 99, 3, 2, 1 };
            Console.WriteLine("改变后arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            Console.WriteLine("特殊引用类型string");
            #region 知识点一 对比值和引用类型
            //值类型————它变我不变————存储在栈内存中
            //无符号整形 有符号整形 浮点数 char bool 结构体
            //引用类型————它变我也变————存储在堆内存中
            //数组 ，strig，类

            #endregion

            #region 知识点二 string的它变我不变
            string str1 = "123";
            string str2 = str1;
            str2 = "321";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            //string是引用类型 但它非常特殊 它具备值类型的特征 它变我也变
            //string虽然方便 但是有一个小缺点 就是频繁的改变string
            //从新赋值会产生大量的内存垃圾
            #endregion

            
        }
    }
}
