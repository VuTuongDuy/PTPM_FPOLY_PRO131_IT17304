using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        bool Add(ViewKhachHang obj);
        bool Update(ViewKhachHang obj);
        bool Delete(ViewKhachHang obj);
        List<ViewKhachHang> GetAll();
    }
}
