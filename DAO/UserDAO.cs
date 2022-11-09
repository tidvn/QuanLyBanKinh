using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanKinh.DTO;
namespace QuanLyBanKinh.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }

        private UserDAO() { }





        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Nhanvien WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            try
            {
                UserDTO.Instance.Init(result);
            }
            catch { }

            return result.Rows.Count > 0;
        }
    }
}
