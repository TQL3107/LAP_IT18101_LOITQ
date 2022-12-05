using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        FpolyDBContext context = new FpolyDBContext();

        public bool all(Khachhang khachhang)
        {
            throw new NotImplementedException();
        }

        public List<Khachhang> Getall()
        {
            return context.Khachhangs.ToList();
        }

        public bool update(Khachhang khachhang)
        {
            throw new NotImplementedException();
        }

        public bool đelete(Khachhang khachhang)
        {
            throw new NotImplementedException();
        }
    }
}
