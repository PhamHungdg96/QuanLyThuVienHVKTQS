using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienHVKTQS.Model;

namespace QuanLyThuVienHVKTQS.controller
{
    class NhaXuatBanController
    {
        QuanLiThuVienHVKTQS db = null;
        public NhaXuatBanController()
        {
            db = new QuanLiThuVienHVKTQS();
        }
        public List<nhaxuatban> Detail()
        {
            return db.nhaxuatbans.ToList();
        }

    }
}
