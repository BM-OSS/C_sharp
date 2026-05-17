using System;
using System.Diagnostics;
namespace class67_260606
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            #region 知识点一 Dictionary
            //可以将Dictionary理解为 拥有泛型的Hashtable
            //它也是基于键的哈希代码组织起来的 键/值对
            //键值对类型从Hashtable的object变为了可以自己制定的泛型


            #endregion

            #region 知识点二 申明

            Dictionary<int,string> dictionary = new Dictionary<int, string>();


            #endregion

            #region 知识点三 增删查改
            //增:不能出现相同的键
            dictionary.Add(1, "123");
            dictionary.Add(2, "234");
            dictionary.Add(3, "345");
            dictionary.Add(4, "567");
            dictionary.Add(5, "678");

            //删：只能通过键去删除
            dictionary.Remove(1);
            dictionary.Remove(3);
            //dictionary.Clear();

            //查
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary[2]);
            //在字典里面找不到的话会直接报错

            //根据键查询
            if (dictionary.ContainsKey(2))
            {
                Console.WriteLine("存在键为2的字典对");
            }

            //根据值查询
            if (dictionary.ContainsValue("234"))
            {
                Console.WriteLine("存在值为234的字典对");
            }

            //改
            Console.WriteLine(dictionary[2]);
            dictionary[2] = "123";
            Console.WriteLine(dictionary[2]);
            #endregion

            #region 知识点四 遍历
            Console.WriteLine(dictionary.Count);

            //1.遍历键
            Console.WriteLine("**************");
            foreach (int item in dictionary.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(dictionary[item]); ;
            }

            //2.遍历值
            Console.WriteLine("**************");
            foreach (string item in dictionary.Values)
            {
                Console.WriteLine(item);
                
            }



            //3.同时遍历键值对
            Console.WriteLine("**************");
            foreach (KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine("键："+item.Key+" 值："+item.Value);
            }




            #endregion


            #region 练习题一
            //使用字典存储0~9的数字对应的大写文字
            //提示用户输入一个不超过三位的数，提供一个方法，返回数的大写
            //例如：306，返回叁零陆

            try
            {
                Console.WriteLine("请输入一个不超过3位数");
                Console.WriteLine(Check(int.Parse(Console.ReadLine())));
            }
            catch 
            {
                Console.WriteLine("请输入数字");
            }


            #endregion

            #region 练习题二
            //计算每个字母出现的次数"welcome to unity world!"，使用字典存储，最后遍历整个字典，不区分大小写

            Dictionary<char, int> dic = new Dictionary<char, int>();

            string str = "Welcome to Unity World";

            //转化成小写
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]] += 1;
                }
                else 
                {
                    dic.Add(str[i], 1);
                }
            }
            foreach (char item in dic.Keys)
            {
                Console.WriteLine("字母{0}出现了{1}次", item, dic[item]);
            }



            #endregion

        }
        static string Check(int num)
        {
            Dictionary<int, string> dictionarys = new Dictionary<int, string>();

            dictionarys.Add(0, "零");
            dictionarys.Add(1, "壹");
            dictionarys.Add(2, "贰");
            dictionarys.Add(3, "叁");
            dictionarys.Add(4, "肆");
            dictionarys.Add(5, "伍");
            dictionarys.Add(6, "陆");
            dictionarys.Add(7, "柒");
            dictionarys.Add(8, "捌");
            dictionarys.Add(9, "玖");

            string str = "";
            //得到百位数
            int b = num / 100;
            if (b != 0)
            {
                str += dictionarys[b];
            }
            

            //得到十位数
            int s = num % 100 / 10;
            if (s != 0 || str != "")
            {
                str += dictionarys[s];
            }
            

            //得到各位数
            int g = num % 10;
            str += dictionarys[g];

            return str;


        }
    }

}