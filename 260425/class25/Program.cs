using System.Numerics;

namespace class25
{
    class Program
    {
        #region 知识点一 学习ref和out的原因
        //学习ref和out原因
        //解决在函数内部改变外部也同时改变
        static void ChangeValue(int value)
        {
            value = 3;
        }
        static void ChangArrValue(int[] arr)
        {
            arr[0] = 99;
        }
        static void ChangeArrValue(int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }
        #endregion

        #region 知识点二 ref和out的使用
        //函数参数的修饰符
        //当传入的值类型参数在内部修改时，
        //或者应用类型参数在内部重新申明时
        //外部的值会发生变化

        //ref
        static void ChangeValueRef(ref int vlaue)
        {
            vlaue = 3;
        }

        static void ChangeArrref(ref int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }


        //out
        static void ChangeValueOut(out int a)
        {
            a = 65;
        }

        static void ChangeArrOut(out int[] arr)
        {
            arr = new int[] { 97, 98, 99 };
        }

        #endregion

        #region 知识点三 ref和out的区别
        //1.ref传入的变量必须要初始化 out不用
        //2.out传入的变量必须在内部赋值 ref不用

        //区别1
        //调用ref函数时里面写的参数必须先赋值，
        //但在内部可以改也可以不改，不然就报错


        //而out调用时就不需要先赋值再调用函数，
        //out传入的变量不用初始化，但在内部必须修改值，不然就报错

        #endregion

        //练习题二函数
        static bool CheckLogin(string name, string passWord,ref string info)
        {
            if (name == "admin")
            {
                if (passWord == "8888")
                {
                    info = "登录成功";
                }
                else
                {
                    info = "密码错误";
                    return false;
                }
            }
            else
            {
                info = "用户名错误";
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ref和out");

            Console.WriteLine("*************");
            int a = 1;
            Console.WriteLine(a);
            ChangeValue(a);
            Console.WriteLine(a);
            ChangeValueRef(ref a);
            Console.WriteLine(a);
            ChangeValueOut(out a);
            Console.WriteLine(a);
            Console.WriteLine("*************");
            int[]arr = {1,2,3};
            Console.WriteLine(arr[0]);
            ChangArrValue(arr);
            Console.WriteLine(arr[0]);
            ChangArrValue(arr);
            Console.WriteLine(arr[0]);
            ChangeArrref(ref arr);
            Console.WriteLine(arr[0]);
            ChangeArrOut(out arr);
            Console.WriteLine(arr[0]);

            #region 练习题一
            //请简要描述ref和out的区别
            //ref的使用 必须对传入的参数进行初始化 out不用
            //out的使用 在内部必须给传入的参数赋值 ref就不用



            #endregion

            #region 练习题二
            //让用户输入用户名和密码，返回给用户一个bool类型的登录结果，
            //并且还要单独的返回给用户一个登录信息。
            //如果用户名错误，除了返回登录界面之外，登录信息为“用户名错误”
            //如果密码错误，除了返回登录结果之外，登录信息为“密码错误”
            Console.WriteLine("练习题二");
            string info = "";
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            while (!(CheckLogin(name, passWord, ref info))) 
            {
                Console.WriteLine(info);
                Console.WriteLine("请输入用户名");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
            }
            Console.WriteLine(info);



            #endregion
        }
    }
}
