using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanKinh.DTO
{
    public class UserDTO
    {
        int id;
        string name;
        string sex;
        string phone;
        string address;
        DateTime birth;
        int id_cv;
        int admin;
        string username;
        string password;


        private static UserDTO instance;
        public static UserDTO Instance
        {
            get { if (instance == null) instance = new UserDTO(); return instance; }
            private set { instance = value; }
        }
        private UserDTO()
        {
        }
        public int Id { get => id; }
        public string Username { get => username; }
        public string Password { get => password; }
        public string Name { get => name; }
        public string Sex { get => sex; }
        public DateTime Birth { get => birth; }
        public string Phone { get => phone; }
        public string Address { get => address; }
        public int Id_cv { get => id_cv; }
        public int Admin { get => admin; }

        public void Init(DataTable data)
        {
            this.id = Convert.ToInt32(data.Rows[0].ItemArray[0]);
            this.username = data.Rows[0].ItemArray[1].ToString();
            this.password = data.Rows[0].ItemArray[2].ToString();
            this.name = data.Rows[0].ItemArray[3].ToString();
            this.sex = data.Rows[0].ItemArray[4].ToString();
            this.birth = DateTime.Parse(data.Rows[0].ItemArray[5].ToString());
            this.phone = data.Rows[0].ItemArray[6].ToString();
            this.address = data.Rows[0].ItemArray[7].ToString();
            this.id_cv = Convert.ToInt32(data.Rows[0].ItemArray[8]);
            this.admin = Convert.ToInt32(data.Rows[0].ItemArray[9]);
        }
    }
}
