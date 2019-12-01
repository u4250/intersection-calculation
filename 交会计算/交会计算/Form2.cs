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
    public partial class Form2_前方交会 : Form
    {
        public Form2_前方交会()
        {
            InitializeComponent();
        }

        private void Form2_前方交会_Load(object sender, EventArgs e)
        {
            ImageList image = new ImageList();

            image.ImageSize = new Size(1, 35);//设置每次点击view时以图片的形式

            ColumnHeader ch = new ColumnHeader();

            ch.Text = "菜单";

            ch.Width = splitContainer1.Panel1.Width;

            ch.TextAlign = HorizontalAlignment.Center;

            listView1.Columns.Add(ch);//设置listview的列名，没啥用处

            listView1.SmallImageList = image;//设置每个view的显示形式

            LoadList();//加载一级栏目

            listView1.Width = ch.Width;//设置每个view的宽度都一致

            listView1.Items[0].BackColor = Color.LightGray;//设置主页的选中后的颜色
        }

        private void LoadList()
        {

            listView1.Items.Clear();//清空菜单

            //添加菜单
            ListViewItem menu_angle = new ListViewItem("角度前方交会");

            ListViewItem menu_distance = new ListViewItem("距离前方交会");

            ListViewItem returnback = new ListViewItem("返回");

            ListViewItem exit = new ListViewItem("退出");

            listView1.Items.Add(menu_angle);

            listView1.Items.Add(menu_distance);

            listView1.Items.Add(returnback);
            listView1.Items.Add(exit);

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            foreach (ListViewItem item in listView1.Items)
            {

                item.BackColor = Color.WhiteSmoke;//遍历每个菜单栏时的颜色

            }

            if (e.Button == MouseButtons.Left)
            {

                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items[listView1.FocusedItem.Index].BackColor = Color.LightGray;//设置选中菜单栏时的颜色

                    string choose = listView1.Items[listView1.FocusedItem.Index].Text;//获取选中菜单栏的文本

                    ChangePlanel(choose.Trim());//根据文本名称进行相应的展示

                }

            }

        }

        private void ChangePlanel(string name)
        {

            switch (name)
            {
                case "角度前方交会": 
                    splitContainer1.Panel2.Controls.Clear();
                    //将最高级的Form_角度前方交会窗口转化成低级的控件，便于放在Panel2中调用
                    Form_角度前方交会 fa = new Form_角度前方交会();
                    fa.TopLevel = false;
                    fa.Dock = DockStyle.Fill;//把子窗体设置为控件
                    fa.FormBorderStyle = FormBorderStyle.None;
                    splitContainer1.Panel2.Controls.Add(fa);
                    //调用Form_角度前方交会
                    fa.Parent = splitContainer1.Panel2;
                    fa.Show();

                    break;

                case "距离前方交会":

                    splitContainer1.Panel2.Controls.Clear();

                    Form_距离前方交会 fd = new Form_距离前方交会();
                     fd.TopLevel = false;
                    fd.Dock = DockStyle.Fill;//把子窗体设置为控件
                    fd.FormBorderStyle = FormBorderStyle.None;
                    splitContainer1.Panel2.Controls.Add(fd);

                    fd.Parent = splitContainer1.Panel2;

                    fd.Show();

                    break;

              

                case "返回":

                    new Form1_封面().Show();
                    this.Close();
                    break;

                case"退出":
                    Application.Exit();
                    break;


                case "重启":

                    try
                    {

                        Application.Restart();

                    }

                    catch (Exception)
                    {

                        System.Environment.Exit(0);

                    }

                    break;

            }

        }

        }
    
}
