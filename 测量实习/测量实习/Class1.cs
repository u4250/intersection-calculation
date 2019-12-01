using System;
using System.Collections.Generic;
using System.Text;

namespace 测量实习
{
   public class Angle
    {
        public int d;
        public int f;
        public int m;
        public Angle()
        {
            this.d = 0;
            this.f = 0;
            this.m = 0;
        }
        public Angle(int d,int f,int m)
        {
            this.d = d;
            this.f = f;
            this.m = m;
        }
        public static Angle operator +(Angle a1,Angle a2)
        {
            Angle a = new Angle();
            a.m = a1.m + a2.m;
            a.f = a1.f + a2.f;
            a.d = a1.d + a2.d;
            if (a.m >= 60)
            {
                a.m -= 60;
                a.f += 1;
                if (a.f >= 60)
                {
                    a.f -= 60;
                    a.d += 1;
                }
            }
            if (a.f >= 60)
            {
                a.f -= 60;
                a.d += 1;
            }
            return a;
        }
        public static Angle operator -(Angle a1, Angle a2)
        {
            Angle a = new Angle();
            a.m = a1.m - a2.m;
            a.f = a1.f - a2.f;
            a.d = a1.d - a2.d;
            if (a.m < 0)
            {
                a.f -= 1;
                a.m += 60;
            }
            if (a.f < 0)
            {
                a.f += 60;
                a.d -= 1;
            }
            return a;
        }
        //public static bool operator <(Angle a1, Angle a2)
        //{
        //    if (a1.d < a2.d && a1.f < a2.f && a1.m < a2.m)
        //    {
        //        return true;
        //    }
        //    else
        //    return true;
        //}
        //public static bool operator >(Angle a1, Angle a2)
        //{
        //    if (a1.d > a2.d && a1.f > a2.f && a1.m > a2.m)
        //    {
        //        return true;
        //    }
        //    else
        //        return true;
        //}
        public Angle GetAngle(Angle Aab, Angle gcj)
        {
            Angle lin = new Angle(0, 0, 0);
            Angle flag = new Angle(360, 0, 0);
            Angle pin = new Angle(180,0,0);
            Angle aziang = new Angle(0,0,0);//坐标方位角
            aziang = Aab+ gcj+pin;
            while (aziang.d >= flag.d || aziang.d < lin.d)
            {
                if (aziang.d >= flag.d)
                {
                    aziang -= flag;
                }
                else if (aziang.d < lin.d)
                {
                    aziang += flag;
                }
            }

            return aziang;
        }
        public Angle GetAngle1(Angle Aab, Angle gcj)
        {
            Angle lin = new Angle(0, 0, 0);
            Angle flag = new Angle(360, 0, 0);
            Angle pin = new Angle(180, 0, 0);
            Angle aziang = new Angle(0, 0, 0);//坐标方位角
            aziang = Aab - gcj + pin;
            while (aziang.d >= flag.d || aziang.d < lin.d)
            {
                if (aziang.d >= flag.d)
                {
                    aziang -= flag;
                }
                else if (aziang.d < lin.d)
                {
                    aziang += flag;
                }
            }

            return aziang;
        }
    }
}
