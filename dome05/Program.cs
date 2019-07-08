using System;

namespace dome05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 语文90 数学80 英语67,编程求总分和平均分

            //int Chinese = 90;
            //int Math = 80;
            //int English = 67;
            //Console.WriteLine("总分是{0},平均成绩是{1}", Chinese + Math + English, (Chinese + Math + English)/3);
            //Console.ReadKey();

            #endregion

            #region 计算半径为5的圆的面积和周长(pi为3.14)

            //int r = 5;
            //double pi = 3.14;
            //double area = pi * r * r;
            //double perimeter = 2 * pi * r;
            //Console.WriteLine("半径为5的圆的面积是:{0},周长是{1}", area, perimeter);
            //Console.ReadKey();

            #endregion

            #region T-shirt 35一件  trousers裤子 120一条 3件T恤,2条裤子共多少钱,打完8.8折后呢

            //int T_shirt = 35;
            //int trousers = 120;
            //int totalMoney = 3 * T_shirt + 2 * trousers;
            //double discount = 0.88;   // 折扣为0.88
            //double realMoney = totalMoney * discount;

            //Console.WriteLine("总共需要:{0}元,8.8折后的价格为{1}", totalMoney,realMoney);


            #endregion

            #region 编程实现计算几天(如46天)是几周零几天

            //Console.WriteLine("请输入天数(整数类型)");
            //int days = int.Parse(Console.ReadLine());
            //CountDayToWeek(days);
            //Console.ReadKey();

            #endregion

            #region 编程实现多少秒(如107653)是几天几小时几分钟几秒

            Console.WriteLine("请输入秒数(整数秒)");
            int seconds = int.Parse(Console.ReadLine());
            SecondConver(seconds);
            Console.ReadKey();

            Console.WriteLine("请输入天数(整数天)");
            int tdays = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入小时数(整数小时<24)");
            int thours = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入分钟数(整数分钟<60)");
            int tminutes = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入秒数(整数秒<60)");
            int tseconds = int.Parse(Console.ReadLine());
            ToConverSecond(tdays, thours, tminutes, tseconds);
            Console.ReadKey();

            #endregion

        }

        // 编程实现计算几天(如46天)是几周零几天
        public static void CountDayToWeek(int day)
        {
            int weeks = day / 7;
            int afterDay = day % 7;
            Console.WriteLine("{0}天是{1}周{2}天", day, weeks, afterDay);
        }

        // 编程实现多少秒(如107653)是几天几小时几分钟几秒
        public static void SecondConver(int seconds)
        {
            int days = seconds / (24 * 60 * 60);  // 天数 = 总秒数整除一天的秒数(24*60*60)         
            int hours = (seconds % (24 * 60 * 60)) / (60 * 60); // 小时数 = 总秒数余一天的秒数(不足一天的总秒数)整除一小时的秒(60*60 
            int minutes = (seconds % (60 * 60)) / 60; // 分钟数 = 总秒数余一小时的秒数(不足一小时的总秒数)整除一分钟的秒数(60)        
            int second = seconds % 60; // 秒数 = 总秒数余一分钟的秒数(即不足一分钟的总秒数)

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, minutes, second);
        }

        public static void ToConverSecond(int days, int hours, int minutes, int seconds)
        {
            Console.WriteLine("{0}天{1}小时{2}分钟{3}秒是{4}秒"
                ,days,hours,minutes,seconds,days*24*60*60+hours*60*60+minutes*60+seconds);
        }
    }

}
