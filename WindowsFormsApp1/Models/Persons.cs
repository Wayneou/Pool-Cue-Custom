using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Persons
    {
        // get變數讀取時執行的程式碼
        // set數值存入時執行的程式碼
        public int id { get; set; }
        public string 姓名 { get; set; }
        public string 電話 { get; set; }
        public string 地址 { get; set; }
        public string email { get; set; }
        public DateTime 生日 { get; set; }
        public int 權限 { get; set; }
        public string 帳號 { get; set; }
        public string 密碼 { get; set; }

        
    }
}
