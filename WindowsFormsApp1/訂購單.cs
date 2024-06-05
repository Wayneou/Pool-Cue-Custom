using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class 訂購單 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string>list商品敘述 = new List<string>();
        List<string> list商品名稱 = new List<string>();
        List<int> list商品價格 = new List<int>();
        List<int> listId = new List<int>();
        public 訂購單()
        {
            InitializeComponent();
        }
        //void 讀取後節資料庫()
        //{
        //    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
        //    con.Open();
        //    string strSQL = "select top 200 * from Table_Wood;";
        //    SqlCommand cmd = new SqlCommand(strSQL, con);
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    int count = 0;

        //    while (reader.Read())
        //    {
        //        listId.Add((int)reader["WoodID"]);
        //        list商品名稱.Add((string)reader["WoodType"]);
        //        list商品價格.Add((int)reader["price"]);
        //        string image_name = (string)reader["image"];
        //        string 完整圖檔路徑 = $"{GlobalVar.image_wood}\\{image_name}";
        //        System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
        //        Image img商品圖檔 = Image.FromStream(fs);
        //        fs.Close();
        //        img商品圖檔.Tag = 完整圖檔路徑;

        //        imageList商品圖檔.Images.Add(img商品圖檔);

        //        count++;
        //    }
        //    reader.Close();
        //    con.Close();
        //    Console.WriteLine($"讀取{count}筆資料"); //在主控台測試
        //}

        //void 讀取前節資料庫()
        //{
        //    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
        //    con.Open();
        //    string strSQL = "select top 200 * from Table_Shaft;";
        //    SqlCommand cmd = new SqlCommand(strSQL, con);
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    int count = 0;

        //    while (reader.Read())
        //    {
        //        listId.Add((int)reader["shaftID"]);
        //        list商品名稱.Add((string)reader["shaftType"]);
        //        list商品價格.Add((int)reader["price"]);
        //        string image_name = (string)reader["image"];
        //        string 完整圖檔路徑 = $"{GlobalVar.image_shaft}\\{image_name}";
        //        Image img商品圖檔 = Image.FromFile(完整圖檔路徑);
        //        img商品圖檔.Tag = 完整圖檔路徑;
        //        imageList商品圖檔.Images.Add(img商品圖檔);

        //        count++;
        //    }
        //    reader.Close();
        //    con.Close();
        //    Console.WriteLine($"讀取{count}筆資料"); //在主控台測試
        //}
        void 顯示listView_圖片()  
        {           
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon; 
            imageList商品圖檔.ImageSize = new Size(200, 200); 
            listView商品展示.LargeImageList = imageList商品圖檔; 
            //listView商品展示.SmallImageList = imageList商品圖檔; 
            //listView商品展示.LargeImageList = imageList商品圖檔;

            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();       
                item.ImageIndex = i;                          
                item.Text = $"{list商品名稱[i]}{list商品價格[i]}元{list商品敘述[i]}";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listId[i];                         
                listView商品展示.Items.Add(item);             
            }
        }
        void 重新載入資料()
        {
            //清空集合
            listId.Clear();
            list商品名稱.Clear();
            list商品價格.Clear();
            imageList商品圖檔.Images.Clear();
        }

        //改成dapper
        void dapper方式讀取底木資料庫()
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "Wayne CUE WorkShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                //資料庫查詢語法 
                string strSql = "Select  WoodID , WoodType , price , image , introduction from Table_Wood;";


                //(查詢語法,參數)
                var results = conn.Query<Wood>(strSql);
                foreach (var wood in results)
                {
                    //Console.WriteLine("木頭簡介 WoodID:{0} WoodType:{1} price:{2} image:{3} introduction:{4}", wood.WoodID,
                    //wood.WoodType, wood.price, wood.image, wood.introduction);

                    listId.Add(wood.WoodID);
                    list商品名稱.Add(wood.WoodType);
                    list商品價格.Add(wood.price);
                    list商品敘述.Add(wood.introduction);
                    string image_name = wood.image;
                    string 完整圖檔路徑 = $"{GlobalVar.image_wood}\\{image_name}";
                    Image img商品圖檔 = Image.FromFile(完整圖檔路徑);
                    img商品圖檔.Tag = 完整圖檔路徑;
                    imageList商品圖檔.Images.Add(img商品圖檔);
                }
            }
        }
        private void btn後節底木_Click(object sender, EventArgs e)
        {
            重新載入資料();
            dapper方式讀取底木資料庫();
            顯示listView_圖片();
        }

        private void btn插角底木_Click(object sender, EventArgs e)
        {
            重新載入資料();
            dapper方式讀取底木資料庫();
            顯示listView_圖片();
        }

        private void btn前節_Click(object sender, EventArgs e)
        {
            重新載入資料();
            //使用dapper
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "Wayne CUE WorkShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                //資料庫查詢語法 
                string strSql = "Select  ShaftID , ShaftType , price , image , introduction from Table_Shaft;";


                //(查詢語法,參數)
                var results = conn.Query<Shaft>(strSql);
                foreach (var shaft in results)
                {
                    Console.WriteLine("前節簡介 ShaftID:{0} ShaftType:{1} price:{2} image:{3} introduction:{4}", shaft.ShaftID,
                    shaft.ShaftType, shaft.price, shaft.image, shaft.introduction);

                    listId.Add(shaft.ShaftID);
                    list商品名稱.Add(shaft.ShaftType);
                    list商品價格.Add(shaft.price);
                    list商品敘述.Add(shaft.introduction);
                    string image_name = shaft.image;
                    string 完整圖檔路徑 = $"{GlobalVar.image_shaft}\\{image_name}";
                    Image img商品圖檔 = Image.FromFile(完整圖檔路徑);
                    img商品圖檔.Tag = 完整圖檔路徑;
                    imageList商品圖檔.Images.Add(img商品圖檔);
                }
            }
            顯示listView_圖片();
        }

        
        private void btn環_Click(object sender, EventArgs e)
        {

        }

        private void btn握把_Click(object sender, EventArgs e)
        {

        }

        private void btn款式_Click(object sender, EventArgs e)
        {

        }

        private void gbox材料選擇_Enter(object sender, EventArgs e)
        {

        }

        private void 訂購單_Load(object sender, EventArgs e)
        {
            

        }

        private void listView商品展示_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            商品詳細資訊 myformDetail = new 商品詳細資訊();
            myformDetail.loadId = (int)listView商品展示.SelectedItems[0].Tag;
            //SelectedItems複數型 傳listView商品展示的集合 tag裡藏ID要轉成int型別  放到loadid

            myformDetail.ShowDialog();  //listView商品展示屬性設定成 one click 
        }
    }
}
