using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace main7
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_封面());
        }
        static double JDZH(string a)
        {
            //string q = "20 18 32";//角度20°18′32″
            string[] strArray;
            strArray = a.Split(' ');//按空格分割{”20“，”18“，”32“}
            int[] j;
            j = Array.ConvertAll<string, int>(strArray, int.Parse);//将字符数组转换为int数组，{20，18，32}
            double hudua = j[0] + j[1] / 60.0 + j[2] / 3600.0;//单位统一为度
            hudua = hudua / 180 * Math.PI;
            Console.WriteLine(1 / Math.Tan(hudua));
            return hudua;
        }
    }
}
