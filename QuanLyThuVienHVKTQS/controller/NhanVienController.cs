using QuanLyThuVienHVKTQS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienHVKTQS.controller
{
    class NhanVienController
    {
        QuanLiThuVienHVKTQS db = null;
        public NhanVienController()
        {
            db = new QuanLiThuVienHVKTQS();
        }
        public List<nhanvien> Detail()
        {
            return db.nhanviens.ToList();
        }
        public string Add(nhanvien entity)
        {
            try
            {
                db.nhanviens.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            return entity.tendangnhap;
        }
        public bool Edit(nhanvien entity)
        {
            try
            {
                var index = db.nhanviens.Find(entity.tendangnhap);
                index.tennv = entity.tennv;
                index.matkhau = entity.matkhau;
                index.sdt = entity.sdt; index.ngaysinh = entity.ngaysinh;
                index.gioitinh = entity.gioitinh; index.diachi = entity.diachi;
                index.socmtnd = entity.socmtnd; index.anh = entity.anh;
                index.quyenhan = entity.quyenhan; index.matkhau = entity.matkhau;
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
        public bool delete(string tendannhap)
        {
            try
            {
                var entity = db.nhanviens.Find(tendannhap);
                db.nhanviens.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public int Login(string tendangnhap, string matkhau)
        {
            var user = db.nhanviens.Find(tendangnhap);
            if (user != null)
            {
                if (user.matkhau == matkhau)
                {
                    if (user.quyenhan == "admin")
                    {
                        return 2;
                    }
                    else
                        return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
        }
        public bool EditOne(nhanvien entity)
        {
            try
            {
                var index = db.nhanviens.Find(entity.tendangnhap);
                index.tennv = entity.tennv;
                index.matkhau = entity.matkhau;
                index.sdt = entity.sdt; index.ngaysinh = entity.ngaysinh;
                index.gioitinh = entity.gioitinh; index.diachi = entity.diachi;
                index.socmtnd = entity.socmtnd; index.anh = entity.anh;

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
        public bool EditOne(string anh, string tendangnhap)
        {
            try
            {
                var index = db.nhanviens.Find(tendangnhap);
                index.anh = anh;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        public nhanvien DetailOne(string tendangnhap)
        {
            return db.nhanviens.Find(tendangnhap);
        }
    }
}
