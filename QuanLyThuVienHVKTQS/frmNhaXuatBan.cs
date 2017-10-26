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
    public partial class frmNhaXuatBan : Form
    {
        List<nhaxuatban> l = null;
        private bool Them_bool = false;
        private bool Sua_bool = true;
        public frmNhaXuatBan()
        {
            InitializeComponent();
            HienThi_NXB();
        }
        private void btn_enable(bool t)
        {
            group_NXB.Enabled = t;
            Them_NXB.Enabled = !t;
            Sua_NXB.Enabled = !t;
            Xoa_NXB.Enabled = !t;
            Luu_NXB.Enabled = t;
            Boqua_NXB.Enabled = t;
            Them_bool = Sua_bool = false;
        }
        public void HienThi_NXB()
        {
            var nxb = new NhaXuatBanController();
            l = nxb.Detail();
            listView_NXB.Items.Clear();
            int i = 1;

            foreach (nhaxuatban row in l)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + i++;
                item.SubItems.Add(row.manxb.ToString());
                item.SubItems.Add(row.tennxb);
                item.SubItems.Add(row.diachi);
                item.SubItems.Add(row.sdt);
                listView_NXB.Items.Add(item);
            }
            btn_enable(false);
        }
        public void ListView_NXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_NXB.SelectedItems.Count == 0) return;
            int id = Convert.ToInt32(listView_NXB.SelectedItems[0].SubItems[1].Text);
            int index = l.FindIndex(m => m.manxb == id);

            manxbtxt.Text = l[index].manxb.ToString();
            tennxbtxt.Text = l[index].tennxb.ToString();
            if (l[index].diachi == null) diachinxbtxt.Text = "";
            else diachinxbtxt.Text = l[index].diachi.ToString();
            if (l[index].sdt == null) sdtnxbtxt.Text = "";
            else sdtnxbtxt.Text = l[index].sdt.ToString();

        }
        private void Them_NXB_Click(object sender, EventArgs e)
        {
           
        }

        private void Sua_NXB_Click(object sender, EventArgs e)
        {
           
        }

        private void Xoa_NXB_Click(object sender, EventArgs e)
        {
            
        }

        private void Luu_NXB_Click(object sender, EventArgs e)
        {
           
        }

        private void Boqua_NXB_Click(object sender, EventArgs e)
        {
            
        }

        private void Thoat_NXB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
