using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class SachController
    {
        QuanLiThuVienHVKTQS db = null;
        public SachController()
        {
            db = new QuanLiThuVienHVKTQS();
        }
        public List<sach> Detail()
        {
            return db.saches.ToList();
        }
        public int Add(sach entity)
        {
            try
            {
                db.saches.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.masach;
        }
        public bool Edit(sach entity)
        {
            try
            {
                var index = db.saches.Find(entity.masach);
                index.tensach = entity.tensach;
                index.tentacgia = entity.tentacgia; index.manxb = entity.manxb;
                index.giatien = entity.giatien; index.soluong = entity.soluong;
                index.namxb = entity.namxb; index.solanxb = entity.solanxb;
                index.theloai = entity.theloai; index.loai = entity.loai;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public bool Del(int masach)
        {
            try
            {
                var entity = db.saches.Find(masach);
                db.saches.Remove(entity);
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
