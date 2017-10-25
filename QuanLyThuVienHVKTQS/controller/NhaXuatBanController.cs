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
        public int Add(nhaxuatban entity)
        {
            try
            {
                db.nhaxuatbans.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.manxb;
        }
        public bool Edit(nhaxuatban entity)
        {
            try
            {
                var index = db.nhaxuatbans.Find(entity.manxb);
                index.tennxb = entity.tennxb;
                index.diachi = entity.diachi; index.sdt = entity.sdt;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public bool Delete(int manxb)
        {
            try
            {
                var entity = db.nhaxuatbans.Find(manxb);
                db.nhaxuatbans.Remove(entity);
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
