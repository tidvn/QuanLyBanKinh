using QuanLyBanKinh.DAO;
using QuanLyBanKinh.DTO;
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
    public partial class fDanhmuc : Form
    {
        List<HanghoaDTO> lst = new List<HanghoaDTO>();
        int index = 0;

        public fDanhmuc()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new fDanhmuc_taomoi().ShowDialog();
        }

        private void fDanhmuc_Load(object sender, EventArgs e)
        {
            addtoList(HanghoaDTO.All());
            showData(index);
            
            
            checkedListBox1.Items.Add("Tên Hàng",CheckState.Checked);
            checkedListBox1.Items.Add("Giá Bán",CheckState.Checked);
            checkedListBox1.Items.Add("GIá Nhập",CheckState.Checked);
            checkedListBox1.Items.Add("Tồn Kho", CheckState.Checked);
            checkedListBox1.Items.Add("Ghi Chú", CheckState.Checked);
            checkedListBox1.Items.Add("Loại Kính", CheckState.Unchecked);
            checkedListBox1.Items.Add("Loại Gọng", CheckState.Unchecked);
            checkedListBox1.Items.Add("Hình Dạng Mắt", CheckState.Unchecked);
            checkedListBox1.Items.Add("Chất Liệu", CheckState.Unchecked);
            checkedListBox1.Items.Add("Xuất Xứ", CheckState.Unchecked);
            checkedListBox1.Items.Add("Màu Sắc", CheckState.Unchecked);
            checkedListBox1.Items.Add("Thương Hiệu", CheckState.Unchecked);
            checkedListBox1.Items.Add("Công Dụng ", CheckState.Unchecked);
            checkedListBox1.Items.Add("Đặc Điểm", CheckState.Unchecked);

        }
        #region function
        void addtoList(DataTable dt)
        {
            this.lst.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                
               HanghoaDTO h = new HanghoaDTO(Convert.ToInt32(dr[0]));
               this.lst.Add(h);
            }
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

        
        void showData(int index)
        {
            guna2DataGridView1.Rows.Clear();
            for (int i = index; i < index + 10; i++)
            {
                try
                {
                   Console.WriteLine(lst[i].Id);
                    //  guna2DataGridView1.Rows.Add(null, Uimg("https://cf.shopee.vn/file/e6592797553ee7d8fbf8ab1470ecc482"), lst[i].Id, lst[i].Name, lst[i].Giaban, lst[i].Gianhap, lst[i].Soluong, lst[i].Note);
                    guna2DataGridView1.Rows.Add(1);

                    guna2DataGridView1.Rows[i - index].Cells[1].Value = Uimg(lst[i].Img);
                    guna2DataGridView1.Rows[i - index].Cells[2].Value = lst[i].Id;
                    guna2DataGridView1.Rows[i - index].Cells[3].Value = lst[i].Name;
                    guna2DataGridView1.Rows[i - index].Cells[4].Value = lst[i].Giaban;
                    guna2DataGridView1.Rows[i - index].Cells[5].Value = lst[i].Gianhap;
                    guna2DataGridView1.Rows[i - index].Cells[6].Value = lst[i].Soluong;
                    guna2DataGridView1.Rows[i - index].Cells[9].Value = lst[i].Note;
                    guna2DataGridView1.Rows[i - index].Cells[10].Value = lst[i].Loaikinh;
                    guna2DataGridView1.Rows[i - index].Cells[11].Value = lst[i].Loaigong;
                    guna2DataGridView1.Rows[i - index].Cells[12].Value = lst[i].Hinhdangmat;
                    guna2DataGridView1.Rows[i - index].Cells[13].Value = lst[i].Chatlieu;
                    guna2DataGridView1.Rows[i - index].Cells[14].Value = lst[i].Xuatxu;
                    guna2DataGridView1.Rows[i - index].Cells[15].Value = lst[i].Mausac;
                    guna2DataGridView1.Rows[i - index].Cells[16].Value = lst[i].Thuonghieu;
                    guna2DataGridView1.Rows[i - index].Cells[17].Value = lst[i].Congdung;
                    guna2DataGridView1.Rows[i - index].Cells[18].Value = lst[i].Dacdiem;

                    // guna2DataGridView1.Rows[i].Cells[5].Value = "Jan 21,2020 -13:30";
                    // guna2DataGridView1.Rows[i].Cells[6].Value = "Jan 21,2020";
                    // guna2DataGridView1.Rows[i].Cells[7].Value = "Jan 21,2020";


                }
                catch { }
            }
            label1.Text = lst.Count.ToString();

            
        }
        #endregion
       
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!checkedListBox1.Visible)
            {
                checkedListBox1.Visible = true;
            }
            else
            {
                checkedListBox1.Visible = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////////////////////////////////
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column4"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column4"].Visible = false;
            }
            /////////////////////////////////
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column5"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column5"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column6"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column6"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column7"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column7"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column10"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column10"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column11"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column11"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column12"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column12"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column13"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column13"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(8) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column14"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column14"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(9) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column15"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column15"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(10) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column16"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column16"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(11) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column17"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column17"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(12) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column18"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column18"].Visible = false;
            }
            ///////////////////////////////
            if (checkedListBox1.GetItemCheckState(13) == CheckState.Checked)
            {
                guna2DataGridView1.Columns["Column19"].Visible = true;
            }
            else
            {
                guna2DataGridView1.Columns["Column19"].Visible = false;
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Xoá ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                new HanghoaDTO().Delete(Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[2].Value));
                showData(index);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
