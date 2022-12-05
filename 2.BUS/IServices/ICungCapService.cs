using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICungCapService
    {
        public string add(Cungcap cungcap);
        public string remove(Cungcap cungcap);
        public string update(Cungcap cungcap);
        List<Cungcap> getCungcapList();
    }
}
