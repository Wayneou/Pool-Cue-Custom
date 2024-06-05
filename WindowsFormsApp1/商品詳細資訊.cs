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
    public partial class 商品詳細資訊 : Form
    {
        public int loadId = 0;      //商品展示表中用來存放隱藏的商品id (tag)
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;    //圖檔是否修改 有:存檔 
        public 商品詳細資訊()
        {
            InitializeComponent();
        }
        void 顯示商品詳細資訊()
        {
            if (loadId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Table_Wood where WoodID = @SearchWoodId ;";  //SQL語法    @SearchId--->帶入參數
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchWoodId", loadId);               //@SearchId 放到 loadId
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //文字
                    txtid.Text = reader["WoodID"].ToString();
                    txt商品名稱.Text = reader["WoodType"].ToString();
                    txt商品價格.Text = reader["price"].ToString();
                    txt商品描述.Text = reader["introduction"].ToString();
                    //圖片
                    str修改後的圖檔名稱 = reader["image"].ToString();
                    string str完整圖檔路徑 = GlobalVar.image_wood + @"\" + str修改後的圖檔名稱;
                    //pictureBox商品圖片.Image = Image.FromFile(str完整圖檔路徑);
                    //讓檔案不會鎖住的刪除方式
                    System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                    pictureBox商品圖片.Image = Image.FromStream(fs);
                    fs.Close();

                    pictureBox商品圖片.Tag = str完整圖檔路徑;    //藏在tag裡
                }
                reader.Close();
                con.Close();

            }
        }

        void 選取商品圖片()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "檔案類型(JPEG,JPG,PNG)|*.jpeg;*.jpg;*.png";     
            DialogResult R = fileDialog.ShowDialog();

            if (R == DialogResult.OK)
            {               

                System.IO.FileStream fs = System.IO.File.OpenRead(fileDialog.FileName);
                pictureBox商品圖片.Image = Image.FromStream(fs);
                fs.Close();

                pictureBox商品圖片.Tag = fileDialog.FileName;  //藏完整路徑


                string str圖檔副檔名 = System.IO.Path.GetExtension(fileDialog.FileName).ToLower();

                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + "_____" + myRnd.Next(100, 10000).ToString();
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        private void 商品詳細資訊_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"loadId:{loadId}");
            if (GlobalVar.使用者權限 >= 1000)
            {//會員
                gBox新增.Visible = false;
                gBox刪除.Visible = false;
                gBox新增.Visible = false;
            }
            else if ((GlobalVar.使用者權限 >= 100) && (GlobalVar.使用者權限 < 1000))
            {//店員
                gBox新增.Visible = false;
                gBox刪除.Visible = false;
                gBox新增.Visible = true;
            }
            else if ((GlobalVar.使用者權限 >= 10) && (GlobalVar.使用者權限 < 100))
            {//店長
                gBox新增.Visible = true;
                gBox刪除.Visible = true;
                gBox新增.Visible = true;
            }
            else if ((GlobalVar.使用者權限 >= 1) && (GlobalVar.使用者權限 < 10))
            {//系統管理者
                gBox新增.Visible = true;
                gBox刪除.Visible = true;
                gBox新增.Visible = true;
            }
            顯示商品詳細資訊();
                    
        }

        private void btn選取圖片1_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btn儲存新增_Click(object sender, EventArgs e)
        {

        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            pictureBox商品圖片.Image = null;
        }

        private void btn選取圖片2_Click(object sender, EventArgs e)
        {

        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {

        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            
        }
    }
}
