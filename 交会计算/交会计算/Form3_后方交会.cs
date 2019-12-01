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
    public partial class Form3_后方交会 : Form
    {
        public Form3_后方交会()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            //已知坐标A
            double Xa = Convert.ToDouble(coorAX.Text);
            double Ya = Convert.ToDouble(coorAY.Text);
            //已知坐标B
            double Xb = Convert.ToDouble(coorBX.Text);
            double Yb = Convert.ToDouble(coorBY.Text);
            //已知坐标C
            double Xc = Convert.ToDouble(coorCX.Text);
            double Yc = Convert.ToDouble(coorCY.Text);
            //观测角度α         
            double Angleα = Convert.ToDouble(angleα.Text);

            if ((Angleα < 0) || (Angleα > 180))
            {
                MessageBox.Show("角度A的度不正确,请重新输入");
                angleα.Clear();
                angleα.Focus();
            }
            double Minuteα = Convert.ToDouble(minuteα.Text);
            if ((Minuteα < 0) || (Minuteα > 60))
            {
                MessageBox.Show("角度A的分不正确,请重新输入");
                minuteα.Clear();
                minuteα.Focus();
            }
            double Secondα = Convert.ToDouble(secondα.Text);
            if ((Secondα < 0) || (Secondα > 60))
            {
                MessageBox.Show("角度A的秒不正确，请重新输入");
                secondα.Clear();
                secondα.Focus();
            }
            double α = (Angleα * 1.0 + Minuteα / 60.0 + Secondα / 3600.0) / 180.0 * Math.PI;
            //观测角度β
            double Angleβ = Convert.ToDouble(angleβ.Text);
            if ((Angleβ < 0) || (Angleβ > 180))
            {
                MessageBox.Show("角度B的度不正确,请重新输入");
                angleβ.Clear();
                angleβ.Focus();
            }
            double Minuteβ = Convert.ToDouble(minuteβ.Text);
            if ((Minuteβ < 0) || (Minuteβ > 60))
            {
                MessageBox.Show("角度B的分不正确，请重新输入");
                minuteβ.Clear();
                minuteβ.Focus();
            }
            double Secondβ = Convert.ToDouble(secondβ.Text);
            if ((Secondβ < 0) || (Secondβ > 60))
            {
                MessageBox.Show("角度B的秒不正确,请重新输入");
                secondβ.Clear();
                secondβ.Focus();
            }
            double β = (Angleβ * 1.0 + Minuteβ / 60.0 + Secondβ / 3600.0) / 180.0 * Math.PI;
            //观测角度γ
            double Angleγ = Convert.ToDouble(angleγ.Text);
            if ((Angleγ < 0) || (Angleγ > 180))
            {
                MessageBox.Show("角度B的度不正确,请重新输入");
                angleγ.Clear();
                angleγ.Focus();
            }
            double Minuteγ = Convert.ToDouble(minuteγ.Text);
            if ((Minuteγ < 0) || (Minuteγ > 60))
            {
                MessageBox.Show("角度B的分不正确，请重新输入");
                minuteγ.Clear();
                minuteγ.Focus();
            }
            double Secondγ = Convert.ToDouble(secondγ.Text);
            if ((Secondγ < 0) || (Secondγ > 60))
            {
                MessageBox.Show("角度B的秒不正确,请重新输入");
                secondγ.Clear();
                secondγ.Focus();
            }
            double γ = (Angleγ * 1.0 + Minuteγ / 60.0 + Secondγ / 3600.0) / 180.0 * Math.PI;
            //坐标方位角
            double αAB = Math.Atan((Yb - Ya) / (Xb - Xa));
            double αBA = Math.Atan((Ya - Yb) / (Xa - Xb));
            double αBC = Math.Atan((Yc - Yb) / (Xc - Xb));
            double αCB = Math.Atan((Yb - Yc) / (Xb - Xc));
            double αAC = Math.Atan((Yc - Ya) / (Xc - Xa));
            double αCA = Math.Atan((Ya - Yc) / (Xa - Xc));
            //固定角
            double A = αAC - αAB;
            double B = αBA - αBC;
            double C = αCB - αCA;
            //仿权值
            double PA = (1 / (1 / Math.Tan(A) - 1 / Math.Tan(α)));
            double PB = (1 / (1 / Math.Tan(B) - 1 / Math.Tan(β)));
            double PC = (1 / (1 / Math.Tan(C) - 1 / Math.Tan(γ)));
            //待定点坐标
            double Xp = (PA * Xa + PB * Xb + PC * Xc) / (PA + PB + PC);
            double Yp = (PA * Ya + PB * Yb + PC * Yc) / (PA + PB + PC);
            coorPX.Text = Xp.ToString("F3");
            coorPY.Text = Yp.ToString("F3");

            //成图

            //更新pictureBox1的图像
            pictureBox1.Image = null;
            pictureBox1.Update();

            List<PointF> ListP = new List<PointF>();
            PointF pa = new PointF((float)Xa, (float)Ya);
            ListP.Add(pa);
            PointF pb = new PointF((float)Xb, (float)Yb);
            ListP.Add(pb);
            PointF pc = new PointF((float)Xc, (float)Yc);
            ListP.Add(pc);
            PointF PP = new PointF((float)Xp, (float)Yp);
            ListP.Add(PP);

            ListP.Sort((a, b) => { return a.X.CompareTo(b.X); });
            double Xmax = ListP[ListP.Count - 1].X;
            double Xmin = ListP[0].X;
            double deltaX = Xmax - Xmin;
            int picWidth = pictureBox1.Width - 100;
            double ratioX = picWidth * 1.0 / deltaX;

            ListP.Sort((a, b) => { return a.Y.CompareTo(b.Y); });
            double Ymax = ListP[ListP.Count - 1].Y;
            double Ymin = ListP[0].Y;
            double deltaY = Ymax - Ymin;
            int picHeight = pictureBox1.Height - 100;
            double ratioY = picHeight * 1.0 / deltaY;

            double ratio = Math.Min(ratioX, ratioY);

            //坐标点
            PointF PAnew = new PointF((float)((pa.X - Xmin) * ratio), (float)(picHeight - ((pa.Y - Ymin) * ratio)));
            PointF PBnew = new PointF((float)((pb.X - Xmin) * ratio), (float)(picHeight - ((pb.Y - Ymin) * ratio)));
            PointF PCnew = new PointF((float)((pc.X - Xmin) * ratio), (float)(picHeight - ((pc.Y - Ymin) * ratio)));
            PointF PPnew = new PointF((float)((PP.X - Xmin) * ratio), (float)(picHeight - ((PP.Y - Ymin) * ratio)));

            //线
            Graphics gh = pictureBox1.CreateGraphics();
            Pen penAB = new Pen(Color.Black, 6);
            Pen penAC = new Pen(Color.Black, 6);
            Pen penBC = new Pen(Color.Black, 6);
            gh.DrawLine(penAB, PAnew, PBnew);
            gh.DrawLine(penBC, PBnew, PCnew);
            gh.DrawLine(penAC, PAnew, PCnew);
            Pen penP = new Pen(Color.Black, 2);
            gh.DrawLine(penP, PAnew, PPnew);
            gh.DrawLine(penP, PBnew, PPnew);
            gh.DrawLine(penP, PCnew, PPnew);

            //字符串
            Font drawFont = new Font("Times New Roman", 6);
            SolidBrush brushAB = new SolidBrush(Color.Black);
            SolidBrush brushBC = new SolidBrush(Color.Black);
            string Astr = "A(" + pa.X.ToString() + "," + pa.Y.ToString() + ")";
            gh.DrawString(Astr, drawFont, brushAB, PAnew.X, PAnew.Y);
            string Bstr = "B(" + pb.X.ToString() + "," + pb.Y.ToString() + ")";
            gh.DrawString(Bstr, drawFont, brushAB, PBnew.X, PBnew.Y);
            string Cstr = "C(" + pc.X.ToString() + "," + pc.Y.ToString() + ")";
            gh.DrawString(Cstr, drawFont, brushBC, PCnew.X, PCnew.Y);
            SolidBrush brushP = new SolidBrush(Color.Red);
            string Pstr = "P(" + PP.X.ToString() + "," + PP.Y.ToString() + ")";
            gh.DrawString(Pstr, drawFont, brushP, PPnew);
        }

        private void anglePA_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLearA_Click(object sender, EventArgs e)
        {
            coorAX.Clear();
            coorAY.Clear();
            coorAX.Focus();
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            coorBX.Clear();
            coorBY.Clear();
            coorBX.Focus();
        }

        private void ClearC_Click(object sender, EventArgs e)
        {
            coorCX.Clear();
            coorCY.Clear();
            coorCX.Focus();
        }

        private void C_Click(object sender, EventArgs e)
        {
            angleα.Clear();
            minuteα.Clear();
            secondα.Clear();
            angleα.Focus();
        }

        private void ClearPB_Click(object sender, EventArgs e)
        {
            angleβ.Clear();
            minuteβ.Clear();
            secondβ.Clear();
            angleβ.Focus();
        }

        private void ClearPC_Click(object sender, EventArgs e)
        {
            angleγ.Clear();
            minuteγ.Clear();
            secondγ.Clear();
            angleγ.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void coorBX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           new Form1_封面().Show();
           this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_后方交会_Load(object sender, EventArgs e)
        {

        }

        private void Button_批量_Click(object sender, EventArgs e)
        {
            Form_读取文件 frw = new Form_读取文件();
            frw.Show();
        }
    }
}
