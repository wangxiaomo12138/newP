﻿using System;
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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UserControl1 user = new UserControl1(GetC(1),3);
            this.flowLayoutPanel1.Controls.Add(user);
            this.flowLayoutPanel1.Visible = true;
        }

        //模拟调用接口过程组装数据
        public static Dictionary<String, List<Content>> GetC(int currentPage)
        {
            Dictionary<String, List<Content>> map = new Dictionary<string, List<Content>>();
            List<Content> contentList = new List<Content>();
            for (int i = 1; i <= 10; i++)
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
            map.Add("data1", contentList);
            map.Add("data2", contentList);
            return map;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }

    public class Content
    {
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        public string e { get; set; }
        public string f { get; set; }
    }
}
