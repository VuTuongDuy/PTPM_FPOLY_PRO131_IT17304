using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _ichucVuRepository;
        
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _ichucVuRepository = new ChucVuRepository();
            
        }

        public string Add(ViewNhanVien obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(ViewNhanVien obj)
        {
            throw new NotImplementedException();
        }

        public List<ViewNhanVien> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(ViewNhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
   
}
