using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    internal interface IChiTietKhuyenMaiRepository
    {
        bool Add(ChiTietKhuyenMai obj);
        bool Update(ChiTietKhuyenMai obj);
        bool Delete(ChiTietKhuyenMai obj);
        List<ChiTietKhuyenMai> GetAll();
        ChiTietKhuyenMai GetById(Guid id);
    }
}
