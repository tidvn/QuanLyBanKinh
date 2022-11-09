using QuanLyBanKinh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanKinh.DTO
{
    internal class HanghoaDTO
    {   


        #region thuoctinh
        int id;
        string name;
        int id_Loaikinh, id_Loaigong, id_Hinhdangmat, id_Xuatxu, id_Chatlieumat, id_Mausac, id_Thuonghieu, id_Congdung, id_Dacdiem;
        int soluong, gianhap, giaban, giamgia;
        DateTime baohanh;
        string img;
        string note;
        #endregion
        #region getset
        public int Id { get => id; }
        public string Name { get => name; }       
        public int Soluong { get => soluong; }
        public int Gianhap { get => gianhap; }
        public int Giaban { get => giaban; }
        public int Giamgia { get => giamgia; }
        public DateTime Baohanh { get => baohanh; }
        public string Img { get => img; }
        public string Note { get => note; }

        public string Loaikinh { get => getValue(MemberInfoGetting.GetMemberName(() => id_Loaikinh).Substring(3),id_Loaikinh); }
        public string Loaigong { get => getValue(MemberInfoGetting.GetMemberName(() => id_Loaigong).Substring(3), id_Loaigong); }
        public string Hinhdangmat { get => getValue(MemberInfoGetting.GetMemberName(() => id_Hinhdangmat).Substring(3), id_Hinhdangmat); }
        public string Xuatxu { get => getValue(MemberInfoGetting.GetMemberName(() => id_Xuatxu).Substring(3), id_Xuatxu); }
        public string Chatlieu { get => getValue(MemberInfoGetting.GetMemberName(() => id_Chatlieumat).Substring(3), id_Chatlieumat); }
        public string Mausac { get => getValue(MemberInfoGetting.GetMemberName(() => id_Mausac).Substring(3), id_Mausac); }
        public string Thuonghieu { get => getValue(MemberInfoGetting.GetMemberName(() => id_Thuonghieu).Substring(3), id_Thuonghieu); }
        public string Congdung { get => getValue(MemberInfoGetting.GetMemberName(() => id_Congdung).Substring(3), id_Congdung); }
        public string Dacdiem { get => getValue(MemberInfoGetting.GetMemberName(() => id_Dacdiem).Substring(3), id_Dacdiem); }

        #endregion

        public HanghoaDTO(int id)
        {
            this.id = id;
            DataTable result = DataProvider.Instance.ExecuteQuery($"SELECT * FROM Hanghoa WHERE id = {id}");
            this.name = result.Rows[0].ItemArray[1].ToString();
            this.id_Loaikinh = (int)result.Rows[0].ItemArray[2];
            this.id_Loaigong = (int)result.Rows[0].ItemArray[3];
            this.id_Hinhdangmat = (int)result.Rows[0].ItemArray[4];
            this.id_Chatlieumat = (int)result.Rows[0].ItemArray[5];
            this.id_Xuatxu = (int)result.Rows[0].ItemArray[6];
            this.id_Mausac = (int)result.Rows[0].ItemArray[7];
            this.id_Thuonghieu = (int)result.Rows[0].ItemArray[8];
            this.id_Congdung = (int)result.Rows[0].ItemArray[9];
            this.id_Dacdiem = (int)result.Rows[0].ItemArray[10];
            this.soluong = (int)result.Rows[0].ItemArray[11];
            this.gianhap = (int)result.Rows[0].ItemArray[12];
            this.giaban = (int)result.Rows[0].ItemArray[13];
            this.giamgia = (int)result.Rows[0].ItemArray[14];
           // this.baohanh = (int)result.Rows[0].ItemArray[15];
            this.img = result.Rows[0].ItemArray[16].ToString();
            this.note = result.Rows[0].ItemArray[17].ToString();
        }
        public HanghoaDTO() { }

            private string getValue(string name_thuoctinh,int id_Thuoctinh)        {
            string query= $"SELECT value FROM dbo.{name_thuoctinh} Where id = {id_Thuoctinh}";
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
        public static DataTable All()
        {
            string query = "SELECT * FROM dbo.Hanghoa";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void Delete(int id)
        {
            DataProvider.Instance.ExecuteNonQuery($"DELETE FROM dbo.Hanghoa WHERE id= {id}");
        }


    }



}
