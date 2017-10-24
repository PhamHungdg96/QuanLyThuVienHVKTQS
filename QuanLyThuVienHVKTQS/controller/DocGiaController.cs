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
        public long Add(docgia entity)
        {
            try
            {
                db.docgias.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            return entity.sothe;
        }
        public bool Edit(docgia entity)
        {
            try
            {
                var index = db.docgias.Find(entity.sothe);
                index.hoten = entity.hoten;
                index.email = entity.email; index.ngaysinh = entity.ngaysinh;
                index.gioitinh = entity.gioitinh; index.diachi = entity.diachi;
                index.socmtnd = entity.socmtnd; index.anhthe = entity.anhthe;
                index.ngaylamthe = entity.ngaylamthe; index.handungthe = entity.handungthe;
                index.note = entity.note;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public bool delete(long sothe)
        {
            try
            {
                var entity = db.docgias.Find(sothe);
                db.docgias.Remove(entity);
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
