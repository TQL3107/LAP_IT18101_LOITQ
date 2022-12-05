using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DonHangRepository : IDonHangRepository
    {
        FpolyDBContext context = new FpolyDBContext();
        public bool add(Donhang donhang)
        {
            if (donhang == null) return false;
            context.Add(donhang);
            context.SaveChanges();
            return true;
        }

        public bool delete(Donhang donhang)
        {
            if(donhang == null) return false;
            //var a = context.Donhangs.FirstOrDefault(x => x.DonhangId == id);
            context.Donhangs.Remove(donhang);
            context.SaveChanges();
            return true;

        }

        public List<Donhang> GetAll()
        {
           return context.Donhangs.ToList();
        }

        public bool update(Donhang donhang)
        {
            if (donhang == null) return false;
            //var a = context.Donhangs.FirstOrDefault(x => x.DonhangId == id);
            //a.DonhangId = donhang.DonhangId;
            //a.NhanvienId = donhang.NhanvienId;
            //a.KhachhangId = donhang.KhachhangId;
            //a.Ngaydathang = donhang.Ngaydathang;
            //a.ShipperId = donhang.ShipperId;
            context.Donhangs.Update(donhang);
            context.SaveChanges();
            return true;    
        }
    }
}
