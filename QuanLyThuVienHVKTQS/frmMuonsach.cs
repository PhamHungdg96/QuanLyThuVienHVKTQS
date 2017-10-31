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
            if (listviewDSMuon.SelectedItems.Count == 0) return;
            long id = Convert.ToInt64(listviewDSMuon.SelectedItems[0].SubItems[1].Text);
            int index = listms.FindIndex(m => m.id == id);
            id_select = listms[index].id;
            txtMaSach.Text = listms[index].masach.ToString();
            cbbTenSach.Text = listms[index].sach.tensach.ToString();
            txtTacGia.Text = listms[index].sach.tentacgia.ToString();
            if (listms[index].sach.manxb != null)
                txtNXB.Text = listms[index].sach.nhaxuatban.tennxb.ToString();
            else
                txtNXB.Text = "";
            txtNamXB.Text = listms[index].sach.namxb.ToString();
            txtGiaDen.Text = listms[index].sach.giatien.ToString();
            
            txtTheLoai.Text = listms[index].sach.theloai.ToString();
            txtLoaiSach.Text = listms[index].sach.loai.ToString();
            dtpHanTra.Text = listms[index].hantra.ToString();
            txtNVDaChoMuon.Text = listms[index].nhanvien.tennv.ToString();
            
        }

        private void cbbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
           DSMuonView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMuonThem_Click(object sender, EventArgs e)
        {
            cbbTenSach.Enabled = true;
            dtpHanTra.Enabled = true;
            btnsua.Enabled = true;
            active(true);

           
            txtNVDaChoMuon.Text = txtNVChoMuon.Text;
            muon_sach = true;
            tra_sach = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        	if (muon_sach == true && tra_sach == false)
            {
                MuonTraSachController mtsc = new MuonTraSachController();
                muonsach m = new muonsach();
                m.sothe = Convert.ToInt32(cbbDocGia.SelectedValue.ToString());
                m.masach = Convert.ToInt32(cbbTenSach.SelectedValue.ToString());
                m.tennv = ConstantCommon.TEN_DANG_NHAP;
                m.ngaymuon = DateTime.Now;
                m.hantra = Convert.ToDateTime(dtpHanTra.Text);
                var bol = mtsc.MuonSach(m);
                if (bol<0)
                {
                    MessageBox.Show("khong them duoc");
                }
                else if(bol==0)
                {
                    MessageBox.Show("khong con sach de cho muon");
                }
            }
            if (muon_sach == false && tra_sach == true)
            {
                if (id_select != 0)
                {
                    MuonTraSachController mtsc = new MuonTraSachController();
                    mtsc.TraSach(id_select);
                }
            }
            DSMuonView();
            
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            active(false);
            muon_sach = false;
            tra_sach = false;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            active(true);
            btnsua.Enabled = false;
            muon_sach = false;
            tra_sach = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (muon_sach == true && tra_sach == false)
            {
                MuonTraSachController mtsc = new MuonTraSachController();
                muonsach m = new muonsach();
                m.id = id_select;
                m.sothe = Convert.ToInt32(cbbDocGia.SelectedValue.ToString());
                m.masach = Convert.ToInt32(cbbTenSach.SelectedValue.ToString());
                m.tennv = ConstantCommon.TEN_DANG_NHAP;
                m.ngaymuon = DateTime.Now;
                m.hantra = Convert.ToDateTime(dtpHanTra.Text);

                if (mtsc.MuonSach(m)<0)
                {
                    MessageBox.Show("khong them duoc");
                }

            }
            DSMuonView();
        }

        private void dtpHanTra_ValueChanged(object sender, EventArgs e)
        {
        	if (DateTime.Compare(dtpHanTra.Value, DateTime.Now) < 0)
            {
                MessageBox.Show("han tra phai sau ngay muon");
            }
        }
    }
}
