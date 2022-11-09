using QuanLyBanKinh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyBanKinh.DTO
{
    internal class thuoctinhDTO
    {
        public thuoctinhDTO() { }
        public SortedDictionary<int,string> all(string ttt)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery($"SELECT * FROM dbo.{ttt}");

            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            foreach (DataRow dr in dt.Rows)
            {
                dict.Add(Convert.ToInt32(dr[0]), dr[1].ToString());
            }

            return dict;  
        }
        
    }
}
