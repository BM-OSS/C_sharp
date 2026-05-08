using System;
using System.Text;

namespace class56_260526
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共了类
            //主要解决的问题是：
            //修改字符串二不是创建一个新的对象，需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间


            #endregion

            #region 初始化 直接指明内容
            StringBuilder str = new StringBuilder("123123");
            //StringBuilder("dsf",5)后面的参数是自己手动分配的长度
            Console.WriteLine(str);



            #endregion

            #region 容量
            //StringBuilder存在一个容量问题,每次往里面增加内容时，会自动扩容
            //获取容量
            Console.WriteLine(str.Capacity);

            //获得字符串长度



            #endregion

            #region 增删查改替换
            //增
            str.Append("444444");
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);


            str.AppendFormat("{0}{1}", 100, 999);
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);

            //插入
            str.Insert(0, "唐老狮");
            Console.WriteLine(str);


            //删
            str.Remove(0, 10);
            Console.WriteLine(str);

            //清空
            //str.Clear();
            //Console.WriteLine(str);


            //查
            Console.WriteLine(str[3]);

            //改
            str[0] = 'A';
            Console.WriteLine(str);
            //本来用str[i]='s';的形式是不能改的
            //但是用了StringBuilder的方式就可以直接改

            //替换
            str.Replace("1","唐");
            Console.WriteLine(str);
            //这里也不会重新生成一个内存，因为是用了StringBuilder的申明方式


            //重新赋值 Stringbuilder
            str.Clear();
            str.Append("123123");
            Console.WriteLine(str);

            //判断StringBuilder是否某一个字符串是否相等
            if (str.Equals("123123"))
            {
                Console.WriteLine("相等");
            }


            #endregion

            #region 练习题一 请描述string和StringBuilder
            //1.string相对stringbuilder更容易产生垃圾 每次修改拼接都会产生垃圾
            //2.string相对stringbuilder更加灵活 因为他提供了更多的方法使用
            //如何选择使用他们
            //需要频繁修改拼接的字符串可以使用stringbuilder
            //需要使用string独特的一些方法来处理一些逻辑事可以使用string


            #endregion

            #region 练习题二
            //内存优化，从两个方面去解答
            //1.如何节约内存
            //2.如何尽量少的GC(垃圾回收)

            //少new对象 少产生垃圾
            //合理的使用static
            //合理使用string和stringbuilder



            #endregion


        }
    }
}
