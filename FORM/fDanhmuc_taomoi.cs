using Guna.UI2.WinForms;
using QuanLyBanKinh.DAO;
using QuanLyBanKinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanKinh.FORM
{
    public partial class fDanhmuc_taomoi : Form
    {
        public fDanhmuc_taomoi()
        {
            InitializeComponent();

        }

        
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tenhang = guna2TextBox2.Text;
            string giavon = guna2TextBox5.Text;
            string giamgia = guna2TextBox3.Text;
            string giaban = guna2TextBox4.Text;
            string soluong = guna2TextBox6.Text;
            string ghichu = guna2TextBox7.Text;
            string img = guna2TextBox8.Text;
            int loaikinh = Convert.ToInt32(guna2ComboBox1.SelectedValue.ToString());
            int loaigong = Convert.ToInt32(guna2ComboBox2.SelectedValue.ToString());
            int hinhdangmat = Convert.ToInt32(guna2ComboBox3.SelectedValue.ToString());
            int chatlieumat = Convert.ToInt32(guna2ComboBox4.SelectedValue.ToString());
            int xuatxu = Convert.ToInt32(guna2ComboBox5.SelectedValue.ToString());
            int mausac = Convert.ToInt32(guna2ComboBox6.SelectedValue.ToString());
            int thuonghieu = Convert.ToInt32(guna2ComboBox7.SelectedValue.ToString());
            int congdung = Convert.ToInt32(guna2ComboBox8.SelectedValue.ToString());
            int dacdiem = Convert.ToInt32(guna2ComboBox9.SelectedValue.ToString());
            string query = $"INSERT INTO Hanghoa (name, id_Loaikinh, id_Loaigong, id_Hinhdangmat,id_Chatlieumat,id_Xuatxu,id_Mausac,id_Thuonghieu,id_Congdung,id_Dacdiem,Soluong,Gianhap,Giaban,Giamgia,Anh,Ghichu) VALUES (N\'{tenhang}\', {loaikinh}, {loaigong}, {hinhdangmat},{chatlieumat},{xuatxu},{mausac},{thuonghieu},{congdung},{dacdiem},{soluong},{giavon},{giaban},{giamgia},N\'{img}\',N'{ghichu}');";
            try
            {
                 DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch {
                Console.WriteLine(query);
                MessageBox.Show("Xảy ra lỗi !");
            }

            
        }
       void setCBB()
        {
            guna2ComboBox1.DataSource = new BindingSource(new thuoctinhDTO().all("Loaikinh"), null);
            guna2ComboBox1.DisplayMember = "Value";
            guna2ComboBox1.ValueMember = "Key";
            guna2ComboBox2.DataSource = new BindingSource(new thuoctinhDTO().all("Loaigong"), null);
            guna2ComboBox2.DisplayMember = "Value";
            guna2ComboBox2.ValueMember = "Key";
            guna2ComboBox3.DataSource = new BindingSource(new thuoctinhDTO().all("Hinhdangmat"), null);
            guna2ComboBox3.DisplayMember = "Value";
            guna2ComboBox3.ValueMember = "Key";
            guna2ComboBox4.DataSource = new BindingSource(new thuoctinhDTO().all("Chatlieumat"), null);
            guna2ComboBox4.DisplayMember = "Value";
            guna2ComboBox4.ValueMember = "Key";
            guna2ComboBox5.DataSource = new BindingSource(new thuoctinhDTO().all("Xuatxu"), null);
            guna2ComboBox5.DisplayMember = "Value";
            guna2ComboBox5.ValueMember = "Key";
            guna2ComboBox6.DataSource = new BindingSource(new thuoctinhDTO().all("Mausac"), null);
            guna2ComboBox6.DisplayMember = "Value";
            guna2ComboBox6.ValueMember = "Key";
            guna2ComboBox7.DataSource = new BindingSource(new thuoctinhDTO().all("Thuonghieu"), null);
            guna2ComboBox7.DisplayMember = "Value";
            guna2ComboBox7.ValueMember = "Key";
            guna2ComboBox8.DataSource = new BindingSource(new thuoctinhDTO().all("Congdung"), null);
            guna2ComboBox8.DisplayMember = "Value";
            guna2ComboBox8.ValueMember = "Key";
            guna2ComboBox9.DataSource = new BindingSource(new thuoctinhDTO().all("Dacdiem"), null);
            guna2ComboBox9.DisplayMember = "Value";
            guna2ComboBox9.ValueMember = "Key";
        }
        
        private void fDanhmuc_taomoi_Load(object sender, EventArgs e)
        {
            setCBB();

        }
        
        
    }
}
