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
            manxbtxt.Text = "";
            tennxbtxt.Text = "";
            diachinxbtxt.Text = "";
            sdtnxbtxt.Text = "";
            btn_enable(true);
            Them_bool = true;
        }

        private void Sua_NXB_Click(object sender, EventArgs e)
        {
            btn_enable(true);
            Sua_bool = true;
        }

        private void Xoa_NXB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(manxbtxt.Text);
                var entity = new NhaXuatBanController();
                if (entity.Delete(id))
                    HienThi_NXB();
                else
                {
                    MessageBox.Show("Không xóa được");
                }
            }
        }

        private void Luu_NXB_Click(object sender, EventArgs e)
        {
            if (Them_bool == true && Sua_bool == false)
            {
                var nxb = new nhaxuatban();
                nxb.tennxb = tennxbtxt.Text;
                nxb.diachi = diachinxbtxt.Text;
                nxb.sdt = sdtnxbtxt.Text;

                var entity = new NhaXuatBanController();
                if (entity.Add(nxb) > 0)
                    HienThi_NXB();
                else
                    MessageBox.Show("Thêm không thành công");
            }
            if (Them_bool == false && Sua_bool == true)
            {
                var nxb = new nhaxuatban();
                nxb.tennxb = tennxbtxt.Text;
                nxb.diachi = diachinxbtxt.Text;
                nxb.sdt = sdtnxbtxt.Text;

                var entity = new NhaXuatBanController();
                if (entity.Edit(nxb))
                    HienThi_NXB();
                else
                    MessageBox.Show("Sửa không thành công");

            }
            btn_enable(false);
        }

        private void Boqua_NXB_Click(object sender, EventArgs e)
        {
            btn_enable(true);
        }

        private void Thoat_NXB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
