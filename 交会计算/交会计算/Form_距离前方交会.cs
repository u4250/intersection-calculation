using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace main7
{
    public partial class Form_距离前方交会 : Form
    {
        public int fl = 0;
        struct jgt
        {
            public double s;
            public double fwjp;
        };
        public Form_距离前方交会()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_批量处理_Click(object sender, EventArgs e)
        {
            fl = 2;
            Form_读取文件 frw = new Form_读取文件();
            frw.flag = this.fl;
            frw.Show();
        }

        private void button_清空_Click(object sender, EventArgs e)
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

        private void Button_Caculate_Click(object sender, EventArgs e)
        {
            Point pointa = new Point();
            Point pointb = new Point();
            Point pointp = new Point();
            double a, b;
            if (Xa.Text == "" || Ya.Text == "" || Xb.Text == "" || Yb.Text == "" || textBox_a.Text == "" || textBox_b.Text == "")
            {
                label5.Text = "请输入完整数据！";
            }
            else
            {
                pointa.x = Convert.ToDouble(Xa.Text);
                pointa.y = Convert.ToDouble(Ya.Text);
                pointb.x = Convert.ToDouble(Xb.Text);
                pointb.y = Convert.ToDouble(Yb.Text);//点坐标

                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);//边长

                pointp = QFJH2(pointa, pointb, a, b);//计算
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
        static Point QFJH2(Point pointA, Point pointB, double distA, double distB)
        {
            jgt jiegou;//结构体包含坐标反算得到的距离，方位角。
            double angleA; //三角形 PAB中的角A
            double angleB;
            double angleBP; //BP 边的方位角
            double angleAP;  //AP 边的方位角
            jiegou = ZBFS(pointA, pointB);//坐标反算
            angleA = Math.Acos((jiegou.s * jiegou.s + distA * distA - distB * distB) / 2 * jiegou.s * distA);
            angleB = Math.Acos((jiegou.s * jiegou.s - distA * distA + distB * distB) / 2 * jiegou.s * distA);
            angleAP = jiegou.fwjp - angleA;
            angleBP = 2 * Math.PI - jiegou.fwjp + angleB;
            Point pointP = new Point
            {
                x = (pointA.x + pointB.x + distA * Math.Cos(angleAP) + distB * Math.Cos(angleBP)) / 2,
                y = (pointA.y + pointB.y + distA * Math.Sin(angleAP) + distB * Math.Sin(angleBP)) / 2
            };
            return pointP;
        }
        static jgt ZBFS(Point pointA, Point pointB)
        {
            double dx;
            double dy;
            jgt jiegouti;
            jiegouti.s = pointA.Distance(pointB);//点间距离
            dx = Math.Abs(pointB.x - pointA.x);
            Console.WriteLine(dx);

            dy = Math.Abs(pointB.y - pointA.y);
            Console.WriteLine(dy);
            double a;
            double angle = 0;
            a = Math.Atan(dy / dx);
            if (pointB.y > pointA.y & pointB.x > pointA.x)
                angle = a;
            else if (pointB.y > pointA.y & pointB.x < pointA.x)
                angle = Math.PI - a;
            else if (pointB.y < pointA.y & pointB.x < pointA.x)
                angle = Math.PI + a;
            else if (pointB.y < pointA.y & pointB.x > pointA.x)
                angle = 2 * Math.PI - a;
            else if (pointB.y == pointA.y & pointB.x > pointA.x)
                angle = 0;
            else if (pointB.y == pointA.y & pointB.x < pointA.x)
                angle = Math.PI;
            else if (pointB.x == pointA.x & pointB.y > pointA.y)
                angle = Math.PI / 2;
            else if (pointB.x == pointA.x & pointB.y < pointA.y)
                angle = Math.PI * 3 / 2;
            jiegouti.fwjp = angle;
            Console.WriteLine(a);
            return jiegouti;
        }

        private void label_Y_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_距离前方交会_Load(object sender, EventArgs e)
        {

        }
    }
}
