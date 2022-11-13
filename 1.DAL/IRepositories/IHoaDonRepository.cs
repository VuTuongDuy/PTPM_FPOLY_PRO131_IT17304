﻿using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.DAL.IRepositories
{
    internal interface IHoaDonRepository
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        HoaDon GetAllById(Guid id);
        List<HoaDon> GetAll();
    }
}
