using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 登入畫面 : Form
    {
        int picNo = 0; //下一張圖片的索引
        List<string> list商品圖片 = new List<string> { "a.jpg", "b.jpg", "c.jpg", "d.jpg", "e.jpg","f.jpg" };

        public 登入畫面()
        {
            InitializeComponent();
        }

        private void 登入畫面_Load(object sender, EventArgs e)
        {
            //圖片與picturebox的大小配合
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //圖檔位置
            string imgPath = @"C:\Users\Wayne\Desktop\個人專題\插圖\登入時商品瀏覽";

            pictureBox1.Image = Image.FromFile(Path.Combine(imgPath, list商品圖片[picNo]));

        }
        private void btn商品瀏覽_Click(object sender, EventArgs e)
        {
            string imgPath = @"C:\Users\Wayne\Desktop\個人專題\插圖\登入時商品瀏覽";

            picNo++;

            if (picNo >= list商品圖片.Count)
            {
                picNo = 0;
            }
            pictureBox1.Image = Image.FromFile(Path.Combine(imgPath, list商品圖片[picNo]));
        }

        private void btn員工登入_Click(object sender, EventArgs e)
        {
            FormStaff Stafflogin = new FormStaff();
            Stafflogin.ShowDialog();
        }


        private void btn帳號註冊_Click(object sender, EventArgs e)
        {
            會員註冊 註冊 = new 會員註冊();
            註冊.ShowDialog();
        }

        private void btn帳號登入_Click(object sender, EventArgs e)
        {
            會員Form2 memberlogin = new 會員Form2();
            memberlogin.ShowDialog();
        }  
    }
}
