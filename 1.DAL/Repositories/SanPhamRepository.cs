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
    public class SanPhamRepository : ISanPhamRepository
    {
        FpolyDBContext context = new FpolyDBContext();

        public bool add(Sanpham sanpham)
        {
            throw new NotImplementedException();
        }

        public bool delete(Sanpham sanpham)
        {
            throw new NotImplementedException();
        }

        public List<Sanpham> GetAll()
        {
            return context.Sanphams.ToList();
        }

        public bool update(Sanpham sanpham)
        {
            throw new NotImplementedException();
        }
    }
}
