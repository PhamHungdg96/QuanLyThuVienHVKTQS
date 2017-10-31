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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (ConstantCommon.LOAI_TAI_KHOAN == 2)
            {
                tsmiNhanVien.Enabled = true;
                ThongKetsmi.Visible = true;
            }
            showOne();
            
        }
       	void showOne()
        {
            var nvc = new NhanVienController();
            var nv = nvc.DetailOne(ConstantCommon.TEN_DANG_NHAP);
            ConstantCommon.HO_TEN_NV = nv.tennv.ToString();
            txtTenDangNhap.Text = nv.tendangnhap;
            tennvtxt.Text = nv.tennv.ToString();
            ngaysinhnv.Text = nv.ngaysinh.ToString();
            if (nv.gioitinh == null) cbbGioiTinh.Text = "";
            else cbbGioiTinh.Text = nv.gioitinh.ToString();
            if (nv.sdt == null) sdttxt.Text = "";
            else sdttxt.Text = nv.sdt.ToString();
            if (nv.diachi == null) diachitxt.Text = "";
            else diachitxt.Text = nv.diachi.ToString();
            if (nv.socmtnd == null) socmtndtxt.Text = "";
            else socmtndtxt.Text = nv.socmtnd.ToString();
            if (nv.anh != null)
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"Pictures\", nv.anh.ToString());
                Image image = Image.FromFile(path);
                this.anhnv_picture.Image = image;
                anhnv_picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            groupedit_NV.Enabled = false;
        }

        private void tsmiMuonSach_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiDanhMucDocGia_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiDanhMucNXB_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiDanhMucSach_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmiTimKiemDocGia_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTimKiemSach_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTimKiemSachDaChoMuon_Click(object sender, EventArgs e)
        {

        }

        private void tsmiTKDocGia_Click(object sender, EventArgs e)
        {
            
        }

        private void anhmoinvbtn_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
