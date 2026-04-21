using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace class29
{
    #region 知识点一 基本概念
    //机构体是一种自定义变量类型 类似枚举需要自己定义
    //它是数据和函数的集合
    //在结构体中 可以申明各种变量和方法

    //作用：用来表现存在关系的数据集合 比如用结构体表现学生 动物 人类等等

    #endregion

    #region 知识点二 基本语法
    //1.结构体一般写在namespace里面
    //2.结构体的关键字为struct
    //struct 自定义结构体名
    //{
    //    第一部分
    //      变量
    //     
    //    第二部分
    //    构造函数
    //    
    //    第三部分
    //      函数
    // 
    //}注意 结构体名字 我们规范的命名方法是帕斯卡命名法




    #endregion

    #region 知识点三 实例
    //创建一个描述学生的结构体
    struct Student
    {

        #region 知识点五 访问修饰符
        //修饰结构体中变量和方法 是否能被外部使用
        //public 公共的 可以被外部访问
        //private 私有的 只能在内容使用
        //默认不写 为private
        #endregion



        //结构体申明的变量 不能直接初始化
        //变量类型 可以写任意类型 包括结构体
        //但是不能是自己的结构体


        //年龄
        private int age;
        //身高
        public float highway;
        //学号
        public string number;
        //姓名
        public string name;
        //性别
        public bool sex;





        //函数方法
        //在结构体中写的函数格式可以不加static关键字
        public void Speak()
        {
            //函数中可以直接使用结构体中已经申明的变量
            Console.WriteLine("我的名字是{0}，我今年{1}岁",name,age);
            //可以根据需求写无数个函数
        }


        //构造函数 构造函数一般是方便初始化
        #region 知识点六 结构体的构造函数
        //基本概念
        //1.没有返回值
        //2.函数名必须和结构体名相同
        //3.必须有参数
        //4.如果申明了构造函数 那么必须在其中对应所有的点亮数据初始化
        public Student(int age, bool sex, string number, string name)
        {
            //加入传入的参数和原有结构体里面的参数相同了
            //就可以用“this”关键字
            //在变量前面加this关键字则是表示原有的结构体变量
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }

        #endregion

    }
    #endregion

    #region 练习题一
    //使用结构体描述学员的信息，姓名，性别，年龄，班级，专业
    //创建两个学员对象，并对其基本信息进行初始化打印
    struct StudentInfo
    {
        public string name;
        public bool sex;
        public int age;
        public int classinfo;
        public string major;

        public StudentInfo(string name, bool sex, int age, int calssinfo, string major)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.classinfo = calssinfo;
            this.major = major;
        }

        public void Speak()
        {
            Console.WriteLine("姓名:{0} 性别:{1} 年龄:{2} 班级:{3} 专业:{4}", name, sex?"男":"女", age, classinfo, major);
        }
    }


    #endregion

    #region 练习题三
    struct Rect
    {
        public float w;
        public float h;
        public float area;
        public float perimeter;

        public Rect(int w, int h)
        {
            this.w = w;
            this.h = h;
            area = w * h;
            perimeter = 2 * (w + h);
        }

        public void wrtieInfo()
        {
            Console.WriteLine("矩形的宽:{0} 矩形的高:{1} 矩形的面积:{2} 矩形的周长:{3}",w,h,area,perimeter);
        }

    }
    #endregion

    #region 练习题四
    //使用结构体描述玩家信息 玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
    //职业：
    //战士（技能：冲锋）
    //猎人（技能：假死）
    //法师（技能：奥术冲击）

    //打印结果：猎人唐老狮释放了假死
    struct PlayerInfo
    {
        public string name;
        public E_Occupation occupation;

        public PlayerInfo(string name, E_Occupation occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }
        public void Atk()
        {
            string o = " ";
            string s = " ";
            switch (occupation)
            {
                case E_Occupation.Warrior:
                    o = "战士";
                    s = "冲锋";
                    break;
                case E_Occupation.Hunter:
                    o = "猎人";
                    s = "假死";
                    break;
                case E_Occupation.Master:
                    o = "法师";
                    s = "奥术冲击";
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}",o,name,s);
        }
    }
    enum E_Occupation
    {
        /// <summary>
        /// 战士
        /// </summary>
        Warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Master
    }

    #endregion


    #region 练习题五+练习题六
    //使用结构体描述小怪兽
    struct Monster
    {
        public string name;
        public int atk;

        public Monster(string name)
        {
            this.name = name;
            Random R = new Random();
            atk = R.Next(10,31);


        }
        public void MonsterAtk()
        {

            Console.WriteLine("{0}的攻击力是{1}",name,atk);
        }

    }
    #endregion

    #region 练习题七
    //应用已学过的知识，实现奥特曼打怪兽
    //提示：
    //结构体描述奥特曼与小怪兽
    //定义一个方法实现奥特曼攻击小怪兽
    //定义一个方法实现小怪兽攻击奥特曼
    
    //奥特曼的结构体信息
    struct Outman
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public Outman(string name,int atk,int def,int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        public void Atk(ref Boss boss)
        {
            boss.hp -= atk - boss.def;
            Console.WriteLine("{0}对{1}造成了{2}攻击，剩余血量{3}", name, boss.name, atk - boss.def, boss.hp);
        }
    }
    //怪兽的结构体信息
    struct Boss
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public Boss(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        public void Atk(ref Outman outman)
        {
            outman.hp -= atk - outman.def;
            Console.WriteLine("{0}对{1}造成了{2}攻击，剩余血量{3}",name,outman.name,atk-outman.def,outman.hp);
        }

    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("复杂数据类型——结构体");

            #region 知识点四 
            //  变量类型 变量名;
            Student s1;
            s1.highway = 1.78f;
            s1.number = "20261533532";
            s1.sex = true;
            s1.name = "tanglaoshi";

            Student s2 = new Student(18,true,"234554623","小红");
            s2.Speak();
            #endregion

            #region 练习题一
            Console.WriteLine("练习题一");

            StudentInfo s01 = new StudentInfo("唐老狮", false, 18, 1, "计算机");
            StudentInfo s02;
            s02.name = "王老师";
            s02.sex = true;
            s02.age = 22;
            s02.classinfo = 3;
            s02.major = "教师";

            s01.Speak();
            s02.Speak();
            #endregion

            #region 练习题二
            //简要描述private和public两个关键字的区别


            //private只能对结构体内部使用
            //public既在结构体内部使用也能在结构体外部使用


            #endregion

            #region 练习题三
            //使用结构体描述矩形的信息，长，宽；创建一个矩形
            //对其长款经行初始化，并打印矩形的长，宽，面积，周长等信息
            Rect rect = new Rect(5,6);
            rect.wrtieInfo();
            #endregion

            #region 练习题四
            //使用结构体描述玩家信息 玩家名字，玩家职业
            //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
            //职业：
            //战士（技能：冲锋）
            //猎人（技能：假死）
            //法师（技能：奥术冲击）

            //打印结果：猎人唐老狮释放了假死
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的职业(0代表战士，1代表猎人，2代表法师)");
            try
            {
                E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
                PlayerInfo player = new PlayerInfo(name, o);
                player.Atk();
            }
            catch
            {
                Console.WriteLine();
            }
            #endregion

            #region 练习题五
            //使用结构体描述小怪兽

            #endregion

            #region 练习题六
            //定义一个数组存储10个上面描述的小怪兽，每个小怪兽第名字为（小怪兽+数组下标）
            //举例 ：小怪兽0，最后打印10个小怪兽的名字+攻击力数值

            //变量类型[] 数组名 = new 变量类型[10]；
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster("小怪兽"+i);
                monsters[i].MonsterAtk();
            }
            #endregion

            #region 练习题七
            //应用已学过的知识，实现奥特曼打怪兽
            //提示：
            //结构体描述奥特曼与小怪兽
            //定义一个方法实现奥特曼攻击小怪兽
            //定义一个方法实现小怪兽攻击奥特曼
            Outman outman = new Outman("迪迦奥特曼", 15, 13, 100);
            Boss boss = new Boss("大怪兽", 18, 10, 100);
            while (true)
            {
                boss.Atk(ref outman);
                if (outman.hp <= 0)
                {
                    Console.WriteLine("{0}胜利",boss.name);
                    break;
                }
                outman.Atk(ref boss);
                if (boss.hp <= 0)
                {
                    Console.WriteLine("{0}胜利", outman.name);
                    break;
                }
            }


            #endregion
        }
    }
    //总结
    
    //访问修饰符：public 和private 用来修饰变量和方法的
    //public 外部可以调用
    //private 内部可以调用 
    //不写的话默认是private修饰
    //构造函数：没有返回值 函数名和结构体相同 可以重载
    //主要是帮助我们快速初始化结构体对象的

    //注意：
    //1.在结构体中申明的变量 不能初始化 只能在外部或则在函数中赋值（初始化）
    //2.在结构中申明的函数 不用加static的
}
