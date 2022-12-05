using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.IRepositoris;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    
    public class DonHangService : IDonHangService
    {
        FpolyDBContext context = new FpolyDBContext();
        private INhanVienRepository nhanVienRepository;
        private IDonHangRepository donHangRepository;
        private IKhachHangRepository khachHangRepository;
        private IShipperRepository shipperRepository;
        //DonHangChiTietService DonHangChiTietService = new DonHangChiTietService();
        List<DonHangView> lstDonHang;
        public DonHangService()
        {
            nhanVienRepository= new NhanVienRepository();
            khachHangRepository= new KhachHangRepository();
            shipperRepository= new ShipperRepository();
            donHangRepository= new DonHangRepository();
        }
        public string add(Donhang donhang)
        {
            if (donhang == null) return "Thêm không thành công";
            else
            {
                donHangRepository.add(donhang);
                return "Thêm mới thành công";
            }    
        }

        public string delete(Donhang donhang)   
        {
            donHangRepository.delete(donhang);
            return "Xóa thành công";
        }

        public List<Donhang> getAll()
        {
            return context.Donhangs.ToList();
        }

        public List<DonHangView> getallView()
        {
            lstDonHang = (from dh in getAll()
                          join kh in khachHangRepository.Getall() on dh.KhachhangId equals kh.KhachhangId   
                          join nv in nhanVienRepository.getAll() on dh.NhanvienId equals nv.NhanviennId
                          join sp in shipperRepository.GetAll() on dh.ShipperId equals sp.ShipperId
                          select new DonHangView
                          {
                              //Donhang = dh,
                              //khachhang = kh,
                              //shipper = sp,
                              //nhanvien = nv,
                              
                          }).ToList();
            return lstDonHang;
        }

        public string update(Donhang donhang)
        {
            if (donhang == null) return "Thêm không thành công";
            else
            {
                donHangRepository.update(donhang);
                return "Thêm mới thành công";
            }
        }
    }
}
