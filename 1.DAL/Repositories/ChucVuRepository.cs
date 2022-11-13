﻿using _1.DAL.Context;
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
    public class ChucVuRepository: IChucVuRepository
=======
    public class ChucVuRepository :IChucVuRepository
>>>>>>> d5bd763052f623ea23cdc532b63cb69546c9e707
    {
        private FpolyDBContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(ChucVu obj)
        {


            if (obj == null) return false;
            var temobj = _dbContext.ChiTietGiays.FirstOrDefault(s => s.Id == obj.Id);

            _dbContext.Remove(temobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;

            return _dbContext.ChucVus.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.ChucVus.FirstOrDefault(s => s.Id == obj.Id);
            temobj.Ma = obj.Ma;
            temobj.Ten = obj.Ten;
            _dbContext.ChucVus.Update(temobj);
            _dbContext.SaveChanges();
            return true;
        }

    }
}
