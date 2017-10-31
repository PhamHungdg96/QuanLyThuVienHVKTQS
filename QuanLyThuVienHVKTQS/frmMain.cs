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
            this.Close();
            ConstantCommon.TEN_DANG_NHAP = "";
            ConstantCommon.LOAI_TAI_KHOAN = 0;
            ConstantCommon.HO_TEN_NV = "";
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            groupedit_NV.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var entity = new nhanvien();
            entity.tendangnhap = txtTenDangNhap.Text;
            entity.matkhau = txtMatKhau.Text;
            entity.tennv = tennvtxt.Text;
            entity.ngaysinh = ngaysinhnv.Value;
            entity.gioitinh = cbbGioiTinh.Text;
            entity.sdt = sdttxt.Text;
            entity.diachi = diachitxt.Text;
            entity.socmtnd = socmtndtxt.Text;

            var nv = new NhanVienController();
            if (nv.EditOne(entity))
            {
                MessageBox.Show("ok");
                showOne();
            }
                
            else
                MessageBox.Show("Thêm nhân viên lỗi!");
            groupedit_NV.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            groupedit_NV.Enabled = false;
        }

        private void tsmiMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonsach frm = new frmMuonsach();
            
            frm.ShowDialog();
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void tsmiDanhMucDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.ShowDialog();
        }

        private void tsmiDanhMucNXB_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan frm = new frmNhaXuatBan();
            frm.ShowDialog();
        }

        private void tsmiDanhMucSach_Click(object sender, EventArgs e)
        {
           frmSach frm = new frmSach();
            frm.ShowDialog();
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
            frmLichSuMuonTra frm = new frmLichSuMuonTra();
            frm.ShowDialog();
        }

        private void anhmoinvbtn_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
                string[] last = filepath.Split('.');
                string destinationPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"Pictures\");
                string destinationFileName = DateTime.Now.ToString("yyyyMMddhhmmss") +"."+ last[last.Length-1]; 
                string sourceFile = ofdImages.FileName;
                string destinationFile = System.IO.Path.Combine(destinationPath, destinationFileName);

                if (!System.IO.Directory.Exists(destinationPath))
                {
                    System.IO.Directory.CreateDirectory(destinationPath);
                }
                System.IO.File.Copy(sourceFile, destinationFile, true);
                NhanVienController nvc = new NhanVienController();
                nvc.EditOne(destinationFileName, ConstantCommon.TEN_DANG_NHAP);
                anhnv_picture.Image = Image.FromFile(destinationFile);
                anhnv_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            
            
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
