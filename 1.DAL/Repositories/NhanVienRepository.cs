using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
<<<<<<< HEAD
    public class NhanVienRepository:INhanVienRepository
=======
    public class NhanVienRepository  : INhanVienRepository
>>>>>>> d5bd763052f623ea23cdc532b63cb69546c9e707
    {
        private FpolyDBContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
           
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.NhanViens.FirstOrDefault(s => s.Id == obj.Id);
            _dbContext.Remove(temobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;

            return _dbContext.NhanViens.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.NhanViens.FirstOrDefault(s => s.Id == obj.Id);
            temobj.Ma = obj.Ma;
            temobj.Ten = obj.Ten;
            temobj.TenDem = obj.TenDem;
            temobj.Ho = obj.Ho;
            temobj.NgaySinh = obj.NgaySinh;
            temobj.Sdt = obj.Sdt;
            temobj.DiaChi = obj.DiaChi;
            temobj.MatKhau = obj.MatKhau;
            temobj.TrangThai = obj.TrangThai;
            _dbContext.NhanViens.Update(temobj);
            _dbContext.SaveChanges();
            return true;
           
        }
    }
}
