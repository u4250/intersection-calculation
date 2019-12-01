using System;

namespace 测量实习
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle(0,0,0);
            //##################################测试数据
            //Angle[] s1 = new Angle[4];
            //s1[0] = new Angle(102, 48, 02);
            //s1[1] = new Angle(78, 51, 08);
            //s1[2] = new Angle(84, 23, 20);
            //s1[3] = new Angle(93, 57, 30);
            //double[] l1 = { 112.01, 87.58, 137.71, 89.50 };
            //Angle[] fwj1 = new Angle[5];
            //fwj1[0] = new Angle(0, 15, 0);
            //for (int i = 0; i < 4; i++)
            //{
            //    fwj1[i + 1] = new Angle().GetAngle1(fwj1[i], s1[i]);
            //    Console.WriteLine(fwj1[i].d.ToString() + " " + fwj1[i].f.ToString() + " " + fwj1[i].m.ToString());

            //}
            //ZBZL(l1, fwj1);
            //##############################################################
            //Angle[] s1 = new Angle[11];
            //s1[0] = new Angle(174, 39, 53);
            //s1[1] = new Angle(102,57,43);
            //s1[2] = new Angle(168,14,39);
            //s1[3] = new Angle(96,14,31);
            //s1[4] = new Angle(172, 15, 18);
            //s1[5] = new Angle(100, 45, 45);
            //s1[6] = new Angle(339, 37, 5);
            //s1[7] = new Angle(99, 40, 19);
            //s1[8] = new Angle(100, 06, 05);
            //s1[9] = new Angle(169, 07, 23);
            //s1[10] = new Angle(96, 21, 19);
           
            //double[] l1 = {87.095,53.819,49.084,50.020,62.025,38.202,38.106,44.345,32.440,41.08,63.164 };
            //Angle[] fwj1 = new Angle[12];
            //fwj1[0] = new Angle(2,3,35);
            //for (int i = 0; i <11; i++)
            //{
            //    fwj1[i +1] = new Angle().GetAngle(fwj1[i], s1[i]);
            //    Console.WriteLine(fwj1[i].d.ToString() + " " + fwj1[i].f.ToString() + " " + fwj1[i].m.ToString());

            //}
            //ZBZL(l1, fwj1);
            //########################################################################################################
            Angle[] s = new Angle[11];
            s[0] =new Angle (92, 56, 18-2);
            s[1] = new Angle(168, 45,33-2);
            s[2] = new Angle(98,29,48-2);
            s[3] = new Angle(175,53,23-2);
            s[4] = new Angle(186,33,16-2);
            s[5] = new Angle(83,16,13-2);
            s[6] = new Angle(177,48,37-2);
            s[7] = new Angle(89,27,28-2);
            s[8] = new Angle(184,13,31-2);
            s[9] = new Angle(182,36,12-1);
            double[] l= {34.891,66.883,56.235,52.682,41.503,49.039,60.515,65.056,41.668,41.776};
            ///#########################################################################################################
            //坐标方位角推算
            Angle[] fwj1 = new Angle[11];
            fwj1[0] = new Angle(2, 3, 34);
            for (int i = 0; i < 9; i++)
            {
                fwj1[i + 1] = new Angle().GetAngle(fwj1[i], s[i+1]);
                Console.WriteLine(fwj1[i].d.ToString() + " " + fwj1[i].f.ToString() + " " + fwj1[i].m.ToString());

            }
            ZBZL(l, fwj1);

        }
        static void ZBZL(double[] l,Angle[] fwj)//坐标增量
        {
            double[] dx= new double[12];
            double [] dy= new double[12];
            double x = 0, y = 0;
            for (int i = 0; i < l.Length; i++)
            {

                dx[i] = l[i] * Math.Cos(JDZH(fwj[i]));
                dy[i] = l[i] * Math.Sin(JDZH(fwj[i]));
                y += dy[i];
                x += dx[i];
            }
        }
         static double JDZH(Angle fwj)
        {
            double hudu;
            hudu =fwj.d +fwj.f / 60.0 + fwj.m / 3600.0;//单位统一为度
            hudu = hudu / 180 * Math.PI;
            return hudu;
        }

    }
}
