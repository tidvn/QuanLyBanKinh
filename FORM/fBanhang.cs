using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanKinh.FORM
{
    public partial class fBanhang : Form
    {
        public fBanhang()
        {
            InitializeComponent();
        }
        public static Image Uimg(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void fBanhang_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(4);
            guna2DataGridView1.Rows[0].Cells[1].Value = Uimg("https://cf.shopee.vn/file/cfa822ce6febda545d9bac0a0b520a4f");
            guna2DataGridView1.Rows[0].Cells[2].Value = "Kính Mắt ABC";
            guna2DataGridView1.Rows[0].Cells[3].Value = "60000";
            guna2DataGridView1.Rows[0].Cells[4].Value = "01";
            guna2DataGridView1.Rows[0].Cells[5].Value = "60000";
            guna2DataGridView1.Rows[0].Cells[6].Value = "Xoá";

            guna2DataGridView1.Rows[1].Cells[1].Value = Uimg("https://cf.shopee.vn/file/cfa822ce6febda545d9bac0a0b520a4f");
            guna2DataGridView1.Rows[1].Cells[2].Value = "Kính Mắt ABC";
            guna2DataGridView1.Rows[1].Cells[3].Value = "60000";
            guna2DataGridView1.Rows[1].Cells[4].Value = "01";
            guna2DataGridView1.Rows[1].Cells[5].Value = "60000";
            guna2DataGridView1.Rows[1].Cells[6].Value = "Xoá";

            guna2DataGridView1.Rows[2].Cells[1].Value = Uimg("https://cf.shopee.vn/file/cfa822ce6febda545d9bac0a0b520a4f");
            guna2DataGridView1.Rows[2].Cells[2].Value = "Kính Mắt ABC";
            guna2DataGridView1.Rows[2].Cells[3].Value = "60000";
            guna2DataGridView1.Rows[2].Cells[4].Value = "01";
            guna2DataGridView1.Rows[2].Cells[5].Value = "60000";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Xoá";

            guna2DataGridView1.Rows[3].Cells[1].Value = Uimg("https://cf.shopee.vn/file/cfa822ce6febda545d9bac0a0b520a4f");
            guna2DataGridView1.Rows[3].Cells[2].Value = "Kính Mắt ABC";
            guna2DataGridView1.Rows[3].Cells[3].Value = "60000";
            guna2DataGridView1.Rows[3].Cells[4].Value = "01";
            guna2DataGridView1.Rows[3].Cells[5].Value = "60000";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Xoá";


        }

        private void guna2DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                //update value both in columns 3 & 5
                string newValue = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Console.WriteLine(newValue);
                guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value = Convert.ToInt32(newValue) * Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                //guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value = TimeAttendanceHelper.FormatHourlyDuration(newValue);
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
