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
    public class ShipperRepository : IShipperRepository
    {
        FpolyDBContext context = new FpolyDBContext();
        public bool add(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public bool delete(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetAll()
        {
            return context.Shippers.ToList();
        }

        public bool update(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
