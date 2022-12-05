using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDanhMucService
    {
        public string add(Danhmuc danhmuc);
        public string delete(Danhmuc danhmuc);
        public string update(Danhmuc danhmuc);
        List<Danhmuc> getall();
    }
}
