using QuanLyThuVienHVKTQS.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienHVKTQS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 0)
            {
                if (txtMatKhau.Text.Length > 0)
                {
                    NhanVienController nvc = new NhanVienController();
                    int id = nvc.Login(txtTenDangNhap.Text, txtMatKhau.Text);
                    if (id == -1)
                    {
                        lblLoi.Text = "Tên đăng nhập không tồn tại";
                    }
                    else if (id == 0)
                    {
                        lblLoi.Text = "Mật khẩu không hợp lệ";
                    }
                    else if (id == 1)
                    {
                        ConstantCommon.LOAI_TAI_KHOAN = 1;
                        ConstantCommon.TEN_DANG_NHAP = txtTenDangNhap.Text;

                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ConstantCommon.LOAI_TAI_KHOAN = 2;
                        ConstantCommon.TEN_DANG_NHAP = txtTenDangNhap.Text;
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();
                        //Close();
                    }
                }
            }
        }
    }
}
