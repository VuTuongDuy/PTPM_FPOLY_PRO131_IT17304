using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool AddNhanVien(NhanVien obj);
        bool UpdateNhanVien(NhanVien obj);
        bool DeleteNhanVien(NhanVien obj);
        NhanVien GetById(Guid id);
        List<NhanVien> GetAllNhanVien();
    }
}
