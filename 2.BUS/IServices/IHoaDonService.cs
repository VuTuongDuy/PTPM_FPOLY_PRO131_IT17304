using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(ViewHoaDon obj);
        string Update(ViewHoaDon obj);
        string Delete(ViewHoaDon obj);
        ChucVu GetByID(Guid id);
<<<<<<< HEAD
        List<HoaDon> GetAllChucVu();
=======
        List<ViewHoaDon> GetAll();
>>>>>>> 7717df2b40c51f1d2545b12f66d24651841b3b69
    }
}
