using System;

namespace class55_260525
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("string");

            #region 字符串指定位置获取
            //字符串本质是char数组
            string str = "唐老狮";
            Console.WriteLine(str[0]);
            //可以把String转换成char数组
            char[] chars=str.ToCharArray();
            Console.WriteLine(chars[1]);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion


            #region 字符串拼接
            str = string.Format("{0}{1}", 123, 123);

            Console.WriteLine(str);

            #endregion

            #region 知识点三 正向查找字符位置
            str = "我是唐老狮！";
            int index = str.IndexOf("唐");
            //返回的是这个字符在字符串的下标位置，如果没找到就返回为-1
            Console.WriteLine(index);


            #endregion

            #region 知识点四 反向查找指定字符串位置
            str = "我是唐老狮唐老狮";
            index = str.LastIndexOf("唐老狮");
            //lastIndexOf是反向查找的和IndexOf不一样
            Console.WriteLine(index);
            index = str.IndexOf("唐老狮");
            Console.WriteLine(index);

            #endregion

            #region 知识点五 移除指定位置后的字符

            str = "我是唐老狮唐老狮";
            str.Remove(4);
            //Remove();这种方法一般不会在原字符串上去删除
            //一般会在新的字符串上面去操作
            Console.WriteLine(str);
            str = str.Remove(4);
            Console.WriteLine(str);
            //这种方法会直接实现在第4个和以后都删除掉
            str= str.Remove(2,2);
            //这是Remove(i,j)的一个重载函数含义是从第i个元素开始，往后删除j个元素
            Console.WriteLine(str);

            #endregion

            #region 知识点六 替换指定字符串
            str = "我是唐老狮唐老狮";
            str.Replace("唐老狮","唐老师");
            //和Remove一样它一般会在一个新的string类型的变量上替换
            Console.WriteLine(str);
            str= str.Replace("唐老狮", "唐老师");
            Console.WriteLine(str);

            #endregion

            #region 知识点七 大小写转换
            str = "sfefgesegdfd";
            Console.WriteLine(str);
            str = str.ToUpper();
            //把小写字符串转换成大写的字符串
            Console.WriteLine(str);
            str = str.ToLower();
            //把大写字符串转换成小写字符串
            Console.WriteLine(str);
            #endregion

            #region 知识点八 字符串截取
            str = "唐老狮唐老狮";
            str.Substring(2);
            Console.WriteLine(str);
            str= str.Substring(2);
            //这个方法是截取指定位置之后的字符串
            Console.WriteLine(str);

            str=str.Substring(2,2);
            //Substring(i，j)i是截取的一个字符的下标，j是表示往后截取的个数
            //注意系统不会帮你判断是否越界，需要自行判断是否越界
            Console.WriteLine(str);

            #endregion

            #region 知识点九 字符串切割
            str = "1,2,3,4,5,6,7";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            string[] strs = str.Split(',');
            //这个方法就是切割字符串中选的的这个字符
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
            #endregion
            #region 练习题一
            Console.WriteLine("练习题一");
            //请写出string中提供的截取和替换对应的函数名
            str = "唐老狮唐老狮";
            str=str.Substring(2, 2);
            Console.WriteLine(str);

            str = "唐老狮唐老狮";
            str = str.Replace("唐老狮","唐老师");
            Console.WriteLine(str);


            #endregion


            #region 练习题二
            //请将字符串1|2|3|4|5|6|7
            //变为     2|3|4|5|6|7|8
            //并输出
            //(使用字符串切割的方法)
            str = "1|2|3|4|5|6|7";
            strs= str.Split('|');
            str = "";
            for (int i = 0; i < strs.Length; i++)
            {
                str += int.Parse(strs[i]) + 1;
                if (i != strs.Length - 1)
                {
                    str += "|";
                }
            }
            Console.WriteLine(str);
            #endregion

            #region 练习题三
            //String和string，Int32和int，Int16和short，Int64和long他们的区别是什么？


            //后者是前者的别名，几乎没有区别


            #endregion

            #region 练习题四
            string str1 = null;
            str1 = "123";
            string str2 = str1;
            str2 = "321";
            str2 += "123";
            //上面的代码分配了多少个新的堆空间


            //3个
            //改变和从新赋值都会产生新的堆空间

            #endregion

            #region 练习题五
            //编写一个函数，将输入的字符串翻转，
            //不要使用中间商，你必须在原地修改输入数组，交换过程不适用额外的空间

            //如输入 {‘h’‘e’‘l’‘l’‘o’}
            //输出   {‘o’‘l’‘l’‘e’‘h’}
            Console.WriteLine("练习题五");
            string str3 = Console.ReadLine();
            char[] chars1 = str3.ToCharArray();
            for (int i = 0; i < chars1.Length/2; i++)
            {
                chars1[i] = (char)(chars1[i] + chars1[chars1.Length - 1-i]);
                chars1[chars1.Length - 1 - i] = (char)(chars1[i] - chars1[chars1.Length - 1 - i]);
                chars1[i] = (char)(chars1[i] - chars1[chars1.Length - 1 - i]);
            }
            for (int i = 0; i < chars1.Length; i++)
            {
                Console.Write(chars1[i]);
            }
            Console.WriteLine();
            str3 = new string(chars1);
            Console.WriteLine(str3);
            #endregion

        }
    }
}