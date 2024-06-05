using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class 商品展示cs : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list商品名稱 = new List<string>();
        List<int> list商品價格 = new List<int>();
        List<int> listId = new List<int>();


        public 商品展示cs()
        {
            InitializeComponent();
        }

        private void btn圖片模式_Click(object sender, EventArgs e)
        {

        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {

        }
    }
}
