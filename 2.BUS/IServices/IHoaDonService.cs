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
        string Delete(Guid obj);
        ChucVu GetByID(Guid id);
        List<ViewHoaDon> GetAll();
    }
}
