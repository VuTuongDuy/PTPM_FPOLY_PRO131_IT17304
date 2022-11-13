using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
<<<<<<< HEAD
    public  interface IHoaDonChiTietRipositry
=======
    public interface IHoaDonChiTietRipositry
>>>>>>> c4def6ee2a2c7398d4e56530640e6575c2c89cd6
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        List<HoaDonChiTiet> GetAll();
        HoaDonChiTiet GetById(Guid id);
    }
}
