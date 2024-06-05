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
    
    public partial class 會員註冊 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public 會員註冊()
        {
            InitializeComponent();
        }
        void 清空欄位()
        {
            txtID.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txt地址.Clear();
            txtEmail.Clear();           
            dtp生日.Value = DateTime.Now;
            txt權限.Clear();
            txt帳號.Clear();
            txt密碼.Clear();
        }
        private void 會員註冊_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "Wayne CUE WorkShop"; 
            scsb.IntegratedSecurity = true; 
            scsb.Encrypt = false;

            strDBConnectionString = scsb.ConnectionString; //指定到資料庫連線字串
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtID.Text, out intId);

            if (string.IsNullOrWhiteSpace(txt姓名.Text))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update persons set 姓名=@NewName, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail, 生日=@NewBirth, 權限=@New權限, 帳號=@NewAccount, 密碼=@NewPassWord where id=@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intId);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@New權限", txt權限.Text);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassWord", txt密碼.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"修改成功");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全!!");
            }
        }

        private void btn資料新增_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                string strSQL = "insert into persons values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@New權限,@NewAccount,@NewPassWord);";
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@New權限", txt權限.Text);
                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassWord", txt密碼.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"註冊成功");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全!!");
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtID.Text, out intId);

            if (intId > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from persons where id = @DeleteId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", intId);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"資料已刪除\n {rows} 個資料列受到影響");
            }
        }
        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {           
            if (txt帳號.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from persons where 帳號 like @Search帳號;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Search帳號", $"%{txt帳號.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtID.Text = reader["id"].ToString();
                    txt姓名.Text = (string)reader["姓名"];
                    txt電話.Text = (string)reader["電話"];
                    txtEmail.Text = (string)reader["email"];
                    txt地址.Text = (string)reader["地址"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    txt權限.Text = reader["權限"].ToString();
                    txt帳號.Text = (string)reader["帳號"];
                    txt密碼.Text = (string)reader["密碼"];

                }              
                else
                {               
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
