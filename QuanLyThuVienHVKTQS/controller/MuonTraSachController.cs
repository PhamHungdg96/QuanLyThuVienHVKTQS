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
        public int MuonSach(muonsach entity)
        {
            try
            {
                var index = db.muonsaches.Find(entity.id);
                var sl = db.muonsaches.Where(m => m.masach == entity.masach && m.ngaytra == null).Count();
                if (sl < db.saches.Find(entity.masach).soluong)
                {
                    if (index != null)
                    {
                        index.masach = entity.masach;
                        index.tennv = entity.tennv;
                        index.sothe = entity.sothe;
                        index.ngaymuon = entity.ngaymuon;
                        index.hantra = entity.hantra;
                    }
                    else
                    {
                        db.muonsaches.Add(entity);
                    }
                    db.SaveChanges();
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                return -1;
                throw;
            }
            return 1;
        }
        public bool TraSach(long id)
        {
            try
            {
                var entity = db.muonsaches.Find(id);
                entity.ngaytra = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
    }
}
