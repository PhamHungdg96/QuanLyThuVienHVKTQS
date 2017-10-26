using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienHVKTQS.controller;
using QuanLyThuVienHVKTQS.Model;

namespace QuanLyThuVienHVKTQS
{
    public partial class frmSach : Form
    {
       

        List<sach> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;
        public frmSach()
        {
            InitializeComponent();
            HienThiSach();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void HienThiSach()
        {
            var s = new SachController();
            l = s.Detail();
            lvSach.Items.Clear();

            var i = 1;

            var nxb = new NhaXuatBanController();
            List<nhaxuatban> listNXB = nxb.Detail();

            cbbNXB.DataSource = listNXB;
            cbbNXB.DisplayMember = "tennxb";
            cbbNXB.ValueMember = "manxb".ToString();

            txtMaSach.Text = l[0].masach.ToString();
            txtTenSach.Text = l[0].tensach.ToString();
            txtTacGia.Text = l[0].tentacgia.ToString();
            if (l[0].nhaxuatban != null)
                cbbNXB.Text = l[0].nhaxuatban.tennxb.ToString();
            else
                cbbNXB.Text = "";
            txtNamXB.Text = l[0].namxb.ToString();

            txtLanXB.Text = l[0].solanxb.ToString();
            txtGiaTien.Text = l[0].giatien.ToString();
            txtSoLuong.Text = l[0].soluong.ToString();
            txtNgonNgu.Text = l[0].ngonngu.ToString();
            txtTheLoai.Text = l[0].theloai.ToString();
            txtLoaiSach.Text = l[0].loai.ToString();
            foreach (sach row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;

                item.SubItems.Add(row.masach.ToString());
                item.SubItems.Add(row.tensach.ToString());
                item.SubItems.Add(row.soluong.ToString());
                lvSach.Items.Add(item);
            }
            btn_edit(false);
        }

        

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {

            
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            
        }
    }
}
