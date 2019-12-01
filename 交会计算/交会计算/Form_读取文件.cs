using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace main7
{
    public partial class Form_读取文件 : Form
    {
        public int flag;
        public Form_读取文件()
        {
            InitializeComponent();
            comboBox1.Items.Add("");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";//存储格式
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)//判断是否打开文件
            {//button1的显示内容为*.Text
                button_文件浏览.Text = "浏览";

                //sr读取openFileDialog提供的文件内容
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                this.textBox_显示内容.Text = sr.ReadToEnd();//"textBox_显示内容"的内容为通过sr的内容
                sr.Close();

                //将openFileDialog中的名字放在combox中显示
                  comboBox1.Items.Clear();//清除之前打开的历史               
                foreach (string s in openFileDialog1.FileNames)                
                {  comboBox1.Items.Add(s);  }         
                comboBox1.SelectedIndex = 0;              
                string file_path = openFileDialog1.FileName;//记录选择的文件全路径
                file_path = comboBox1.Text;
            }
        }

        private void TextBox_显示内容_TextChanged(object sender, EventArgs e)
        {

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
        static Point QFJH(Point pointA, Point pointB, double gcja, double gcjb)
        {
            Point pointP = new Point(0, 0);
            pointP.x = (pointA.x / Math.Tan(gcjb) + pointB.x / Math.Tan(gcja) + (pointB.y - pointA.y)) / (1 / Math.Tan(gcja) + 1 / System.Math.Tan(gcjb));
            pointP.y = (pointA.y / Math.Tan(gcjb) + pointB.y / Math.Tan(gcja) - (pointB.x - pointA.x)) / (1 / Math.Tan(gcja) + 1 / System.Math.Tan(gcjb));
            return pointP;
        }
        static Point HFJH(Point pointA, Point pointB, Point pointC, double Anglea, double Angleb, double Angelc)
        {
            Point pointp = new Point();
            //坐标方位角
            double αAB = Math.Atan((pointB.y - pointA.y) / (pointB.x - pointA.x));
            double αBA = Math.Atan((pointA.y - pointB.y) / (pointA.x - pointB.x));
            double αBC = Math.Atan((pointC.y - pointB.y) / (pointC.x - pointB.x));
            double αCB = Math.Atan((pointB.y - pointC.y) / (pointB.x - pointC.x));
            double αAC = Math.Atan((pointC.y - pointA.y) / (pointC.x - pointA.x));
            double αCA = Math.Atan((pointA.y - pointC.y) / (pointA.x - pointC.x));
            //固定角
            double A = αAC - αAB;
            double B = αBA - αBC;
            double C = αCB - αCA;
            //仿权值
            double PA = (1 / (1 / Math.Tan(A) - 1 / Math.Tan(Anglea)));
            double PB = (1 / (1 / Math.Tan(B) - 1 / Math.Tan(Angleb)));
            double PC = (1 / (1 / Math.Tan(C) - 1 / Math.Tan(Angelc)));
            //待定点坐标
            pointp.x = (PA * pointA.x + PB * pointB.x + PC * pointC.x) / (PA + PB + PC);
            pointp.y = (PA * pointA.y + PB * pointB.y + PC * pointC.y) / (PA + PB + PC);
            return pointp;
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                double[] fwja = new double[100];//最多支持导入100条数据   （方位角a)
                double[] fwjb = new double[100];
                Point[] pointp = new Point[100];//待求坐标点
                string[] str;
                Point[] d1 = new Point[100];//坐标点A构成点数组
                Point[] d2 = new Point[100];//坐标点B构成点数组
                string txt;
                for (int i = 0; (txt = sr.ReadLine()) != null; i++)
                {
                    if (string.IsNullOrEmpty(txt))
                    {
                        continue;//如果本行为空行则跳过此次循环

                    }
                    else
                    {
                        //txt = sr.ReadLine();//行数据格式 A点 B点 观测角1 观测角2 （x,y,度分秒中间均由空格隔开）
                        str = txt.Replace(',', ' ').Replace('°', ' ').Replace('′', ' ').Replace('″', ' ').Split(' ');//按行提取数据
                        d1[i] = new Point(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));//提取前两个数据形成坐标点A
                        d2[i] = new Point(Convert.ToDouble(str[2]), Convert.ToDouble(str[3]));
                        fwja[i] = JDZH(str[4] + ' ' + str[5] + ' ' + str[6]);//形成方位角  调用JDZH()函数，将度分秒转换为度
                        fwjb[i] = JDZH(str[7] + ' ' + str[8] + ' ' + str[9]);
                        pointp[i] = new Point(QFJH(d1[i], d2[i], fwja[i], fwjb[i]).x, QFJH(d1[i], d2[i], fwja[i], fwjb[i]).y);//调用QFJH()函数计算待定点
                        this.textBox_计算结果.Text = this.textBox_计算结果.Text + '\n' + Convert.ToString(pointp[i].x) + ' ' + Convert.ToString(pointp[i].y);//将结果循环写入texbox
                    }
                }
                    sr.Close();
                
            }
            else if (flag == 2)
            {
                // QFJH2(pointa, pointb, a, b);
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                double[] a = new double[100];//最多支持导入100条数据   （方位角a)
                double[] b = new double[100];
                Point[] pointp = new Point[100];//待求坐标点
                string[] str;
                Point[] d1 = new Point[100];//坐标点A构成点数组
                Point[] d2 = new Point[100];//坐标点B构成点数组
                string txt;
                for (int i = 0; (txt = sr.ReadLine()) != null; i++)
                {
                    if (string.IsNullOrEmpty(txt))
                    {
                        continue;//如果本行为空行则跳过此次循环

                    }
                    else
                    {
                        //txt = sr.ReadLine();//行数据格式 A点 B点 观测角1 观测角2 （x,y,度分秒中间均由空格隔开）
                        str = txt.Replace(',', ' ').Replace('°', ' ').Replace('′', ' ').Replace('″', ' ').Split(' ');//按行提取数据
                        d1[i] = new Point(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));//提取前两个数据形成坐标点A
                        d2[i] = new Point(Convert.ToDouble(str[2]), Convert.ToDouble(str[3]));
                        a[i] = Convert.ToDouble(str[4]);//形成方位角  调用JDZH()函数，将度分秒转换为度
                        b[i] = Convert.ToDouble(str[5]);
                        pointp[i] = new Point(QFJH(d1[i], d2[i], a[i], b[i]).x, QFJH(d1[i], d2[i], a[i], b[i]).y);//调用QFJH()函数计算待定点
                        this.textBox_计算结果.Text = this.textBox_计算结果.Text + '\n' + Convert.ToString(pointp[i].x) + ' ' + Convert.ToString(pointp[i].y);//将结果循环写入texbox
                    }
                }
                sr.Close();

            }

            else
            {//后方交会
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                double[] fwja = new double[100];
                double[] fwjb = new double[100];
                double[] fwjc = new double[100];
                Point[] pointp = new Point[100];
                string[] str;
                Point[] d1 = new Point[100];//点数组 A点
                Point[] d2 = new Point[100];//B点
                Point[] d3 = new Point[100];
                string txt;
                for (int i = 0; (txt = sr.ReadLine()) != null; i++)
                {
                    if (string.IsNullOrEmpty(txt))
                    {
                        continue;//如果本行为空行则跳过此次循环

                    }
                    else
                    {
                        str = txt.Replace(',', ' ').Replace('°', ' ').Replace('′', ' ').Replace('″', ' ').Split(' ');//按行提取数据
                        d1[i] = new Point(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));//提取前两个数据形成坐标点A
                        d2[i] = new Point(Convert.ToDouble(str[2]), Convert.ToDouble(str[3]));
                        d3[i] = new Point(Convert.ToDouble(str[4]), Convert.ToDouble(str[5]));
                        fwja[i] = JDZH(str[6] + ' ' + str[7] + ' ' + str[8]);//  调用JDZH()函数，将度分秒转换为度
                        fwjb[i] = JDZH(str[9] + ' ' + str[10] + ' ' + str[11]);
                        fwjc[i] = JDZH(str[12] + ' ' + str[13] + ' ' + str[14]);
                        pointp[i] = new Point(HFJH(d1[i], d2[i], d3[i], fwja[i], fwjb[i], fwjc[i]).x, HFJH(d1[i], d2[i], d3[i], fwja[i], fwjb[i], fwjc[i]).y);//调用QFJH()函数计算待定点           
                        this.textBox_计算结果.Text = this.textBox_计算结果.Text + '\n' + Convert.ToString(pointp[i].x) + ' ' + Convert.ToString(pointp[i].y);//将结果循环写入texbox
                    }
                }
                    sr.Close();
                
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_导出数据_Click(object sender, EventArgs e)
        {
            //保存到saveFileDialog提供的路径中
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";//决定存储的格式
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)//判断是否点击按钮
            {
                button_导出数据.Text = "导出";//显示
                 string result = this.textBox_计算结果.Text.Trim(); //用result读取"textBox_计算结果"的内容

                 string fp = saveFileDialog1.FileName;//记录saveFileDialog选择的路径
                 StreamWriter sw = File.AppendText(fp); //保存到指定路径
                 sw.Write(result);
                    sw.Flush();
                    sw.Close();
                
            }
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
