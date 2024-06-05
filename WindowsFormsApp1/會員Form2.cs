using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using WindowsFormsApp1.Models;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class 會員Form2 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        
        public 會員Form2()
        {
            InitializeComponent();
        }

        private void 會員Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "Wayne CUE WorkShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            scsb.Encrypt = false;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                //資料庫查詢語法 參數化
                string strSql = "Select * from persons where 帳號 = @帳號 and 密碼 = @密碼 ;";

                //(查詢語法,參數)
                var results = conn.Query<Persons>(strSql, new { 帳號 = txt帳號.Text, 密碼 = txt密碼.Text });
                //result回傳的項目數為0,沒有這組帳號密碼.
                if (results.Count() == 0)
                {
                    MessageBox.Show("輸入錯誤");
                }
                else
                {
                    訂購單 訂購單 = new 訂購單();
                    訂購單.ShowDialog();
                }

            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            會員註冊 資料修改 = new 會員註冊();
            資料修改.ShowDialog();
        }

        private void lbl帳號_Click(object sender, EventArgs e)
        {

        }
    }
}
