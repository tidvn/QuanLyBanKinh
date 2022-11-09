using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanKinh.FORM
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            panelGiaodich.Visible = false;
            panelHanghoa.Visible = false;
            panelNhanvien.Visible = false;
            panelDoitac.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                // hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        Guna2Button currentBtn;
        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Guna.UI2.WinForms.Guna2Button)senderBtn;
                currentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
                currentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                currentBtn.ForeColor = System.Drawing.Color.White;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button
                currentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                currentBtn.FillColor = System.Drawing.Color.Transparent;
                currentBtn.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(childForm);
            guna2Panel_container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bntHanghoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHanghoa);
        }

        private void btnGiaodich_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGiaodich);
        }
        private void btnDoitac_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoitac);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanvien);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fTongquan());
        }
        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Danh Mục";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fDanhmuc());
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Nhập Hàng";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fNhaphang());
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Bán Hàng";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fBanhang());
        }


        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Bán Hàng";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fBanhang());

        }

        private void btnTongquan_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fTongquan());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fKhachhang());
        }

        private void btnThuoctinh_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Thuộc Tính";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fThuoctinh());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Nhà Cung Cấp";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fNhacungcap());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            label_val.Text = "Danh Sách Nhân Viên";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            openChildForm(new fNhanvien());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

        }
    }
}
