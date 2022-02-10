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
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(List<Content> contentList)
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = contentList;
            this.redisList = contentList;
            
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
    }
}
