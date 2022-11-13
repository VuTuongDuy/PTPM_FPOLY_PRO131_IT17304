using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuService
    {
        string Add(ChucVu obj);
        string Update(ChucVu obj);
        string Delete(ChucVu obj);
        ChucVu GetByID(Guid id);
        List<ViewChucVu> GetAllChucVu();
    }
}
