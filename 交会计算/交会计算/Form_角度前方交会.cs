using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main7
{
    public partial class Form_角度前方交会 : Form
    {
        public int flg = 0;//初始化
        public Form_角度前方交会()
        {
            InitializeComponent();
        }

        private void label_X1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_End_Click(object sender, EventArgs e)
        {//点A,B,P代号
            Point pointa = new Point();
            Point pointb = new Point();
            Point pointp = new Point();
            string a, b;
            double ha, hb;
            if (Xa.Text == "" || Ya.Text == "" || Xb.Text == "" || Yb.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                label5.Text = "请输入完整数据！";
            }
            else
            {
                //读取坐标内容且string强制转化成double
                pointa.x = Convert.ToDouble(Xa.Text);//Xa
                pointa.y = Convert.ToDouble(Ya.Text);//Ya
                pointb.x = Convert.ToDouble(Xb.Text);//Xb
                pointb.y = Convert.ToDouble(Yb.Text);//Yb

                //读取角度内容
                a = textBox1.Text;
                b = textBox2.Text;
                //角度换算
                ha = JDZH(a);
                hb = JDZH(b);
                //获得P点坐标
                pointp = QFJH(pointa, pointb, ha, hb);
                //输出结果
                label1.Text = Convert.ToString(pointp.x);
                label2.Text = Convert.ToString(pointp.y);


                //成图 

                //更新pictureBox1的图像
                pictureBox1.Image = null;
                pictureBox1.Update();

                //在picturebox中定义点
                List<PointF> ListP = new List<PointF>();
                PointF PA = new PointF((float)pointa.x, (float)pointa.y);
                ListP.Add(PA);
                PointF PB = new PointF((float)pointb.x, (float)pointb.y);
                ListP.Add(PB);
                PointF PP = new PointF((float)pointp.x, (float)pointp.y);
                ListP.Add(PP);

                //X方向
                ListP.Sort((m, n) => { return m.X.CompareTo(n.X); });
                double Xmax = ListP[ListP.Count - 1].X;
                double Xmin = ListP[0].X;
                double deltaX = Xmax - Xmin;
                int picWidth = pictureBox1.Width - 100;
                double ratioX = picWidth * 1.0 / deltaX;
                //Y方向
                ListP.Sort((m, n) => { return m.Y.CompareTo(n.Y); });
                double Ymax = ListP[ListP.Count - 1].Y;
                double Ymin = ListP[0].Y;
                double deltaY = Ymax - Ymin;
                int picHeight = pictureBox1.Height - 100;
                double ratioY = picHeight * 1.0 / deltaY;
                double ratio = Math.Min(ratioX, ratioY);

                //坐标点
                PointF PAnew = new PointF((float)((PA.X - Xmin) * ratio), (float)(picHeight - ((PA.Y - Ymin) * ratio)));
                PointF PBnew = new PointF((float)((PB.X - Xmin) * ratio), (float)(picHeight - ((PB.Y - Ymin) * ratio)));
                PointF PPnew = new PointF((float)((PP.X - Xmin) * ratio), (float)(picHeight - ((PP.Y - Ymin) * ratio)));

                //线
                Graphics gh = pictureBox1.CreateGraphics();
                Pen penAB = new Pen(Color.Black, 6);
                Pen penAC = new Pen(Color.Black, 6);
                Pen penBC = new Pen(Color.Black, 6);
                gh.DrawLine(penAB, PAnew, PBnew);

                Pen penP = new Pen(Color.Black, 2);
                gh.DrawLine(penP, PAnew, PPnew);
                gh.DrawLine(penP, PBnew, PPnew);

                //字符串(图像显示点坐标)
                Font drawFont = new Font("Times New Roman", 6);//画笔粗细
                SolidBrush brushAB = new SolidBrush(Color.Black);//AB颜色
                SolidBrush brushBC = new SolidBrush(Color.Black);//BC颜色
                string Astr = "A(" + PA.X.ToString() + "," + PA.Y.ToString() + ")";//A点
                gh.DrawString(Astr, drawFont, brushAB, PAnew.X, PAnew.Y);
                string Bstr = "B(" + PB.X.ToString() + "," + PB.Y.ToString() + ")";
                gh.DrawString(Bstr, drawFont, brushAB, PBnew.X, PBnew.Y);
                SolidBrush brushP = new SolidBrush(Color.Black);
                string Pstr = "P(" + PP.X.ToString() + "," + PP.Y.ToString() + ")";
                gh.DrawString(Pstr, drawFont, brushP, PPnew);
            }

        }

        private void label_格式提示_Click(object sender, EventArgs e)
        {

        }

        public void button_批量处理_Click(object sender, EventArgs e)
        {
            flg = 1;
            Form_读取文件 frw = new Form_读取文件();
            frw.flag=this.flg;
            frw.Show();
        }


        //转化为弧度制的函数
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

        //建立点集
        static Point QFJH(Point pointA, Point pointB, double gcja, double gcjb)
        {
            Point pointP = new Point(0, 0);
            pointP.x = (pointA.x / Math.Tan(gcjb) + pointB.x / Math.Tan(gcja) + (pointB.y - pointA.y)) / (1 / Math.Tan(gcja) + 1 / Math.Tan(gcjb));
            pointP.y = (pointA.y / Math.Tan(gcjb) + pointB.y / Math.Tan(gcja) - (pointB.x - pointA.x)) / (1 / Math.Tan(gcja) + 1 / Math.Tan(gcjb));
            return pointP;
        }
        private void Form_角度前方交会_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button_清空_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    //循环清空TEXTBOX里面的内容
                    ((TextBox)item).Text = "";
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_angleB_Click(object sender, EventArgs e)
        {

        }

        private void label_angleA_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label_X_Click(object sender, EventArgs e)
        {

        }

        private void label_Y_Click(object sender, EventArgs e)
        {

        }
    }
}
