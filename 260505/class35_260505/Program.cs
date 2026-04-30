using System;


namespace class35_260505
{
    #region 知识点一 成员方法申明
    //基本概念
    //成员方法（函数）用来表现对象行为
    //1.申明在类语句块中
    //2.是用来描述对象的行为的
    //3.规则和函数申明的规则相同
    //4.受到访问修饰符的控制
    //5.返回值参数不做限制
    //6.方法数量不做限制

    //注意：
    //1.成员方法不要加static修饰符
    //2.成员方法 必须实例化出对象
    //再通过对象来使用 相当于该对象执行了某个行为
    //3.成员方法 受到访问修饰符的影响
    class Person
    {

        /// <summary>
        /// 说话的行为
        /// </summary>
        /// <param name="str">说话的内容</param>
        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}",name,str);
        }
        public string name;
        public int age;
        //朋友列表
        public Person[] friends;


        /// <summary>
        /// 添加朋友的方法
        /// </summary>
        /// <param name="p">传入新朋友</param>
        public void AddFriend(Person p)
        {
            if (friends == null)
            {
                friends = new Person[] { p };

            }
            else
            {
                //扩容
                Person[] newFriend = new Person[friends.Length + 1];
                //搬家
                for (int i = 0; i < friends.Length; i++)
                {
                    newFriend[i] = friends[i];
                }
                //把新加的朋友放到最后一个
                newFriend[newFriend.Length - 1] = p;
                //地址重定向
                friends = newFriend;
            }
        }


        /// <summary>
        /// 判断是否成年
        /// </summary>
        /// <returns></returns>
        public bool IsAdult()
        {
            return age >= 18;
        }


    }


    #endregion


    #region 练习题一
    //为人类定义说话，走路，吃饭等方法
    class Persons
    {
        public string name;
        public float heihgt;
        public int age;
        public string homeAddress;

        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}",name,str);
        }
        public void Walk()
        {
            Console.WriteLine("{0}开始走路");
        }
        public void Eat(Food f)
        {
            Console.WriteLine("{0}开始吃饭，吃的{1}",name,f.name);
        }


    }




    #endregion

    #region 练习题二
    //为学生类定义学习，吃饭等方法
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskmate;

        public void Learn()
        {
            Console.WriteLine("{0}开始学习",name);
        }
        public void Eat(Food f)
        {
            Console.WriteLine("{0}开始吃饭,吃的{1}", name,f.name);
        }

    }



    #endregion

    #region 练习题三
    //定义一个食物类，有名称，热量，等特征
    //思考如何和人类以及学生类联系起来
    class Food
    {
        public string name;
        public int kaluli;



    }



    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法");


            #region 知识点二 成员方法的使用
            //2.成员方法 必须实例化除对象 再通过对象来使用相当于该对象执行了某个行为
            Person p = new Person();
            p.name = "唐老狮";
            p.age = 18;
            p.Speak("大家好");

            if (p.IsAdult())
            {
                p.Speak("我是成年人了");
            }


            Person p2 = new Person();
            p2.name = "火山哥";
            p2.age = 16;
            p.AddFriend(p2);
            for (int i = 0; i < p.friends.Length; i++)
            {
                Console.WriteLine(p.friends[i].name);
            }

            #endregion
            Persons p3 = new Persons();
            p3.name = "唐老狮";
            Student s3= new Student();
            s3.name = "小火";

            Food f = new Food();
            f.name = "火龙果";
            p3.Eat(f);
            s3.Eat(f);
        }
    }

}
