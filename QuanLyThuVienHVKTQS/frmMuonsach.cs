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
using System.Globalization;

namespace QuanLyThuVienHVKTQS
{
    public partial class frmMuonsach : Form
    {
        List<muonsach> listms;
        bool bindingsach = false;
        bool muon_sach = false;
        bool tra_sach = false;
        long id_select = 0;
        public frmMuonsach()
        {
            InitializeComponent();
            HienThiView();
            active(false);
        }
        
        void HienThiView()
        {
            DocGiaController dg = new DocGiaController();
            var listDocGia = dg.Detail();

            BindingSource bindingDocGia = new BindingSource();
            bindingDocGia.DataSource = listDocGia;
            //bindingDocGia.DataMember = "sothe";

            cbbDocGia.DataSource = bindingDocGia;
            cbbDocGia.DisplayMember = "hoten";
            cbbDocGia.ValueMember = "sothe";

            txtNgaySinhDocGia.DataBindings.Add("Text", bindingDocGia, "ngaysinh");
            txtGioiTinhDocGia.DataBindings.Add("Text", bindingDocGia, "gioitinh");
            txtEmailDocGia.DataBindings.Add("Text", bindingDocGia, "email");
            txtDiaChiDocGia.DataBindings.Add("Text", bindingDocGia, "diachi");
            // danh sach sach muon
            DSMuonView();
            SachController sc = new SachController();
            var listsach = sc.Detail();

            BindingSource bindingSach = new BindingSource();
            bindingSach.DataSource = listsach;
            //bindingDocGia.DataMember = "sothe";

            cbbTenSach.DataSource = bindingSach;
            cbbTenSach.DisplayMember = "tensach";
            cbbTenSach.ValueMember = "masach";

            if (!bindingsach)
            {
                //if(txtMaSach.DataBindings==null)
                txtMaSach.DataBindings.Add("Text", bindingSach, "masach", false, DataSourceUpdateMode.Never);
                //if (txtTacGia.DataBindings == null)
                txtTacGia.DataBindings.Add("Text", bindingSach, "tentacgia");
                //if (txtNXB.DataBindings == null)
                txtNXB.DataBindings.Add("Text", bindingSach, "manxb");
                //if (txtTheLoai.DataBindings == null)
                txtTheLoai.DataBindings.Add("Text", bindingSach, "theloai");
                //if (txtLoaiSach.DataBindings == null)
                txtLoaiSach.DataBindings.Add("Text", bindingSach, "loai");
                //if (txtNamXB.DataBindings == null)
                txtNamXB.DataBindings.Add("Text", bindingSach, "namxb");
                //if (txtGiaDen.DataBindings == null)
                txtGiaDen.DataBindings.Add("Text", bindingSach, "giatien");
                //if (txtSoLuongCon.DataBindings == null)
               
                bindingsach = true;
            }

            txtNVChoMuon.Text = ConstantCommon.HO_TEN_NV;

        }
        void active(bool t)
        {
            btnBoQua.Enabled = t;
            btnLuu.Enabled = t;
            btnsua.Enabled = t;
            btnMuonThem.Enabled = !t;
            btnTra.Enabled = !t;
            btnThoat.Enabled = !t;
            cbbTenSach.Enabled = t;
            
        }
        void DSMuonView()
        {
            decimal tienden=0;
            MuonTraSachController msc = new MuonTraSachController();
            try
            {
                var v = Convert.ToInt32(cbbDocGia.SelectedValue.ToString());
                listms = msc.DSMuon(v);
                var i = 0;
                listviewDSMuon.Items.Clear();
                foreach (var row in listms)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = "" + i++;

                    item.SubItems.Add(row.id.ToString());
                    item.SubItems.Add(row.sach.tensach.ToString());
                    item.SubItems.Add(((DateTime)row.ngaymuon).ToShortDateString());
                    item.SubItems.Add(((DateTime)row.hantra).ToShortDateString());
                    listviewDSMuon.Items.Add(item);
                    if (DateTime.Compare((DateTime)row.hantra, DateTime.Now)<0)
                    {
                        int numberday = -((DateTime)row.hantra - DateTime.Now).Days;
                        tienden = ((decimal)row.sach.giatien) * numberday;
                    }
                }
                textBox16.Text = tienden.ToString("0.00");
            }
            catch (Exception)
            {

                //throw;
            }
        }
        

        private void listviewDSMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMuonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }

        private void dtpHanTra_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
