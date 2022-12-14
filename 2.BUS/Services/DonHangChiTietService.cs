using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.IRepositoris;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class DonHangChiTietService : IDonHangChiTietService
    {
        FpolyDBContext context = new FpolyDBContext();
        private IDonHangChiTietRepository donHangChiTietRepository;
        private IDonHangRepository donHangRepository;
        private ISanPhamRepository sanPhamRepository;
        private ICungCapRepository cungCapRepository;
        
        //private DonhangChitiet dhct;
        //DonHangService donHangService = new DonHangService();
        List<DonHangChiTietView> lstdh;
        public DonHangChiTietService()
        {
            donHangChiTietRepository = new DonHangChiTietRepository();
            donHangRepository = new DonHangRepository();
            sanPhamRepository= new SanPhamRepository();
            cungCapRepository = new CungCapRepository();
        }
        
        public string add(DonhangChitiet donhangChitiet)
        {
            throw new NotImplementedException();
        }

        public List<DonhangChitiet> GetAll()
        {
            return context.DonhangChitiets.ToList();
        }

        public List<DonHangChiTietView> GetViews()
        {
            lstdh = (from dhct in GetAll()
                     join dh in donHangRepository.GetAll() on dhct.DonhangId equals dh.DonhangId
                     join sp in sanPhamRepository.GetAll() on dhct.SanphamId equals sp.SanphamId
                     select new DonHangChiTietView
                     {
                         donhangChitiet = dhct,
                         donhang = dh,
                         sanpham = sp,
                     }).ToList();
            return lstdh;
        }
        public string remove(DonhangChitiet donhangChitiet)
        {
            throw new NotImplementedException();
        }
        public string update(DonhangChitiet donhangChitiet)
        {
            throw new NotImplementedException();
        }
    }
}
