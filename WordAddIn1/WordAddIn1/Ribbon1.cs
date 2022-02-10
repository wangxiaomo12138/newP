using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            UserControl2 user = new UserControl2();
            Microsoft.Office.Tools.CustomTaskPane table = Globals.ThisAddIn.CustomTaskPanes.Add(user, "标题搜索");
            table.Visible = true;
        }
    }
}
