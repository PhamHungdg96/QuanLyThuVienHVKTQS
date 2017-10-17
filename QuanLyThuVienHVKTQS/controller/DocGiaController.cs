using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class DocGiaController
    {
        QuanLiThuVienHVKTQS db = null;
        public DocGiaController()
        {
            db = new QuanLiThuVienHVKTQS();
        }
        public List<docgia> Detail()
        {
            return db.docgias.ToList();
        }

    }
}
