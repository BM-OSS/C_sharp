using System;

namespace class54_260524
{
    class Test
    {
        public int i = 1;
        public Test2 t2 = new Test2();

        public Test Clone()
        {
            return MemberwiseClone() as Test;
        }
        public override string ToString()
        {
            //可以直接重写这个ToString（用的比较多）
            return base.ToString();
            
        }
        
    }
    class Test2
    {
        public int i = 2;
    }

    #region 练习题一
    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
    //请在控制台打印出“玩家xx，血量xx，攻击力xx，防御力xx”
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public int miss;
        public Player(string name, int hp, int atk, int def, int miss)
        {
            this.name = name;
            this.hp= hp;
            this.atk= atk;
            this.def= def;
            this.miss = miss;

        }
        public override string ToString()
        {
            return string.Format("玩家{0}，血量{1}，攻击力{2}，防御力{3}，闪避{4}", name, hp, atk, def, miss);
        }
    }


    #endregion

    #region 练习题二
    //一个Monster类的引用对象A，Monster类有 攻击力，防御力，血量，技能ID等属性
    //现在想要复制一个和A对象一模一样的B类对象，并且改变了B的属性，A不会受到影响，请问如何实现
    //使用浅拷贝方法
    class Monster
    {
        public Monster(int atk,int def,int hp,int skillID)
        {
            Atk= atk;
            Def = def;
            Hp = hp;
            SkillID = skillID;
            
        }
        public int Atk
        {
            get;
            set;
        }
        public int Def
        {
            get;
            set;
        }
        public int Hp
        {
            get;
            set;
        }
        public int SkillID
        {
            get;
            set;
        }
        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }

        public override string ToString()
        {
            return string.Format("攻击力{0}，防御力{1}，血量{2}，技能{3}", Atk, Def, Hp, SkillID);
        }
    }




    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法");
            #region 知识点一 Object中的静态方法
            //静态方法 Equals 判断两个对象是否相等
            //最终的判决权，交给左侧对象的Equals方法
            //不管值类型引用类型都会按早左侧的对象
            //Equals方法规则来进行比较
            //
            Console.WriteLine(Object.Equals(1, 2));
            Console.WriteLine(Object.Equals(1, 1));
            //值类型的判断相等是判断数值上是否相等
            //引用类型的判断相等是判断指向的内存地址是否相等
            Test t1 = new Test();
            Test t2 = new Test();
            Console.WriteLine(Object.Equals(t1, t2));

            //静态方法ReferenceEquals
            //比较两个对象是否是相同的引用，主要用来比较引用类型的对象
            //值类型对象返回值始终是false
            //
            Console.WriteLine(Object.ReferenceEquals(t2, t1));
            t2 = t1;
            Console.WriteLine(Object.ReferenceEquals(t2, t1));
            Console.WriteLine(Object.ReferenceEquals(1, 1));

            
            #endregion

            #region 知识点二 object中的成员方法
            //普通方法GetType
            //该方法在反射相关知识点中是非常重要的方法，之后会有返回的Type类型
            //该方法的主要作用就是获取对象运行时的类型Type
            //通过Type结合反射相关知识点可以做很多关于对象的操作
            //
            Test t = new Test();
            Type type = t.GetType();

            //普通方法MemberwiseClone
            //该方法用于获取对象的浅拷贝对象，口语化的意思就是会返回一个新的对象
            //但是新的对象中的引用类型变量会和老对象中引用类型变量一致
            Test t3 = t.Clone();

            Console.WriteLine("克隆对象后");
            Console.WriteLine("t.i="+t.i);
            Console.WriteLine("t.t2.i="+t.t2.i);
            Console.WriteLine("t3.i=" +t3.i);
            Console.WriteLine("t3.t2.i="+ t3.t2.i);

            t3.i = 20;
            t3.t2.i = 21;

            Console.WriteLine("改变克隆体信息后");
            Console.WriteLine("t.i="+ t.i);
            Console.WriteLine("t.t2.i="+ t.t2.i);
            Console.WriteLine("t3.i=" +t3.i);
            Console.WriteLine("t3.t2.i=" +t3.t2.i);

            #endregion

            #region 知识点三 object中的虚方法
            //虚方法Equals
            //默认实现还是比较两者是否为同一个引用，及相当于ReferenceEquals
            //但是微软在所有值类型的基类System.ValueType中重写了该方法，用来比较值相等
            //我们也可以重写该方法，定义自己的比较相等的规则
            //了解即可



            //虚方法GetHashCode
            //该方法时获取对象的哈希码
            //(一种通过算法算出的，表示对象唯一编码，不同对象哈希码有课能一样，具体根据哈希算法决定)
            //我们可以通过重写该函数来自定义对象的哈希码算法，正常情况下，我们使用的极少
            //了解即可



            //虚方法ToString
            //该方法用于返回当前对象代表的字符串，我们可以重写它定义我们自己的对象转字符串规则
            //该方法非常常用，当我们调用打印字符串是，默认使用的就是对象的ToString方法后打印出来的内容
            Console.WriteLine(t);
            Random r= new Random();
            Console.WriteLine(r);

            #endregion
            Console.WriteLine("练习题一");
            Player p = new Player("唐老狮",100,10,5,20);
            Console.WriteLine(p);

            Console.WriteLine("练习题二");
            Monster m1 = new Monster(10, 5, 100, 1);
            Monster m2 = m1.Clone();
            m2.Hp = 200;
            m2.SkillID = 3;
            Console.WriteLine(m1);
            Console.WriteLine(m2);

        }
    }
    //总结：

    //1.虚方法 toString 自定义字符串转换规则
    //2.成员方法 GetType 反射相关
    //3.成员方法 MemberwiseClone 浅拷贝
    //4.虚方法 Equals 自定义判断相等的规则
    
    

}