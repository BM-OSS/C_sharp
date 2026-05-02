using System;
using System.Security.AccessControl;

namespace Class37_260507
{
    #region 知识点一 成员属性的基本概念
    //基本概念
    //1.用于保护成员属性的获取和赋值添加逻辑处理
    //2.为成员属性的获取和赋值添加逻辑处理
    //3.解决3p的局限性
    //public——内外访问
    //private——内部访问
    //protected——内部和子类访问
    //属性可以让成员变量在外部
    //只能获取 不能修改 或则 只能修改 不能获取
    #endregion


    #region 知识点二 成员属性的基本语法
    //访问修饰符 属性类型 属性名
    //{
    //    get{}
    //    set{}
    //
    //
    //}


    #region 练习题一
    //定义一个学生类，有5种属性，分别为姓名，性别，年龄，C_sharp成绩，Unity成绩
    //有两个方法：
    //一个打招呼：介绍自己叫XX，今年几岁了。是男同学还是女同学
    //计算自己总分数和平均分并显示的方法
    //一个使用属性完成：年龄必须是0~150岁之间，成绩必须是0~100
    //性别只能是男或者女
    //实例化两个对象并测试
    class Student
    {

        private int age;
        private int c_Sharp;
        private int unity;
        private string sex;
        public string Name
        {
            get;
            set;
        }
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value!="男"&& value != "女")
                {
                    sex = "未知";
                }
                else
                {
                    sex = value;
                }
            }
        }
        public int Age
        {
            get 
            {
                return age;
            }
            set 
            {
                if (value <= 0)
                {
                    age = 0;
                }
                else if (value >= 150)
                {
                    age = 150;
                }
                else 
                {
                    age = value;
                }
            }
        }
        public int C_Sharp
        {
            get 
            {
                return c_Sharp;
            }
            set 
            {
                if (value <= 0)
                {
                    c_Sharp = 0;
                }
                else if (value >= 100)
                {
                    c_Sharp = 100;
                }
                else
                {
                    c_Sharp = value;
                }

            }
        }
        public int Unity
        {
            get
            {
                return unity;
            }
            set
            {
                if (value <= 0)
                {
                    unity = 0;
                }
                else if (value >= 100)
                {
                    unity = 100;
                }
                else
                {
                    unity = value;
                }

            }
        }

        public void SayHellow()
        {
            Console.WriteLine("我叫{0},今年{1}岁,我是{2}同学",Name,Age,Sex);
        }
        public void ShowInfo()
        {
            int sum=C_Sharp+Unity;
            float avg = sum / 2f;
            Console.WriteLine("总分{0}，平均成绩{1}",sum,avg);
        }


    }



    #endregion
    class Person
    {
        private string name;
        private int age;
        private int money;
        private bool sex;
        private float height;

        public string Name
        {
            get
            {
                //可以在返回之前添加一些逻辑规则
                //意味着 这个属性可以获取的内容
                return name;
            }
            set
            {
                //可以在设置之前添加一些逻辑规则
                //value 关键字 用于表示 外部传入的值
                name = value;
            }
        }


        public int Money
        {
            get
            {
                //加密处理
                return money - 5;
            }
            set
            {
                //加密处理
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("钱不能少于0,强制设置为0了");
                }
                money = value + 5;
            }

        }

        #region 知识点五 get和set可以只有一个
        //只有一个时，没必要在前面加修饰符
        //一般只会出现只有get的情况，很少有出现只有set的情况
        public bool Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }


        #endregion

        #region 知识点六 自动属性
        //作用：外部能得不能改的特征
        //如果类有一个特征是只希望外部能得不能改的 又没有什么特殊处理
        //那么可以直接使用自动属性


        public float Height
        {
            //没有在get和set中写逻辑的需求或想法
            get 
            {
                return height;
            }
            set 
            {
                height = value;
            }

        }




    #endregion


    }




    #endregion

    #region 知识点四 成员属性中 get和set前可以加访问修饰符
    //注意

    //1.默认不加 会使用属性申明时的访问权限
    //2.假的访问修饰符要低于属性的访问权限
    //3.不能让get和set的权限都低于属性的权限
    //里面的权限不能大于外面的权限



    #endregion




    class Program
    {
        






        static void Main(string[] args)
        {

            Console.WriteLine("成员属性");


            #region 知识点三 成员属性的使用
            Person p = new Person();
            p.Name = "唐老狮";
            Console.WriteLine(p.Name);



            #endregion

            p.Money = 10000;
            Console.WriteLine(p.Money);

            Console.WriteLine(p.Sex);


            //练习题一
            Console.WriteLine("练习题一");
            Student s1 = new Student();
            s1.Name = "唐老狮";
            s1.Sex = "超人";
            s1.C_Sharp = 150;
            s1.Unity = 150;
            s1.Age = 160;
            s1.SayHellow();
            s1.ShowInfo();


            Student s2 = new Student();
            s2.Name = "小明";
            s2.Sex = "女";
            s2.C_Sharp = 93;
            s2.Unity = 84;
            s2.Age = 20;
            s2.SayHellow();
            s2.ShowInfo();


        }


    }




}