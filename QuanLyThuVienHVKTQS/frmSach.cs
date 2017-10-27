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
            if (lvSach.SelectedItems.Count == 0)
                return;
            int i = Convert.ToInt32(lvSach.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.masach == i);
            txtMaSach.Text = l[index].masach.ToString();
            txtTenSach.Text = l[index].tensach.ToString();
            txtTacGia.Text = l[index].tentacgia.ToString();
            if (l[index].manxb != null)
                cbbNXB.Text = l[index].nhaxuatban.tennxb.ToString();
            else
                cbbNXB.Text = "";
            txtNamXB.Text = l[index].namxb.ToString();

            txtLanXB.Text = l[index].solanxb.ToString();
            txtGiaTien.Text = l[index].giatien.ToString();
            txtSoLuong.Text = l[index].soluong.ToString();
            txtNgonNgu.Text = l[index].ngonngu.ToString();
            txtTheLoai.Text = l[index].theloai.ToString();
            txtLoaiSach.Text = l[index].loai.ToString();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {

            btn_edit(true);
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            //txtNXB.Text = "";
            txtNamXB.Text = "";

            txtLanXB.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            txtNgonNgu.Text = "";
            txtTheLoai.Text = "";
            txtLoaiSach.Text = "";
            this.Them_bool = true;
        }

        public void btn_edit(bool t)
        {
            grpEdit.Enabled = t;
            btnLuuSach.Enabled = t;
            btnBoQua.Enabled = t;
            btnThemSach.Enabled = !t;
            btnSuaSach.Enabled = !t;
            btnXoaSach.Enabled = !t;
            btnThoat.Enabled = !t;
            Them_bool = false;
            Sua_bool = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btn_edit(false);
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            this.Sua_bool = true;
        }
        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (Them_bool == true && Sua_bool == false)
            {
                sach entity = new sach();
                //txtMaSach.Text = "";
                entity.tensach = txtTenSach.Text;
                entity.tentacgia = txtTacGia.Text;
                entity.manxb = Convert.ToInt32(cbbNXB.SelectedValue.ToString());
                if (txtNamXB.Text.Length > 0)
                    entity.namxb = Convert.ToInt32(txtNamXB.Text);

                if (txtLanXB.Text.Length > 0)
                    entity.solanxb = Convert.ToInt32(txtLanXB.Text);
                if (txtGiaTien.Text.Length > 0)
                    entity.giatien = Convert.ToDecimal(txtGiaTien.Text);
                if (txtSoLuong.Text.Length > 0)
                    entity.soluong = Convert.ToInt32(txtSoLuong.Text);
                entity.ngonngu = txtNgonNgu.Text;
                entity.theloai = txtTheLoai.Text;
                entity.loai = txtLoaiSach.Text;
                var s = new SachController();
                int t = s.Add(entity);
                if (t > 0)
                    HienThiSach();
            }
            if (Them_bool == false && Sua_bool == true)
            {
                sach entity = new sach();
                entity.masach = Convert.ToInt32(txtMaSach.Text);
                entity.tensach = txtTenSach.Text;
                entity.tentacgia = txtTacGia.Text;
                entity.manxb = Convert.ToInt32(cbbNXB.SelectedValue.ToString());
                if (txtNamXB.Text.Length > 0)
                    entity.namxb = Convert.ToInt32(txtNamXB.Text);

                if (txtLanXB.Text.Length > 0)
                    entity.solanxb = Convert.ToInt32(txtLanXB.Text);
                if (txtGiaTien.Text.Length > 0)
                    entity.giatien = Convert.ToDecimal(txtGiaTien.Text);
                if (txtSoLuong.Text.Length > 0)
                    entity.soluong = Convert.ToInt32(txtSoLuong.Text);
                entity.ngonngu = txtNgonNgu.Text;
                entity.theloai = txtTheLoai.Text;
                entity.loai = txtLoaiSach.Text;
                var s = new SachController();
                if (s.Edit(entity))
                    HienThiSach();
                else
                {
                    MessageBox.Show("khong sua duoc!");
                }
            }
            btn_edit(false);
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co thuc su muon xoa?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int masach = Convert.ToInt32(txtMaSach.Text);
                var s = new SachController();
                if (s.Del(masach))
                    HienThiSach();
                else
                {
                    MessageBox.Show("khong xoa duoc!");
                }
            }
        }
    }
}
