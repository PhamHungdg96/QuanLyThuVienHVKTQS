using QuanLyThuVienHVKTQS.controller;
using QuanLyThuVienHVKTQS.Model;
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
    public partial class frmLichSuMuonTra : Form
    {
        List<muonsach> list = null;
        List<muonsach> listcbb = null;
        public frmLichSuMuonTra()
        {
            InitializeComponent();
            ShowView();
        }
        void ShowView()
        {
            SachController dgs = new SachController();
            var listSach = dgs.Detail();
            listSach.Insert(0, new sach { tensach = "", masach = -1 });
            NhanVienController dgnv = new NhanVienController();
            var listNhanVien = dgnv.Detail();
            listNhanVien.Insert(0, new nhanvien { tendangnhap = "", tennv = "" });
            DocGiaController dg = new DocGiaController();
            var listDocGia = dg.Detail();
            listDocGia.Insert(0, new docgia { hoten = "", sothe = -1 });

            cbbNhanVien.DataSource = listNhanVien;
            cbbNhanVien.DisplayMember = "tennv";
            cbbNhanVien.ValueMember = "tendangnhap";

            cbbDocGia.DataSource = listDocGia;
            cbbDocGia.DisplayMember = "hoten";
            cbbDocGia.ValueMember = "sothe";

            cbbSach.DataSource = listSach;
            cbbSach.DisplayMember = "tensach";
            cbbSach.ValueMember = "masach";
            MuonTraSachController mtsc = new MuonTraSachController();
            list = null;
            list = mtsc.DSLS();
            LoadListView(list);
        }
        void LoadListView(List<muonsach> Inlist)
        {
            var i = 0;
            listviewDSLSMuonTra.Items.Clear();
            foreach (var row in Inlist)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;

                item.SubItems.Add(row.id.ToString());
                item.SubItems.Add(row.sach.tensach.ToString());
                item.SubItems.Add(row.tennv);
                item.SubItems.Add(row.docgia.hoten);
                if (row.ngaymuon != null)
                {
                    item.SubItems.Add(((DateTime)row.ngaymuon).ToShortDateString());
                }
                else
                {
                    item.SubItems.Add(row.ngaymuon.ToString());
                }
                if (row.ngaytra != null)
                {
                    item.SubItems.Add(((DateTime)row.ngaytra).ToShortDateString());
                }
                else
                {
                    item.SubItems.Add(row.ngaytra.ToString());
                }

                listviewDSLSMuonTra.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MuonTraSachController mtsc = new MuonTraSachController();
                list = null;
                list = mtsc.DSLS();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MuonTraSachController mtsc = new MuonTraSachController();
                list = null;
                list = mtsc.DSLSMuon();
            }
            else
            {
                MuonTraSachController mtsc = new MuonTraSachController();
                list = null;
                list = mtsc.DSLSTra();
            }
            LoadListView(list);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            if (cbbNhanVien.SelectedValue.ToString().Length > 0)
            {
                listcbb = listcbb.Where(m => m.tennv == cbbNhanVien.SelectedValue.ToString()).ToList();
            }
            if (Convert.ToInt64(cbbDocGia.SelectedValue.ToString()) > 0)
            {
                listcbb = listcbb.Where(m => m.sothe == Convert.ToInt64(cbbDocGia.SelectedValue.ToString())).ToList();
            }
            if (Convert.ToInt64(cbbSach.SelectedValue.ToString()) > 0)
            {
                listcbb = listcbb.Where(m => m.masach == Convert.ToInt32(cbbSach.SelectedValue.ToString())).ToList();
            }
            LoadListView(listcbb);
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            listcbb = list;
        }

        private void cbbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            listcbb = list;
        }

        private void cbbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            listcbb = list;
        }
    }
}
