using System;
namespace class64_260603
{
    #region 知识点一 泛型是什么

    //泛型实现了类型参数化，达到代码重用目的
    //通过类型参数化来实现同一份代码上操作多种类

    //泛型相当于类型占位符
    //定义类或方法时使用替代符代表变量类型
    //当真正使用类或者方法时再具体指定类型

    #endregion

    #region 知识点二 泛型分类
    //泛型类和泛型接口
    //基本语法
    //class 类名<泛型占位字母>
    //interface 接口名<泛型占位字母>

    //泛型函数
    //基本语法：函数名<泛型占位字母>(参数列表)

    //注意：泛型占位字母可以有多个，用逗号分开
    #endregion


    #region 知识点三 泛型类和接口
    class TestClass<T>
    {
        public T Value 
        { 
            get; 
            set; 
        }
    }


    class TestClass2<T,K,M,Key,S>
    {
        public T Value;
        public K Value1;
        public M Value2;
        public Key Value3;
        public S Value4;
    }


    interface TestInerface<T>
    {
        T Value
        {
            get;
            set;
        }
    }

    class Test : TestInerface<int>
    {
        public int Value 
        { 

            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        
        }
    }


    #endregion

    #region 知识点四 泛型方法
    //1.普通类中的泛型方法
    class Test2
    {
        public void TestFun<T>(T value)
        {
            Console.WriteLine(value);
        }

        public void TestFun<T>()
        {
            T t = default(T);
        }

        //用T作为返回值类型
        public T TestFun<T>(string v)
        {
            return default(T);
        }

        


    }


    //泛型类中的泛型方法
    class Test2<T>
    {
        public T value;

        //这种写法不叫泛型方法，
        //因为申明变量的时候就给类型定死了
        //就不叫泛型方法
        public void TestFun<T>()
        {
            Console.WriteLine(value);
        }

        //这种就是泛型函数，因为这个尖括号里面不是和类里面的形同

        public void TestFun<K>(K k)
        {
            Console.WriteLine(k);
        }

    }



    #endregion

    #region 知识点五 泛型的作用
    //1不同类型对象的相同逻辑处理就可以选择泛型
    //2使用泛型可以一定程度避免装箱拆箱
    //3举例：优化ArrayList

    class ArrayList<T>
    {
        private T[] array;
        //传入的类型是和T类型一样的内容
        public void Add(T value)
        {
            
        }

        public void Remove(T value)
        {
            
        }
    }



    #endregion

    #region 泛型注意事项
    //1声明泛型时 它只是一个类型的占位符
    //2泛型真正起作用的时候，是在使用它的时候
    //3泛型占位字母可以是大写字母T开头
    //4泛型占位字母一般是单个字母
    //5不确定泛型类型时 获取默认值，可以使用default(占位字符)
    //6看到<T>包括的字母 那肯定是泛型
    //endregion
    #endregion

    #region 练习题
    //定义一个泛型方法，方法内判断该泛型为何种类型，并返回类型的名称与占有的
    //如果是int，则返回"整型，4字节"
    //int: 整型
    //char: 字符
    //float: 单精度浮点型
    //string: 字符串
    //如果是其它类型，则返回"其它类型"
    //（可以通过typeof(类型) == typeof(类型)的方式进行判断）
    #endregion






    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型");

            //如果已经申明了t为int类型，就不能改变这个类型了
            TestClass<int> t = new TestClass<int>();
            t.Value = 10; 
            Console.WriteLine(t.Value);

            TestClass<string> str = new TestClass<string>();
            str.Value = "唐老狮";
            Console.WriteLine(str.Value);


            TestClass2<int, string, float, TestClass<int>, bool> t3 = new TestClass2<int, string, float, TestClass<int>, bool>();

            Test2 t2 = new Test2();
            t2.TestFun<string>("C#语言好难");

            Test2 tt = new Test2();
            //<>这里尖括号可以不写，
            //可以根据后面的内容自动识别类型
            tt.TestFun<int>(99);
            tt.TestFun<string>("123456");
            tt.TestFun<bool>(true);


            Console.WriteLine(Fun<int>());
            Console.WriteLine(Fun<string>());
            Console.WriteLine(Fun<float>());
            Console.WriteLine(Fun<char>());
            Console.WriteLine(Fun<bool>());
            Console.WriteLine(Fun<uint>());
            
            
            
            
            
            
        }


        static string Fun<T>()
        {
            if (typeof(T) == typeof(int))
            {
                return string.Format("{0}{1}字节", "整形", sizeof(int));
            }
            else if (typeof(T) == typeof(char))
            {
                return string.Format("{0}{1}字节", "字符", sizeof(char));
            }
            else if (typeof(T) == typeof(float))
            {
                return string.Format("{0}{1}字节", "单精度浮点数", sizeof(float));
            }
            else if (typeof(T) == typeof(string))
            {
                return string.Format("{0}{1}字节", "字符串", "?");
            }


            return "其他类型";
        }


    }
}
