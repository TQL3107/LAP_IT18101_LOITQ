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
    public class DonHangChiTietRepository : IDonHangChiTietRepository
    {
        FpolyDBContext context = new FpolyDBContext();

        public bool add(DonhangChitiet donhangChitiet)
        {
            if (donhangChitiet == null) return false;
            context.Add(donhangChitiet);
            context.SaveChanges();
            return true;
        }

        public List<DonhangChitiet> GetAll()
        {
            return context.DonhangChitiets.ToList();
        }

        public bool remove(DonhangChitiet donhangChitiet)
        {
            if (donhangChitiet == null) return false;
            //var a = context.DonhangChitiets.FirstOrDefault(x => x.DonhangChitietId == id);
            context.Remove(donhangChitiet);
            context.SaveChanges();
            return true;
        }

        public bool update(DonhangChitiet donhangChitiet)
        {
            if (donhangChitiet == null) return false;
            //var a = context.DonhangChitiets.FirstOrDefault(x => x.DonhangChitietId == id);
            //a.DonhangChitietId = donhangChitiet.DonhangChitietId;
            //a.DonhangId = donhangChitiet.DonhangId;
            //a.SanphamId = donhangChitiet.SanphamId;
            //a.Soluong = donhangChitiet.Soluong;
            context.Update(donhangChitiet);
            context.SaveChanges();
            return true;
        }
    }
}


