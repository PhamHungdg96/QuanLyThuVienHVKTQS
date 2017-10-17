using QuanLyThuVienHVKTQS.controller;
using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienHVKTQS
{
    public partial class frmNhanVien : Form
    {
        List<nhanvien> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = false;

        public void btn_edit(bool t)
        {
            groupedit_NV.Enabled = t;
            ThemNV.Enabled = !t;
            SuaNV.Enabled = !t;
            XoaNV.Enabled = !t;
            LuuNV.Enabled = t;
            BoquaNV.Enabled = t;
            Them_bool = false;
            Sua_bool = false;
        }
        public frmNhanVien()
        {
            InitializeComponent();
            HienthiNV();
        }

        public void HienthiNV()
        {

            var nv = new NhanVienController();
            l = nv.Detail();
            listView_NV.Items.Clear();
            var i = 1;

            if (l.Count > 0)
            {
                txtTenDangNhap.Text = l[0].tendangnhap;
                tennvtxt.Text = l[0].tennv.ToString();
                ngaysinhnv.Text = l[0].ngaysinh.ToString();
                if (l[0].gioitinh == null) gioitinhcbb.Text = "";
                else gioitinhcbb.Text = l[0].gioitinh.ToString();
                if (l[0].sdt == null) sdttxt.Text = "";
                else sdttxt.Text = l[0].sdt.ToString();
                if (l[0].diachi == null) diachitxt.Text = "";
                else diachitxt.Text = l[0].diachi.ToString();
                if (l[0].socmtnd == null) socmtndtxt.Text = "";
                else socmtndtxt.Text = l[0].socmtnd.ToString();
                if (l[0].quyenhan == null) cbbQuyenHan.Text = "";
                else cbbQuyenHan.Text = l[0].quyenhan.ToString();
                if (l[0].anh != null)
                {
                    string path = Path.Combine(Environment.CurrentDirectory, @"Pictures\", l[0].anh.ToString());
                    Image image = Image.FromFile(path);
                    this.anhnv_picture.Image = image;
                    anhnv_picture.SizeMode = PictureBoxSizeMode.Zoom;
                }
                foreach (nhanvien row in l)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "" + i++;
                    item.SubItems.Add(row.tendangnhap);
                    item.SubItems.Add(row.tennv.ToString());
                    item.SubItems.Add(row.diachi.ToString());
                    item.SubItems.Add(row.sdt.ToString());
                    listView_NV.Items.Add(item);
                }
            }
            btn_edit(false);
        }

        private void ListView_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_NV.SelectedItems.Count == 0)
                return;
            string i = listView_NV.SelectedItems[0].SubItems[1].Text;
            int index = l.FindIndex(m => m.tendangnhap == i);
            txtTenDangNhap.Text = l[index].tendangnhap;
            tennvtxt.Text = l[index].tennv.ToString();
            ngaysinhnv.Text = l[index].ngaysinh.ToString();
            if (l[index].gioitinh == null) gioitinhcbb.Text = "";
            else gioitinhcbb.Text = l[index].gioitinh.ToString();
            if (l[index].sdt == null) sdttxt.Text = "";
            else sdttxt.Text = l[index].sdt.ToString();
            if (l[index].diachi == null) diachitxt.Text = "";
            else diachitxt.Text = l[index].diachi.ToString();
            if (l[index].socmtnd == null) socmtndtxt.Text = "";
            else socmtndtxt.Text = l[index].socmtnd.ToString();
            if (l[index].quyenhan == null) cbbQuyenHan.Text = "";
            else cbbQuyenHan.Text = l[index].quyenhan.ToString();
            if (l[index].anh != null)
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"Pictures\", l[index].anh.ToString());
                Image image = Image.FromFile(path);
                this.anhnv_picture.Image = image;
                anhnv_picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ThemNV_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            txtTenDangNhap.Text = "";
            tennvtxt.Text = "";
            gioitinhcbb.Text = "";
            sdttxt.Text = "";
            diachitxt.Text = "";
            socmtndtxt.Text = "";
            cbbQuyenHan.Text = "";
            this.Them_bool = true;
        }


        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaNV_Click(object sender, EventArgs e)
        {
            btn_edit(true);
            Sua_bool = true;
        }

        private void XoaNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string id = txtTenDangNhap.Text;
                var entity = new NhanVienController();
                if (entity.delete(id))
                    HienthiNV();
                else
                    MessageBox.Show("Không xóa được!");
            }
        }

        private void LuuNV_Click(object sender, EventArgs e)
        {
            if (Them_bool == true && Sua_bool == false)
            {
                var entity = new nhanvien();
                entity.matkhau = txtMatKhau.Text;
                entity.tennv = tennvtxt.Text;
                entity.ngaysinh = ngaysinhnv.Value;
                entity.gioitinh = gioitinhcbb.Text;
                entity.sdt = sdttxt.Text;
                entity.diachi = diachitxt.Text;
                entity.socmtnd = socmtndtxt.Text;
                entity.quyenhan = cbbQuyenHan.Text;

                var nv = new NhanVienController();
                string t = nv.Add(entity);
                if (t != null && t.Length > 0)
                    HienthiNV();
                else
                    MessageBox.Show("Thêm nhân viên lỗi!");
            }
            if (Them_bool == false && Sua_bool == true)
            {
                var entity = new nhanvien();
                entity.tendangnhap = txtTenDangNhap.Text;
                entity.matkhau = txtMatKhau.Text;
                entity.tennv = tennvtxt.Text;
                entity.ngaysinh = ngaysinhnv.Value;
                entity.gioitinh = gioitinhcbb.Text;
                entity.sdt = sdttxt.Text;
                entity.diachi = diachitxt.Text;
                entity.socmtnd = socmtndtxt.Text;
                entity.quyenhan = cbbQuyenHan.Text;

                var nv = new NhanVienController();
                if (nv.Edit(entity))
                    HienthiNV();
                else
                    MessageBox.Show("Sửa lỗi!");
            }
            btn_edit(false);
        }

        private void BoquaNV_Click(object sender, EventArgs e)
        {
            btn_edit(false);
        }
    }
}
