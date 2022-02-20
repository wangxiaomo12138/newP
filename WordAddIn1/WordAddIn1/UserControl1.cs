using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAddIn1
{
    public partial class UserControl1 : UserControl
    {
        List<Content> redisList;
        int totalPage;
        int currentPage;
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Dictionary<string,List<Content>> contentList, int totalPage)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            foreach(var item in contentList)
            {
                if (item.Key.Equals("data1"))
                {
                    this.redisList = item.Value;
                    this.dataGridView1.DataSource = item.Value;
                }
                if (item.Key.Equals("data2"))
                {
                    this.redisList = item.Value;
                    this.dataGridView1.DataSource = item.Value;
                }
            }
           
            this.totalPage = totalPage;
            this.currentPage = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Content c = redisList.ToArray()[e.RowIndex];
            if (e.ColumnIndex == 0 )
            {
                System.Diagnostics.Process.Start("iexplore.exe", c.e);
            }
            if(e.ColumnIndex == 1)
            {
                System.Diagnostics.Process.Start("iexplore.exe", c.f);
            }
        }

        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage--;
            if(currentPage <= 0)
            {
                currentPage++;
                MessageBox.Show("已经是第一页");
            }
            else
            {
                //调用接口的方法
               // List<Content> contentList = UserControl2.GetC(currentPage);
                List<Content> contentList = new List<Content>();
                for (int i = 5; i <= 15; i++)
                {
                    Content content = new Content();
                    content.a = i.ToString();
                    content.b = i.ToString();
                    content.c = i.ToString();
                    content.d = i.ToString();
                    content.e = "www.baidu.com";
                    content.f = "www.taobao.com";
                    contentList.Add(content);
                }
                this.dataGridView1.DataSource = contentList;
                this.redisList = contentList;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPage++;
            if(currentPage > totalPage)
            {
                currentPage--;
                MessageBox.Show("已经是最后一页");
            }
            else
            {
                //调用接口的方法
                List<Content> contentList = new List<Content>();
                for (int i = 8; i <= 18; i++)
                {
                    Content content = new Content();
                    content.a = i.ToString();
                    content.b = i.ToString();
                    content.c = i.ToString();
                    content.d = i.ToString();
                    content.e = "www.baidu.com";
                    content.f = "www.taobao.com";
                    contentList.Add(content);
                }
                this.dataGridView1.DataSource = contentList;
                this.redisList = contentList;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
