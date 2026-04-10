using System;

namespace class15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do-while循环");
            #region 知识点一 基本语法
            //与while相似
            //但do-while是先执行一次循环体在进行条件语句判断
            //与C语言里面的do-while一样

            #endregion
            #region 知识点二 实际使用
            int a = 1;
            do
            {
                Console.WriteLine(a);
            } while (a > 2);

            #endregion

            #region 知识点三 嵌套使用
            //与C语言里面一样用法（在实际使用中用的较少）
            #endregion

            #region 练习题一
            //要求用户输入用户名和和密码
            //只要不是admin和8888就一直提示用户名或
            //者密码错误，请从新输入
            Console.WriteLine("练习题一");
            bool isShow = false;
            string userName;
            string passWord;
            do
            {
                if (isShow == true)
                {
                    Console.WriteLine("用户名或密码错误，请从新输入");
                }
                
                Console.WriteLine("请输入用户名");
                userName= Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord= Console.ReadLine();
                isShow = true;
            } while (userName!="admin" || passWord!="8888");


            #endregion

            #region 练习题二
            //不断提示请输入你的姓名，直到输入q结束
            string input = "";
            do
            {
                Console.WriteLine("请输入你的姓名");
                input = Console.ReadLine();

            }
            while (input != "q");
            #endregion
        }
    }
}
