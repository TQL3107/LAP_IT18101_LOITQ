using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        bool all(Khachhang khachhang);
        bool update(Khachhang khachhang);
        bool đelete(Khachhang khachhang);
        List<Khachhang> Getall();
    }
}
