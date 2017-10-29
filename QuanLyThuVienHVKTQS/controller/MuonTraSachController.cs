using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class MuonTraSachController
    {
        QuanLiThuVienHVKTQS db = null;
        public MuonTraSachController()
        {
            db = new QuanLiThuVienHVKTQS();
        }
        public List<muonsach> DSMuon(int sothe)
        {
            var result = db.muonsaches.Where(m => m.sothe == sothe && m.ngaytra == null).ToList();
            return result;
        }
        public List<muonsach> DSLSMuon()
        {
            var result = db.muonsaches.Where(m => m.ngaytra == null).ToList();
            return result;
        }
        public List<muonsach> DSLSTra()
        {
            var result = db.muonsaches.Where(m => m.ngaytra != null).ToList();
            return result;
        }
        public List<muonsach> DSLS()
        {
            var result = db.muonsaches.ToList();
            return result;
        }
        
    }
}
