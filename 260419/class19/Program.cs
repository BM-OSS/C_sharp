namespace class19
{

    #region 知识点一 基本概念
    //1.枚举是什么
    //枚举是一个比较提别的存在
    //它是一个被命名的整形常量的集合
    //一般用它来表示 状态 类型 等等

    //2.申明枚举 和申明枚举变量
    //注意：申明枚举和申明枚举变量是两个概念
    //申明枚举： 相当与创建一个自定义的枚举类型
    //申明枚举变量： 使用申明的自定义枚举类型 创建一个枚举变量


    //3.申明枚举语法
    //    enum E_自定义枚举名
    //{
    //    自定义枚举名字,//枚举中包裹的 整形常量 第一个默认值是0 下面会依次累加
    //    自定义枚举名字1,//1
    //    自定义枚举名字2,//2
    //    自定义枚举名字3,//100
    //    自定义枚举名字4//101
    //    //虽然枚举项是默认从0开始累加
    //    //但是也可以自己赋值再在后面的项继续累加
    //}
    #endregion
    #region 知识点二 在哪里申明枚举
    //1.namespace语句块上申明（常用的）
    //2.class上也行，struct语句块中也行
    //注意：枚举是不可以在函数中申明

    enum E_MonsterType
    {
        Normal,//0
        Boss,//1
    }
    enum E_PlayerType
    {
        Main,
        Other,
    }

    enum E_QQType
    {
        /// <summary>
        /// 在线
        /// </summary>
        OLine,
        /// <summary>
        /// 离线
        /// </summary>
        Leave,
        /// <summary>
        /// 忙碌
        /// </summary>
        Busy,
        /// <summary>
        /// 隐身的
        /// </summary>
        Invisble,
    }

    enum E_coffeeType
    { 
        medium,
        mug,
        super,
    }
    enum E_sex
    {
        Man,
        Woman,
    }
    enum E_occupation
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
        Master,
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");


            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义的枚举类型 变量名 = 默认值;（自定义的枚举类型.枚举项）
            E_PlayerType playerType = E_PlayerType.Main;

            if (playerType == E_PlayerType.Main)
            {
                Console.WriteLine("主玩家逻辑");
            }
            else
            {
                Console.WriteLine("其他玩家逻辑");
            }
            //枚举和switch是天生一队
            //switch是判断
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch (monsterType)
            { 
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物的逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("boss逻辑");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点四枚举的类型转换
            //1.枚举和int相互转换
            int i = (int)playerType;
            Console.WriteLine(i);
            //int直接转枚举
            playerType = 0;
            //2.枚举和string相互转换
            string str = playerType.ToString();
            Console.WriteLine(str);

            //把string转换成枚举
            //Parse后第一个参数：你要转换为的是那个 枚举类型
            //第二个参数：用与转换的应用的对应枚举类型的字符串
            playerType =(E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");


            #endregion

            #region 知识点五 枚举的作用
            //在游戏开发中 对象很多时候 会有许多的状态
            //比如玩家 有一个动作状态 我们需要用
            //一个变量或则标识 来表示当前玩家处于那种状态
            //综合考虑 可能会使用 int 来表示他的状态
            //1.行走 2.待机 3.跑步 4.跳跃...等等状态

            //枚举可以帮助我们 清晰的分清楚状态的含义
            #endregion

            #region 练习题一
            //用枚举定义QQ的状态
            //并提示用户选择一个在线的状态
            //我们接受输入的数字，并将其转换成枚举类型
            E_QQType type=E_QQType.OLine;
            try
            {
                Console.WriteLine("请输入QQ的状态（0在线，1离开，2忙，3隐身的）");
                int type1 = int.Parse(Console.ReadLine());
                E_QQType QQtype = (E_QQType)type1;
                Console.WriteLine(QQtype);
            }
            catch 
            {
                Console.WriteLine("请输入数字");
            }
            #endregion


            #region MyRegion
            //用户去星巴克买咖啡 分为中杯（35元） 大杯（40元）超大杯（43元）
            //请用户选择要购买的类型 用户选择后 打印：你购买了xxx咖啡 花费了xx元
            //例如：你购买了中杯咖啡 花费了35元
            try
            {
                Console.WriteLine("请选择你想喝的咖啡类型(0中杯，1大杯，2超大杯)");
                int type2 = int.Parse(Console.ReadLine());
                E_coffeeType coffeeType = (E_coffeeType)type2;
                switch(coffeeType)
                {
                    case E_coffeeType.medium:
                        Console.WriteLine("你购买了中杯咖啡，花费了35元");
                        break;
                    case E_coffeeType.mug:
                        Console.WriteLine("你购买了大杯咖啡，花了40元");
                        break;
                    case E_coffeeType.super:
                        Console.WriteLine("你购买了超大杯咖啡，花费了43元");
                        break;
                }
            }
            catch 
            {
                Console.WriteLine("请重新输入正确的数字");
            }
            #endregion

            #region 练习题三
            //请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，防御力，技能）
            //性别：
            //男（攻击力+50，防御力+100）
            //女（攻击力+150，防御力+20）
            //职业：
            //战士（攻击力+20，防御力+100，技能：冲锋）
            //猎人（攻击力+120，防御力+30，技能：假死）
            //法师（攻击力+200，防御力+10，技能：奥数冲击）

            //举例打印：你选了“女法师”，攻击力：350，防御力：30，职业技能：奥数冲击

            try
            {
                Console.WriteLine("请输入性别（男0，女1）");
                E_sex sex = (E_sex)int.Parse(Console.ReadLine());
                string sexStr = "";
                int atk = 0;
                int def = 0;
                switch (sex)
                {
                    case E_sex.Man:
                        sexStr = "男性";
                        atk += 50;
                        def += 100;
                        break;
                    case E_sex.Woman:
                        sexStr = "女性";
                        atk += 150;
                        def += 20;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("请选择职业（战士0猎人1法师2）");
                E_occupation occupation = (E_occupation)int.Parse(Console.ReadLine());
                string skill = "";
                string occ = "";
                switch (occupation)
                {
                    case E_occupation.Warrior:
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        occ = "战士";
                        break;
                    case E_occupation.Hunter:
                        atk += 120;
                        def += 30;
                        skill = "假死";
                        occ = "猎人";
                        break;
                    case E_occupation.Master:
                        atk += 200;
                        def += 10;
                        skill = "奥数冲击";
                        occ = "法师";
                        break;
                    default:
                        
                        break;
                }
                Console.WriteLine("你选的\"{0}{1}\",攻击力：{2}，防御力:{3}，职业技能:{4}",sexStr,occ,atk,def,skill);
            }
            catch 
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
        }
    }
}
