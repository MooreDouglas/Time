//Moore, Douglas
namespace REPIGE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string orgtime = "1";
            bool start = true;

            /////////////////////////////////////
            
            while(start == true)
            {
                FifthOption(orgtime);
            }
        }
        static void FifthOption(string orgtime)
        {
            Random rng = new Random();
            int Mmin = 0;
            int Mmax = 61;
            int Minute = rng.Next(Mmin, Mmax);
            int Hmin = 1;
            int Hmax = 13;
            int Hour = rng.Next(Hmin, Hmax);
            int day = 1;
            bool daytime = true;
            Option(Minute, Hour, day, daytime);
        }
        static void Option(int Minute, int Hour, int day, bool daytime)
        {
            string time;
            int timen;
            string SMinute;
            string SHour;
            string amp;
            int ampn;
            while (true)
            {
                if (Minute == 60)
                {
                    Minute = 0;
                    Hour++;
                }
                if (Hour == 13)
                {
                    Hour = 1;
                    if (daytime == true)
                    {
                        daytime = false;
                    }
                    else
                    {
                        daytime = true;
                        day++;
                    }
                }
                if (daytime == true)
                {
                    amp = "AM";
                    ampn = 1;
                }
                else
                {
                    amp = "PM";
                    ampn = 2;
                }
                if (Minute < 10)
                {
                    SMinute = "0" + Minute;
                }
                else
                {
                    SMinute = "" + Minute;
                }
                if (Hour < 10)
                {
                    SHour = "0" + Hour;
                }
                else
                {
                    SHour = "" + Hour;
                }
                time = SHour + ":" + SMinute + " " + amp;
                timen = day * 100000 + Hour * 1000 + Minute * 10 + ampn;
                Console.WriteLine("Day: " + day + " Time: " + time + " ");
                Console.WriteLine(timen);
                Minute++;
//                Thread.Sleep(1000);

            }
        }
    }
}